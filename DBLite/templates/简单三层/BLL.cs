/*  
* ───────────────────────────────────
* 功 能： N/A
* 类 名： 
* ───────────────────────────────────
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/4/3 14:07:19   N/A    初版
*
* ───────────────────────────────────
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using ${ClassNameSpace}.Model;
using ${ClassNameSpace}.DAL

namespace ${ClassNameSpace}.BLL
{
	public class ${ClassName}BLL
	{
	   // Get an instance of the Product DAL using the DALFactory
        // Making this static will cache the DAL instance after the initial load
        private static readonly ${ClassName}DAL dal = new ${ClassName}DAL();        
		
		#region  BasicMethod
		
		/// <summary>
        /// 插入实体对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
		public bool Insert(${ClassName}Model model)
		{
			dal.Insert(model);
		}
		
		/// <summary>
        /// 删除实体对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
		public bool Delete(${ClassName}Model model)
		{
			dal.Delete(model);
		}
		
		/// <summary>
        /// 修改实体对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
		public bool Modify(${ClassName}Model model)
		{
			dal.Modify(model);
		}
		
		/// <summary>
        /// 根据主键查询单个实体
        /// </summary>
        /// <param name="${PrimaryKey.Column.Camel}"></param>
        /// <returns></returns>
		public ${ClassName}Model Get(string ${PrimaryKey.Column.Camel})
		{
			dal.Get(${PrimaryKey.Column.Camel});
		}
		
		/// <summary>
        /// 查询实体集合
        /// </summary>
		/// <param name="whereList">条件</param>
		/// <param name="orderBy">排序</param>
        /// <returns>实体集合</returns>
		public IList<${ClassName}Model> GetList(List<string> whereList, string orderBy)
		{
			dal.GetList(whereList, orderBy);
		}
		
		/// <summary>
		/// 分页--查询实体集合
		/// </summary>
		/// <param name="whereList">条件</param>
		/// <param name="orderBy">排序</param>
		/// <param name="pageIndex">页索引</param>
		/// <param name="pageSize">页大小</param>
		/// <param name="total">总记录数</param>
		/// <returns>实体集合</returns>
		public IList<${ClassName}Model> GetPageList(List<string> whereList, string orderBy, int pageIndex, int pageSize, out long total);
		{
			dal.GetPageList(whereList, orderBy, pageIndex, pageSize, out total);
		}
		
		#endregion

		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}