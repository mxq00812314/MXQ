using System;
using System.Collections.Generic;
using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using SuperSocket.SocketBase.Logging;

namespace TestSoketServer
{
    public class SoketServerHandle : AppServer<SoketSessionHandle>
    {
        /// <summary>  
        /// 输出新连接信息  
        /// </summary>  
        /// <param name="session"></param>  
        protected override void OnNewSessionConnected(SoketSessionHandle session)
        {
            base.OnNewSessionConnected(session);
            ConsoleHelper.OutputString(session.LocalEndPoint.Address.ToString() + ':' + session.LocalEndPoint.Port + "<==>" + session.RemoteEndPoint.Address + ':' + session.RemoteEndPoint.Port + "收到新连接", ConsoleColor.Green);
        }

        /// <summary>
        /// 收到文本消息事件
        /// </summary>
        /// <param name="messageType"></param>
        /// <param name="messageData"></param>
        protected override void OnSystemMessageReceived(string messageType, object messageData)
        {
            base.OnSystemMessageReceived(messageType, messageData);
            var requestInfo = (StringRequestInfo)messageData;
            ConsoleHelper.OutputString(requestInfo);
        }

        /// <summary>  
        /// 输出断开连接信息  
        /// </summary>  
        /// <param name="session"></param>  
        /// <param name="reason"></param>  
        protected override void OnSessionClosed(SoketSessionHandle session, CloseReason reason)
        {
            base.OnSessionClosed(session, reason);
            ConsoleHelper.OutputString(session.LocalEndPoint.Address.ToString() + ':' + session.LocalEndPoint.Port + "<==>" + session.RemoteEndPoint.Address + ':' + session.RemoteEndPoint.Port + "断开连接", ConsoleColor.Blue);
        }
        /// <summary>
        /// 当服务器关闭时执行
        /// </summary>
        protected override void OnStopped()
        {
            base.OnStopped();
            ConsoleHelper.OutputString("服务器已停止");
        }
    }
}
