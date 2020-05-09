/*  
* ───────────────────────────────────
* 功 能： N/A
* 类 名： ${ClassNameSpace}.DALFactory
* ───────────────────────────────────
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  ${CreateDateTime.ToString("yyyy-MM-dd HH:mm:ss")}   N/A    初版
*
* ───────────────────────────────────
*/
using System.Reflection;
using System.Configuration;
using ${ClassNameSpace}.IDAL;

namespace ${ClassNameSpace}.DALFactory {

    /// <summary>
    /// This class is implemented following the Abstract Factory pattern to create the DAL implementation
    /// specified from the configuration file
    /// </summary>
    public sealed class DataAccess {

        // Look up the DAL implementation we should be using
        private static readonly string path = ConfigurationManager.AppSettings["DAL"];
        
        private DataAccess() { }

        public static ${ClassNameSpace}.IDAL.I${ClassName.ToPascal()} Create${ClassName.ToPascal()}() {
            string className = path + $".${ClassName.ToPascal()}DAL";
            return (${ClassNameSpace}.IDAL.I${ClassName.ToPascal()})Assembly.Load(path).CreateInstance(className);
        }
    }
}