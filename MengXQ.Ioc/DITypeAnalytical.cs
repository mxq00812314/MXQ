using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MengXQ.Ioc
{
    public class DITypeAnalytical : IDITypeAnalytical
    {

        public T GetValue<T>()
        {
            Type type = typeof(T);
            return (T)TypeAnalytical(type);
        }

        private object TypeAnalytical(Type type)
        {
            ConstructorInfo[] constructorInfos = type.GetConstructors();
            object instance = null;
            #region 构造函数注入
            foreach (ConstructorInfo conInfo in constructorInfos)
            {
                if (conInfo.GetParameters().Length > 0)
                {
                    ParameterInfo[] paras = conInfo.GetParameters();
                    List<object> args = new List<object>();

                    foreach (ParameterInfo para in paras)
                    {
                        if (IoCContext.Context.DITyoeInfoManage.ContainsKey(para.ParameterType))
                        {
                            object par = TypeAnalytical(IoCContext.Context.DITyoeInfoManage.GetTypeInfo(para.ParameterType));
                            args.Add(par);
                        }
                    }
                    instance = CreateInstance(type, args.ToArray());
                    break;
                }
            }
            #endregion
            if (instance == null)
            {
                instance = CreateInstance(type);
            }
            #region 属性注入
            if (type.GetProperties().Length > 0)
            {
                PropertyInfo[] proertyInfos = type.GetProperties();
                foreach (PropertyInfo propertyInfo in proertyInfos)
                {
                    if (propertyInfo.GetCustomAttributes(typeof(DITypeAttribute), false).Length > 0)
                    {
                        if (IoCContext.Context.DITyoeInfoManage.ContainsKey(propertyInfo.PropertyType))
                        {
                            object propertyvalue = TypeAnalytical(IoCContext.Context.DITyoeInfoManage.GetTypeInfo(propertyInfo.PropertyType));
                            propertyInfo.SetValue(instance, propertyvalue, null);
                        }
                    }
                }
            }
            #endregion

            return instance;
        }

        private object CreateInstance(Type type, params object[] args)
        {
            return Activator.CreateInstance(type, args);
        }
    }
}
