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
    public partial class fmModifyCode : Form
    {
        #region 公共属性字段
        public string RstModifyCodeString { get; set; } = "";

        public delegate void ModifyCodeEventHandler(object sender, EventArgs e);
        public event ModifyCodeEventHandler McYes;

        #endregion

        public fmModifyCode(DataTable dt)
        {
            InitializeComponent();

            #region 表结构 复选框初始化

            new Common.DataGridViewEx(dgvTableStructure);

            #endregion

            if (dt!=null && dt.Rows.Count > 0)
            {
                dgvTableStructure.DataSource = dt;
                DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
                cmb.HeaderText = "表单类型";
                cmb.Name = "FormControlType";
                cmb.MaxDropDownItems = 4;
                cmb.Items.Add("Text");
                cmb.Items.Add("Select");
                //cmb.Items.Add("Radio");
                //cmb.Items.Add("Checkbox");
                cmb.DefaultCellStyle.NullValue = "Text";
                dgvTableStructure.Columns.Insert(3, cmb);
            }
        }

        private string GetRstString()
        {
            var rstStr = $"{dgvTableStructure.Rows.Count}\t条记录";
            var htmlStr = "//=========================================\r\n//            维护Dlg\r\n//=========================================\r\n\r\n";
            var jsParmsStr = "///=========================================\r\n//            JS变量\r\n///=========================================\r\n\r\n";
            var ajaxParmsStr = "///=========================================\r\n//            Ajax参数\r\n///=========================================\r\n\r\n";
            var addJsParmsStr = "///=========================================\r\n//            添加Dlg参数\r\n///=========================================\r\n\r\n";
            var editJsParmsStr = "///=========================================\r\n//           编辑Dlg参数\r\n///=========================================\r\n\r\n";
            var temlTitlelStr = "///=========================================\r\n//            模版列表表头\r\n///=========================================\r\n\r\n";
            var temlItemlStr = "//=========================================\r\n//            模版列表内容项\r\n///=========================================\r\n\r\n";

            var ckedFileList = Common.DataGridViewEx.DataGridViewSelectedFliedList(dgvTableStructure, 0);

            for (int i = 0; i < dgvTableStructure.Rows.Count; i++)
            {
                var row = dgvTableStructure.Rows[i];
                var fieldName = row.Cells["列名"].Value;
                var fieldDesc = row.Cells["说明"].Value;
                var fildFormType = row.Cells["FormControlType"].FormattedValue;

                #region 正选/反选处理

                if (rdoMofifyFaceSide.Checked)
                {
                    if (ckedFileList.Count > 0 && !ckedFileList.Contains(fieldName))
                        continue;
                }

                if (rdoMofifyReverSide.Checked)
                {
                    if (ckedFileList.Count > 0 && ckedFileList.Contains(fieldName))
                        continue;
                }
                #endregion

                htmlStr += GetFormTypeToHtml(fieldName, fieldDesc, fildFormType, 1);
                jsParmsStr += GetFormTypeToHtml(fieldName, fieldDesc, fildFormType, 2);
                ajaxParmsStr += GetFormTypeToHtml(fieldName, fieldDesc, fildFormType, 3);
                addJsParmsStr += GetFormTypeToHtml(fieldName, fieldDesc, fildFormType, 4);
                editJsParmsStr += GetFormTypeToHtml(fieldName, fieldDesc, fildFormType, 5);
                temlTitlelStr += GetFormTypeToHtml(fieldName, fieldDesc, fildFormType, 6);
                temlItemlStr += GetFormTypeToHtml(fieldName, fieldDesc, fildFormType, 7);
            }
            temlTitlelStr += "<td>操作</td>\r\n";
            //            列表表头           列表内容      维护HtmlTag  js变量          添加弹窗参数       编辑弹窗参数        保存Ajax参数
            rstStr += $"{temlTitlelStr}\r\n{temlItemlStr}\r\n{htmlStr}\r\n{jsParmsStr}\r\n{addJsParmsStr}\r\n{editJsParmsStr}\r\n{ajaxParmsStr}";
            return rstStr;
        }

        private string GetFormTypeToHtml(object fieldName, object fieldDesc, object formType, int opReturnType = 1)
        {
            string rstStr = "", formTypeStr = "", lowerFildName = "";
            if (fieldName == null) return "";
            if (formType == null) return "";
            fieldName = fieldName.ToString().Substring(0, 1).ToUpper() + fieldName.ToString().Substring(1);
            lowerFildName = fieldName.ToString().ToLower();
            formTypeStr = formType.ToString();

            switch (formTypeStr)
            {
                case "Select":
                    if (opReturnType == 1) rstStr = $"<tr><td class=\"column_name\">{fieldDesc}</td><td><select id=\"slt{fieldName}\" class=\"title_ipt\" ><option value=\"2\">否</option><option value=\"1\">是</option></select></td></tr>\r\n";
                    if (opReturnType == 2) rstStr = $" var ${fieldName} = $('#slt{fieldName}');\r\n";
                    if (opReturnType == 3) rstStr = $" {fieldName} : $.trim(${fieldName}.val()),\r\n";
                    if (opReturnType == 4) rstStr = $" ${fieldName}.find(\"option: eq(0)\").attr(\"selected\", true);\r\n";
                    if (opReturnType == 5) rstStr = $" ${fieldName}.find(\"option[value = '\" + $that.{lowerFildName} + \"']\").attr(\"selected\", true).siblings().attr('selected', false);\r\n";
                    if (opReturnType == 6) goto default;
                    if (opReturnType == 7) goto default;
                    break;
                case "Text":
                default:
                    if (opReturnType == 1) rstStr = $"<tr><td class=\"column_name\"><div class=\"air - input - top\">{fieldDesc}</td><td><input type = \"text\" id=\"txt{fieldName}\" value=\"\" maxlength=\"50\" class=\"title_ipt w100 mar0 not_input\" /></div></td></tr>\r\n";
                    if (opReturnType == 2) rstStr = $" var ${fieldName} = $('#txt{fieldName}');\r\n";
                    if (opReturnType == 3) rstStr = $" {fieldName} : $.trim(${fieldName}.val()),\r\n";
                    if (opReturnType == 4) rstStr = $" ${fieldName}.val('');\r\n";
                    if (opReturnType == 5) rstStr = $" ${fieldName}.val($that.{lowerFildName});\r\n";
                    if (opReturnType == 6) rstStr = "<td>" + fieldDesc + "</td>\r\n";
                    if (opReturnType == 7) rstStr = "<td>{{=item." + lowerFildName + " || ''}}</td>\r\n";
                    break;
            }
            return rstStr;
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            RstModifyCodeString = GetRstString();

            //将自定义事件绑定到控件事件上  
            if (McYes != null)
            {
                McYes(sender, e);
            }
        }
    }
}
