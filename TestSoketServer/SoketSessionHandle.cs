using System;
using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace TestSoketServer
{
    public class SoketSessionHandle :AppSession<SoketSessionHandle>
    {

        public static SoketSessionHandle instance;

        /// <summary>  
        /// 新连接  
        /// </summary>  
        protected override void OnSessionStarted()
        {
            base.OnSessionStarted();
            instance = this;
        }

        /// <summary>  
        /// 捕捉异常并输出  
        /// </summary>  
        /// <param name="e"></param>  
        protected override void HandleException(Exception e)
        {
            byte[] data = Encoding.UTF8.GetBytes($"Exception: { e.Message}");
            base.Send(data, 0, data.Length);
            ConsoleHelper.OutputString("异常信息：" + e.Message, ConsoleColor.Red);
        }

        /// <summary>  
        /// 未知的Command  
        /// </summary>  
        /// <param name="requestInfo"></param>  
        protected override void HandleUnknownRequest(StringRequestInfo requestInfo)
        {
            base.HandleUnknownRequest(requestInfo);
            byte[] data = Encoding.UTF8.GetBytes($"UnknownRequest: { requestInfo.Body}");
            base.Send(data, 0, data.Length);
            ConsoleHelper.OutputString("未知命令", requestInfo);
        }

        /// <summary>  
        /// 连接关闭  
        /// </summary>  
        /// <param name="reason"></param>  
        protected override void OnSessionClosed(CloseReason reason)
        {
            byte[] data = Encoding.UTF8.GetBytes($"SessionClosed");
            base.Send(data, 0, data.Length);
            ConsoleHelper.OutputString("连接关闭：" + reason.ToString(), ConsoleColor.Yellow);
        }

        /// <summary>
        /// 向客户端发送消息
        /// </summary>
        /// <param name="msg"></param>
        public void SendMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            base.Send(data,0, data.Length);
            ConsoleHelper.OutputString("Server To Client：" + message);
        }
    }
}
