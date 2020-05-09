/*  
* ───────────────────────────────────
* 功 能： N/A
* 类 名：  ${ClassName.ToPascal()}BLL
* ───────────────────────────────────
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  ${CreateDateTime.ToString("yyyy-MM-dd HH:mm:ss")}   N/A    初版
*
* ───────────────────────────────────
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using EP.Data;
using ${ClassNameSpace}.Model;
using ${ClassNameSpace}.IDAL;

namespace ${ClassNameSpace}.BLL
{
	public class ${ClassName.ToPascal()}BLL
	{
	   // Get an instance of the Product DAL using the DALFactory
        // Making this static will cache the DAL instance after the initial load
        private static readonly I${ClassName.ToPascal()} dal = ${ClassNameSpace}.DALFactory.DataAccess.Create${ClassName.ToPascal()}();        
		
		#region  BasicMethod
		
		/// <summary>
        /// 插入实体对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
		public static bool Insert${ClassName.ToPascal()}(${ClassName.ToPascal()}Model model)
		{
			return dal.Insert${ClassName.ToPascal()}(model);
		}
		
		/// <summary>
        /// 删除实体对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
		public static bool Delete${ClassName.ToPascal()}(${ClassName.ToPascal()}Model model)
		{
			return dal.Delete${ClassName.ToPascal()}(model);
		}
		
		/// <summary>
        /// 修改实体对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
		public static bool Modify${ClassName.ToPascal()}(${ClassName.ToPascal()}Model model)
		{
			return dal.Modify${ClassName.ToPascal()}(model);
		}
		
		/// <summary>
        /// 根据主键查询单个实体
        /// </summary>
        /// <param name="whereList">条件</param>
		/// <param name="whereOperator">条件操作符</param>
        /// <returns></returns>
		public static ${ClassName.ToPascal()}Model Get${ClassName.ToPascal()}(List<string> whereList = null, WhereOperatorEnum whereOperator = WhereOperatorEnum.And)
		{
			return dal.Get${ClassName.ToPascal()}(whereList, whereOperator);
		}
		
		/// <summary>
        /// 查询实体集合
        /// </summary>
		/// <param name="whereList">条件</param>
		/// <param name="whereOperator">条件操作符</param>
		/// <param name="orderBy">排序</param>
        /// <returns>实体集合</returns>
		public static IList<${ClassName.ToPascal()}Model> Get${ClassName.ToPascal()}List(List<string> whereList = null, WhereOperatorEnum whereOperator = WhereOperatorEnum.And, string orderBy = "")
		{
			return dal.Get${ClassName.ToPascal()}List(whereList, whereOperator, orderBy);
		}
		
        /// <summary>
        /// 分页--查询实体集合
        /// </summary>
        /// <param name="totalRecord">总记录数</param>
        /// <param name="totalPage">总记页数</param>
        /// <param name="whereList">条件</param>
        /// <param name="whereOperator">条件操作符</param>
        /// <param name="orderBy">排序</param>
        /// <param name="pageIndex">页索引</param>
        /// <param name="pageSize">页大小</param>
        /// <returns>实体集合</returns>
		public static IList<${ClassName.ToPascal()}Model> Get${ClassName.ToPascal()}PageList(out long totalRecord, out long totalPage
			, List<string> whereList = null, WhereOperatorEnum whereOperator = WhereOperatorEnum.And
			, string orderBy = "", int pageIndex = 1, int pageSize = 20)
		{
			return dal.Get${ClassName.ToPascal()}PageList(out totalRecord, out totalPage, whereList, whereOperator, orderBy, pageIndex, pageSize);
		}
		
		#endregion

		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}