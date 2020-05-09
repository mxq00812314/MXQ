using System.Reflection;
using System.Configuration;

namespace ${ClassNameSpace}.DALFactory {

    /// <summary>
    /// This class is implemented following the Abstract Factory pattern to create the DAL implementation
    /// specified from the configuration file
    /// </summary>
    public sealed class DataAccess {

        // Look up the DAL implementation we should be using
        private static readonly string path = ConfigurationManager.AppSettings["DAL"];
        
        private DataAccess() { }

        public static ${ClassNameSpace}.I${ClassName}DAL Create${ClassName}() {
            string className = path + $".${ClassName}DAL";
            return (${ClassNameSpace}.IDAL.I${ClassName}DAL)Assembly.Load(path).CreateInstance(className);
        }
    }
}
