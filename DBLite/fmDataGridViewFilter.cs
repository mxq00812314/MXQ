using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBLite
{
    public partial class fmDataGridViewFilter : Form
    {

        #region 公共属性字段

        public string FiledPreFix { get; set; } = "";
        public string SelectedFiledValue { get; set; } = "";

        public delegate void DataGridViewFilterEventHandler(object sender, EventArgs e);
        public event DataGridViewFilterEventHandler FilterYes;

        public delegate void DataGridViewFilterCloserEventHandler(object sender);
        public event DataGridViewFilterCloserEventHandler FilterClose;

        public fmDataGridViewFilter(List<string> _FiledList)
        {
            InitializeComponent();
            cboDataGridViewFilterField.DataSource = _FiledList;
        }

        #endregion

        private void fmDataGridViewFilter_Load(object sender, EventArgs e)
        {
            cboDataGridViewFilterFieldOperate.SelectedIndex = 0;

            TreeView tv = tvDataGridViewFilterItem;

            TreeNode tnRoot = new TreeNode();
            tnRoot.Text = "WHERE";
            tnRoot.ToolTipText = " WHERE ";
            tnRoot.Name = "where";

            tv.Scrollable = true;
            tv.TopNode = tnRoot;
            tv.Nodes.Add(tnRoot);
            tv.SelectedNode = tnRoot;
            tv.ExpandAll();
        }

        /// <summary>
        /// 筛选过滤执行按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDataGridViewFilterYes_Click(object sender, EventArgs e)
        {
            SelectedFiledValue = filterGetCondition();

            //将自定义事件绑定到控件事件上  
            if (FilterYes != null)
            {
                FilterYes(sender, e);
            }
        }

        /// <summary>
        /// 获取完整过滤条件
        /// </summary>
        /// <returns></returns>
        private string filterGetCondition()
        {
            var rst = "";
            var rootTn = tvDataGridViewFilterItem.Nodes[0];
            foreach (TreeNode tn in rootTn.Nodes)
            {
                if (tn.Name == "filterItem")
                    rst += tn.Text;

            }
            return rst;
        }

        /// <summary>
        /// 获取过滤条件
        /// </summary>
        /// <returns></returns>
        private string getFilterString()
        {
            string rstStr = "";
            string filedPreFixStr = (!string.IsNullOrWhiteSpace(FiledPreFix) ? FiledPreFix + "." : "");
            string flied = (string)cboDataGridViewFilterField.SelectedItem;

            string opreateStr = "=";
            if (cboDataGridViewFilterFieldOperate.SelectedItem != null)
                opreateStr = (string)cboDataGridViewFilterFieldOperate.SelectedItem;

            string value = txtDataGridViewFilterValue.Text;


            string leftBrackets = "";
            string rightBrackets = "";
            string logicOpString = "";

            if (cboLeftBrackets.SelectedItem != null)
                leftBrackets = (string)cboLeftBrackets.SelectedItem;
            if (cboRightBrackets.SelectedItem != null)
                rightBrackets = (string)cboRightBrackets.SelectedItem;
            if (cboLogicOpStr.SelectedItem != null)
                logicOpString = (string)cboLogicOpStr.SelectedItem;

            switch (opreateStr)
            {
                case "=":
                case ">":
                case "<":
                case ">=":
                case "<=":
                case "<>":
                    rstStr = $" {leftBrackets} {logicOpString} {filedPreFixStr}`{flied}` {opreateStr} '{value}' {rightBrackets}";
                    break;
                case "LIKE":
                    rstStr = $" {leftBrackets} {logicOpString} {filedPreFixStr}`{flied}` {opreateStr} '%{value}%' {rightBrackets}";
                    break;
                default:
                    rstStr = "";
                    break;

            }
            return rstStr;
        }

        /// <summary>
        /// 窗体关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmDataGridViewFilter_FormClosed(object sender, FormClosedEventArgs e)
        {
            SelectedFiledValue = "";
            txtDataGridViewFilterValue.Text = "";
            cboDataGridViewFilterField.DataSource = new List<string>();

            //将自定义事件绑定到控件事件上  
            if (FilterClose != null)
            {
                FilterClose(sender);
            }
        }

        private void cboLeftBrackets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLeftBrackets.SelectedItem != null)
            {
                cboRightBrackets.SelectedIndex = cboLeftBrackets.SelectedIndex;
                cboLogicOpStr.SelectedIndex = 0;
            }
        }

        private void cboRightBrackets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRightBrackets.SelectedItem != null)
            {
                cboLeftBrackets.SelectedIndex = cboRightBrackets.SelectedIndex;
                cboLogicOpStr.SelectedIndex = 0;
            }
        }

        private void btnDataGridViewSubAppendFilter_Click(object sender, EventArgs e)
        {
            AppendFilterItem(getFilterString());
        }

        private void btnDataGridViewAppendFilterDel_Click(object sender, EventArgs e)
        {
            var tn = tvDataGridViewFilterItem.SelectedNode;
            if (tn != null)
            {
                if (tn.Name == "filterItem")
                    tn.Remove();
            }

            if (tvDataGridViewFilterItem.Nodes[0].Nodes.Count == 0)
            {
                cboLogicOpStr.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// 筛选条件追加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDataGridViewAppendFilter_Click(object sender, EventArgs e)
        {
            AppendFilterItem(getFilterString());
        }

        /// <summary>
        /// 左边括号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeftBrackets_Click(object sender, EventArgs e)
        {
            AppendFilterItem(" ( ");
        }

        /// <summary>
        /// 右边括号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRightBrackets_Click(object sender, EventArgs e)
        {
            AppendFilterItem(" ) ");
        }

        /// <summary>
        /// 逻辑操作符 AND
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeftlogicAnd_Click(object sender, EventArgs e)
        {
            AppendFilterItem(" AND ");
        }

        /// <summary>
        /// 逻辑操作符 OR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeftlogicOr_Click(object sender, EventArgs e)
        {
            AppendFilterItem(" OR ");
        }

        /// <summary>
        /// 追加筛选项目
        /// </summary>
        /// <param name="filterItemStr"></param>
        private void AppendFilterItem(string filterItemStr)
        {
            var tn = tvDataGridViewFilterItem.SelectedNode;
            if (tn != null)
            {
                var node = new TreeNode();
                node.Name = "filterItem";
                node.Text = filterItemStr;
                node.ToolTipText = filterItemStr;

                if (tn.Name == "where")
                    tn.Nodes.Add(node);
                else
                    tn.Parent.Nodes.Add(node);
            }
            if (tvDataGridViewFilterItem.Nodes[0].Nodes.Count > 0) {
                cboLogicOpStr.SelectedIndex = 0; 
            }
            tvDataGridViewFilterItem.ExpandAll();
        }

    }

    public class DataGridViewFilter
    {

        public string FilterKey { get; set; }

        public string FilterOp { get; set; }

        public string FilterValue { get; set; }
    }

}

