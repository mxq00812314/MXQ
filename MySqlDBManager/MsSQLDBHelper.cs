using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DB;

namespace DBManager
{
    public class MsSQLDBHelper
    {
        private const string use = "USE ";
        private const string useMaster = "USE [Master] ";

        private const string getDataBaseList = " SELECT name, database_id FROM SYS.DATABASES ORDER BY name ASC";
        private const string getTableList = " SELECT name, object_id, type_desc FROM SYS.TABLES ORDER BY name ASC";
        private const string getViewList = " SELECT name,object_id, type_desc  FROM SYS.objects WHERE type='V' ORDER BY name ASC";
        private const string getStoredProcedureList = " SELECT name, object_id, type_desc  FROM SYS.objects WHERE type='P' ORDER BY name ASC ";

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
        public string MysqlDBConnString { get; set; } = DB.SqlHelper.connString;

        public MsSQLDBHelper(string dbConn = "")
        {
            if (!string.IsNullOrWhiteSpace(dbConn))
                this.MysqlDBConnString = dbConn;
        }

        #region 获取对象

        /// <summary>
        /// 获取系统数据库
        /// </summary>
        /// <returns></returns>
        public DataTable DataBaseBind()
        {
            return SqlHelper.ExecuteDataTable(MysqlDBConnString, CommandType.Text, useMaster + getDataBaseList, null).Tables[0];
        }

        /// <summary>
        /// 获取系统数据表
        /// </summary>
        /// <returns></returns>
        public DataTable DataTableBind(string selecedDataBaseName)
        {
            return SqlHelper.ExecuteDataTable(MysqlDBConnString, CommandType.Text, use + selecedDataBaseName + getTableList, null).Tables[0];
        }

        /// <summary>
        /// 获取视图
        /// </summary>
        /// <returns></returns>
        public DataTable DataViewBind(string selecedDataBaseName)
        {
            return SqlHelper.ExecuteDataTable(MysqlDBConnString, CommandType.Text, use + selecedDataBaseName + getViewList, null).Tables[0];
        }

        /// <summary>
        /// 获取存储过程
        /// </summary>
        /// <returns></returns>
        public DataTable DataStoredProcedureBind(string selecedDataBaseName)
        {
            return SqlHelper.ExecuteDataTable(MysqlDBConnString, CommandType.Text, use + selecedDataBaseName + getStoredProcedureList, null).Tables[0];
        }

        /// <summary>
        /// 获取表信息
        /// </summary>
        /// <param name="selecedDataBaseName"></param>
        /// <param name="selecedTableName"></param>
        /// <returns></returns>
        public DataTable getTableInfo(string selecedDataBaseName, string selecedTableName)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(" USE [" + selecedDataBaseName + "] ");
            sqlStr.Append("  SELECT  col.column_id AS '序号', col.name AS '列名',  bt.name  AS '数据类型', ");
            sqlStr.Append("          CASE WHEN col.[max_length]=-1 and bt.Name!='xml' THEN 'max/2G' WHEN bt.Name='xml' THEN '2^31-1字節/2G' ELSE rtrim(col.[max_length]) END '长度',   ");
            sqlStr.Append("          ISNULL(ColumnProperty(col.object_id,col.Name,'Scale'),0) AS '小数',  col.precision AS '精度' , ");
            sqlStr.Append("          CASE WHEN EXISTS( ");
            sqlStr.Append("                             SELECT 1 from sys.objects so ");
            sqlStr.Append("                             JOIN sys.indexes si ON so.Type=N'PK' and so.Name=si.Name ");
            sqlStr.Append("                             JOIN sysindexkeys s ON S.ID=col.Object_id AND S.indid=si.index_id ");
            sqlStr.Append("                             AND s.Colid=col.Column_id)  THEN N'√' ELSE N'' END AS '主键',  ");
            sqlStr.Append("          CASE WHEN col.is_nullable=1 THEN N'√' ELSE N'' END AS '允许NULL值', CASE WHEN col.is_identity=1 THEN N'√' ELSE N'' END AS '标识列',");
            sqlStr.Append("          CASE WHEN(idc.column_id is null) THEN N'' ELSE CONVERT(nvarchar(40), idc.seed_value) END AS '标识种子',");
            sqlStr.Append("          CASE WHEN(idc.column_id is null) THEN N'' ELSE CONVERT(nvarchar(40), idc.increment_value) END AS '标识增量', ");
            sqlStr.Append("          ISNULL(defCst.[definition],N'') AS '默认值',  ISNULL(sep.value,N'')  AS '说明', dobj.create_date AS '创建日期', dobj.modify_date AS '修改日期'");
            sqlStr.Append(" from sys.columns col ");
            sqlStr.Append("           left outer join sys.types st on st.user_type_id = col.user_type_id ");
            sqlStr.Append("           left outer join sys.types bt on bt.user_type_id = col.system_type_id ");
            sqlStr.Append("           left outer join sys.objects dobj ON col.[object_id]=dobj.[object_id] AND (dobj.type='U' or dobj.type='V') AND dobj.is_ms_shipped=0");
            sqlStr.Append("           left outer join sys.default_constraints defCst on defCst.parent_object_id = col.object_id and defCst.parent_column_id = col.column_id ");
            sqlStr.Append("           left outer join sys.identity_columns idc on idc.object_id = col.object_id and idc.column_id = col.column_id ");
            sqlStr.Append("           left outer join sys.extended_properties sep on sep.minor_id=col.column_id and sep.major_id=col.object_id and sep.class='1' and sep.name='MS_Description'");
            sqlStr.Append(" where col.object_id = object_id(@TableName) ");
            sqlStr.Append(" order by col.column_id");
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@TableName",selecedTableName),
            };
            return SqlHelper.ExecuteDataTable(MysqlDBConnString, CommandType.Text, sqlStr.ToString(), sp).Tables[0];
        }

        /// <summary>
        /// 读取视图
        /// </summary>
        /// <param name="selecedDataBaseName"></param>
        /// <param name="selecedViewName"></param>
        /// <returns></returns>
        public DataTable getViewInfo(string selecedDataBaseName, string selecedViewName)
        {
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@ViewName",selecedViewName),
            };
            return SqlHelper.ExecuteDataTable(MysqlDBConnString, CommandType.Text, use + selecedDataBaseName + getViewInfoSQLStr, sp).Tables[0];
        }

        /// <summary>
        /// 读取存储过程
        /// </summary>
        /// <param name="selecedDataBaseName"></param>
        /// <param name="selecedViewName"></param>
        /// <returns></returns>
        public object getProInfo(string selecedDataBaseName, string selecedProName)
        {
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@ProName",selecedProName),
            };
            return SqlHelper.ExecuteDataTable(MysqlDBConnString, CommandType.Text, use + selecedDataBaseName + getProInfoSQLStr, sp).Tables[0];
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
            sqlStr.Append("FROM 	[" + selecedDataBaseName + "].[dbo].[" + selecedTableName + "] ");
            if (!string.IsNullOrWhiteSpace(whereStr))
                sqlStr.Append("WHERE 	" + whereStr + " ");

            if (!string.IsNullOrWhiteSpace(orderByFliedName))
                sqlStr.Append("ORDER BY " + orderByFliedName + " " + sortMode + " ");

            sqlStr.Append("OFFSET  " + skin + "  ROW FETCH NEXT " + PageSize + " ROWS ONLY;");
            return DB.SqlHelper.ExecuteDataTable(MysqlDBConnString, CommandType.Text, sqlStr.ToString(), null).Tables[0];
        }


        public string getTableTop100_ToSql(string selecedDataBaseName, string selecedTableName, string whereStr, string orderByFliedName = "", string sortMode = "DESC", int page = 1, int PageSize = 100)
        {
            int skin = ((page - 1) * PageSize);

            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append("SELECT 	* ");
            sqlStr.Append("FROM 	[" + selecedDataBaseName + "].[dbo].[" + selecedTableName + "] ");
            if (!string.IsNullOrWhiteSpace(whereStr))
                sqlStr.Append("WHERE 	" + whereStr + " ");

            if (!string.IsNullOrWhiteSpace(orderByFliedName))
                sqlStr.Append("ORDER BY " + orderByFliedName + " " + sortMode + " ");

            sqlStr.Append("OFFSET  " + skin + "  ROW FETCH NEXT " + PageSize + " ROWS ONLY;");
            return sqlStr.ToString();
        }

        public DbResult runT_Sql(string T_Sql)
        {
            DbResult rst = new DBManager.DbResult();

            if (T_Sql.IndexOf("SELECT") != -1)
            {
                rst.DbResultType = DbResultType.db_DataTable;
                rst.DbResultData = DB.SqlHelper.ExecuteDataTable(MysqlDBConnString, CommandType.Text, T_Sql, null).Tables[0];
            }
            else
            {
                rst.DbResultType = DbResultType.db_Int32;
                rst.DbResultData = DB.SqlHelper.ExecuteNonQuery(MysqlDBConnString, CommandType.Text, T_Sql, null);
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
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@NAME", dataBaseName) };
            result = SqlHelper.ExecuteScalar(MysqlDBConnString, CommandType.Text, isExistsDataBase, sp);
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
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@tableName", tableName) };
            result = SqlHelper.ExecuteScalar(MysqlDBConnString, CommandType.Text, use + dataBaseName + isExistsDataTable, sp);
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
            SqlParameter[] sp = new SqlParameter[] { 
                new SqlParameter("@TableName", dataTableName) ,
                new SqlParameter("@TableColumnName", dataTableColumnName) 
            };
            result = SqlHelper.ExecuteScalar(MysqlDBConnString, CommandType.Text, use + dataBaseName + isExistsDataTableColumn, sp);
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
            SqlParameter[] sp = new SqlParameter[] { 
                new SqlParameter("@tableName", dataTableName) ,
            };
            result = SqlHelper.ExecuteScalar(MysqlDBConnString, CommandType.Text, use + dataBaseName + isExistsDataTableExtendedProperties, sp);
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
            SqlParameter[] sp = new SqlParameter[] { 
                new SqlParameter("@@tableName", dataTableName) ,
                new SqlParameter("@@ColumnName", dataTableColumnName) 
            };
            result = SqlHelper.ExecuteScalar(MysqlDBConnString, CommandType.Text, use + dataBaseName + isExistsDataTableColumnExtendedProperties, sp);
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
        public string CreateSelectTSQLString(string dataBaseName, string dataTableName)
        {
            return CreateSelectTSQLString(dataBaseName, dataTableName, getTableInfo(dataBaseName, dataTableName));
        }

        /// <summary>
        /// 拼 Select TSQL语句
        /// </summary>
        /// <param name="dataBaseName">数据库名称</param>
        /// <param name="dataTableName">数据表名称</param>
        /// <param name="dataTable">数据表结构</param>
        /// <returns></returns>
        public string CreateSelectTSQLString(string dataBaseName, string dataTableName, DataTable dataTable)
        {
            DataRow[] dataRows = dataTable.Select();
            StringBuilder sb = new StringBuilder();
            string firstColumnName = "";
            sb.Append("SELECT TOP 100");
            for (var i = 0; i < dataRows.Length; i++)
            {
                if (i == 0)
                {
                    firstColumnName = dataRows[i]["列名"].ToString();
                }
                sb.Append(" [" + dataRows[i]["列名"].ToString() + "]," + (i > 0 ? (i % 6 == 0 ? "\r\n\t " : "") : ""));
            }
            return sb.ToString().Remove(sb.ToString().LastIndexOf(','))
                + "\r\n FROM [" + dataBaseName + "].[dbo].[" + dataTableName + "] "
                + "\r\n WHERE 1=1 \r\n ORDER BY [" + firstColumnName + "] DESC \r\n";

        }
        #endregion

        #endregion

        public bool AddObjectExtendedProperty(string dataBaseName, string dataTableName, string columnName, string extendedPropertyValue)
        {
            StringBuilder sqlStr = new StringBuilder();
            Boolean result_bool = new Boolean();
            SqlParameter[] sp;
            try
            {
                sqlStr = new StringBuilder();
                sqlStr.Append(" USE [" + dataBaseName + "] ");
                sqlStr.Append(" EXEC sys.sp_addextendedproperty @name=N'MS_Description',  ");
                sqlStr.Append(" @value=@DataColumnDescription, @level0type=N'SCHEMA', ");
                sqlStr.Append(" @level0name=N'dbo',@level1type=N'TABLE',@level1name=N'" + dataTableName + "', ");
                sqlStr.Append(" @level2type=N'COLUMN',@level2name=N'" + columnName + "' ");
                sp = new SqlParameter[] {
                    new  SqlParameter("@DataColumnDescription",extendedPropertyValue.Trim()),
                };
                if (SqlHelper.ExecuteNonQuery(MysqlDBConnString, CommandType.Text, sqlStr.ToString(), sp) > 0)
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
                sp = new SqlParameter[] {
                    new  SqlParameter("@DataColumnDescription",extendedPropertyValue.Trim()),
                };
                if (SqlHelper.ExecuteNonQuery(MysqlDBConnString, CommandType.Text, sqlStr.ToString(), sp) > 0)
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

        #region "拼SqlParamete [] sp;"

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
            sbSqlParameterStr.AppendLine("SqlParameter[] sp = new SqlParameter[]");
            sbSqlParameterStr.AppendLine("\t{");
            for (var i = 0; i < dataRows.Length; i++)
            {
                if (i > 0)
                {
                    sbSqlParameterStr.Append("，\r\n");
                }
                sbSqlParameterStr.AppendFormat("\t\tnew SqlParameter(\"@{0}\", {1}Model.{0} )", dataRows[i]["列名"], dataTableName);
            }
            sbSqlParameterStr.AppendLine("\r\n\t} ");
            return sbSqlParameterStr.ToString();
        }

        #endregion
    }
}
