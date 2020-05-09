using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    /// <summary>
    /// DataGridView 功能扩展
    /// </summary>
    public class DataGridViewEx : DataGridView
    {
        /// <summary>
        /// DataGridView 扩展对象
        /// </summary>
        public System.Windows.Forms.DataGridView DataGridViewExControl;

        /// <summary>
        /// checkBox 所在列索引
        /// </summary>
        public System.Int32 CheckBoxExColumnIndex = 0;

        public DataGridViewEx(DataGridView DataGridViewControl, int CheckBoxCellIndex = 0)
        {
            this.DataGridViewExControl = DataGridViewControl;
            this.CheckBoxExColumnIndex = CheckBoxCellIndex;
            this.DataGridViewExControl.GridColor = Color.FromArgb(209, 212, 231);
            this.DataGridViewExControl.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(214, 232, 255);
            this.DataGridViewExControl.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 241, 253);
            this.DataGridViewExControl.RowHeadersDefaultCellStyle.ForeColor = Color.FromArgb(214, 232, 255);
            this.DataGridViewExControl.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 241, 253);
            this.BindAllSelectEvent();
        }

        /// <summary>
        ///  列表头添加 全选CheckBox
        /// </summary>
        void BindAllSelectEvent()
        {
            DataGridViewCheckBoxColumn dbCbo = new DataGridViewCheckBoxColumn();
            this.DataGridViewExControl.Columns.Insert(CheckBoxExColumnIndex, dbCbo);
            this.DataGridViewExControl.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(DataGridViewExControl_DataBindingComplete);
            this.DataGridViewExControl.Scroll += new ScrollEventHandler(DataGridViewExCheckBox_Scroll);
            System.Windows.Forms.CheckBox ckBox = new System.Windows.Forms.CheckBox();
            System.Drawing.Rectangle rect = DataGridViewExControl.GetCellDisplayRectangle(CheckBoxExColumnIndex, -1, true);
            ckBox.Name = "ck";
            ckBox.Size = new System.Drawing.Size(13, 13);
            ckBox.Location = new Point(6 + rect.Location.X + DataGridViewExControl.Columns[CheckBoxExColumnIndex].Width / 2 - 13 / 2, rect.Location.Y + 3);
            ckBox.CheckedChanged += new EventHandler(DataGridViewExCheckBox_CheckedChanged);
            this.DataGridViewExControl.Controls.Add(ckBox);
            this.DataGridViewExControl.Columns[CheckBoxExColumnIndex].Width = 30;
        }

        void DataGridViewExCheckBox_Scroll(object sender, EventArgs e)
        {
            if (((ScrollEventArgs)e).ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                var ck = this.DataGridViewExControl.Controls.Find("ck", false).First();
                System.Drawing.Rectangle rect = DataGridViewExControl.GetCellDisplayRectangle(CheckBoxExColumnIndex, -1, true);
                ck.Location = new Point(6 + rect.Location.X + DataGridViewExControl.Columns[CheckBoxExColumnIndex].Width / 2 - 13 / 2, rect.Location.Y + 3);
            }
        }

        void DataGridViewExControl_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Color rowColor = Color.FromArgb(239, 243, 248);
            if (this.DataGridViewExControl.Rows.Count > 0)
            {
                var rowCount = this.DataGridViewExControl.Rows.Count;
                for (int i = 0; i < rowCount; i++)
                {
                    var itemRow = this.DataGridViewExControl.Rows[i] ;
                    
                    if (i % 2 == 0)
                    {
                        itemRow.DefaultCellStyle.BackColor = rowColor;
                    }

                }
            }
        }

        /// <summary>
        /// 全选/反选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DataGridViewExCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var rowCount = this.DataGridViewExControl.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                this.DataGridViewExControl.Rows[i].Cells[this.CheckBoxExColumnIndex].Value = ((System.Windows.Forms.CheckBox)sender).Checked;
            }
            this.DataGridViewExControl.EndEdit();
        }

        /// <summary>
        /// DataGridView --> 获取选中行
        /// </summary>
        /// <returns></returns>
        public static List<DataGridViewRow> DataGridViewSelectedRow(object sender, int checkboxInddx)
        {
            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
            int ckedCount = ((DataGridView)sender).Rows.Count;
            for (int i = 0; i < ckedCount; i++)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)((DataGridView)sender).Rows[i].Cells[checkboxInddx];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {
                    selectedRows.Add(((DataGridView)sender).Rows[i]);
                }
            }
            return selectedRows;
        }

        /// <summary>
        /// DataGridView --> 获取选中行 某列值
        /// </summary>
        /// <returns></returns>
        public static List<string> DataGridViewSelectedFliedList(object sender, int checkboxInddx, int cellIndexValue = 1)
        {
            List<string> selectedFliedList = new List<string>();
            int ckedCount = ((DataGridView)sender).Rows.Count;
            for (int i = 0; i < ckedCount; i++)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)((DataGridView)sender).Rows[i].Cells[checkboxInddx];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {
                    try
                    {
                        selectedFliedList.Add(((DataGridView)sender).Rows[i].Cells[cellIndexValue].Value.ToString());
                    }
                    catch
                    {
                        selectedFliedList.Add(((DataGridView)sender).Rows[i].Cells[cellIndexValue].FormattedValue.ToString());
                    }
                }
            }
            return selectedFliedList;
        }
    }
}
