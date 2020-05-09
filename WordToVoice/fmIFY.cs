using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IFY;

using EP.PlugIn;

namespace WordToVoice
{
    public partial class fmIFY : Form
    {
        public fmIFY()
        {
            InitializeComponent();
            updateStatus = new SetStatus(setStatusMethod);
        }

        #region 全局变量

        int ret = 0;
        const int BUFFER_NUM = 1024 * 20;
        const int waitTime = 1000;
        IntPtr session_ID;
        string filename = $"Call.wav"; //合成的语音文件  

        #endregion

        #region 事件处理

        /// <summary>
        /// 本地语音识别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocalVoice_Click(object sender, EventArgs e)
        {
            //业务流程:
            //1.调用 MSPLogin(...)接口登入，可以只登入一次，但是必须保证在调用其他接口前先登入；
            //2.调用 QISRSessionBegin(...)开始一次语音听写；
            //3.循环调用 QISRAudioWrite(...) 分块写入音频数据
            //4.循环调用 QISRGetResult(...) 接口返回听写结果
            //5.调用 QISRSessionEnd(...) 主动结束本次听写
            //6.不再使用服务的时候 调用MSPLogout()登出，避免不必要的麻烦。

            try
            {
                //识别结果
                string text = String.Empty;
                //登录参数,自己注册后获取的appid  
                string login_configs = "appid=5983daf6";
                //语音路径
                var voicePath = AppDomain.CurrentDomain.BaseDirectory + filename;
                //检测文件是否存在
                if (!File.Exists(voicePath)) MessageBox.Show("文件" + voicePath + "不存在！");
                //读取音频文件
                using (FileStream fileStream = new FileStream(voicePath, FileMode.OpenOrCreate))
                {
                    IntPtr intPtr = Marshal.AllocHGlobal(BUFFER_NUM);
                    byte[] array = new byte[BUFFER_NUM];


                    LoadingHelper.ShowLoading("加载中", this, o =>
                    {

                        AudioStatus audioStatus = AudioStatus.MSP_AUDIO_SAMPLE_CONTINUE;
                        EpStatus epStatus = EpStatus.MSP_EP_LOOKING_FOR_READY;
                        RsltStatus recogStatus = RsltStatus.MSP_REC_STATUS_FOR_READY;

                        //MSPLogin(...)接口登入
                        this.BeginInvoke(updateStatus, "登录接口");
                        ret = IFYDll.MSPLogin("137586129@qq.com", "jkljlk123", login_configs);
                        if (ret != (int)ErrorCode.MSP_SUCCESS)
                        {
                            return;
                        }

                        //QISRSessionBegin 开始一次语音识别  
                        this.BeginInvoke(updateStatus, "开始一次语音识别");
                        string _params = $"domain=iat,sub=iat,aue=speex-wb;7,sample_rate=16000,result_type=plain";
                        session_ID = IFYDll.QISRSessionBegin(null, _params, ref ret);
                        if (ret != (int)ErrorCode.MSP_SUCCESS)
                        {
                            return;
                        }

                        //QISRAudioWrite 写入本次识别的音频。
                        this.BeginInvoke(updateStatus, "分块写入识别的音频");
                        while (fileStream.Position != fileStream.Length)
                        {
                            int waveLen = fileStream.Read(array, 0, BUFFER_NUM);
                            Marshal.Copy(array, 0, intPtr, array.Length);
                            ret = IFYDll.QISRAudioWrite(Ptr2Str(session_ID), intPtr, (uint)waveLen, audioStatus, ref epStatus, ref recogStatus);
                            if (ret != 0)
                            {
                                fileStream.Close();
                                throw new Exception("QISRAudioWrite err,errCode=" + ret);
                            }
                            Thread.Sleep(500);
                        }

                        this.BeginInvoke(updateStatus, "写入最后一块音频");
                        audioStatus = AudioStatus.MSP_AUDIO_SAMPLE_LAST;
                        ret = IFYDll.QISRAudioWrite(Ptr2Str(session_ID), intPtr, 1u, audioStatus, ref epStatus, ref recogStatus);
                        if (ret != 0)
                        {
                            throw new Exception("QISRAudioWrite write last audio err,errCode=" + ret);
                        }

                        //QISRGetResult 读取识别结果
                        this.BeginInvoke(updateStatus, "读取识别结果");
                        while (true)
                        {
                            IntPtr intPtr2 = IFYDll.QISRGetResult(Ptr2Str(session_ID), ref recogStatus, waitTime, ref ret);
                            if (intPtr2 != IntPtr.Zero)
                            {
                                text += Ptr2Str(intPtr2);
                            }
                            if (ret != 0)
                            {
                                break;
                            }
                            Thread.Sleep(500);
                            if (recogStatus == RsltStatus.MSP_REC_STATUS_COMPLETE)
                            {
                                break;
                            }
                        }
                    });
                    txtLocalVoiceRecognitionResult.Text = text;
                }
            }
            catch (Exception ex)
            {
                txtLocalVoiceRecognitionResult.Text = ex.Message;
            }
            finally
            {
                //主动结束本次语音识别
                this.BeginInvoke(updateStatus, "结束本次识别结果");
                ret = IFYDll.QISRSessionEnd(Ptr2Str(session_ID), "");

                //退出登录  
                this.BeginInvoke(updateStatus, "退出登录");
                ret = IFYDll.MSPLogout();
            }
            Thread.Sleep(3000);
            this.BeginInvoke(updateStatus, "就绪");
        }


        /// <summary>
        ///音频合成 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTextToVoice_Click(object sender, EventArgs e)
        {
            try
            {
                //登录参数,自己注册后获取的appid  
                string login_configs = "appid=5983daf6";
                string text = txtInput.Text.Trim();//待合成的文本  
                uint audio_len = 0;

                if (string.IsNullOrEmpty(txtInput.Text.Trim()))
                {
                    txtInput.Text = "请输入合成语音的内容";
                    return;
                }

                var speekerCode = IFYDll.GetSpeekerCode(cboSpeeker.SelectedIndex);
                LoadingHelper.ShowLoading("加载中", this, o =>
                {
                    SynthStatus synth_status = SynthStatus.MSP_TTS_FLAG_STILL_HAVE_DATA;

                    //第一个参数为用户名，第二个参数为密码，第三个参数是登录参数，用户名和密码需要在http://open.voicecloud.cn  
                    this.BeginInvoke(updateStatus, "登录接口");
                    ret = IFYDll.MSPLogin("137586129@qq.com", "jkljlk123", login_configs);
                    //MSPLogin方法返回失败  
                    if (ret != (int)ErrorCode.MSP_SUCCESS)
                    {
                        return;
                    }

                    string _params = $"ssm=1,ent=sms16k,vcn={speekerCode},spd=medium,aue=speex-wb;7,vol=x-loud,auf=audio/L16;rate=16000";
                    session_ID = IFYDll.QTTSSessionBegin(_params, ref ret);
                    //QTTSSessionBegin方法返回失败  
                    if (ret != (int)ErrorCode.MSP_SUCCESS)
                    {
                        return;
                    }

                    //发送待合成音频文本
                    this.BeginInvoke(updateStatus, "发送文字");
                    ret = IFYDll.QTTSTextPut(Ptr2Str(session_ID), text, (uint)Encoding.Default.GetByteCount(text), string.Empty);
                    //QTTSTextPut方法返回失败  
                    if (ret != (int)ErrorCode.MSP_SUCCESS)
                    {
                        return;
                    }

                    //分块获取合成音频流
                    this.BeginInvoke(updateStatus, "获取合成语音");
                    MemoryStream memoryStream = new MemoryStream();
                    memoryStream.Write(new byte[44], 0, 44);
                    while (true)
                    {
                        IntPtr source = IFYDll.QTTSAudioGet(Ptr2Str(session_ID), ref audio_len, ref synth_status, ref ret);
                        byte[] array = new byte[(int)audio_len];
                        if (audio_len > 0)
                        {
                            Marshal.Copy(source, array, 0, (int)audio_len);
                        }
                        memoryStream.Write(array, 0, array.Length);
                        Thread.Sleep(1000);
                        if (synth_status == SynthStatus.MSP_TTS_FLAG_DATA_END || ret != 0)
                            break;
                    }

                    WAVE_Header wave_Header = getWave_Header((int)memoryStream.Length - 44);
                    byte[] array2 = this.StructToBytes(wave_Header);
                    memoryStream.Position = 0L;
                    memoryStream.Write(array2, 0, array2.Length);
                    memoryStream.Position = 0L;

                    //播放器 播放音频流
                    SoundPlayer soundPlayer = new SoundPlayer(memoryStream);
                    soundPlayer.Stop();
                    soundPlayer.Play();

                    //将音频流 保存为文件
                    if (filename != null)
                    {
                        FileStream fileStream = new FileStream(filename, FileMode.Create, FileAccess.Write);
                        memoryStream.WriteTo(fileStream);
                        memoryStream.Close();
                        fileStream.Close();
                    }
                });
                this.BeginInvoke(updateStatus, "就绪");
            }
            catch (Exception ex)
            {
                txtInput.Text = ex.Message;
            }
            finally
            {
                //主动结束本次音频合成
                ret = IFYDll.QTTSSessionEnd(Ptr2Str(session_ID), "");

                //退出登录  
                ret = IFYDll.MSPLogout();
            }
        }

        /// <summary>
        /// 打开合成语音目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenVoice_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", AppDomain.CurrentDomain.BaseDirectory);
        }

        /// <summary>
        /// 进行语音识别
        /// </summary>
        /// <param name="inFile"></param>
        /// <returns></returns>
        public string AudioToString(string inFile)
        {
            int ret = 0;
            string text = String.Empty;
            FileStream fileStream = new FileStream(inFile, FileMode.OpenOrCreate);
            byte[] array = new byte[BUFFER_NUM];
            IntPtr intPtr = Marshal.AllocHGlobal(BUFFER_NUM);
            AudioStatus audioStatus = AudioStatus.MSP_AUDIO_SAMPLE_CONTINUE;
            EpStatus epStatus = EpStatus.MSP_EP_LOOKING_FOR_READY;
            RsltStatus recogStatus = RsltStatus.MSP_REC_STATUS_FOR_READY;
            RsltStatus rsltStatus = RsltStatus.MSP_REC_STATUS_FOR_READY;

            while (fileStream.Position != fileStream.Length)
            {
                int waveLen = fileStream.Read(array, 0, BUFFER_NUM);
                Marshal.Copy(array, 0, intPtr, array.Length);
                ret = IFYDll.QISRAudioWrite(Ptr2Str(session_ID), intPtr, (uint)waveLen, audioStatus, ref epStatus, ref recogStatus);
                if (ret != 0)
                {
                    fileStream.Close();
                    throw new Exception("QISRAudioWrite err,errCode=" + ret);
                }
                if (recogStatus == 0)
                {
                    IntPtr intPtr2 = IFYDll.QISRGetResult(Ptr2Str(session_ID), ref rsltStatus, 0, ref ret);
                    if (intPtr2 != IntPtr.Zero)
                    {
                        text += Ptr2Str(intPtr2);
                    }
                }
                Thread.Sleep(500);
            }
            fileStream.Close();
            audioStatus = AudioStatus.MSP_AUDIO_SAMPLE_LAST;
            ret = IFYDll.QISRAudioWrite(Ptr2Str(session_ID), intPtr, 1u, audioStatus, ref epStatus, ref recogStatus);
            if (ret != 0)
            {
                throw new Exception("QISRAudioWrite write last audio err,errCode=" + ret);
            }
            int timesCount = 0;
            while (true)
            {
                IntPtr intPtr2 = IFYDll.QISRGetResult(Ptr2Str(session_ID), ref rsltStatus, 0, ref ret);
                if (intPtr2 != IntPtr.Zero)
                {
                    text += Ptr2Str(intPtr2);
                }
                if (ret != 0)
                {
                    break;
                }
                Thread.Sleep(200);
                if (rsltStatus == RsltStatus.MSP_REC_STATUS_COMPLETE || timesCount++ >= 50)
                {
                    break;
                }
            }
            return text;
        }

        #endregion

        #region WAV 音频处理

        /// <summary>  
        /// 结构体初始化赋值  
        /// </summary>  
        /// <param name="data_len"></param>  
        /// <returns></returns>  
        private WAVE_Header getWave_Header(int data_len)
        {
            return new WAVE_Header
            {
                RIFF_ID = 1179011410,
                File_Size = data_len + 36,
                RIFF_Type = 1163280727,
                FMT_ID = 544501094,
                FMT_Size = 16,
                FMT_Tag = 1,
                FMT_Channel = 1,
                FMT_SamplesPerSec = 16000,
                AvgBytesPerSec = 32000,
                BlockAlign = 2,
                BitsPerSample = 16,
                DATA_ID = 1635017060,
                DATA_Size = data_len
            };
        }

        /// <summary>  
        /// 语音音频头  
        /// </summary>  
        private struct WAVE_Header
        {
            public int RIFF_ID;
            public int File_Size;
            public int RIFF_Type;
            public int FMT_ID;
            public int FMT_Size;
            public short FMT_Tag;
            public ushort FMT_Channel;
            public int FMT_SamplesPerSec;
            public int AvgBytesPerSec;
            public ushort BlockAlign;
            public ushort BitsPerSample;
            public int DATA_ID;
            public int DATA_Size;
        }

        #endregion

        #region 辅助方法

        /// <summary>  
        /// 结构体转字符串  
        /// </summary>  
        /// <param name="structure"></param>  
        /// <returns></returns>  
        private byte[] StructToBytes(object structure)
        {
            int num = Marshal.SizeOf(structure);
            IntPtr intPtr = Marshal.AllocHGlobal(num);
            byte[] result;
            try
            {
                Marshal.StructureToPtr(structure, intPtr, false);
                byte[] array = new byte[num];
                Marshal.Copy(intPtr, array, 0, num);
                result = array;
            }
            finally
            {
                Marshal.FreeHGlobal(intPtr);
            }
            return result;
        }

        /// 指针转字符串  
        /// </summary>  
        /// <param name="p">指向非托管代码字符串的指针</param>  
        /// <returns>返回指针指向的字符串</returns>  
        public static string Ptr2Str(IntPtr p)
        {
            if (p != null)
            {
                List<byte> lb = new List<byte>();
                try
                {
                    while (Marshal.ReadByte(p) != 0)
                    {
                        lb.Add(Marshal.ReadByte(p));
                        p = p + 1;
                    }
                }
                catch { }
                return Encoding.Default.GetString(lb.ToArray());
            }
            else
            {
                return "";
            }
        }


        //创建一个委托，是为访问TextBox控件服务的。
        public delegate void SetStatus(string msg);
        //定义一个委托变量
        public SetStatus updateStatus;
        //设置状态方法
        private void setStatusMethod(string msg)
        {
            lblStatus.Text = msg;
        }


        #endregion


    }
}
