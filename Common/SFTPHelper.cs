using System;
using System.Collections;
using Tamir.SharpSsh.jsch;

namespace Common
{
    /// <summary>
    /// SFTPHelper
    /// </summary>
    public class SFTPHelper
    {
        //SFTP Session
        private Session m_session;
        //SFTP 协议  
        private Channel m_channel;
        // SFTP Object
        private ChannelSftp m_sftp;

        /// <summary>
        /// 实例化 SFTP 对象
        /// </summary>
        /// <param name="ip">服务器IP</param>
        /// <param name="user">用户名</param>
        /// <param name="pwd">密码</param>
        /// <param name="port">端口</param>
        /// <param name="privateKey">私钥</param>
        /// <param name="passphrase">私钥口令</param>
        public SFTPHelper(string ip, string user, string pwd, int port = 22, string privateKey = "", string passphrase = "")
        {
            JSch jsch = new JSch();
            jsch.addIdentity(privateKey, passphrase);
            m_session = jsch.getSession(user, ip, port);
            MyUserInfo ui = new MyUserInfo();
            ui.setPassword(pwd);
            m_session.setUserInfo(ui);
            this.Connect();
        }

        /// <summary>
        /// SFTP连接状态
        /// </summary>
        public bool Connected { get { return m_session.isConnected(); } }

        /// <summary>
        /// 消息
        /// </summary>
        public string SFTP_Message { get; set; } = "";

        /// <summary>
        /// 连接SFTP
        /// </summary>
        public bool Connect()
        {
            try
            {
                if (!Connected)
                {
                    m_session.connect();
                    m_channel = m_session.openChannel("sftp");
                    m_channel.connect();
                    m_sftp = (ChannelSftp)m_channel;
                    SFTP_Message = "连接成功";
                }
                return true;
            }
            catch (Exception ex)
            {
                SFTP_Message = "连接失败，异常：" + ex.Message;
                this.Disconnect();
                return false;
            }
        }
  
        /// <summary>
        /// 断开SFTP
        /// </summary>   
        public void Disconnect()
        {
            if (Connected)
            {
                m_channel.disconnect();
                m_session.disconnect();
            }
        }

        /// <summary>
        /// SFTP 上传文件
        /// </summary>
        /// <param name="localPath"></param>
        /// <param name="remotePath"></param>
        /// <returns></returns>
        public bool Put(string localPath, string remotePath)
        {
            try
            {
                Tamir.SharpSsh.java.String src = new Tamir.SharpSsh.java.String(localPath);
                Tamir.SharpSsh.java.String dst = new Tamir.SharpSsh.java.String(remotePath);
                m_sftp.put(src, dst);
                SFTP_Message = "上传成功";
                return true;
            }
            catch (Exception ex)
            {
                SFTP_Message = "上传失败，异常：" + ex.Message;
                this.Disconnect();
                return false;
            }
        }

        /// <summary>
        /// SFTP获取文件
        /// </summary>
        /// <param name="remotePath"></param>
        /// <param name="localPath"></param>
        /// <returns></returns>
        public bool Get(string remotePath, string localPath)
        {
            try
            {
                Tamir.SharpSsh.java.String src = new Tamir.SharpSsh.java.String(remotePath);
                Tamir.SharpSsh.java.String dst = new Tamir.SharpSsh.java.String(localPath);
                m_sftp.get(src, dst);
                SFTP_Message = "获取文件成功";
                return true;
            }
            catch (Exception ex)
            {
                SFTP_Message = "获取文件失败，异常：" + ex.Message;
                return false;
            }
        }

        /// <summary>
        /// 删除SFTP文件
        /// </summary>
        /// <param name="remoteFile"></param>
        /// <returns></returns>
        public bool Delete(string remoteFile)
        {
            try
            {
                m_sftp.rm(remoteFile);
                SFTP_Message = "删除文件成功";
                return true;
            }
            catch (Exception ex)
            {
                SFTP_Message = "删除文件失败，异常：" + ex.Message;
                this.Disconnect();
                return false;
            }
        }

        /// <summary>
        /// 获取SFTP文件列表
        /// </summary>
        /// <param name="remotePath"></param>
        /// <param name="fileType"></param>
        /// <returns></returns>
        public ArrayList GetFileList(string remotePath, string fileType)
        {
            try
            {
                Tamir.SharpSsh.java.util.Vector vvv = m_sftp.ls(remotePath);
                ArrayList objList = new ArrayList();
                foreach (Tamir.SharpSsh.jsch.ChannelSftp.LsEntry qqq in vvv)
                {
                    string sss = qqq.getFilename();
                    if (sss.Length > (fileType.Length + 1) && fileType == sss.Substring(sss.Length - fileType.Length))
                    { objList.Add(sss); }
                    else { continue; }
                }
                SFTP_Message = "文件列表获取成功";
                return objList;
            }
            catch (Exception ex)
            {
                SFTP_Message = "文件列表获取失败，异常：" + ex.Message;
                this.Disconnect();
                return null;
            }
        }
    }

    /// <summary>
    /// SFTP 登录信息          
    /// </summary>
    public class MyUserInfo : UserInfo
    {
        String passwd;
        public String getPassword() { return passwd; }
        public void setPassword(String passwd) { this.passwd = passwd; }

        public String getPassphrase() { return null; }
        public bool promptPassphrase(String message) { return true; }

        public bool promptPassword(String message) { return true; }
        public bool promptYesNo(String message) { return true; }
        public void showMessage(String message) { }
    }
}
