using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace UserControlCollections
{
    public partial class DataGridViewFilter : UserControl
    {

        Point mousePointOnControl;

        public DataGridViewFilter()
        {
            InitializeComponent();

            pnlDataGridViewFilterTitle.MouseDown += new MouseEventHandler(control_MouseDown);
            pnlDataGridViewFilterTitle.MouseMove += new MouseEventHandler(control_MouseMove);
            pnlDataGridViewFilterTitle.MouseUp += new MouseEventHandler(control_MouseUp);
        }



        #region 自定义控件属性

        /// <summary>
        /// 字段列表
        /// </summary>
        private List<string> _FiledList = new List<string>();
        public List<string> FiledList
        {
            get { return FiledList; }
            set
            {
                _FiledList = value;
                cboDataGridViewFilterField.DataSource = value;
            }
        }

        public string FiledPreFix { get; set; }

        /// <summary>
        /// 筛选控件值
        /// </summary>
        public string SelectedFiledValue { get; set; } = "";

        /// <summary>
        /// 操作符
        /// </summary>
        public string FilterOprate
        {
            get
            {
                return (string)cboDataGridViewFilterFieldOperate.SelectedValue;
            }
        }

        /// <summary>
        /// 字段值
        /// </summary>
        private string _FiltreValue = "";
        public string FilterValue
        {
            get
            {
                return (string)txtDataGridViewFilterValue.Text;
            }

            set
            {
                _FiltreValue = value;
                txtDataGridViewFilterValue.Text = value;
            }
        }


        #endregion

        #region 自定义事件

        public delegate void DataGridViewFilterEventHandler(object sender, EventArgs e);
        public event DataGridViewFilterEventHandler FilterYes;


        #endregion

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDataGridViewFilterClose_Click(object sender, EventArgs e)
        {
            SelectedFiledValue = "";
            this.txtDataGridViewFilterValue.Text = "";
            this.Visible = false;
        }

        /// <summary>
        /// 确定按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDataGridViewFilterYes_Click(object sender, EventArgs e)
        {
            string rstStr = "";
            string filedPreFixStr = (!string.IsNullOrWhiteSpace(FiledPreFix) ? FiledPreFix + "." : "");
            string flied = (string)cboDataGridViewFilterField.SelectedValue;
            string opreateStr = "=";
            string value = txtDataGridViewFilterValue.Text;
            if (cboDataGridViewFilterFieldOperate.SelectedValue != null)
            {
                opreateStr = (string)cboDataGridViewFilterFieldOperate.SelectedValue;
            }

            switch (opreateStr)
            {
                case "=":
                case ">":
                case "<":
                case ">=":
                case "<=":
                case "<>":
                    rstStr = $"{filedPreFixStr}`{flied}` {opreateStr} '{value}'";
                    break;
                case "LIKE":
                    rstStr = $"{filedPreFixStr}`{flied}` {opreateStr} '%{value}%'";
                    break;
                default:
                    rstStr = "";
                    break;

            }
            SelectedFiledValue = rstStr;

            //将自定义事件绑定到控件事件上  
            if (FilterYes != null)
            {
                FilterYes(sender, e);
            }
        }

        void control_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 只能左键操作
            {
                this.pnlDataGridViewFilterTitle.Cursor = Cursors.SizeAll;
                Control control = sender as Control;
                mousePointOnControl = control.PointToClient(MousePosition);
            }
        }
        void control_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 只能左键操作
            {
                this.pnlDataGridViewFilterTitle.Cursor = Cursors.Default;
            }
        }

        void control_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePointOnContainer = this.PointToClient(MousePosition); // 鼠标在容器上的相对坐
                this.Location = new Point((mousePointOnContainer.X - mousePointOnControl.X), (mousePointOnContainer.Y - mousePointOnControl.Y));
            }
        }

        private void btnDataGridViewFilterYes_Click_1(object sender, EventArgs e)
        {

        }
    }
}
