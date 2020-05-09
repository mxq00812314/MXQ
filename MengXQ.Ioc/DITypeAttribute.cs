using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MengXQ.Ioc
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class DITypeAttribute : Attribute
    {
        public DITypeAttribute() { }

    }
}