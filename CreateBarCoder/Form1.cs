using BarcodeLib;
using EP.PlugIn;
using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CreateBarCoder
{
    public partial class Form1 : Form
    {
        private static PrintDocument printDocument1 = new PrintDocument();
        Barcode bar = new Barcode();
        Bitmap printCoderImage = null;

        /// <summary>
        /// 窗体初始化
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbEncodeType.SelectedIndex = 0;
            this.cbBarcodeAlign.SelectedIndex = 0;
            this.cbLabelLocation.SelectedIndex = 0;
            this.cbRotateFlip.DataSource = System.Enum.GetNames(typeof(RotateFlipType));
            int i = 0;
            foreach (object o in cbRotateFlip.Items)
            {
                if (o.ToString().Trim().ToLower() == "rotatenoneflipnone")
                    break;
                i++;
            }
            this.cbEncodeType.SelectedItem = "Code 128";
            this.cbRotateFlip.SelectedIndex = i;
            this.btnBackColor.BackColor = this.bar.BackColor;
            this.btnForeColor.BackColor = this.bar.ForeColor;
            this.txtContent.Focus();
        }

        #region 条码工具

        /// <summary>
        /// 条码前景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnForeColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cdialog = new ColorDialog())
            {
                cdialog.AnyColor = true;
                if (cdialog.ShowDialog() == DialogResult.OK)
                {
                    this.bar.ForeColor = cdialog.Color;
                    this.btnForeColor.BackColor = cdialog.Color;
                }
            }
        }

        /// <summary>
        /// 条码背景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cdialog = new ColorDialog())
            {
                cdialog.AnyColor = true;
                if (cdialog.ShowDialog() == DialogResult.OK)
                {
                    this.bar.BackColor = cdialog.Color;
                    this.btnBackColor.BackColor = cdialog.Color;
                }
            }
        }

        /// <summary>
        /// 输出条码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEncode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContent.Text))
                TipHelper.TipMsg(this, $"请输入标签内容！");

            errorProvider1.Clear();
            int W = Convert.ToInt32(this.txtWidth.Text.Trim());
            int H = Convert.ToInt32(this.txtHeight.Text.Trim());
            bar.Alignment = BarcodeLib.AlignmentPositions.CENTER;

            //条形码对齐
            switch (cbBarcodeAlign.SelectedItem.ToString().Trim().ToLower())
            {
                case "left": bar.Alignment = BarcodeLib.AlignmentPositions.LEFT; break;
                case "right": bar.Alignment = BarcodeLib.AlignmentPositions.RIGHT; break;
                default: bar.Alignment = BarcodeLib.AlignmentPositions.CENTER; break;
            }

            BarcodeLib.TYPE type = BarcodeLib.TYPE.UNSPECIFIED;
            switch (cbEncodeType.SelectedItem.ToString().Trim())
            {
                case "UPC-A": type = BarcodeLib.TYPE.UPCA; break;
                case "UPC-E": type = BarcodeLib.TYPE.UPCE; break;
                case "UPC 2 Digit Ext.": type = BarcodeLib.TYPE.UPC_SUPPLEMENTAL_2DIGIT; break;
                case "UPC 5 Digit Ext.": type = BarcodeLib.TYPE.UPC_SUPPLEMENTAL_5DIGIT; break;
                case "EAN-13": type = BarcodeLib.TYPE.EAN13; break;
                case "JAN-13": type = BarcodeLib.TYPE.JAN13; break;
                case "EAN-8": type = BarcodeLib.TYPE.EAN8; break;
                case "ITF-14": type = BarcodeLib.TYPE.ITF14; break;
                case "Codabar": type = BarcodeLib.TYPE.Codabar; break;
                case "PostNet": type = BarcodeLib.TYPE.PostNet; break;
                case "Bookland/ISBN": type = BarcodeLib.TYPE.BOOKLAND; break;
                case "Code 11": type = BarcodeLib.TYPE.CODE11; break;
                case "Code 39": type = BarcodeLib.TYPE.CODE39; break;
                case "Code 39 Extended": type = BarcodeLib.TYPE.CODE39Extended; break;
                case "Code 39 Mod 43": type = BarcodeLib.TYPE.CODE39_Mod43; break;
                case "Code 93": type = BarcodeLib.TYPE.CODE93; break;
                case "LOGMARS": type = BarcodeLib.TYPE.LOGMARS; break;
                case "MSI": type = BarcodeLib.TYPE.MSI_Mod10; break;
                case "Interleaved 2 of 5": type = BarcodeLib.TYPE.Interleaved2of5; break;
                case "Standard 2 of 5": type = BarcodeLib.TYPE.Standard2of5; break;
                case "Code 128": type = BarcodeLib.TYPE.CODE128; break;
                case "Code 128-A": type = BarcodeLib.TYPE.CODE128A; break;
                case "Code 128-B": type = BarcodeLib.TYPE.CODE128B; break;
                case "Code 128-C": type = BarcodeLib.TYPE.CODE128C; break;
                case "Telepen": type = BarcodeLib.TYPE.TELEPEN; break;
                case "FIM": type = BarcodeLib.TYPE.FIM; break;
                case "Pharmacode": type = BarcodeLib.TYPE.PHARMACODE; break;
                default: TipHelper.TipMsg(this, "请指定条码编码类型！"); break;
            }

            try
            {
                if (type != BarcodeLib.TYPE.UNSPECIFIED)
                {
                    try
                    {
                        bar.BarWidth = textBoxBarWidth.Text.Trim().Length < 1 ? null : (int?)Convert.ToInt32(textBoxBarWidth.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Unable to parse BarWidth: " + ex.Message, ex);
                    }
                    try
                    {
                        bar.AspectRatio = textBoxAspectRatio.Text.Trim().Length < 1 ? null : (double?)Convert.ToDouble(textBoxAspectRatio.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Unable to parse AspectRatio: " + ex.Message, ex);
                    }

                    bar.IncludeLabel = this.chkGenerateLabel.Checked;

                    bar.RotateFlipType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), this.cbRotateFlip.SelectedItem.ToString(), true);

                    //标签对齐和位置
                    switch (this.cbLabelLocation.SelectedItem.ToString().Trim().ToUpper())
                    {
                        case "BOTTOMLEFT": bar.LabelPosition = BarcodeLib.LabelPositions.BOTTOMLEFT; break;
                        case "BOTTOMRIGHT": bar.LabelPosition = BarcodeLib.LabelPositions.BOTTOMRIGHT; break;
                        case "TOPCENTER": bar.LabelPosition = BarcodeLib.LabelPositions.TOPCENTER; break;
                        case "TOPLEFT": bar.LabelPosition = BarcodeLib.LabelPositions.TOPLEFT; break;
                        case "TOPRIGHT": bar.LabelPosition = BarcodeLib.LabelPositions.TOPRIGHT; break;
                        default: bar.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER; break;
                    }

                    //===== 此处执行编码 =====
                    gbxBarCoder.BackgroundImage = bar.Encode(type, this.txtContent.Text.Trim(), this.btnForeColor.BackColor, this.btnBackColor.BackColor, W, H);
                    //===================================

                    //显示编码耗时
                    this.lblEncodingTime.Text = "(" + Math.Round(bar.EncodingTime, 0, MidpointRounding.AwayFromZero).ToString() + "ms)";

                    txtEncoded.Text = bar.EncodedValue;

                    //读取动态计算的宽度/高度，因为用户感兴趣。
                    if (bar.BarWidth.HasValue)
                        txtWidth.Text = bar.Width.ToString();
                    if (bar.AspectRatio.HasValue)
                        txtHeight.Text = bar.Height.ToString();
                }//if

                //条形码图像重新定位到中间
                gbxBarCoder.Location = new Point((this.gbxBarCoder.Location.X + this.gbxBarCoder.Width / 2) - gbxBarCoder.Width / 2, (this.gbxBarCoder.Location.Y + this.gbxBarCoder.Height / 2) - gbxBarCoder.Height / 2);
            }
            catch (Exception ex)
            {
                TipHelper.TipMsg(this, $"{ex.Message}");
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif";
            sfd.FilterIndex = 3;
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BarcodeLib.SaveTypes savetype = BarcodeLib.SaveTypes.UNSPECIFIED;
                switch (sfd.FilterIndex)
                {
                    case 1: /* BMP */  savetype = BarcodeLib.SaveTypes.BMP; break;
                    case 2: /* GIF */  savetype = BarcodeLib.SaveTypes.GIF; break;
                    case 3: /* JPG */  savetype = BarcodeLib.SaveTypes.JPG; break;
                    case 4: /* PNG */  savetype = BarcodeLib.SaveTypes.PNG; break;
                    case 5: /* TIFF */ savetype = BarcodeLib.SaveTypes.TIFF; break;
                    default: break;
                }

                //Bitmap bitmap = new Bitmap(b.EncodedImage);
                //var fff = 140;//(float)Convert.ToDouble(dpiBox.Text);
                //设置其生成图片的dpi
                //bitmap.SetResolution(fff, fff);
                //bitmap.Save(sfd.FileName);
                bar.SaveImage(sfd.FileName, savetype);
            }
        }

        /// <summary>
        /// 条码打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBarCoderPrint_Click(object sender, EventArgs e)
        {
            PrintCoder((Bitmap)gbxBarCoder.BackgroundImage);
        }

        #endregion

        #region 二维码工具

        private void btnEncodeQRCoder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContent.Text))
                TipHelper.TipMsg(this, $"请输入标签内容！");
            gbxQRCoder.BackgroundImage = GenerateQRCcodes(txtContent.Text, (int)numPixelsPerModule.Value);
        }

        private void btnQRCoderPrint_Click(object sender, EventArgs e)
        {
            PrintCoder((Bitmap)gbxQRCoder.BackgroundImage);
        }

        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="QRCodeStr">二维码内容</param>
        /// <param name="pixelsPerModule">像素模块大小</param>
        /// <returns></returns>
        private Bitmap GenerateQRCcodes(string QRCodeStr, int pixelsPerModule)
        {
            QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(QRCodeStr, QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrcode.GetGraphic(pixelsPerModule, Color.Black, Color.White, null, 15, 6, false);
            return qrCodeImage;
        }

        #endregion

        /// <summary>
        /// 保存二维码图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveQRCoder_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif";
            sfd.FilterIndex = 3;
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
                    default: break;
                }

                Bitmap bitmap = new Bitmap(gbxQRCoder.BackgroundImage);
                bitmap.Save(sfd.FileName, tempImageFormat);
            }
        }


        private void PrintCoder(Bitmap coderImage) {

            printCoderImage = coderImage;
            printDocument1 = new PrintDocument();
            printDocument1.PrintController = new StandardPrintController(); //不要打印进度框
            printDocument1.DefaultPageSettings.Landscape = false; //设置打印横向还是纵向  
            printDocument1.PrintPage += new PrintPageEventHandler(MyPrintDoc1_PrintPage);
            try
            {
                printDocument1.Print();
                printDocument1.PrintPage -= new PrintPageEventHandler(MyPrintDoc1_PrintPage);
            }
            catch (Exception ex)
            {
                TipHelper.TipMsg(this, $"打印异常：{ex.Message}");
            }
            printCoderImage = null;
        }

        /// <summary>
        /// 打印事件 豪润-原材料标签 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void MyPrintDoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
                SolidBrush drawBrush = new SolidBrush(Color.Black);//颜色
                StringFormat strFormat = new StringFormat();
                strFormat.FormatFlags = StringFormatFlags.NoWrap;
                Font itemFont = new Font("微软雅黑", 8, FontStyle.Regular);//字体
                
                e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                e.Graphics.DrawImage(printCoderImage, new Point((int)numLeft.Value, (int)numTop.Value));
                e.Graphics.DrawString(
                     $"打印内容：{txtContent.Text}"
                    , itemFont, drawBrush
                    , new Point((int)numLeft.Value, printCoderImage.Height + 20)
                    , strFormat);
                e.HasMorePages = false;
        }
    }
}
