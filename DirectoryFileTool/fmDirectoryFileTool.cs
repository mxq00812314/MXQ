using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DirectoryFileTool
{
    public partial class fmDirectoryFileTool : Form
    {
        public fmDirectoryFileTool()
        {
            InitializeComponent();
        }



        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            string saveConfigDirectory1 = "";
            string openConfigDirectory1 = txtDirectory.Text.Trim();
            if (string.IsNullOrWhiteSpace(openConfigDirectory1))
            {
                folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            }
            else
            {
                if (!Directory.Exists(openConfigDirectory1))
                {
                    Directory.CreateDirectory(openConfigDirectory1);
                }
                folderBrowserDialog1.SelectedPath = $@"{openConfigDirectory1}";
            }

            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                saveConfigDirectory1 = folderBrowserDialog1.SelectedPath;
                txtDirectory.Text = saveConfigDirectory1;
            }

            if (string.IsNullOrWhiteSpace(saveConfigDirectory1)) return;
            var fileDirectoryList = GetDirectoryFileNameList(saveConfigDirectory1);
            foreach (string itemDirectory in fileDirectoryList) {
                txtDirectoryList.Text +=$"{itemDirectory},\r\n";
            }
        }


        /// <summary>
        /// 查询载入图纸名称 
        /// </summary>
        /// <returns></returns>
        private static List<string> GetDirectoryFileNameList(string directoryInfoPath)
        {
            DirectoryInfo theFolder = new DirectoryInfo(directoryInfoPath);
            FileInfo[] fileInfo = theFolder.GetFiles();
            var list = new List<string>();
            foreach (FileInfo file in fileInfo)  //遍历文件
            {
                list.Add(file.Name.Replace(file.Extension, ""));
            }
            return list;
        }
    }
}
