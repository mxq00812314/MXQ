using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using EP.Common;

namespace StringTool
{
    public partial class fmStringToolBox : Form
    {
        public fmStringToolBox()
        {
            InitializeComponent();
        }

        #region string 解析
        private void btnCreateArray_Click_2(object sender, EventArgs e)
        {
            var rstStr = GetRst();
            txtResult.Text = rstStr;
            tabDiff.SelectedIndex = 1;
        }

        private void btnFormmatJson_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInputStr.Text)) { MessageBox.Show("请输入Json串"); return; }
            txtResult.Text = StringHelper.FormatJsonString(StringHelper.RemoveSpecialChar(txtInputStr.Text));
            tabDiff.SelectedIndex = 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInputStr.Text = "";
            txtResult.Text = "";
        }

        #region 获取户数据
        protected List<string> GetStrArr()
        {
            List<string> rstArr = new List<string>();
            string inputStr = txtInputStr.Text;
            rstArr = txtInputStr.Lines.ToList<string>();
            return rstArr;
        }

        protected string GetRst()
        {
            List<string> strArr = GetStrArr();
            string rstStr = "";
            rstStr += "[";
            foreach (string strItem in strArr)
            {
                string fliedDataName = strItem;
                string tempDataName = "";

                #region 单引号转义
                if (ckDanYin.Checked && fliedDataName.IndexOf('\'') != -1)
                {
                    Regex douReg = new Regex("\'", RegexOptions.IgnoreCase);
                    fliedDataName = douReg.Replace(fliedDataName, "\\'");
                }
                #endregion

                #region 双引号转义
                if (ckShuangYin.Checked && fliedDataName.IndexOf('\"') != -1)
                {
                    Regex yinReg = new Regex("\"", RegexOptions.IgnoreCase);
                    fliedDataName = yinReg.Replace(fliedDataName, "\\\"");
                }
                #endregion

                #region 斜杠转义
                if (ckXieGang.Checked && fliedDataName.IndexOf('\\') != -1)
                {

                    Regex gangReg = new Regex("\\", RegexOptions.Multiline);
                    fliedDataName = gangReg.Replace(fliedDataName, "\\\\");
                }
                #endregion

                #region 逗号转义
                if (ckDanYin.Checked && fliedDataName.IndexOf(',') != -1)
                {
                    Regex douReg = new Regex(",", RegexOptions.IgnoreCase);
                    fliedDataName = douReg.Replace(fliedDataName, "\\,");
                }
                #endregion

                #region 行分隔符拆分
                if (ckRowSplitChar.Checked)
                {
                    var tempFliedDataNameArr = fliedDataName.Split(Char.Parse(txtRowSplitOldChar.Text));
                    fliedDataName = string.Join(txtRowSplitNewChar.Text, tempFliedDataNameArr);
                }

                #endregion

                #region 字段外包裹字符处理
                if (ckStringInclude.Checked)
                {
                    tempDataName = txtStringIncludeBefor.Text + fliedDataName + txtStringIncludeAfter.Text + ", ";
                }
                else
                {
                    tempDataName = fliedDataName + ", ";
                }
                #endregion

                #region 数组格式模式 JSON数据处理

                if (rdoJsonArray.Checked)
                {
                    if (ckStringInclude.Checked)
                    {
                        tempDataName = "\t" + txtStringIncludeBefor.Text + fliedDataName + txtStringIncludeAfter.Text;
                        tempDataName += " : " + fliedDataName + ", \r\n";
                    }
                    else
                    {
                        tempDataName = "\t" + fliedDataName + " : " + txtJsonVal.Text + ", \r\n";
                    }
                }

                #endregion

                rstStr += tempDataName;
            }

            #region 小写处理
            if (rdoStringLower.Checked)
            {
                rstStr = rstStr.ToLower();
            }
            #endregion

            #region 大写处理
            if (rdoStringUpper.Checked)
            {
                rstStr = rstStr.ToUpper();
            }
            #endregion

            #region 去掉最后的 逗号 ","

            rstStr = rstStr.TrimEnd(' ');
            rstStr = rstStr.TrimEnd(',');

            #endregion

            #region 分隔符处理
            if (ckStringSplit.Checked)
            {
                rstStr = rstStr.Replace(',', Char.Parse(txtStringSplit.Text));
            }
            #endregion

            rstStr += "]";
            return rstStr;
        }
        #endregion

        #endregion

        #region List<string> 比较不同
        private void btnCompare_Click(object sender, EventArgs e)
        {
            List<string> leftStrList = new List<string>();
            List<string> rightStrList = new List<string>();
            if (ckSplitByCustom.Checked)
            {
                leftStrList = txtLeftStr.Text.Trim().Split(Char.Parse(txtSplitByCustomStr.Text)).ToList();
                rightStrList = txtRightStr.Text.Trim().Split(Char.Parse(txtSplitByCustomStr.Text)).ToList();
            }
            else {
                leftStrList = txtLeftStr.Lines.ToList();
                rightStrList = txtRightStr.Lines.ToList();
            }

            lblleftData.Text = "左边数据："+ leftStrList.Count;
            lblRightData.Text = "右边数据：" + rightStrList.Count;

            var leftNotEqualArr = leftStrList.Except(rightStrList).ToArray();
            var rightNotEqualArr = rightStrList.Except(leftStrList).ToArray();
            var equalArr = leftStrList.Intersect(rightStrList).ToArray();

            lblLeftMoreThenRightData.Text = "左边比右边多数据：" + leftNotEqualArr.Count(); 
            lblRightMoreThenLeftData.Text = "右边比左边多数据：" + rightNotEqualArr.Count();
            lblEqualData.Text = "左右相同的值：" + equalArr.Count();

            if (ckIsSort.Checked)
            {
                Array.Sort(equalArr);
                Array.Sort(leftNotEqualArr);
                Array.Sort(rightNotEqualArr);
            }

            txtLeftNotEqualStr.Text = string.Join("\r\n", leftNotEqualArr);
            txtRightNotEqualStr.Text = string.Join("\r\n", rightNotEqualArr);
            txtEqualStr.Text = string.Join("\r\n", equalArr);

            //var diffBuilder = new InlineDiffBuilder(new Differ());
            //var diff = diffBuilder.BuildDiffModel(txtLeftNotEqualStr.Text, txtRightNotEqualStr.Text);
            
            //foreach (var line in diff.Lines)
            //{
            //    switch (line.Type)
            //    {
            //        case ChangeType.Inserted:
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.Write("+ ");
            //            break;
            //        case ChangeType.Deleted:
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.Write("- ");
            //            break;
            //        default:
            //            Console.ForegroundColor = ConsoleColor.White;
            //            Console.Write("  ");
            //            break;
            //    }

            //    //Console.WriteLine(line.Text);
            //    rtxtRightNotEqualStr.AppendText(line.Text);
            //}

        }

        private void ckSplitByCustom_CheckedChanged(object sender, EventArgs e)
        {
            txtSplitByCustomStr.Enabled = ckSplitByCustom.Checked;
        }


        #endregion

    }
}
