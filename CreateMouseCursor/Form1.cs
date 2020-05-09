using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CreateMouseCursor
{
    public partial class Form1 : Form
    {
        Bitmap bitmap = new Bitmap(22, 22);

        Pen blackPen = new Pen(Color.Black);

        Point p0_0 = new Point(7, 7);

        Point p1_1 = new Point(0, 5);
        Point p1_2 = new Point(10, 5);

        Point p2_1 = new Point(5, 0);
        Point p2_2 = new Point(5, 10);

        Bitmap bitmap16 = null;

        string saveConfigDirectory1 = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = Application.ExecutablePath;

            openFile.Filter = "所有文件(*.*) | *.*";
            openFile.FilterIndex = 0;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string fullName = openFile.FileName;
                string fileName = Path.GetFileName(fullName);
                bitmap16 = EP.Common.ImageHelper.GetImage(fullName);
                picMouseImage.Image = bitmap16;
                lblPath.Text = $"选中路径：{fullName}";
            }
        }

        private void btnCreateMouseCursor_Click(object sender, EventArgs e)
        {
            if (bitmap16 != null)
            {
                CreateNewImage(bitmap16);
                return;
            }
            else if (!string.IsNullOrWhiteSpace(saveConfigDirectory1))
            {
                CreateNewImageByDirectoryInfo(saveConfigDirectory1);
                return;
            }
            EP.PlugIn.TipHelper.TipMsg(this, "未选择图片或文件夹！", 1200);
        }

        private void CreateNewImage(Bitmap bitmap16)
        {
            bitmap = new Bitmap(22, 22);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawLine(blackPen, p1_1, p1_2);
            g.DrawLine(blackPen, p2_1, p2_2);
            g.DrawImage(bitmap16, p0_0);
            gbxPre.BackgroundImage = bitmap;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif|Icon (*.icon)|*.icon";
            sfd.FilterIndex = 4;
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ImageFormat tempImageFormat = null;
                switch (sfd.FilterIndex)
                {
                    case 1: /* BMP */  tempImageFormat = ImageFormat.Bmp; break;
                    case 2: /* GIF */  tempImageFormat = ImageFormat.Gif; break;
                    case 3: /* JPG */  tempImageFormat = ImageFormat.Jpeg; break;
                    case 4: /* PNG */  tempImageFormat = ImageFormat.Png; break;
                    case 5: /* TIFF */ tempImageFormat = ImageFormat.Tiff; break;
                    case 6: /* TIFF */ tempImageFormat = ImageFormat.Icon; break;
                    default: break;
                }

                Bitmap bitmap = new Bitmap(gbxPre.BackgroundImage);
                bitmap.Save(sfd.FileName, tempImageFormat);
            }
            bitmap = null;
        }

        private void CreateNewImageByDirectoryInfo(string bitmapPath)
        {
            DirectoryInfo drawFolder = new DirectoryInfo(bitmapPath);
            FileInfo[] drawFileCollections = drawFolder.GetFiles();
            string[] imageExtNames = new string[] { ".jpg", ".png", ".bmp", ".jpeg", ".icon" };
            Graphics g = null;
            foreach (FileInfo file in drawFileCollections)  //遍历文件
            {
                string extName = file.Extension;
                string name = file.Name.Replace(extName, "");
                string filePath = file.FullName;
                bitmap16 = EP.Common.ImageHelper.GetImage(filePath);

                if (Array.IndexOf(imageExtNames, extName.ToLower()) != -1)
                {
                    bitmap = new Bitmap(22, 22);
                    g = Graphics.FromImage(bitmap);

                    g.DrawLine(blackPen, p1_1, p1_2);
                    g.DrawLine(blackPen, p2_1, p2_2);
                    g.DrawImage(bitmap16, p0_0);
                    bitmap.Save($@"{saveConfigDirectory1}\{name}_1{extName}", ImageFormat.Png);
                }
            }
            g?.Dispose();
            EP.PlugIn.TipHelper.TipMsg(this, "生成完成！", 1200);

            saveConfigDirectory1 = "";
            lblPath.Text = $"选中路径：/";
        }

        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            string openConfigDirectory1 = "";
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
                lblPath.Text = $"选中路径：{saveConfigDirectory1}";
            }
        }
    }
}
