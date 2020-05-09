using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MakeEffect
{
    public partial class fmEffect : Form
    {
        [DllImport("Kernel32.dll", EntryPoint = "RtlMoveMemory", SetLastError = true)]
        // Marshal.Copy 居然没有从一个内存地址直接复制到另外一个内存的重载函数        
        private static extern void CopyMemory(IntPtr Dest, IntPtr src, int Length);

        private Bitmap Bmp;
        private IntPtr ImageCopyPointer, ImagePointer;
        private int DataLength;

        public fmEffect()
        {
            InitializeComponent();
        }

        private void fmEffect_Load(object sender, EventArgs e)
        {
            UpdateControlState();
        }

        protected override void OnClosed(EventArgs e)
        {
            if (Bmp != null)
            {
                Bmp.Dispose();
                Marshal.FreeHGlobal(ImageCopyPointer);
            }
            base.OnClosed(e);
        }

        /// <summary>
        /// 打开图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|Png files (*.png)|*.png|All valid files (*.bmp/*.jpg/*.png)|*.bmp;*.jpg;*.png";
            openFileDialog.FilterIndex = 4;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Bmp != null)
                {
                    Bmp.Dispose();
                    Marshal.FreeHGlobal(ImageCopyPointer);
                }
                try
                {
                    Bmp = (Bitmap)Bitmap.FromFile(openFileDialog.FileName);
                    BitmapData BmpData = new BitmapData();
                    Bmp.LockBits(new Rectangle(0, 0, Bmp.Width, Bmp.Height), ImageLockMode.ReadWrite, Bmp.PixelFormat, BmpData);    // 用原始格式LockBits,得到图像在内存中真正地址，这个地址在图像的大小，色深等未发生变化时，每次Lock返回的Scan0值都是相同的。
                    ImagePointer = BmpData.Scan0;                            //  记录图像在内存中的真正地址
                    DataLength = BmpData.Stride * BmpData.Height;           //  记录整幅图像占用的内存大小
                    ImageCopyPointer = Marshal.AllocHGlobal(DataLength);    //  直接用内存数据来做备份，AllocHGlobal在内部调用的是LocalAlloc函数
                    CopyMemory(ImageCopyPointer, ImagePointer, DataLength); //  这里当然也可以用Bitmap的Clone方式来处理，但是我总认为直接处理内存数据比用对象的方式速度快。
                    Bmp.UnlockBits(BmpData);
                    Pic.Image = Bmp;
                    UpdateImage();
                }
                catch (Exception d)
                {
                    MessageBox.Show(d.Message);
                }
            }
        }

        /// <summary>
        /// 高斯模糊
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadBlur_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControlState();
            UpdateImage();
        }

        /// <summary>
        /// 锐化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadSharp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControlState();
            UpdateImage();
        }


        /// <summary>
        /// 设置按钮状态
        /// </summary>
        private void UpdateControlState()
        {
            if (RadBlur.Checked == true)
            {
                ChkExpandEdge.Enabled = true;
                LblAmount.Enabled = false;
                BarAmount.Enabled = false;
                LblANumber.Enabled = false;
            }
            else
            {
                ChkExpandEdge.Enabled = false;
                LblAmount.Enabled = true;
                BarAmount.Enabled = true;
                LblANumber.Enabled = true;
            }
        }

        /// <summary>
        /// 更新图片
        /// </summary>
        private void UpdateImage()
        {
            if (Bmp != null)
            {
                CopyMemory(ImagePointer, ImageCopyPointer, DataLength);             // 需要恢复原始的图像数据，不然模糊就会叠加了。
                Rectangle Rect = new Rectangle(0, 0, Bmp.Width, Bmp.Height);
                Stopwatch Sw = new Stopwatch();
                Sw.Start();
                if (RadBlur.Checked == true)
                    Bmp.GaussianBlur(ref Rect, BarRadius.Value, ChkExpandEdge.Checked);
                else
                    Bmp.UsmSharpen(ref Rect, BarRadius.Value, BarAmount.Value);
                Sw.Stop();
                lblInfo.Text = "耗时：" + Sw.ElapsedMilliseconds.ToString() + "ms";
                Pic.Image = Bmp;
            }
        }

        /// <summary>
        /// 设置高斯模糊范围
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarRadius_Scroll(object sender, EventArgs e)
        {
            LblRNumber.Text = BarRadius.Value.ToString();
        }

        /// <summary>
        /// 更新图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarRadius_MouseUp(object sender, MouseEventArgs e)
        {
            UpdateImage();
        }

        private void BarAmount_Scroll(object sender, EventArgs e)
        {
            LblANumber.Text = BarAmount.Value.ToString();
        }

        private void btnImageSave_Click(object sender, EventArgs e)
        {
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

                Bmp.Save(sfd.FileName, tempImageFormat);
            }
        }

        private void BarAmount_MouseUp(object sender, MouseEventArgs e)
        {
            UpdateImage();
        }
    }
}
