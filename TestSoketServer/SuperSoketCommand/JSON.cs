using System;
using System.IO;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
using System.Diagnostics;

namespace TestSoketServer.SuperSoketCommand
{
    public class JSON : CommandBase<SoketSessionHandle, StringRequestInfo>
    {
      
        public override void ExecuteCommand(SoketSessionHandle session, StringRequestInfo requestInfo)
        {
            ConsoleHelper.OutputString("JSON", session, requestInfo);
        }
    }
}
