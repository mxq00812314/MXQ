using MengXQ.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestIoc
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IoCTest

            IIoCKernel iocKernel = new IoCKernel();
            iocKernel.Bind<IAbstractOne>().To<AchieveOne>();
            iocKernel.Bind<IAbstractTwo>().To<AchieveTwo>();
            iocKernel.Bind<IAbstractOne_One>().To<AbstractOne_One>();
            iocKernel.Bind<IAbstractOne_Two>().To<AbstractOne_Two>();
            DITest diType = iocKernel.GetValue<DITest>();
            diType.Writer("IoC Frame Work Test");
            #endregion

            Console.ReadLine();
        }
    }


    public class DITest
    {
        private IAbstractOne _AbstractOne;
        public DITest(IAbstractOne abstractone)
        {
            _AbstractOne = abstractone;
        }

        private IAbstractTwo _AbstractTwo;

        [DIType]
        public IAbstractTwo AbstractTwo
        {
            get
            {
                return _AbstractTwo;
            }
            set
            {
                _AbstractTwo = value;
            }
        }

        public void Writer(string meg)
        {
            _AbstractOne.WriterLine(meg);
            _AbstractTwo.WriterLine(meg);
        }
    }

}
