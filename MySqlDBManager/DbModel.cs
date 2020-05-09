using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManager
{
    /// <summary>
    /// 数据库模型对象
    /// </summary>
    [Serializable]
    public class DbModel
    {
        /// <summary>
        /// 数据库名
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// 数据库描述
        /// </summary>
        public string DatabaseComment { get; set; }

        /// <summary>
        /// 数据表名称
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// 数据表描述
        /// </summary>
        public string TableComment { get; set; }
        /// <summary>
        /// 表数据行数
        /// </summary>
        public int TableRows { get; set; }

        /// <summary>
        /// 视图名称
        /// </summary>
        public string ViewName { get; set; }

        /// <summary>
        /// 存储过程
        /// </summary>
        public string ProcName { get; set; }
    }
}
