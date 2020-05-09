namespace Test
{
    public class Dpi
    {

        public Dpi() { }
        /// <summary>
        /// DPI 构造函数
        /// </summary>
        /// <param name="dpiX"></param>
        /// <param name="dpiY"></param>
        public Dpi(int dpiX, int dpiY) {
            this.DpiX = dpiX;
            this.DpiY = dpiY;
        }
        /// <summary>
        /// DPI X
        /// </summary>
        public int DpiX { get; set; } = 96;

        /// <summary>
        ///  DPI Y
        /// </summary>
        public int DpiY { get; set; } = 96;
    }

    public class DpiF
    {
        /// <summary>
        /// DPI X
        /// </summary>
        public float DpiX { get; set; } = 96f;

        /// <summary>
        ///  DPI Y
        /// </summary>
        public float DpiY { get; set; } = 96f;
    }
}