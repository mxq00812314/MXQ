using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MengXQ.Ioc
{
    public interface IDITypeAnalytical
    {
        T GetValue<T>();
    }
}
