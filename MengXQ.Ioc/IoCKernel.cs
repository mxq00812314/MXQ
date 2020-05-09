using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MengXQ.Ioc
{
    public class IoCKernel : IIoCKernel
    {
        private Type _BaseType;

        public IoCKernel()
        {
            IoCContext.Context.DITyoeInfoManage = new DITypeInfoManage();
        }

        public IIoCKernel Bind<T>()
        {
            _BaseType = typeof(T);
            return this;
        }

        public IIoCKernel To<U>() where U : class
        {
            Type achieveType = typeof(U);
            if (achieveType.BaseType == _BaseType || achieveType.GetInterface(_BaseType.Name) != null)
            {
                IoCContext.Context.DITyoeInfoManage.AddTypeInfo(_BaseType, achieveType);
            }
            return this;
        }

        public V GetValue<V>() where V : class
        {
            return IoCContext.Context.DITypeAnalyticalProvider.CreteDITypeAnalaytical().GetValue<V>();
        }
    }
}
