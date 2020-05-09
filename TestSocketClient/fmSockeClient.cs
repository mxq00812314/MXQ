using System;
using System.Configuration;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TestSocketClient
{
    public partial class fmSockeClient : Form
    {
        string ipAddress = System.Configuration.ConfigurationManager.AppSettings["LocalIp"];
        string port = System.Configuration.ConfigurationManager.AppSettings["LocalPort"];
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        Socket clientSocket;


        //创建一个委托，是为访问TextBox控件服务的。
        public delegate void UpdateTxtDelegate(string msg);
        //定义一个委托变量
        public UpdateTxtDelegate updateTxtDelegate;

        /// <summary>
        /// 窗体初始化
        /// </summary>
        public fmSockeClient()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmSockeClient_Load(object sender, EventArgs e)
        {
            this.Text = $"Socket IP：{ipAddress}    Port：{port}";

            txtServerIP.Text = ipAddress;
            txtServerPort.Text = port;

            myTimer.Interval = 1000;
            myTimer.Tick += new EventHandler(CheckSoketConnectState);

            updateTxtDelegate = new UpdateTxtDelegate(SetResponseText);

            OpenSoketConnect();


            Thread objThread = new Thread(new ThreadStart(delegate
            {
                ReceiveServerResponse();
            }));

            objThread.Start();
        }

        /// <summary>
        /// 打开soket 连接
        /// </summary>
        public void OpenSoketConnect()
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                clientSocket.Connect(new IPEndPoint(IPAddress.Parse(ipAddress), int.Parse(port))); //配置服务器IP与端口  

                myTimer.Start();
                SetResponseText($"连接服务器成功！");
            }
            catch (Exception ex)
            {
                myTimer.Stop();
                SoketDispose();
                SetResponseText($"连接服务器失败！ 原因:{ex.Message}");
                return;
            }
        }

        private void SetResponseText(string responseStr)
        {
            textBox2.AppendText($"\r\n{DateTime.Now.ToString("HH:mm:ss.fff")}\t{responseStr}");
            textBox2.ScrollToCaret();
        }

        /// <summary>
        /// 检测soket 连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckSoketConnectState(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 接受服务器响应信息
        /// </summary>
        private void ReceiveServerResponse()
        {
            while (true)
            {

                try
                {
                    if (clientSocket.Connected)
                    {
                        byte[] resultArr = new byte[1024 * 1024];
                        int receiveLength = clientSocket.Receive(resultArr);
                        if (receiveLength == 0)
                        {
                            this.BeginInvoke(updateTxtDelegate, "服务器连接中断！");
                            break;
                        }
                        string responseMessage = Encoding.UTF8.GetString(resultArr, 0, receiveLength);
                        this.BeginInvoke(updateTxtDelegate, responseMessage);
                    }
                }
                catch
                {
                    this.BeginInvoke(updateTxtDelegate, "服务器连接中断！");
                    break;
                }
            }
        }

        /// <summary>
        /// 向服务器发送信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClientSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientSocket.Connected)
                {
                    string sendMessage = textBox1.Text + "\r\n";
                    byte[] data = Encoding.UTF8.GetBytes(sendMessage);
                    clientSocket.Send(data);
                }
                SoketDispose();
                OpenSoketConnect();
            }
            catch (Exception ex)
            {
                this.BeginInvoke(updateTxtDelegate, "服务器连接中断！");
            }
        }

        /// <summary>
        /// 打开服务器端通信
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClientConnect_Click(object sender, EventArgs e)
        {
            OpenSoketConnect();
        }


        /// <summary>
        /// 释放Soket 资源
        /// </summary>
        public void SoketDispose()
        {
            try
            {
                this.clientSocket.Shutdown(SocketShutdown.Both);
                this.clientSocket.Dispose();
                this.clientSocket.Close();
                this.clientSocket = null;
            }
            catch (Exception ex) { }
        }

        private void btnSaveSocket_Click(object sender, EventArgs e)
        {
            SoketDispose();

            string serverIp = txtServerIP.Text.Trim();
            string serverPort = txtServerPort.Text.Trim();
            ipAddress = serverIp;
            port = serverPort;
            this.Text = $"Socket IP：{serverIp}    Port：{serverPort}";
            AccessAppSettings(serverIp, serverPort);

            OpenSoketConnect();
        }

        /// <summary>
        /// xml对App.config appsetting修改读取
        /// </summary>
        private void AccessAppSettings(string serverIp, string serverPort)
        {
            //获取Configuration对象
            Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //修改
            config.AppSettings.Settings["LocalIp"].Value = $"{serverIp}";
            config.AppSettings.Settings["LocalPort"].Value = $"{serverPort}";
            //保存配置文件
            config.Save(ConfigurationSaveMode.Modified);
            //刷新，否则程序读取的还是之前的值（可能已装入内存）
            System.Configuration.ConfigurationManager.RefreshSection("appSettings");
        }

        private void fmSockeClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            SoketDispose();
            Application.Exit();

        }
    }

    public class StringRequestInfo
    {
        public string Key { get; }

        public string Body { get; }

        public string[] Parameters { get; }
    }

}
