using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;



namespace DBManager
{
    /// <summary>
    /// Mysql数据Helper
    /// </summary>
    public class MySqlDBHelper
    {
        private const string use = "USE ";
        //数据库名称列表
        private const string getDataBaseList = "; SHOW DATABASES;";
        //数据表名称列表
        private const string getTableList = ";SHOW TABLE STATUS;";
        //视图名称列表
        private const string getViewList = "; SELECT TABLE_NAME, TABLE_TYPE, TABLE_ROWS, CREATE_TIME, TABLE_COLLATION, TABLE_COMMENT FROM `information_schema`.`tables` WHERE TABLE_TYPE = 'VIEW'  GROUP BY TABLE_SCHEMA ORDER BY TABLE_NAME ASC;";
        //存储过程名称列表
        private const string getStoredProcedureList = "; SELECT * FROM MySQL.proc WHERE db = @DBNAME AND `type` = 'PROCEDURE'; ";

        private string isExistsDataBase = "USE master  SELECT COUNT(0) FROM SYSDATABASES WHERE NAME = @NAME ";
        private string isExistsDataTable = " SELECT COUNT(0) FROM SYS.TABLES WHERE name LIKE '%@tableName%' ";
        private string isExistsDataTableColumn = "USE DataBasesName SELECT COUNT(0) FROM SYSCOLUMNS WHERE ID=object_id(@TableName) AND NAME =@TableColumnName ";
        private string isExistsDataTableExtendedProperties = "SELECT COUNT(0) FROM sys.extended_properties AS SEP WHERE major_id= object_id(@tableName) AND minor_id=0";
        private string isExistsDataTableColumnExtendedProperties = "SELECT COUNT (0) FROM sys.extended_properties AS SEP WHERE SEP.name=N'MS_Description' AND SEP.class=N'1' AND major_id= object_id(@tableName) AND minor_id=(SELECT TOP 1 column_id FROM sys.columns WHERE name=@ColumnName)";

        private string getViewInfoSQLStr = " EXEC SP_HELPTEXT @ViewName";
        private string getProInfoSQLStr = " EXEC SP_HELPTEXT @ProName";

        /// <summary>
        /// 数据库连接串
        /// </summary>
        public string MysqlDBConnString { get; set; } = DB.MySqlHelper.connString;

        public MySqlDBHelper(string dbConn = "")
        {   if(!string.IsNullOrWhiteSpace(dbConn))
                this.MysqlDBConnString = dbConn;
        }

        #region 获取对象

        /// <summary>
        /// 获取系统数据库
        /// </summary>
        /// <returns></returns>
        public DataTable DataBaseBind()
        {
            return DB.MySqlHelper.ExecuteDataTable(MysqlDBConnString, CommandType.Text, getDataBaseList, null).Tables[0];
        }

        /// <summary>
        /// 获取系统数据表
        /// </summary>
        /// <param name="selecedDataBaseName">数据库名称</param>
        /// <returns></returns>
        public DataTable DataTableBind(string selecedDataBaseName)
        {
            return DB.MySqlHelper.ExecuteDataTable(MysqlDBConnString, CommandType.Text, use + selecedDataBaseName + getTableList, null).Tables[0];
        }

        /// <summary>
        /// 获取视图
        /// </summary>
        /// <param name="selecedDataBaseName">数据库名称</param>
        /// <returns></returns>
        public DataTable DataViewBind(string selecedDataBaseName)
        {
            return DB.MySqlHelper.ExecuteDataTable(MysqlDBConnString, CommandType.Text, use + selecedDataBaseName + getViewList, null).Tables[0];
        }

        /// <summary>
        /// 获取存储过程
        /// </summary>
        /// <param name="selecedDataBaseName">数据库名称</param>
        /// <returns></returns>
        public DataTable DataStoredProcedureBind(string selecedDataBaseName)
        {
            return DB.MySqlHelper.ExecuteDataTable(MysqlDBConnString, CommandType.Text, getStoredProcedureList, new MySqlParameter("@DBNAME", selecedDataBaseName)).Tables[0];
        }

        /// <summary>
        /// 获取表信息
        /// </summary>
        /// <param name="selecedDataBaseName">数据库名称</param>
        /// <param name="selecedTableName"></param>
        /// <returns></returns>
        public DataTable getTableInfo(string selecedDataBaseName, string selecedTableName)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(" SELECT 	`COLUMN_NAME` AS '列名',");
            sqlStr.Append(" 	`COLUMN_TYPE` AS '类型',");
            sqlStr.Append(" 	`COLUMN_COMMENT` AS '说明',");
            sqlStr.Append(" 	`EXTRA` AS '标识列',");
            sqlStr.Append(" 	 CASE `IS_NULLABLE` WHEN 'YES' THEN '否'ELSE '是' END  AS 'IsNull',");
            sqlStr.Append(" 	 IFNULL(`COLUMN_DEFAULT`,'') AS '默认值',");
            sqlStr.Append(" 	`DATA_TYPE` AS '数据类型',");
            sqlStr.Append(" 	 IFNULL(`CHARACTER_MAXIMUM_LENGTH`, '') AS '长度',");
            sqlStr.Append(" 	`PRIVILEGES` AS '权限',");
            sqlStr.Append(" 	`COLUMN_KEY` AS '键值',");
            sqlStr.Append(" 	 IFNULL(`CHARACTER_SET_NAME`, '') AS '字符集',");
            sqlStr.Append(" 	 IFNULL(`COLLATION_NAME`, '') AS '编码'");
            sqlStr.Append(" FROM 	`INFORMATION_SCHEMA`.`COLUMNS`");
            sqlStr.Append(" WHERE 	TABLE_SCHEMA= '" + selecedDataBaseName + "' AND TABLE_NAME = '" + selecedTableName + "';");
            return DB.MySqlHelper.ExecuteDataTable(MysqlDBConnString, CommandType.Text, sqlStr.ToString(), null).Tables[0];
        }

        /// <summary>
        /// 读取视图
        /// </summary>
        /// <param name="selecedDataBaseName">数据库名称</param>
        /// <param name="selecedViewName">视图名称</param>
        /// <returns></returns>
        public DataTable getViewInfo(string selecedDataBaseName, string selecedViewName)
        {
            MySqlParameter[] sp = new MySqlParameter[]{
                new MySqlParameter("@ViewName",selecedViewName),
            };
            return DB.MySqlHelper.ExecuteDataTable(MysqlDBConnString, CommandType.Text, use + selecedDataBaseName + getViewInfoSQLStr, sp).Tables[0];
        }

        /// <summary>
        /// 读取存储过程
        /// </summary>
        /// <param name="selecedDataBaseName">数据库名称</param>
        /// <param name="selecedProName">存储过程名称</param>
        /// <returns></returns>
        public object getProInfo(string selecedDataBaseName, string selecedProName)
        {
            MySqlParameter[] sp = new MySqlParameter[]{
                new MySqlParameter("@ProName",selecedProName),
            };
            return DB.MySqlHelper.ExecuteDataTable(MysqlDBConnString, CommandType.Text, use + selecedDataBaseName + getProInfoSQLStr, sp).Tables[0];
        }

        /// <summary>
        /// 查询100条数据(默认倒叙,带分页)
        /// </summary>
        /// <param name="selecedDataBaseName">数据库名称</param>
        /// <param name="selecedTableName">数据表名</param>
        /// <param name="orderByFliedName">排序字段</param>
        /// <param name="sortMode">排序模式(升序:ASC、降序:DESC)</param>
        /// <param name="page">分页索引(默认:1)</param>
        /// <param name="PageSize">分页Size(默认:100)</param>
        /// <returns></returns>
        public DataTable getTableTop100(string selecedDataBaseName, string selecedTableName, string whereStr, string orderByFliedName = "", string sortMode = "DESC", int page = 1, int PageSize = 100)
        {
            int skin = ((page - 1) * PageSize);

            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append("SELECT 	* ");
            sqlStr.Append("FROM 	`" + selecedDataBaseName + "`.`" + selecedTableName + "` ");
            if (!string.IsNullOrWhiteSpace(whereStr))
                sqlStr.Append("WHERE 	" + whereStr + " ");

            if (!string.IsNullOrWhiteSpace(orderByFliedName))
                sqlStr.Append("ORDER BY " + orderByFliedName + " " + sortMode + " ");

            sqlStr.Append("LIMIT " + skin + ", " + PageSize + ";");
            return DB.MySqlHelper.ExecuteDataTable(MysqlDBConnString, CommandType.Text, sqlStr.ToString(), null).Tables[0];
        }


        public string getTableTop100_ToSql(string selecedDataBaseName, string selecedTableName, string whereStr, string orderByFliedName = "", string sortMode = "DESC", int page = 1, int PageSize = 100)
        {
            int skin = ((page - 1) * PageSize);

            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append("SELECT 	* ");
            sqlStr.Append("FROM 	`" + selecedDataBaseName + "`.`" + selecedTableName + "` ");
            if (!string.IsNullOrWhiteSpace(whereStr))
                sqlStr.Append("WHERE 	" + whereStr + " ");

            if (!string.IsNullOrWhiteSpace(orderByFliedName))
                sqlStr.Append("ORDER BY " + orderByFliedName + " " + sortMode + " ");

            sqlStr.Append("LIMIT " + skin + ", " + PageSize + ";");
            return sqlStr.ToString();
        }

        public DbResult runT_Sql(string T_Sql)
        {
            DbResult rst = new DBManager.DbResult();

            if (T_Sql.IndexOf("SELECT") != -1)
            {
                rst.DbResultType = DbResultType.db_DataTable;
                rst.DbResultData = DB.MySqlHelper.ExecuteDataTable(MysqlDBConnString, CommandType.Text, T_Sql, null).Tables[0];
            }
            else
            {
                rst.DbResultType = DbResultType.db_Int32;
                rst.DbResultData = DB.MySqlHelper.ExecuteNonQuery(MysqlDBConnString, CommandType.Text, T_Sql, null);
            }
            return rst;
        }

        #endregion

        #region 检测对象是否存在
        /// <summary>
        /// 检测数据库是否存在
        /// </summary>
        /// <param name="dataBaseName">数据库名</param>
        /// <returns></returns>
        public bool IsExistsDataBaseByName(string dataBaseName)
        {
            object result = new object();
            MySqlParameter[] sp = new MySqlParameter[] { new MySqlParameter("@NAME", dataBaseName) };
            result = DB.MySqlHelper.ExecuteScalar(MysqlDBConnString, CommandType.Text, isExistsDataBase, sp);
            return Convert.ToInt32(result) > 0;
        }

        /// <summary>
        /// 检测是数据表否存在
        /// </summary>
        /// <param name="dataBaseName">数据库名称</param>
        /// <param name="tableName">数据表名称</param>
        /// <returns></returns>
        public bool IsExistsDataTableByName(string dataBaseName, string tableName)
        {
            object result = new object();
            MySqlParameter[] sp = new MySqlParameter[] { new MySqlParameter("@tableName", tableName) };
            result = DB.MySqlHelper.ExecuteScalar(MysqlDBConnString, CommandType.Text, use + dataBaseName + isExistsDataTable, sp);
            return Convert.ToInt32(result) > 0;
        }

        /// <summary>
        /// 检测是数据表中列否存在
        /// </summary>
        /// <param name="dataBaseName">数据库名称</param>
        /// <param name="tableName">数据表名称</param>
        /// <param name="dataTableColumnName">数据表列名称</param>
        /// <returns></returns>
        public bool IsExistsDataTableColumnByName(string dataBaseName, string dataTableName, string dataTableColumnName)
        {
            object result = new object();
            MySqlParameter[] sp = new MySqlParameter[] {
                new MySqlParameter("@TableName", dataTableName) ,
                new MySqlParameter("@TableColumnName", dataTableColumnName)
            };
            result = DB.MySqlHelper.ExecuteScalar(MysqlDBConnString, CommandType.Text, use + dataBaseName + isExistsDataTableColumn, sp);
            return Convert.ToInt32(result) > 0;
        }

        /// <summary>
        /// 是否存数据表的扩展属性
        /// </summary>
        /// <param name="dataBaseName">数据库名称</param>
        /// <param name="dataTableName">数据表名称</param>
        /// <returns></returns>
        public bool isExistsDataTableExtendedPropertiesByName(string dataBaseName, string dataTableName)
        {
            object result = new object();
            MySqlParameter[] sp = new MySqlParameter[] {
                new MySqlParameter("@tableName", dataTableName) ,
            };
            result = DB.MySqlHelper.ExecuteScalar(MysqlDBConnString, CommandType.Text, use + dataBaseName + isExistsDataTableExtendedProperties, sp);
            return Convert.ToInt32(result) > 0;
        }

        /// <summary>
        /// 是否存数据表列的扩展属性
        /// </summary>
        /// <param name="dataBaseName">数据库名称</param>
        /// <param name="dataTableName">数据表名称</param>
        /// <param name="dataTableColumnName">数据表列名称</param>
        /// <returns></returns>
        public bool isExistsDataTableColumnExtendedPropertiesByName(string dataBaseName, string dataTableName, string dataTableColumnName)
        {
            object result = new object();
            MySqlParameter[] sp = new MySqlParameter[] {
                new MySqlParameter("@@tableName", dataTableName) ,
                new MySqlParameter("@@ColumnName", dataTableColumnName)
            };
            result = DB.MySqlHelper.ExecuteScalar(MysqlDBConnString, CommandType.Text, use + dataBaseName + isExistsDataTableColumnExtendedProperties, sp);
            return Convert.ToInt32(result) > 0;
        }

        #endregion

        #region 拼接T_SQL语句

        #region "创建Insert TSQL语句"

        /// <summary>
        /// 拼 Insert TSQL语句
        /// </summary>
        /// <param name="dataBaseName">数据库名称</param>
        /// <param name="dataTableName">数据表名称</param>
        /// <returns></returns>
        public string CreateInsertTSQLString(string dataBaseName, string dataTableName)
        {
            return CreateInsertTSQLString(dataBaseName, dataTableName, getTableInfo(dataBaseName, dataTableName));
        }


        /// <summary>
        /// 拼 Insert TSQL语句
        /// </summary>
        /// <param name="dataBaseName">数据库名称</param>
        /// <param name="dataTableName">数据表名称</param>
        /// <param name="dataTable">数据表结构</param>
        /// <returns></returns>
        public string CreateInsertTSQLString(string dataBaseName, string dataTableName, DataTable dataTable)
        {
            DataRow[] dataRows = dataTable.Select();
            StringBuilder sbStr = new StringBuilder();
            StringBuilder sbValueArrayStr = new StringBuilder();
            sbStr.AppendLine("INSERT INTO [" + dataBaseName + "].[dbo].[" + dataTableName + "]");
            sbValueArrayStr.Append("VALUES ( ");
            sbStr.Append("\t   ( ");
            for (var i = 0; i < dataRows.Length; i++)
            {
                if (i > 0)
                {
                    sbStr.Append(", ");
                    sbValueArrayStr.Append(", ");
                }
                if (i > 0 && i % 6 == 0)
                {
                    sbStr.Append("\r\n\t\t[" + dataRows[i]["列名"].ToString() + "]");
                    sbValueArrayStr.AppendFormat("\r\n\t\t@{0}", dataRows[i]["列名"]);
                }
                else
                {
                    sbStr.Append("[" + dataRows[i]["列名"].ToString() + "]");
                    sbValueArrayStr.AppendFormat("@{0}", dataRows[i]["列名"]);
                }
            }
            return string.Format("{0} )\r\n{1} )\r\n{2}", sbStr, sbValueArrayStr, CreateSqlParameterArray(dataBaseName, dataTableName, dataTable));
        }

        #endregion

        #region "创建Delete TSQL语句"
        /// <summary>
        /// 创建Delete TSQL语句
        /// </summary>
        /// <param name="dataBaseName">数据库名称</param>
        /// <param name="dataTableName">数据表名称</param>
        /// <returns></returns>
        public string CreateDeleteTSQLString(string dataBaseName, string dataTableName)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" DELETE FROM [" + dataBaseName + "].[dbo].[" + dataTableName + "]");
            sb.Append(" WHERE 1=2 \r\n");
            return sb.ToString();
        }

        #endregion

        #region "创建Update TSQL语句"
        /// <summary>
        /// "创建Update TSQL语句
        /// </summary>
        /// <param name="dataBaseName">数据库名称</param>
        /// <param name="dataTableName">数据表名称</param>
        /// <returns></returns>
        public string CreateUpdateTSQLString(string dataBaseName, string dataTableName)
        {

            return CreateUpdateTSQLString(dataBaseName, dataTableName, getTableInfo(dataBaseName, dataTableName));
        }


        /// <summary>
        /// "创建Update TSQL语句
        /// </summary>
        /// <param name="dataBaseName">数据库名称</param>
        /// <param name="dataTableName">数据表名称</param>
        /// <param name="dataTable">数据表结构</param>
        /// <returns></returns>
        public string CreateUpdateTSQLString(string dataBaseName, string dataTableName, DataTable dataTable)
        {
            DataRow[] dataRows = dataTable.Select();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("UPDATE [" + dataBaseName + "].[dbo].[" + dataTableName + "] ");
            sb.AppendLine("SET");
            for (int i = 0; i < dataRows.Length; i++)
            {
                sb.Append("\t\t[" + dataRows[i]["列名"] + "]=@" + dataRows[i]["列名"] + "," + (i % 6 == 0 ? "\r\n\t" : ""));
            }
            return sb.ToString().Remove(sb.ToString().LastIndexOf(',')) + " \r\n WHERE 1=1 \r\n";
        }

        #endregion

        #region "创建Select TSQL语句"
        /// <summary>
        /// 拼 Select TSQL语句
        /// </summary>
        /// <param name="dataBaseName">数据库名称</param>
        /// <param name="dataTableName">数据表名称</param>

        /// <returns></returns>
        public string CreateSelectTSQLString(string dataBaseName, string dataTableName, string prefix = "")
        {
            return CreateSelectTSQLString(dataBaseName, dataTableName, getTableInfo(dataBaseName, dataTableName), prefix);
        }

        /// <summary>
        /// 拼 Select TSQL语句
        /// </summary>
        /// <param name="dataBaseName">数据库名称</param>
        /// <param name="dataTableName">数据表名称</param>
        /// <param name="dataTable">数据表结构</param>
        /// <param name="prefix">数据表别名</param>
        /// <returns></returns>
        public string CreateSelectTSQLString(string dataBaseName, string dataTableName, DataTable dataTable, string prefix = "")
        {
            DataRow[] dataRows = dataTable.Select();
            StringBuilder sb = new StringBuilder();
            string firstColumnName = "";
            sb.Append("SELECT ");
            for (var i = 0; i < dataRows.Length; i++)
            {
                if (i == 0)
                {
                    firstColumnName = (!string.IsNullOrWhiteSpace(prefix) ? prefix + "." : "") + "`" + dataRows[i]["列名"].ToString() + "`";
                }

                sb.Append((!string.IsNullOrWhiteSpace(prefix) ? prefix + "." : "") + "`" + dataRows[i]["列名"].ToString() + "`," + (i > 0 ? (i % 6 == 0 ? "\r\n\t" : "") : ""));
            }
            return sb.ToString().Remove(sb.ToString().LastIndexOf(','))
                + "\r\nFROM\t`" + dataBaseName + "`.`" + dataTableName + "` " + (!string.IsNullOrWhiteSpace(prefix) ? " AS " + prefix : "")
                + "\r\nWHERE\t1 = 1 "
                + "\r\nORDER BY\t" + firstColumnName + " DESC "
                + "\r\nLimit\t0, 100;\r\n";
        }
        #endregion

        #endregion

        #region 表扩展属性
        public bool AddObjectExtendedProperty(string dataBaseName, string dataTableName, string columnName, string extendedPropertyValue)
        {
            StringBuilder sqlStr = new StringBuilder();
            Boolean result_bool = new Boolean();
            MySqlParameter[] sp;
            try
            {
                sqlStr = new StringBuilder();
                sqlStr.Append(" USE [" + dataBaseName + "] ");
                sqlStr.Append(" EXEC sys.sp_addextendedproperty @name=N'MS_Description',  ");
                sqlStr.Append(" @value=@DataColumnDescription, @level0type=N'SCHEMA', ");
                sqlStr.Append(" @level0name=N'dbo',@level1type=N'TABLE',@level1name=N'" + dataTableName + "', ");
                sqlStr.Append(" @level2type=N'COLUMN',@level2name=N'" + columnName + "' ");
                sp = new MySqlParameter[] {
                    new  MySqlParameter("@DataColumnDescription",extendedPropertyValue.Trim()),
                };
                if (DB.MySqlHelper.ExecuteNonQuery(MysqlDBConnString, CommandType.Text, sqlStr.ToString(), sp) > 0)
                {
                    result_bool = true;
                }
                else
                {
                    result_bool = false;
                }
            }
            catch
            {
                sqlStr.Clear();
                sqlStr.Append(" USE [" + dataBaseName + "] ");
                sqlStr.Append(" DECLARE @v sql_variant  ");
                sqlStr.Append(" SET @v=@DataColumnDescription ");
                sqlStr.Append(" EXECUTE sp_updateextendedproperty N'MS_Description', @v, N'SCHEMA', ");
                sqlStr.Append(" N'dbo', N'TABLE', N'" + dataTableName + "', N'COLUMN', N'" + columnName + "' ");
                sp = new MySqlParameter[] {
                    new  MySqlParameter("@DataColumnDescription",extendedPropertyValue.Trim()),
                };
                if (DB.MySqlHelper.ExecuteNonQuery(MysqlDBConnString, CommandType.Text, sqlStr.ToString(), sp) > 0)
                {
                    result_bool = true;
                }
                else
                {
                    result_bool = false;
                }
            }

            return result_bool;
        }

        #endregion

        #region 拼SqlParamete [] sp;

        /// <summary>
        /// 拼SqlParamete [] sp;
        /// </summary>
        /// <param name="dataBaseName">数据库名称</param>
        /// <param name="dataTableName">数据表名称</param>
        /// <returns></returns>
        public string CreateSqlParameterArray(string dataBaseName, string dataTableName)
        {
            return CreateSqlParameterArray(dataBaseName, dataTableName, getTableInfo(dataBaseName, dataTableName));
        }

        /// <summary>
        /// 拼SqlParamete [] sp;
        /// </summary>
        /// <param name="dataBaseName">数据库名称</param>
        /// <param name="dataTableName">数据表名称</param>
        /// <param name="dataTable">数据表结构</param>
        /// <returns></returns>
        public string CreateSqlParameterArray(string dataBaseName, string dataTableName, DataTable dataTable)
        {
            DataRow[] dataRows = dataTable.Select();
            StringBuilder sbSqlParameterStr = new StringBuilder();
            sbSqlParameterStr.AppendLine("MySqlParameter[] sp = new MySqlParameter[]");
            sbSqlParameterStr.AppendLine("\t{");
            for (var i = 0; i < dataRows.Length; i++)
            {
                if (i > 0)
                {
                    sbSqlParameterStr.Append("，\r\n");
                }
                sbSqlParameterStr.AppendFormat("\t\tnew MySqlParameter(\"@{0}\", {1}Model.{0} )", dataRows[i]["列名"], dataTableName);
            }
            sbSqlParameterStr.AppendLine("\r\n\t} ");
            return sbSqlParameterStr.ToString();
        }

        #endregion
    }

}
