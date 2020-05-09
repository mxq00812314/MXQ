using Common;
using System;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using EP.Common;
using Test.MXQToolBox;

namespace Test
{
    public partial class Main
    {

        [DllImport("User32.dll ", EntryPoint = "SetParent")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll ", EntryPoint = "ShowWindow")]
        public static extern int ShowWindow(IntPtr hwnd, int nCmdShow);


        //2017 正月二月二十二
        public DateTime MarryDate = DateTime.Parse("2017-02-18 00:00:00");
        public DateTime GFDate = DateTime.Parse("2014-10-01 00:00:00");
        public DateTime RestTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd") + " 17:00:00");
        IniFileHelper iniFile = new IniFileHelper();
        string WorkLogPath = System.Environment.CurrentDirectory + @"\WeekWorkLog.ini";

        public string WorkLogName = "周工作日志";

        public Main()
        {
            InitializeComponent();

            string[] weekTexts = new string[] { "周日", "周一", "周二", "周三", "周四", "周五", "周六" };
            string weekText = weekTexts[Convert.ToInt32(DateTime.Now.DayOfWeek.ToString("d"))].ToString();
            lblMsg.Text = DateTime.Now.ToString("yy-MM-dd ") + weekText + DateTime.Now.ToString(" HH:mm");
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tMainTimer.Start();
            iniFile.Path = WorkLogPath;

            DateTime today = DateTime.Now;
            int dayofweek = Convert.ToInt32(today.DayOfWeek);
            DateTime beginDate = today.AddDays(1 - dayofweek);
            DateTime endDate = today.AddDays(7 - dayofweek);
            WorkLogName = beginDate.ToString("yyyy-MM-dd") + "~" + endDate.ToString("yyyy-MM-dd");
            gpWeekWorkLog.Text = $"周工作日志[{WorkLogName}]";
            GetWorkLogList();
            //runCmdWindow();
        }


        #region 菜单区


        private void 换肤ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkinPeeler sk = new SkinPeeler();
            sk.Show();
        }

        #endregion

        #region 功能区

        /// <summary>
        /// 展示当前系统时间
        /// </summary>
        public void showTime()
        {
            RestTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd") + " 17:00:00");
            var ts = DateTime.Now - MarryDate;
            lblMarryDate.Text = string.Format("据2017-02-18日已经过去：{0}", ts.Days.ToString() + "天" + ts.Hours.ToString() + "小时" + ts.Minutes.ToString() + "分钟" + ts.Seconds.ToString() + "秒");
            var ts2 = DateTime.Now - GFDate;
            lblGF.Text = string.Format("据2014-10-01日已经过去：{0}", ts2.Days.ToString() + "天" + ts2.Hours.ToString() + "小时" + ts2.Minutes.ToString() + "分钟" + ts2.Seconds.ToString() + "秒");
            var tsRest = RestTime - DateTime.Now;
            lblRest.Text = string.Format("据17点：{0}", tsRest.Hours.ToString() + "小时" + tsRest.Minutes.ToString() + "分钟" + tsRest.Seconds.ToString() + "秒");
        }

        /// <summary>
        /// 定时器触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tMainTimer_Tick(object sender, EventArgs e)
        {
            showTime();
        }

        /// <summary>
        /// 启动CMD命令
        /// </summary>
        public void runCmdWindow()
        {
            try
            {
                var p = Process.Start(@"C:\Windows\System32\cmd.exe", @"cd/");
                System.Threading.Thread.Sleep(120);//加上，100如果效果没有就继续加大
                SetParent(p.MainWindowHandle, this.gbNpm.Handle); //为要显示外部程序的容器，这里需要注意一些
                ShowWindow(p.MainWindowHandle, 3);
            }
            catch (Exception ex) { }
        }

        /// <summary>
        /// 保存工作日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnWorkLogSave_Click(object sender, EventArgs e)
        {
            iniFile.SetSectionValue(WorkLogName, txtWorkLog.Text);
            GetWorkLogList();
            txtWorkLog.Text = "";
        }

        /// <summary>
        /// 获取工作日志列表
        /// </summary>
        private void GetWorkLogList()
        {
            txtWeekWorkLog.Text = "";
            string[] logArr = iniFile.GetSectionValues(WorkLogName);
            if (logArr != null)
            {
                foreach (var log in logArr)
                    txtWeekWorkLog.AppendText(log + "\r\n");
            }
        }

        /// <summary>
        /// 打开工作日志文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWorkLogOpen_Click(object sender, EventArgs e)
        {
            string v_OpenFolderPath = WorkLogPath;
            System.Diagnostics.Process.Start("explorer.exe", v_OpenFolderPath);
        }

        /// <summary>
        /// 执行cmd命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRunCmd_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCmdStr.Text))
                RunCmd(txtCmdStr.Text.Trim());
        }

        /// <summary>
        /// 记事本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenNotepad_Click(object sender, EventArgs e)
        {
            RunCmd("Notepad");
        }

        /// <summary>
        /// 画图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenMsPaint_Click(object sender, EventArgs e)
        {
            RunCmd("MsPaint");
        }

        /// <summary>
        /// 远程桌面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenMsTsc_Click(object sender, EventArgs e)
        {
            RunCmd("MsTsc");
        }

        /// <summary>
        /// 截图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenSnipping_Click(object sender, EventArgs e)
        {
            RunCmd("SnippingTool");
        }

        /// <summary>  
        /// 执行cmd命令  
        /// 多命令请使用批处理命令连接符：  
        /// <![CDATA[  
        /// &:同时执行两个命令  
        /// |:将上一个命令的输出,作为下一个命令的输入  
        /// &&：当&&前的命令成功时,才执行&&后的命令  
        /// ||：当||前的命令失败时,才执行||后的命令]]>  
        /// 其他请百度  
        /// </summary>  
        public static string RunCmd(string cmdText)
        {
            string strOutput = "";
            var cmd = cmdText + " &exit"; //说明：不管命令是否成功均执行exit命令，否则当调用ReadToEnd()方法时，会处于假死状态  
            using (var p = new System.Diagnostics.Process())
            {
                p.StartInfo.FileName = @"C:\Windows\System32\cmd.exe";
                p.StartInfo.UseShellExecute = false; //是否使用操作系统shell启动  
                p.StartInfo.RedirectStandardInput = true; //接受来自调用程序的输入信息  
                p.StartInfo.RedirectStandardOutput = true; //由调用程序获取输出信息  
                p.StartInfo.RedirectStandardError = true; //重定向标准错误输出  
                p.StartInfo.CreateNoWindow = true; //不显示程序窗口  
                p.Start(); //启动程序  

                //向cmd窗口写入命令  
                p.StandardInput.WriteLine(cmd);
                p.StandardInput.AutoFlush = true;
                strOutput = p.StandardOutput.ReadToEnd();
                p.WaitForExit(); //等待程序执行完退出进程  
                p.Close();
            }
            return strOutput;
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = ReplaceJia(textBox1.Text);
        }
        public string ReplaceJia(string replaceStr)
        {

            var rstStr = Regex.Replace(replaceStr, @"\+", "＋", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return rstStr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            byte[] buffer = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(buffer, 0, buffer.Length);

            ms.Close();

            File.WriteAllBytes("demo.bin", buffer);//保存为二进制文件

            File.WriteAllText("demobase64.txt", Convert.ToBase64String(buffer));//保存为文本文件
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string contents = File.ReadAllText("demobase64.txt");

            byte[] imageBytes = Convert.FromBase64String(contents);
            //读入MemoryStream对象
            MemoryStream memoryStream = new MemoryStream(imageBytes, 0, imageBytes.Length);
            memoryStream.Write(imageBytes, 0, imageBytes.Length);
            //转成图片
            Image image2 = Image.FromStream(memoryStream);
            

           
            //Image image2 = Image.FromStream(new MemoryStream(Convert.FromBase64String(contents)));

            pictureBox2.Image = image2;
        }


        private void btnOpenSFTP_Click(object sender, EventArgs e)
        {

            SFTPHelper sftp = new SFTPHelper("111.202.58.171", "abc", "123456", 20000, Path.Combine(System.Environment.CurrentDirectory , "sftpkey.ssh"),"123456");
            bool connectState = sftp.Connected;
            lblSftpState.Text = sftp.SFTP_Message;
            if (connectState) {
                sftp.Put(Path.Combine(System.Environment.CurrentDirectory, "test_upload.txt"),"/upload/tripg/test_upload.txt");
                lblSftpState.Text = sftp.SFTP_Message;
            }
        }

    }
}
