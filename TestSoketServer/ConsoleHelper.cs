using System;
using SuperSocket.SocketBase.Protocol;

namespace TestSoketServer
{
    public static class ConsoleHelper
    {
        static string timeFormat = "HH:mm:ss:fff";
        static string nowTime = DateTime.Now.ToString(timeFormat) + "\t";

        public static string ToString(SoketSessionHandle session, StringRequestInfo requestInfo)
        {
            nowTime = DateTime.Now.ToString(timeFormat) + "\t";
            return $"{nowTime}{session.RemoteEndPoint.Address.ToString() + ':' + session.RemoteEndPoint.Port} 命令：{requestInfo.Key } Body :{requestInfo.Body } ";
        }

        public static void OutputString(string outPut)
        {
            nowTime = DateTime.Now.ToString(timeFormat) + "\t";
            Console.WriteLine($"{nowTime}{outPut} ");
        }

        public static void OutputString(StringRequestInfo requestInfo)
        {
            nowTime = DateTime.Now.ToString(timeFormat) + "\t";
            Console.WriteLine($"{nowTime} 命令：{requestInfo.Key } Body :{requestInfo.Body }");
        }

        public static void OutputString(string title, StringRequestInfo requestInfo)
        {
            nowTime = DateTime.Now.ToString(timeFormat) + "\t";
            Console.WriteLine($"{nowTime}{title} 命令：{requestInfo.Key } Body :{requestInfo.Body }");
        }

        public static void OutputString(SoketSessionHandle session, StringRequestInfo requestInfo)
        {
            nowTime = DateTime.Now.ToString(timeFormat) + "\t";
            Console.WriteLine($"{nowTime}{session.RemoteEndPoint.Address.ToString() + ':' + session.RemoteEndPoint.Port} 命令：{requestInfo.Key } Body :{requestInfo.Body }");
        }

        public static void OutputString(string commandName, SoketSessionHandle session, StringRequestInfo requestInfo)
        {
            nowTime = DateTime.Now.ToString(timeFormat) + "\t";
            Console.WriteLine($"{nowTime}{commandName} {session.RemoteEndPoint.Address.ToString() + ':' + session.RemoteEndPoint.Port} 命令：{requestInfo.Key } Body :{requestInfo.Body }");
        }

        public static void OutputString(string outPut, ConsoleColor forecolor = ConsoleColor.Gray)
        {
            nowTime = DateTime.Now.ToString(timeFormat) + "\t";
            Console.ForegroundColor = forecolor;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"{nowTime}{outPut} ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
