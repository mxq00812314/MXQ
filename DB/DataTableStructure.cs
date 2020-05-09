using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class DataTableStruct
    {
        /// <summary>
        /// 类描述
        /// </summary>
        public string ClassDescription { get; set; }

        /// <summary>
        /// 类命名空间
        /// </summary>
        public string ClassNameSpace { get; set; }

        /// <summary>
        /// 类名
        /// </summary>
        public DataName ClassName { get; set; }

        /// <summary>
        /// T_SQL 参数前缀
        /// </summary>
        public string ParmPrefix { get; set; }

        /// <summary>
        /// 数据库表名称
        /// </summary>
        public DataName Table { get; set; }

        /// <summary>
        /// 数据行列名
        /// </summary>
        public List<DataColumnStruct> DataColumnCollection { get; set; }

        /// <summary>
        /// 数据列个数
        /// </summary>
        public int DataRowCount => DataColumnCollection?.Count() ?? 0;

        /// <summary>
        /// 主键列
        /// </summary>
        public DataColumnStruct PrimaryKeyColumn => DataColumnCollection?.Count > 0 ? DataColumnCollection.Find(n => n.IsPrimaryKey == true) : null;

        /// <summary>
        /// 第一列
        /// </summary>
        public DataColumnStruct FirstColumn => DataColumnCollection?.Count > 0 ? DataColumnCollection.Find(n => n.ColumnIndex == 0) : null;

        public DateTime CreateDateTime => DateTime.Now;
    }

    public class DataColumnStruct
    {
        public DataColumnStruct() { }

        /// <summary>
        /// 数据列名称
        /// </summary>
        public DataName Column { get; set; }

        /// <summary>
        /// 数据列数据类型
        /// </summary>
        public string ColumnDataType { get; set; }

        /// <summary>
        /// 类数据类型
        /// </summary>
        public string FliedDataType { get; set; }


        /// <summary>
        /// 字段显示名称
        /// </summary>
        public string ColumnDescription { get; set; }

        /// <summary>
        /// 字段描述
        /// </summary>
        public string FliedDescription { get; set; }

        /// <summary>
        /// 是否是主键
        /// </summary>
        public bool IsPrimaryKey { get; set; }

        /// <summary>
        /// 字段索引
        /// </summary>
        public int ColumnIndex { get; set; } = 0;

    }

    public class DataName
    {
        public DataName(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 字段名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 类字段名称-->骆驼命名法(Camel)首字母小写
        /// </summary>
        public virtual string ToCamel() => Name.Length > 1 ? $"{Name.Substring(0, 1).ToLower()}{Name.Substring(1)}" : Name;

        /// <summary>
        /// 类字段名称-->帕斯卡命名法(Pascal)首字母大写
        /// </summary>
        public virtual string ToPascal() => Name.Length > 1 ? $"{Name.Substring(0, 1).ToUpper()}{Name.Substring(1)}" : Name;

    }

    public static class DataTableStructureExtend
    {
        public static DataTableStruct ToModel(this DataTable db_table
            , string classNameSpace
            , string classSpace
            , string tableName
            , string parmPrefix
            , string classDescription = "")
        {
            DataTableStruct tableStructure = new DataTableStruct();
            tableStructure.ClassDescription = classDescription;
            tableStructure.ClassNameSpace = classNameSpace;
            tableStructure.ClassName = new DataName(classSpace);
            tableStructure.Table = new DataName(tableName);
            tableStructure.ParmPrefix = parmPrefix;
            tableStructure.DataColumnCollection = new List<DataColumnStruct>();
            for (int i = 0; i < db_table.Rows.Count; i++)
            {
                var fliedName = db_table.Rows[i]["列名"].ToString();
                var fliedDataType = db_table.Rows[i]["数据类型"].ToString();
                var fliedDescription = db_table.Rows[i]["说明"].ToString();
                var primaryKey = db_table.Rows[i]["键值"].ToString();

                tableStructure.DataColumnCollection.Add(new DataColumnStruct()
                {
                    Column = new DataName(fliedName),
                    ColumnDataType = fliedDataType,
                    ColumnDescription = fliedDescription,

                    FliedDataType = GetCSharpDataType(fliedDataType),
                    FliedDescription = GetCSharpDescribe(fliedDescription),

                    IsPrimaryKey = !string.IsNullOrWhiteSpace(primaryKey) && primaryKey.Equals("PRI", StringComparison.InvariantCultureIgnoreCase),
                    ColumnIndex = i
                });

            }
            return tableStructure;
        }


        /// <summary>
        /// 类字段名称-->帕斯卡命名法(Pascal)首字母大写
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToPascal(this string str) { return $"{str.Substring(0, 1).ToUpper()}{str.Substring(1)}"; }

        /// <summary>
        /// 类字段名称-->骆驼命名法(Camel)首字母小写
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToCamel(this string str) { return $"{str.Substring(0, 1).ToLower()}{str.Substring(1)}"; }

        /// <summary>
        /// 获取字段描述说明
        /// </summary>
        /// <param name="columnDescribe"></param>
        /// <returns></returns>
        public static string GetCSharpDescribe(string columnDescribe)
        {
            string rst = columnDescribe;
            if (!string.IsNullOrWhiteSpace(columnDescribe))
            {
                string splitStr = string.Empty;
                if (columnDescribe.IndexOf(':') != -1) splitStr = ":";
                else if (columnDescribe.IndexOf('：') != -1) splitStr = "：";
                else if (columnDescribe.IndexOf('|') != -1) splitStr = "|";
                else if (columnDescribe.IndexOf('_') != -1) splitStr = "_";
                else if (columnDescribe.IndexOf('-') != -1) splitStr = "-";
                else if (columnDescribe.IndexOf('(') != -1) splitStr = "(";
                else if (columnDescribe.IndexOf('，') != -1) splitStr = "，";
                else if (columnDescribe.IndexOf(',') != -1) splitStr = ",";
                else if (columnDescribe.IndexOf(' ') != -1) splitStr = " ";
                else splitStr = string.Empty;
                if (!string.IsNullOrEmpty(splitStr))
                    rst = columnDescribe.Substring(0, columnDescribe.IndexOf(splitStr));
            }
            return rst;
        }

        /// <summary>
        /// 获取.NET 数据类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetCSharpDataType(string DbDataType)
        {
            string rst = "";
            switch (DbDataType)
            {
                case "tinyint":
                    rst = "Int16";
                    break;
                case "smallint":
                    rst = "short";
                    break;
                case "double":
                    rst = "double";
                    break;
                case "decimal":
                    rst = "decimal";
                    break;
                case "float":
                    rst = "float";
                    break;
                case "bit":
                    rst = "bool";
                    break;
                case "int":
                    rst = "int";
                    break;
                case "bigint":
                    rst = "long";
                    break;
                case "varchar":
                case "char":
                    rst = "string";
                    break;
                case "nvarchar":
                    rst = "string";
                    break;
                case "datetime":
                case "timestamp":
                case "date":
                    rst = "DateTime";
                    break;
                case "text":
                    rst = "string";
                    break;
                default:
                    rst = "string";
                    break;
            }
            return rst;
        }
    }

}
