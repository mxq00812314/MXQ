using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestIoc
{
    public interface IAbstractTwo
    {
        void WriterLine(string meg);
    }

    public class AchieveTwo : IAbstractTwo
    {
        public void WriterLine(string meg)
        {
            Console.WriteLine(meg + "-This is TestTwo");
        }
    }
}
