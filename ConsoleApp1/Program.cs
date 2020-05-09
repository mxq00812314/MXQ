using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTool
{
    class Program
    {
        static void Main(string[] args)
        {
            SpecialGraph s = new SpecialGraph("EP", ' ', '/');
            try
            {
                s.DrawingGraph();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
