using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class DbResult
    {
        /// <summary>
        /// 执行状态码
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 执行消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        public object Result { get; set; }

        /// <summary>
        /// 数据对象
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// 测试信息
        /// </summary>
        public object DebugInfo { get; set; }

        public DbResult() { }

        public DbResult(int code, string message)
        {
            this.Code = code;
            this.Message = message;
        }

        public DbResult(int code, string message, object data)
        {
            this.Code = code;
            this.Message = message;
            this.Data = data;
        }

        public DbResult(int code, string message, bool status, object result, object data)
        {
            this.Code = code;
            this.Message = message;
            this.Status = status;
            this.Result = result;
            this.Data = data;
        }

        public static DbResult Fail(string msg)
        {
            LogHelper.Error(msg);
            return new DbResult(0, msg);
        }

        public static DbResult Fail(string msg, Exception ex)
        {
            LogHelper.Error(msg, ex);
            return new DbResult(0, msg);
        }

        public static DbResult Success(string msg)
        {
            return new DbResult(1, msg);
        }
    }
}
