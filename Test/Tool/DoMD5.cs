using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Test.Tool
{
    public static class DoMD5
    {
        /// <summary>
        /// 对需要加密的字符串List进行ASC排序
        /// </summary>
        /// <param name="SortList">需要排序的List</param>
        /// <returns></returns>
        public static List<string> DoSort(List<string> SortList)
        {
            for (int i = 0; i < SortList.Count - 1; i++)
            {
                for (int j = i + 1; j < SortList.Count; j++)
                {
                    if (string.CompareOrdinal(SortList[i], SortList[j]) > 0)
                    {
                        string temp = "";
                        temp = SortList[i];
                        SortList[i] = SortList[j];
                        SortList[j] = temp;
                    }
                }
            }
            return SortList;
        }
        /// <summary>
        /// 进行MD5加密
        /// </summary>
        /// <param name="SortList">需要加密的字符串数组(包含Sign、Key)</param>
        /// <returns></returns>
        public static string CreateMD5(List<string> SortList)
        {
            SortList = DoSort(SortList);
            string Info = "";
            for (int i = 0; i < SortList.Count; i++)
            {
                Info = Info + SortList[i];
            }
            string Md5Key = Md5Encrypt(Info);
            return Md5Key;
        }
        /// <summary>
        /// 获取字符数组的MD5加密值
        /// </summary>
        /// <param name="sortedArray">待计算MD5哈希值的输入字符数组</param>
        /// <param name="key">密钥</param>
        /// <param name="charset"></param>
        /// <returns>输入字符数组的MD5哈希值</returns>
        public static string GetMD5ByArray(string[] sortedArray, string key, string charset)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < sortedArray.Length; i++)
            {
                if (i == sortedArray.Length - 1)
                {
                    builder.Append(sortedArray[i]);
                }
                else
                {
                    builder.Append(sortedArray[i] + "&");
                }
            }
            builder.Append(key);
            return GetMD5(builder.ToString(), charset);
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="input">待计算MD5哈希值的输入字符串</param>
        /// <param name="charset">输入字符串的字符集</param>
        /// <returns>输入字符串的MD5哈希值</returns>
        public static string GetMD5(string input, string charset)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = md5.ComputeHash(Encoding.GetEncoding(charset).GetBytes(input));
            StringBuilder builder = new StringBuilder(32);
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }
            return builder.ToString();
        }
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="input">待加密字符串</param>
        /// <returns></returns>
        public static string Md5Encrypt(string input)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            var data = Encoding.UTF8.GetBytes(input);
            var encs = md5.ComputeHash(data);
            return BitConverter.ToString(encs).Replace("-", "").ToLower();
        }
        /// <summary>  
        /// 获取时间戳  
        /// </summary>  
        /// <returns></returns>  
        public static Int64 GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds);
        }

        ///// <summary>
        ///// 获取加密KEY
        ///// </summary>
        ///// <param name="Sign">用户名</param>
        ///// <param name="Type">类型</param>
        ///// <returns></returns>
        //public static string GetKey(string Sign, string Type)
        //{
        //    string getKeySql = "select enKey from ALL_Authority where applyType='" + Type + "' AND applyUser='" + Sign + "'";
        //    try
        //    {
        //        using (MySqlConnection connection = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString))
        //        {
        //            using (MySqlCommand cmd = new MySqlCommand(getKeySql, connection))
        //            {
        //                try
        //                {
        //                    connection.Open();
        //                    DataSet ds = new DataSet();
        //                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //                    da.Fill(ds);
        //                    if (ds.Tables[0].Rows.Count != 0)
        //                    {
        //                        return ds.Tables[0].Rows[0][0].ToString();
        //                    }
        //                    else
        //                    {
        //                        return "";
        //                    }
        //                }
        //                catch (MySql.Data.MySqlClient.MySqlException Ex)
        //                {
        //                    connection.Close();
        //                    throw new Exception(Ex.Message);
        //                }
        //                finally
        //                {
        //                    cmd.Dispose();
        //                    connection.Close();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
