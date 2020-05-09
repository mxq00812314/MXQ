using Common.SystemAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class fmTest : Form
    {
        public fmTest()
        {
            InitializeComponent();

        }

        private void fmTest_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 获取系统dipi
        /// </summary>
        /// <returns></returns>
        public static Dpi GetDPI()
        {
            using (ManagementClass mc = new ManagementClass("Win32_DesktopMonitor"))
            {

                Dpi ScreenDPI = new Dpi();
                using (ManagementObjectCollection moc = mc.GetInstances())
                {
                    int PixelsPerXLogicalInch = 0; // dpi for x
                    int PixelsPerYLogicalInch = 0; // dpi for y

                    foreach (ManagementObject each in moc)
                    {
                        PixelsPerXLogicalInch = int.Parse((each.Properties["PixelsPerXLogicalInch"].Value.ToString()));
                        PixelsPerYLogicalInch = int.Parse((each.Properties["PixelsPerYLogicalInch"].Value.ToString()));

                        ScreenDPI.DpiX = PixelsPerXLogicalInch;
                        ScreenDPI.DpiY = PixelsPerYLogicalInch;
                    }
                }
                return ScreenDPI;
            }
        }

        private static float inLenf = 25.399999961392f;

        /// <summary>
        /// 厘米转像素
        /// </summary>
        /// <param name="cm"></param>
        /// <param name="fDPI"></param>
        /// <returns></returns>
        public static float CentimeterToPiToPixel(float cm, float fDPI)
        {
            return (float)Math.Round((cm * 10 * fDPI / inLenf), 2);
        }


        /// <summary>
        /// 毫米转为像素(注：dpi分水平和垂直，获取方法为得到 Graphics 的实例化对象 g，调用g.DpiX、g.DpiY)
        /// </summary>
        /// <param name="mm">毫米</param>
        /// <param name="fDPI">分辨率(水平/垂直)</param>
        /// <returns></returns>
        public static float MillimetersToPixel(float mm, float fDPI)
        {
            //毫米转像素：mm * dpi / 25.4 
            return (float)Math.Round((mm * fDPI / inLenf), 2);
        }

        /// <summary>
        /// 像素转为毫米(注：dpi分水平和垂直，获取方法为得到 Graphics 的实例化对象 g，调用g.DpiX、g.DpiY)
        /// </summary>
        /// <param name="px">像素</param>
        /// <param name="fDPI">分辨率(水平/垂直)</param>
        /// <returns></returns>
        public static float PixelToMillimeters(float px, float fDPI)
        {
            //像素转毫米：px * 25.4 / dpi
            return (float)Math.Round(((px * inLenf) / fDPI), 2); ;
        }

        /// <summary>
        /// 英寸到像素
        /// </summary>
        /// <param name="inches"></param>
        /// <returns></returns>
        public static float InchesToPixels(float inches, float fDPI)
        {
            return (float)Math.Round(inches * fDPI, 2);
        }

        /// <summary>
        /// 像素到英寸
        /// </summary>
        /// <param name="px"></param>
        /// <returns></returns>
        public static float PixelsToInches(float px, float fDPI)
        {
            return (float)Math.Round(px / fDPI, 2);
        }
        /// <summary>
        /// 毫米到英寸
        /// </summary>
        /// <param name="mm"></param>
        /// <returns></returns>
        public static float MillimetersToInches(float mm)
        {
            return (float)Math.Round(mm / inLenf, 2);
        }
        /// <summary>
        /// 英寸到毫米
        /// </summary>
        /// <param name="mm"></param>
        /// <returns></returns>
        public static float InchesToMillimeters(float Inches)
        {
            return (float)Math.Round(Inches * inLenf, 2);
        }

        private static PrintDocument printDocument1 = new PrintDocument();//获取默认打印机
        private void button1_Click(object sender, EventArgs e)
        {
            Dpi screenDpi = GetDPI();
            Dpi gDpi = new Dpi((int)numDpiX.Value, (int)numDpiY.Value);
            Pen penRed = new Pen(Color.Red, 1);//设置笔的粗细为,颜色为红色
            Pen penGreen = new Pen(Color.Green, 1);//设置笔的粗细为,颜色为红色
            Brush brushRed = new SolidBrush(Color.Black);

            PointF p1_1 = new PointF();
            PointF p1_2 = new PointF();

            PointF p2_1 = new PointF();
            PointF p2_2 = new PointF();


            var xLen = CentimeterToPiToPixel(10, gDpi.DpiX);
            var yLen = CentimeterToPiToPixel(10, gDpi.DpiY);
            var mmxLen = CentimeterToPiToPixel(0.1f, gDpi.DpiX);
            var mmyLen = CentimeterToPiToPixel(0.1f, gDpi.DpiY);

            //设置一个30cm高15cm 的画布
            Bitmap b1 = new Bitmap((int)CentimeterToPiToPixel(30, gDpi.DpiX), (int)CentimeterToPiToPixel(15, gDpi.DpiY));
            b1.SetResolution(gDpi.DpiX, gDpi.DpiY);
            Graphics g = Graphics.FromImage(b1);

            p1_1 = new PointF(50, 40);
            p1_2 = new PointF(p1_1.X + xLen, p1_1.Y);


            p2_1 = new PointF(50, 40);
            p2_2 = new PointF(p2_1.X, p2_1.Y + yLen);

            //10cm 横线
            g.DrawLine(penRed, p1_1, p1_2);
            int m = 0, cm = 0;
            //刻度
            for (float i = 0, j = xLen; i <= j;)
            {
                if (m % 10 == 0 || i == j)
                {
                    g.DrawLine(penRed, p1_1.X + i, p1_1.Y - 15, p1_1.X + i, p1_1.Y);
                    g.DrawString($"{cm}", new Font("宋体", 9f), brushRed, new PointF(p1_1.X + i - 2, p1_1.Y + 5f));
                    cm++;
                }
                if (m % 5 == 0 && m % 10 != 0)
                {
                    g.DrawLine(penRed, p1_1.X + i, p1_1.Y - 10, p1_1.X + i, p1_1.Y);
                }
                else
                {
                    g.DrawLine(penRed, p1_1.X + i, p1_1.Y - 5, p1_1.X + i, p1_1.Y);
                }
                i += mmxLen;
                m++;
            }

            g.DrawLine(penRed, p1_2.X, p1_2.Y - 15, p1_2.X, p1_2.Y);
            g.DrawString($"{cm}", new Font("宋体", 9f), brushRed, new PointF(p1_2.X - 2, p1_2.Y + 5f));

            g.DrawLine(penRed, p2_1, p2_2);
            //10cm竖线
            m = 0;
            cm = 0;
            //刻度
            for (float i = 0, j = yLen; i <= j;)
            {
                if (m % 10 == 0 || i == j)
                {
                    g.DrawLine(penRed, p1_1.X - 15, p1_1.Y + i, p1_1.X, p1_1.Y + i);
                    g.DrawString($"{cm}", new Font("宋体", 9f), brushRed, new PointF(p1_1.X, p1_1.Y + i - 5f));
                    cm++;
                }
                if (m % 5 == 0 && m % 10 != 0)
                {
                    g.DrawLine(penRed, p1_1.X - 10, p1_1.Y + i, p1_1.X, p1_1.Y + i);
                }
                else
                {
                    g.DrawLine(penRed, p1_1.X - 5, p1_1.Y + i, p1_1.X, p1_1.Y + i);
                }
                i += mmyLen;
                m++;
            }
            g.DrawLine(penRed, p2_2.X - 15, p2_2.Y, p2_2.X, p2_2.Y);
            g.DrawString($"{cm}", new Font("宋体", 9f), brushRed, new PointF(p2_2.X, p2_2.Y - 5f));
            g.DrawString($"画一根长度10cm的直线 屏幕DPI【{screenDpi.DpiX},{screenDpi.DpiY}】 画布DPI【{g.DpiX},{g.DpiY}】", new Font("宋体", 9f), brushRed, new PointF(p1_1.X + 20, p1_1.Y + 30f));

            this.BackgroundImageLayout = ImageLayout.None;
            this.BackgroundImage = b1;

            //printDocument1 = new PrintDocument();
            //printDocument1.PrintController = new StandardPrintController(); //不要打印进度框
            //printDocument1.DefaultPageSettings.Landscape = false; //设置打印横向还是纵向  
            //printDocument1.PrintPage += new PrintPageEventHandler(MyPrintDoc1_PrintPage);
            //try
            //{
            //    printDocument1.Print();
            //    printDocument1.PrintPage -= new PrintPageEventHandler(MyPrintDoc1_PrintPage);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("请安装打印机", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        protected void MyPrintDoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
            DpiF dpiF = new DpiF();
            dpiF.DpiX = e.Graphics.DpiX;
            dpiF.DpiY = e.Graphics.DpiY;

            var xLen = CentimeterToPiToPixel(10, 100);
            var yLen = CentimeterToPiToPixel(10, 100);

            PointF p1_1 = new PointF();
            PointF p1_2 = new PointF();

            PointF p2_1 = new PointF();
            PointF p2_2 = new PointF();

            p1_1 = new PointF(10, 10);
            p1_2 = new PointF(p1_1.X + xLen, p1_1.Y);
            p2_1 = new PointF(10, 20);
            p2_2 = new PointF(p2_1.X + 100, p2_1.Y);

            Pen penRed = new Pen(Color.Red, 1);//设置笔的粗细为,颜色为红色
            Pen penGreen = new Pen(Color.Green, 1);//设置笔的粗细为,颜色为红色

            e.Graphics.DrawLine(penRed, p1_1, p1_2);
            e.Graphics.DrawLine(penGreen, p2_1, p2_2);
            e.HasMorePages = false;


        }
    }
}
