using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManager
{
    [Serializable]
    public class DbServer
    {
        /// <summary>
        /// 服务器连接名称
        /// </summary>
        public string DbServerName { get; set; }

        /// <summary>
        /// 服务器IP
        /// </summary>
        public string DbServerHost { get; set; }

        /// <summary>
        /// 服务器主机IP
        /// </summary>
        public string DbServerUserName { get; set; }

        /// <summary>
        /// 服务器密码
        /// </summary>
        public string DbServerUserPwd { get; set; }

        /// <summary>
        /// 服务器端口
        /// </summary>
        public string DbServerPort { get; set; }

        /// <summary>
        /// 服务器数据库
        /// </summary>
        public string DbServerDataBase { get; set; }

        /// <summary>
        /// 服务器会员超时时间
        /// </summary>
        public int DbServerSessionTimeOut { get; set; } = 28800;

        public string DbServerConnection { get; set; } = "";

        public DbServer() { }

        public DbServer(string DbServerName, string DbServerHost, string DbServerUserName, string DbServerUserPwd, string DbServerPort, string DbServerDataBase, int DbServerSessionTimeOut = 28800)
        {
            this.DbServerName = DbServerName;
            this.DbServerHost = DbServerHost;
            this.DbServerUserName = DbServerUserName;
            this.DbServerUserPwd = DbServerUserPwd;
            this.DbServerPort = DbServerPort;
            this.DbServerDataBase = DbServerDataBase;
            this.DbServerSessionTimeOut = DbServerSessionTimeOut;
            this.DbServerConnection = $"Host={DbServerHost};UserName={DbServerUserName};Password={DbServerUserPwd};Database={DbServerDataBase};Port={DbServerPort};CharSet=utf8;Allow Zero Datetime=true;Allow User Variables = True;";
        }
    }
}
