using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestIoc
{
    public interface IAbstractOne_Two
    {
        void WriterLine(string meg);
    }

    public class AbstractOne_Two : IAbstractOne_Two
    {
        public void WriterLine(string meg)
        {
            Console.WriteLine(meg + "-This is TestOne_Two");
        }
    }

}
