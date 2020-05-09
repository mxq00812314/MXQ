using System;
using System.Data;
using System.Collections;
using MySql.Data.MySqlClient;

namespace DB
{
    public class MySqlHelper
    {
        private static MySqlConnection connection;
        public static string connString = System.Configuration.ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        private static Hashtable parmCache = Hashtable.Synchronized(new Hashtable());

        #region 执行SQL语句或存储过程返回DataSet

        public static DataSet ExecuteDataTable(string cmdText)
        {
            MySqlCommand sqlcmd = new MySqlCommand();
            DataSet ds = new DataSet();
            using (MySqlConnection sqlConn = new MySqlConnection(connString))
            {
                PrepareCommand(sqlcmd, sqlConn, null, CommandType.Text, cmdText, null);
                MySqlDataAdapter da = new MySqlDataAdapter(sqlcmd);
                da.Fill(ds);
                sqlcmd.Parameters.Clear();
                return ds;
            }
        }

        public static DataSet ExecuteDataTable(string cmdText, params MySqlParameter[] commandParameters)
        {
            MySqlCommand sqlcmd = new MySqlCommand();
            DataSet ds = new DataSet();
            using (MySqlConnection sqlConn = new MySqlConnection(connString))
            {
                PrepareCommand(sqlcmd, sqlConn, null, CommandType.Text, cmdText, commandParameters);
                MySqlDataAdapter da = new MySqlDataAdapter(sqlcmd);
                da.Fill(ds);
                sqlcmd.Parameters.Clear();
                return ds;
            }
        }

        public static DataSet ExecuteDataTable(string connectionString, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {
            MySqlCommand sqlcmd = new MySqlCommand();
            DataSet ds = new DataSet();
            using (MySqlConnection sqlConn = new MySqlConnection(connectionString))
            {
                PrepareCommand(sqlcmd, sqlConn, null, cmdType, cmdText, commandParameters);
                MySqlDataAdapter da = new MySqlDataAdapter(sqlcmd);
                da.Fill(ds);
                sqlcmd.Parameters.Clear();
                return ds;
            }
        }

        public static DataSet ExecuteDataTable(string connectionString, CommandType cmdType, string cmdText, int ExecuteTime, params MySqlParameter[] commandParameters)
        {
            MySqlCommand sqlcmd = new MySqlCommand();
            DataSet ds = new DataSet();
            using (MySqlConnection sqlConn = new MySqlConnection(connectionString))
            {
                PrepareCommand(sqlcmd, sqlConn, null, cmdType, cmdText, commandParameters, ExecuteTime);
                MySqlDataAdapter da = new MySqlDataAdapter(sqlcmd);
                da.Fill(ds);
                sqlcmd.Parameters.Clear();
                return ds;
            }
        }

        public static DataSet ExecuteDataTable(MySqlConnection sqlConn, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {
            MySqlCommand sqlCmd = new MySqlCommand();
            DataSet ds = new DataSet();
            PrepareCommand(sqlCmd, sqlConn, null, cmdType, cmdText, commandParameters);
            MySqlDataAdapter da = new MySqlDataAdapter(sqlCmd);
            da.Fill(ds);
            sqlCmd.Parameters.Clear();
            return ds;
        }

        public static DataSet ExecuteDataTable(MySqlConnection sqlConn, CommandType cmdType, string cmdText, int ExecuteTime, params MySqlParameter[] commandParameters)
        {
            MySqlCommand sqlCmd = new MySqlCommand();
            DataSet ds = new DataSet();
            PrepareCommand(sqlCmd, sqlConn, null, cmdType, cmdText, commandParameters, ExecuteTime);
            MySqlDataAdapter da = new MySqlDataAdapter(sqlCmd);
            da.Fill(ds);
            sqlCmd.Parameters.Clear();
            return ds;
        }

        #endregion

        #region 执行SQL语句或存储过程返回受影响的行数

        public static int ExecuteNonQuery(string cmdText)
        {

            MySqlCommand cmd = new MySqlCommand();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                PrepareCommand(cmd, conn, null, CommandType.Text, cmdText, null);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }

        public static int ExecuteNonQuery(string cmdText, params MySqlParameter[] commandParameters)
        {

            MySqlCommand cmd = new MySqlCommand();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                PrepareCommand(cmd, conn, null, CommandType.Text, cmdText, commandParameters);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }

        public static int ExecuteNonQuery(string connectionString, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {

            MySqlCommand cmd = new MySqlCommand();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }

        public static int ExecuteNonQuery(string connectionString, CommandType cmdType, string cmdText, int ExecuteTime, params MySqlParameter[] commandParameters)
        {

            MySqlCommand cmd = new MySqlCommand();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters, ExecuteTime);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }

        public static int ExecuteNonQuery(MySqlConnection connection, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {

            MySqlCommand cmd = new MySqlCommand();

            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }

        public static int ExecuteNonQuery(MySqlConnection connection, CommandType cmdType, string cmdText, int ExecuteTime, params MySqlParameter[] commandParameters)
        {

            MySqlCommand cmd = new MySqlCommand();

            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters, ExecuteTime);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }

        public static int ExecuteNonQuery(MySqlTransaction trans, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {
            MySqlCommand cmd = new MySqlCommand();
            PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }

        public static int ExecuteNonQuery(MySqlTransaction trans, CommandType cmdType, string cmdText, int ExecuteTime, params MySqlParameter[] commandParameters)
        {
            MySqlCommand cmd = new MySqlCommand();
            PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters, ExecuteTime);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }

        #endregion

        #region 执行SQL语句或存储过程返回MySqlDataReader
        public static MySqlDataReader ExecuteReader(string cmdText)
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection(connString);

            // we use a try/catch here because if the method throws an exception we want to 
            // close the connection throw code, because no datareader will exist, hence the 
            // commandBehaviour.CloseConnection will not work
            try
            {
                PrepareCommand(cmd, conn, null, CommandType.Text, cmdText, null);
                MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                conn.Close();
                throw;
            }
        }

        public static MySqlDataReader ExecuteReader(string cmdText, params MySqlParameter[] commandParameters)
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection(connString);

            // we use a try/catch here because if the method throws an exception we want to 
            // close the connection throw code, because no datareader will exist, hence the 
            // commandBehaviour.CloseConnection will not work
            try
            {
                PrepareCommand(cmd, conn, null, CommandType.Text, cmdText, commandParameters);
                MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                conn.Close();
                throw;
            }
        }

        public static MySqlDataReader ExecuteReader(string connectionString, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection(connectionString);

            // we use a try/catch here because if the method throws an exception we want to 
            // close the connection throw code, because no datareader will exist, hence the 
            // commandBehaviour.CloseConnection will not work
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                conn.Close();
                throw;
            }
        }

        public static MySqlDataReader ExecuteReader(string connectionString, CommandType cmdType, string cmdText, int ExecuteTime, params MySqlParameter[] commandParameters)
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection(connectionString);

            // we use a try/catch here because if the method throws an exception we want to 
            // close the connection throw code, because no datareader will exist, hence the 
            // commandBehaviour.CloseConnection will not work
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters, ExecuteTime);
                MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                conn.Close();
                throw;
            }
        }

        #endregion

        #region 执行SQL语句或存储过程返回object
        public static object ExecuteScalar(string connectionString, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {
            MySqlCommand cmd = new MySqlCommand();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return val;
            }
        }


        public static object ExecuteScalar(MySqlConnection connection, CommandType cmdType, string cmdText, params MySqlParameter[] commandParameters)
        {

            MySqlCommand cmd = new MySqlCommand();

            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
            object val = cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            return val;
        }
        #endregion

        #region 获取或设置缓存中的参数
        /// <summary>
        /// add parameter array to the cache
        /// </summary>
        /// <param name="cacheKey">Key to the parameter cache</param>
        /// <param name="cmdParms">an array of SqlParamters to be cached</param>
        public static void CacheParameters(string cacheKey, params MySqlParameter[] commandParameters)
        {
            parmCache[cacheKey] = commandParameters;
        }

        /// <summary>
        /// Retrieve cached parameters
        /// </summary>
        /// <param name="cacheKey">key used to lookup parameters</param>
        /// <returns>Cached SqlParamters array</returns>
        public static MySqlParameter[] GetCachedParameters(string cacheKey)
        {
            MySqlParameter[] cachedParms = (MySqlParameter[])parmCache[cacheKey];

            if (cachedParms == null)
                return null;

            MySqlParameter[] clonedParms = new MySqlParameter[cachedParms.Length];

            for (int i = 0, j = cachedParms.Length; i < j; i++)
                clonedParms[i] = (MySqlParameter)((ICloneable)cachedParms[i]).Clone();

            return clonedParms;
        }
        #endregion

        #region 执行Method
        /// <summary>
        /// Prepare a command for execution
        /// </summary>
        /// <param name="cmd">MySqlCommand object</param>
        /// <param name="conn">MySqlConnection object</param>
        /// <param name="trans">MySqlTransaction object</param>
        /// <param name="cmdType">Cmd type e.g. stored procedure or text</param>
        /// <param name="cmdText">Command text, e.g. Select * from Products</param>
        /// <param name="cmdParms">SqlParameters to use in the command</param>
        private static void PrepareCommand(MySqlCommand cmd, MySqlConnection conn, MySqlTransaction trans, CommandType cmdType, string cmdText, MySqlParameter[] cmdParms)
        {

            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;

            if (cmdParms != null)
            {
                foreach (MySqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }

        /// <summary>
        /// Prepare a command for execution
        /// </summary>
        /// <param name="cmd">MySqlCommand object</param>
        /// <param name="conn">MySqlConnection object</param>
        /// <param name="trans">MySqlTransaction object</param>
        /// <param name="cmdType">Cmd type e.g. stored procedure or text</param>
        /// <param name="cmdText">Command text, e.g. Select * from Products</param>
        /// <param name="cmdParms">SqlParameters to use in the command</param>
        private static void PrepareCommand(MySqlCommand cmd, MySqlConnection conn, MySqlTransaction trans, CommandType cmdType, string cmdText, MySqlParameter[] cmdParms, int ExecuteTime)
        {

            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;
            cmd.CommandTimeout = ExecuteTime;

            if (cmdParms != null)
            {
                foreach (MySqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }

        #endregion
    }
}

