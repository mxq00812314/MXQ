using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckWavFile
{
    public partial class fmCheckVoice : Form
    {
        public fmCheckVoice()
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
            listView1.Clear();
            foreach (string itemDirectory in fileDirectoryList)
            {
                listView1.Items.Add($"{itemDirectory}");
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems != null && listView1.SelectedItems.Count > 0)
            {
                Play(listView1.SelectedItems[0].Text.ToString());
            }
        }

        /// <summary>
        /// 语音服务 自定义语音
        /// </summary>
        /// <param name="voicePath"></param>
        public void Play(string voicePath)
        {
            using (System.Media.SoundPlayer player = new System.Media.SoundPlayer())
            {
                string wavPath = Path.Combine(txtDirectory.Text, $"{voicePath}.wav");
                if (File.Exists(wavPath))
                {
                    player.SoundLocation = wavPath;
                    player.Load();
                    player.Play();
                }
            }
        }
    }
}
