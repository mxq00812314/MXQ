using System;
using System.Collections.Generic;
using System.Reflection;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
namespace DB
{
    public class Model
    {
        /// <summary>
        /// DataTable 转 单实体类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <returns></returns>
        public static T ToModel<T>(DataTable table) where T : new()
        {
            if (table == null)
            {
                return default(T);
            }

            if (table != null && table.Rows.Count == 0)
            {
                return default(T);
            }

            T entity = new T();
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                foreach (var item in entity.GetType().GetProperties())
                {
                    if (row.Table.Columns.Contains(item.Name))
                    {
                        if (DBNull.Value != row[item.Name])
                        {
                            item.SetValue(entity, Convert.ChangeType(row[item.Name], item.PropertyType), null);
                        }
                    }
                }
            }
            return entity;
        }

        /// <summary>
        /// DataTable 转实体集合List<>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <returns></returns>
        public static IList<T> ToModelList<T>(DataTable table) where T : new()
        {
            if (table == null)
            {
                return default(IList<T>);
            }

            if (table != null && table.Rows.Count == 0)
            {
                return default(IList<T>);
            }
            IList<T> entities = new List<T>();
            foreach (DataRow row in table.Rows)
            {
                T entity = new T();
                foreach (var item in entity.GetType().GetProperties())
                {
                    if (row.Table.Columns.Contains(item.Name))
                    {
                        if (DBNull.Value != row[item.Name])
                        {
                            item.SetValue(entity, Convert.ChangeType(row[item.Name], item.PropertyType), null);
                        }
                    }
                }
                entities.Add(entity);
            }
            return entities;
        }

        /// <summary>
        /// 生成插入MY_SQL 插入语句
        /// </summary>
        /// <param name="model"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static string ToInsertSql(object model, string sql)
        {
            if (String.IsNullOrWhiteSpace(sql))
            {
                return string.Empty;
            }
            sql = sql.ToLower();
            string sql2 = sql;
            Dictionary<string, object> parms = new Dictionary<string, object>();
            Type type = model.GetType();
            PropertyInfo[] propertyInfos = type.GetProperties();
            foreach (var itemProperty in propertyInfos)
            {
                var name = itemProperty.Name;
                var value = itemProperty.GetValue(model, propertyInfos);
                parms.Add(name, value);
                name = name.ToLower();
                if (value != null)
                {
                    sql = sql.Replace(@"$" + name + @"$", value.ToString()).Replace(@"#" + name + @"#", value.ToString());
                }
                else
                {
                    sql = sql.Replace(@"$" + name + @"$", "").Replace(@"#" + name + @"#", "");
                }
            }
            sql = sql.Replace("\r", "").Replace("\n", "").Replace("\t", "");
            return sql;
        }

        /// <summary>
        /// 生成插入MY_SQL 插入语句
        /// </summary>
        /// <param name="model"></param>
        /// <param name="tableName"></param>
        /// <param name="isToUpper"></param>
        /// <returns></returns>
        public static string ModelToInsertSql(object model, string tableName, bool isToUpper = false)
        {
            #region 验证
            if (model == null)
            {
                return "实体对象为空";
            }

            if (String.IsNullOrWhiteSpace(tableName))
            {
                return "TableName 条件为空";
            }
            #endregion

            StringBuilder fieldSb = new StringBuilder();
            StringBuilder valueSb = new StringBuilder();
            fieldSb.AppendFormat(" INSERT INTO {0} ", tableName);

            List<MySqlParameter> parmsList = new List<MySqlParameter>();
            Type type = model.GetType();
            PropertyInfo[] propertyInfos = type.GetProperties();


            var fieldStrs = "";
            var fieldValueStrs = "";
            var i = 0;
            var splitStr = "";
            foreach (var itemProperty in propertyInfos)
            {
                var name = itemProperty.Name;
                var value = itemProperty.GetValue(model, propertyInfos);

                splitStr = (i > 0 ? ", " : "");

                fieldStrs += splitStr + name;
                fieldValueStrs += splitStr + (value != null ? "'" + value.ToString() + "'" : "''");
                i++;
            }
            if (isToUpper)
            {
                return fieldSb.AppendFormat(" ({0})", fieldStrs).ToString().ToUpper() + " VALUES (" + fieldValueStrs + "); ";
            }
            else
            {
                return fieldSb.AppendFormat(" ({0})", fieldStrs).ToString() + " VALUES (" + fieldValueStrs + "); ";
            }
        }

        /// <summary>
        /// 生成插入MY_SQL 修改语句
        /// </summary>
        /// <param name="model"></param>
        /// <param name="tableName"></param>
        /// <param name="whereStr"></param>
        /// <param name="isToUpper"></param>
        /// <returns></returns>
        public static string ModelToUpdateSql(object model, string tableName, string whereStr, bool isToUpper = false)
        {

            #region 验证
            if (model == null)
            {
                return "实体对象为空";
            }

            if (String.IsNullOrWhiteSpace(tableName))
            {
                return "TableName 条件为空";
            }

            if (String.IsNullOrWhiteSpace(whereStr))
            {
                return "Where 条件为空";
            }

            #endregion

            StringBuilder fieldSb = new StringBuilder();
            StringBuilder valueSb = new StringBuilder();
            fieldSb.AppendFormat(" UPDATE {0} ", tableName);

            Type type = model.GetType();
            PropertyInfo[] propertyInfos = type.GetProperties();


            var fieldStrs = "";
            var fieldWhereStrs = "";
            int i = 0, wherei = 0;
            var splitStr = "";
            foreach (var itemProperty in propertyInfos)
            {
                var name = itemProperty.Name.ToLower();
                var value = itemProperty.GetValue(model, propertyInfos);

                if (whereStr.IndexOf(name) == -1)
                {
                    if (value != null)
                    {
                        splitStr = (i > 0 ? ", " : "");
                        fieldStrs += splitStr + name + " = " + "'" + value.ToString() + "'";
                        i++;
                    }
                }
                else
                {
                    splitStr = (wherei > 0 ? " AND " : "");
                    fieldWhereStrs += splitStr + name + " = " + (value != null ? "'" + value.ToString() + "'" : "''");
                    wherei++;
                }
            }
            if (wherei == 0)
            {
                return "Where 条件为空";
            }

            if (isToUpper)
            {
                return fieldSb.AppendFormat(" SET {0} ", fieldStrs).ToString().ToUpper() + " WHERE " + fieldWhereStrs + "; ";
            }
            else
            {
                return fieldSb.AppendFormat(" SET {0} ", fieldStrs).ToString() + " WHERE " + fieldWhereStrs + "; ";
            }
        }

        /// <summary>
        /// 生成插入MY_SQL 删除语句
        /// </summary>
        /// <param name="model"></param>
        /// <param name="tableName"></param>
        /// <param name="whereStr"></param>
        /// <param name="isToUpper"></param>
        /// <returns></returns>
        public static string ModelToDeleteSql(object model, string tableName, string whereStr, bool isToUpper = false)
        {
            #region 验证
            if (model == null)
            {
                return "实体对象为空";
            }

            if (String.IsNullOrWhiteSpace(tableName))
            {
                return "TableName 条件为空";
            }

            if (String.IsNullOrWhiteSpace(whereStr))
            {
                return "Where 条件为空";
            }

            #endregion

            StringBuilder fieldSb = new StringBuilder();
            StringBuilder valueSb = new StringBuilder();
            fieldSb.AppendFormat(" DELETE FROM {0} ", tableName);

            Type type = model.GetType();
            PropertyInfo[] propertyInfos = type.GetProperties();

            var fieldWhereStrs = "";
            int wherei = 0;
            var splitStr = "";
            foreach (var itemProperty in propertyInfos)
            {
                var name = itemProperty.Name.ToLower();
                var value = itemProperty.GetValue(model, propertyInfos);

                if (whereStr.IndexOf(name) != -1)
                {
                    if (value != null)
                    {
                        splitStr = (wherei > 0 ? " AND " : "");
                        fieldWhereStrs += splitStr + name + " = " + (value != null ? "'" + value.ToString() + "'" : "''");
                        wherei++;
                    }
                }
            }
            if (wherei == 0)
            {
                return "Where 条件为空";
            }

            if (isToUpper)
            {
                return fieldSb.ToString().ToUpper() + " WHERE " + fieldWhereStrs + "; ";
            }
            else
            {
                return fieldSb.ToString() + " WHERE " + fieldWhereStrs + "; ";
            }

        }

        /// <summary>
        /// 更新实体类的值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dbModel"></param>
        /// <param name="dataModel"></param>
        /// <returns></returns>
        public static T UpdateForModel<T>(object dbModel, object dataModel, string UnUpdate = "")
        {
            if (dataModel == null)
                return (T)dbModel;

            Type dbType = dbModel.GetType();
            PropertyInfo[] dbPerArr = dbType.GetProperties();

            Type dataType = dataModel.GetType();
            PropertyInfo[] dataPerArr = dataType.GetProperties();

            foreach (var item in dbPerArr)
            {
                var dbName = item.Name;
                var dbValue = item.GetValue(dbModel, dataPerArr);
                if (!string.IsNullOrWhiteSpace(UnUpdate))
                {
                    UnUpdate = UnUpdate.ToLower();
                    if (UnUpdate.Contains(dbName.ToLower()))
                    {
                        continue;
                    }
                }
                foreach (var dataItem in dataPerArr)
                {
                    var dataName = dataItem.Name;
                    var dataValue = dataItem.GetValue(dataModel, dataPerArr);
                    if (dbName.ToLower().Equals(dataName.ToLower()))
                    {
                        if (dbValue != dataValue)
                        {
                            item.SetValue(dbModel, dataValue, null);
                            break;
                        }
                    }
                }
            }
            return (T)dbModel;
        }

        ///// <summary>
        ///// 检测实体类变更内容
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="oldModel"></param>
        ///// <param name="newModel"></param>
        ///// <param name="UnCheck"></param>
        ///// <returns></returns>
        //public string CheckModelChange<T>(T oldModel, T newModel, string UnCheck = "")
        //{
        //    //string rstStr = "";
        //    //if (newModel == null)
        //    //    return rstStr;
        //    //try
        //    //{
        //    //    Type dbType = oldModel.GetType();
        //    //    PropertyInfo[] dbPerArr = dbType.GetProperties();

        //    //    Type dataType = newModel.GetType();
        //    //    PropertyInfo[] dataPerArr = dataType.GetProperties();

        //    //    foreach (var item in dbPerArr)
        //    //    {
        //    //        var dbName = item.Name;
        //    //        var dbValue = item.GetValue(oldModel, dbPerArr);
        //    //        if (!string.IsNullOrWhiteSpace(UnCheck))
        //    //        {
        //    //            UnCheck = UnCheck.ToLower();
        //    //            if (UnCheck.Contains(dbName.ToLower()))
        //    //            {
        //    //                continue;
        //    //            }
        //    //        }
        //    //        foreach (var dataItem in dataPerArr)
        //    //        {
        //    //            var dataName = dataItem.Name;
        //    //            var dataValue = dataItem.GetValue(newModel, dataPerArr);
        //    //            var tempDispalyAttr = dataItem.GetCustomAttribute<DisplayNameAttribute>();
        //    //            var dataDispalyName = tempDispalyAttr != null ? tempDispalyAttr.DisplayName : "";
        //    //            if (dbName.Equals(dataName))
        //    //            {
        //    //                if (dbValue != null && dataValue != null && !dbValue.Equals(dataValue))
        //    //                {
        //    //                    rstStr += $"{dataDispalyName}由“{dbValue}“变更为：“{dataValue}“，";
        //    //                    break;
        //    //                }
        //    //                else if (dbValue == null && dataValue != null && !dbValue.Equals(dataValue))
        //    //                {
        //    //                    rstStr += $"{dataDispalyName}的值变更为：“{dataValue}“，";
        //    //                    break;
        //    //                }
        //    //            }
        //    //        }
        //    //    }
        //    //    rstStr = rstStr.TrimEnd('，');
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    var stringError = ex.Message;
        //    //}
        //    //return rstStr;
        //}

        /// <summary>
        /// 实体类 转MySql MySqlParameter[]
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static MySqlParameter[] ToMysqlParms(Object model)
        {

            List<MySqlParameter> parmsList = new List<MySqlParameter>();
            Type type = model.GetType();
            PropertyInfo[] propertyInfos = type.GetProperties();
            foreach (var itemProperty in propertyInfos)
            {
                var name = itemProperty.Name;
                var value = itemProperty.GetValue(model, propertyInfos);
                parmsList.Add(new MySqlParameter(name, value));
            }
            return parmsList.ToArray();
        }

        /// <summary>
        /// 获取实体类 某个值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="info"></param>
        /// <param name="field"></param>
        /// <returns></returns>
        public static T GetPropertyValue<T>(object info, string field)
        {
            if (info == null) return default(T);
            Type t = info.GetType();
            IEnumerable<System.Reflection.PropertyInfo> property = from pi in t.GetProperties() where pi.Name.ToLower() == field.ToLower() select pi;
            return (T)property.First().GetValue(info, null);
        }

    }
}
