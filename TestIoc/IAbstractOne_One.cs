using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestIoc
{
    public interface IAbstractOne_One
    {
        void WirterLine(string meg);
    }

    public class AbstractOne_One : IAbstractOne_One
    {
        public void WirterLine(string meg)
        {
            Console.WriteLine(meg + "-This is TestOne_One");
        }
    }

}
