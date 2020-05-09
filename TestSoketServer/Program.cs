using System;
using System.Text;
using System.Timers;
using SuperSocket.SocketBase.Config;
using System.Configuration;
using System.IO;

namespace TestSoketServer
{

    public class Program
    {
        static SoketServerHandle soketAppServer;
        static ServerConfig serverConfig;
        static string localIp = ConfigurationManager.AppSettings["LocalIp"].ToString();
        static string localPort = ConfigurationManager.AppSettings["LocalPort"].ToString();

        [STAThread]
        static void Main(string[] args)
        {

            localIp = ConfigurationManager.AppSettings["LocalIp"].ToString();
            localPort = ConfigurationManager.AppSettings["LocalPort"].ToString();


            #region 生产环境 引导配置

            ConsoleHelper.OutputString("//============================================================", ConsoleColor.Green);
            ConsoleHelper.OutputString("//                     //////////       ////////              ", ConsoleColor.Yellow);
            ConsoleHelper.OutputString("//                    ///              ////    ///            ", ConsoleColor.Yellow);
            ConsoleHelper.OutputString("//                   ///              ///      ///            ", ConsoleColor.Yellow);
            ConsoleHelper.OutputString("//                  ///              ///      ///             ", ConsoleColor.Yellow);
            ConsoleHelper.OutputString("//                 //////////       ///     ///               ", ConsoleColor.Yellow);
            ConsoleHelper.OutputString("//                ///              /////////                  ", ConsoleColor.Yellow);
            ConsoleHelper.OutputString("//               ///              ///                         ", ConsoleColor.Yellow);
            ConsoleHelper.OutputString("//              ///              ///                          ", ConsoleColor.Yellow);
            ConsoleHelper.OutputString("//             //////////       ///                           ", ConsoleColor.Yellow);
            ConsoleHelper.OutputString("//============================================================", ConsoleColor.Green);
            ConsoleHelper.OutputString("//                  .NET Socket 通信测试服务端                ", ConsoleColor.Yellow);
            ConsoleHelper.OutputString($"//\tIP：{localIp}\tPort：{localPort}   ", ConsoleColor.Yellow);
            ConsoleHelper.OutputString("//============================================================", ConsoleColor.Green);


            ConsoleHelper.OutputString("程序启动中...");


            ConsoleHelper.OutputString("程序开始运行...");

            //下位机Socket服务启动
            SuperSocketServerInit();

            ConsoleHelper.OutputString("Socket服务已停止，按任意键退出");
            Console.Read();

            #endregion 生产环境配置

        }

        /// <summary>
        /// SuperSocket 服务器启动
        /// </summary>
        static void SuperSocketServerInit()
        {
            soketAppServer = new SoketServerHandle();

            serverConfig = new ServerConfig
            {
                Port = Convert.ToInt32(localPort),
                Ip = localIp,
                TextEncoding = "utf-8",
                MaxRequestLength = 1024 * 1024,
            };

            if (!soketAppServer.Setup(serverConfig))
            {
                ConsoleHelper.OutputString("Socket服务初始化失败！\r\n", ConsoleColor.Red);
                return;
            }

            if (!soketAppServer.Start())
            {
                ConsoleHelper.OutputString("Socket服务启动失败！\r\n", ConsoleColor.Red);
                return;
            }
            ConsoleHelper.OutputString("启动Socket服务成功！\r\n", ConsoleColor.Green);
            ConsoleHelper.OutputString("按Q键退出！\r\n");
            while (true)
            {
                var str = Console.ReadLine();
                if (str.ToLower().Trim().Equals("q"))
                {
                    break;
                }

                foreach (var session in soketAppServer.GetAllSessions())
                {
                    byte[] arrClientSendMsg = Encoding.UTF8.GetBytes(str);
                    session.Send(arrClientSendMsg, 0, arrClientSendMsg.Length);
                }

            }
            soketAppServer.Stop();

        }
    }
}
