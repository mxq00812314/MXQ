
using DBManager;
using EP.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBLite.SQLBang
{
    public partial class fmTableCompare : Form
    {
        public MySqlDBHelper sh = null;
        public MySqlDBHelper sh2 = null;
        IniFileHelper iniFile = new IniFileHelper();

        public fmTableCompare()
        {
            InitializeComponent();
        }        

        private void fmTableCompare_Load(object sender, EventArgs e)
        {
            cboDbCon1.DataSource = GetDbServerNameList();
            cboDbCon2.DataSource = GetDbServerNameList();

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
    }
}
