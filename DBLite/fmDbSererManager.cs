using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DBManager;
using EP.Common;

namespace DBLite
{
    public partial class fmDbSererManager : Form
    {
        IniFileHelper iniFile = new IniFileHelper(System.Environment.CurrentDirectory + @"\Dbconfig.ini");
        Timer t = new Timer();

        public fmDbSererManager()
        {
            InitializeComponent();

            t.Interval = 3000;
            t.Tick += new EventHandler(resetStatusMsg);

            lblDbServerName.Visible = false;
            txtDbServerName.Visible = false;
        }

        private void fmDbSererManager_Load(object sender, EventArgs e)
        {
            BindServerList();
        }

        /// <summary>
        /// 创建 按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDbServerNewCreate_Click(object sender, EventArgs e)
        {
            lblDbServerName.Visible = true;
            txtDbServerName.Visible = true;

            txtDbServerName.Text = "localhost";
            txtDbServerHost.Text = "localhost";
            txtDbServerUserId.Text = "root";
            txtDbServerUserPwd.Text = "";
            txtDbServerPort.Text = "3306";
            txtDbServerDataBase.Text = "";
        }

        /// <summary>
        ///  保存 按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDbServerSave_Click(object sender, EventArgs e)
        {
            if (!CheckServerInput())
                return;

            var sName = txtDbServerName.Text;
            var host = txtDbServerHost.Text;
            var uName = txtDbServerUserId.Text;
            var uPwd = txtDbServerUserPwd.Text;
            var port = txtDbServerPort.Text;
            var dataBase = txtDbServerDataBase.Text;
            var sessionTitmeOut = 28800;
            if (rdoDbSessionTimeOutCustom.Checked)
            {
                sessionTitmeOut = Convert.ToInt32(txtDbSessionTimeOutCustom.Text);
            }

            DbServer server = new DbServer(sName, host, uName, uPwd, port, dataBase, sessionTitmeOut);
            if (IsExistedServer(sName))
            {
                if (txtDbServerName.Visible == true)
                    SetStatusMsg(sName + "已经存在");
                else
                {
                    DialogResult dr = MessageBox.Show("确定变更连接么?", "系统提示", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.Cancel)
                        return;
                    DelServer(sName);
                }
            }

            iniFile.SetSectionValue("DbServerList", sName);
            var rst = iniFile.SetSectionValue(sName, StringHelper.ToJSON(server));
            if (rst)
            {
                SetStatusMsg("保存成功");
                lblDbServerName.Visible = false;
                txtDbServerName.Visible = false;
                BindServerList();
            }
            else
            {
                SetStatusMsg("保存失败");
            }
        }

        /// <summary>
        /// 删除 按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDbServerDel_Click(object sender, EventArgs e)
        {
            if (cboDbServerList.SelectedItem == null)
                return;

            DelServer(cboDbServerList.SelectedItem.ToString());
        }

        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDbServerConnection_Click(object sender, EventArgs e)
        {
            if (cboDbServerList.SelectedItem != null)
            {
                this.Hide();
                var server = GetDbServer(cboDbServerList.SelectedItem.ToString());
                fmMySql fm = new fmMySql(server);
                fm.Show();

            }
        }

        /// <summary>
        /// 验证服务器配置
        /// </summary>
        /// <returns></returns>
        private bool CheckServerInput()
        {
            var sName = txtDbServerName.Text;
            var host = txtDbServerHost.Text;
            var uName = txtDbServerUserId.Text;
            var uPwd = txtDbServerUserPwd.Text;
            var port = txtDbServerPort.Text;
            var dataBase = txtDbServerDataBase.Text;

            if (string.IsNullOrWhiteSpace(sName))
            {
                SetStatusMsg("连接名没有填写");
                return false;
            }
            if (string.IsNullOrWhiteSpace(host))
            {
                SetStatusMsg("主机名为空");
                return false;
            }
            if (string.IsNullOrWhiteSpace(uName))
            {
                SetStatusMsg("用户名为空");
                return false;
            }
            if (string.IsNullOrWhiteSpace(uPwd))
            {
                SetStatusMsg("密码为空");
                return false;
            }
            if (string.IsNullOrWhiteSpace(port))
            {
                SetStatusMsg("端口为空");
                return false;
            }
            return true;
        }

        /// <summary>
        /// 设置状态栏 消息
        /// </summary>
        /// <param name="msg"></param>
        private void SetStatusMsg(string msg = "就绪")
        {

            tstlblMsg.Text = msg;
            if (msg != "就绪")
            {
                t.Start();
            }
        }

        /// <summary>
        /// 重置状态栏 消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetStatusMsg(object sender, EventArgs e)
        {
            t.Stop();
            SetStatusMsg();
        }

        /// <summary>
        /// 绑定服务器 下拉框
        /// </summary>
        private void BindServerList()
        {
            cboDbServerList.DataSource = GetDbServerNameList();
        }

        /// <summary>
        /// 删除保存的服务器
        /// </summary>
        /// <param name="serverName"></param>
        public void DelServer(string serverName)
        {
            var serverList = GetDbServerList();
            iniFile.DelSection("DbServerList");
            foreach (var server in serverList)
            {
                if (server.DbServerName == serverName)
                    iniFile.DelSection(server.DbServerName);
                else
                    iniFile.SetSectionValue("DbServerList", server.DbServerName);
            }
            BindServerList();
        }

        /// <summary>
        /// 是否已经存在过
        /// </summary>
        /// <param name="serverName"></param>
        /// <returns></returns>
        private bool IsExistedServer(string serverName)
        {
            bool rst = false;
            var serverNameList = GetDbServerNameList();
            if (serverNameList.Contains(serverName))
                rst = true;
            return rst;
        }

        /// <summary>
        /// 获取全部保存的服务器名称
        /// </summary>
        /// <returns></returns>
        private List<string> GetDbServerNameList()
        {
            List<string> dbServerList = new List<string>();
            string[] dbServerArr = iniFile.GetSectionValues("DbServerList");
            if (dbServerArr == null)
                return dbServerList;
            dbServerList = dbServerArr.ToList();
            return dbServerList;
        }

        /// <summary>
        /// 根据名称获取连接信息
        /// </summary>
        /// <param name="serverName"></param>
        /// <returns></returns>
        private DbServer GetDbServer(string serverName)
        {
            DbServer dbServerModel = null;
            string[] dataArr = iniFile.GetSectionValues(serverName);
            if (dataArr == null)
                return dbServerModel;
            string jsonStr = string.Join("", dataArr);
            dbServerModel = StringHelper.ToObject<DbServer>(jsonStr);
            return dbServerModel;
        }

        /// <summary>
        /// 获取全部连接信息
        /// </summary>
        /// <returns></returns>
        private List<DbServer> GetDbServerList()
        {
            List<DbServer> dbServerModelList = new List<DbServer>();
            var dbServerList = GetDbServerNameList();
            foreach (string str in dbServerList)
            {
                string[] dataArr = iniFile.GetSectionValues(str);
                if (dataArr == null)
                    continue;
                string jsonStr = string.Join("", dataArr);
                var dbServerModel = StringHelper.ToObject<DbServer>(jsonStr);
                dbServerModelList.Add(dbServerModel);
            }
            return dbServerModelList;
        }

        /// <summary>
        /// 服务器列表下拉框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboDbServerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDbServerList.SelectedItem == null)
                return;
            string serverName = cboDbServerList.SelectedItem.ToString();
            DbServer dbServerModel = GetDbServer(serverName);

            txtDbServerName.Text = dbServerModel.DbServerName;
            txtDbServerHost.Text = dbServerModel.DbServerHost;
            txtDbServerUserId.Text = dbServerModel.DbServerUserName;
            txtDbServerUserPwd.Text = dbServerModel.DbServerUserPwd;
            txtDbServerPort.Text = dbServerModel.DbServerPort;
            txtDbServerDataBase.Text = dbServerModel.DbServerDataBase;
        }

        /// <summary>
        /// 下拉框变更时候 隐藏主机名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboDbServerList_Enter(object sender, EventArgs e)
        {
            lblDbServerName.Visible = false;
            txtDbServerName.Visible = false;
        }


        private void rdoDbSessionTimeOutCustom_CheckedChanged(object sender, EventArgs e)
        {
            txtDbSessionTimeOutCustom.ReadOnly = false;
        }

        private void rdoDbSessionTimeOutDefault_CheckedChanged(object sender, EventArgs e)
        {
            txtDbSessionTimeOutCustom.ReadOnly = true;
        }

        private void btnDbServerOpenConfig_Click(object sender, EventArgs e)
        {
            string v_OpenFolderPath = iniFile.Path;
            System.Diagnostics.Process.Start("explorer.exe", v_OpenFolderPath);
        }

        private void txtDbSessionTimeOutCustom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }
        }
    }
}
