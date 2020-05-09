using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTool
{
    public class SpecialGraph
    {
     
        string inputStr = "";
        char[] inputArr = new char[] { };
        char spaceStr = new char();
        char symbolStr = new char();
        public SpecialGraph(string text, char space, char symbol)
        {
            inputStr = text;
            spaceStr = space;
            symbolStr = symbol;
            inputArr = text.ToCharArray();
        }
        /// 将字符以指定符号填充的形式输出到控制台
        /// 需要输出的字符串
        /// 反色符号.建议放空格.
        /// 用于填充的符号.
        public void DrawingGraph()
        {
            Bitmap bm = new Bitmap(inputArr.Length * 20, 20);
            Graphics g = Graphics.FromImage(bm);
            SolidBrush brush = new SolidBrush(Color.Black);
            Font font = new Font("Arial", 12, FontStyle.Italic);
            PointF point = new PointF(0, 0);

            g.Clear(Color.White);
            g.DrawString(inputStr, font, brush, point);

            char[,] outPutArr = new char[bm.Height,bm.Width];
            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    if (bm.GetPixel(x, y).Name == "ffffffff")
                    {
                        outPutArr[y,x] = spaceStr;
                        Console.Write($"{spaceStr}");
                    }
                    else
                    {
                        outPutArr[y,x] = symbolStr;
                        Console.Write(symbolStr);
                    }
                }
                Console.WriteLine();
            }
            g.Dispose();
        }
   
    }
}
