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

namespace ${ClassNameSpace}.IDAL
{
	public sealed interface I${ClassName}
	{
		#region  BasicMethod
		
		/// <summary>
        /// 插入实体对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
		public bool Insert(${ClassName}Model model);
		
		/// <summary>
        /// 删除实体对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
		public bool Delete(${ClassName}Model model);
		
		/// <summary>
        /// 修改实体对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
		public bool Modify(${ClassName}Model model);
		
		/// <summary>
        /// 根据主键查询单个实体
        /// </summary>
        /// <param name="${PrimaryKey.Column.Camel}"></param>
        /// <returns></returns>
		public ${ClassName}Model Get(string ${PrimaryKey.Column.Camel});
		
		/// <summary>
        /// 查询实体集合
        /// </summary>
		/// <param name="whereList">条件</param>
		/// <param name="orderBy">排序</param>
        /// <returns>实体集合</returns>
		public IList<${ClassName}Model> GetList(List<string> whereList, string orderBy);
		
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
		
		#endregion

		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}