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

using Dapper;

using ${ClassNameSpace}.DAL.Providers;
using ${ClassNameSpace}.Model;

namespace ${ClassNameSpace}.DAL 
{
	public sealed class ${ClassName}DAL : ${ClassName}CRUD<MySQLProvider> { }
	
	public class ${ClassName}CRUD<TProvider> : DB<TProvider> where TProvider : DatabaseProvider
	{
		#region  BasicMethod
		
		/// <summary>
        /// 插入实体对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
		public bool Insert(${ClassName}Model model){
			string sqlInsert = "INSERT INTO ${ClassName} (${FliedArr}) VALUES (${FliedParmArr})";
			var execRst = connection.Execute(sqlInsert, model) > 0;
            return execRst;
		}
		
		/// <summary>
        /// 删除实体对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
		public bool Delete(${ClassName}Model model){
			string sqlDelete = "DELETE FROM ${ClassName} WHERE ${PrimaryKey.Column.Camel} = @${PrimaryKey.Column.Pascal}";
			var execRst = connection.Execute(sqlDelete, new { ${PrimaryKey.Column.Pascal} = model.${PrimaryKey.Column.Pascal} }) > 0;
            return execRst;
		}
		
		/// <summary>
        /// 修改实体对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
		public bool Modify(${ClassName}Model model){
			string sqlUpdate = "UPDATE ${ClassName} SET ${FliedModifyParmArr} WHERE ${PrimaryKey.Column.Camel} = @${PrimaryKey.Column.Pascal}";
			var execRst = connection.Execute(sqlUpdate, new { ${PrimaryKey.Column.Pascal} = model.${PrimaryKey.Column.Pascal} }) > 0;
            return execRst;
		}
		
		/// <summary>
        /// 根据主键查询单个实体
        /// </summary>
        /// <param name="${PrimaryKey.Column.Camel}"></param>
        /// <returns></returns>
		public ${ClassName}Model Get(string ${PrimaryKey.Column.Camel}){
			string sqlSelect = "SELECT ${FliedArr} FROM ${ClassName} WHERE ${PrimaryKey.Column.Camel} = @${PrimaryKey.Column.Pascal} LIMIT 1;";
			${ClassName}Model ${ClassNameCamel}Model = connection.Query<${ClassName}Model>(sqlSelect, new { ${PrimaryKey.Column.Pascal} = ${PrimaryKey.Column.Camel} }).FirstOrDefault();
            return ${ClassNameCamel}Model;
		}
		
		/// <summary>
        /// 查询实体集合
        /// </summary>
		/// <param name="whereList">条件</param>
		/// <param name="orderBy">排序</param>
        /// <returns>实体集合</returns>
		public IList<${ClassName}Model> GetList(List<string> whereList, string orderBy){
			string whereStr = whereList != null && whereList.Count > 0 ? $" WHERE {string.Join("AND ", whereList.ToArray())}" : " ";
			string sqlSelect = "SELECT ${FliedArr} FROM ${ClassName} {whereStr} {orderBy};";
			IList<${ClassName}Model> ${ClassNameCamel}List = connection.Query<${ClassName}Model>(sqlSelect).ToList();
            return ${ClassNameCamel}List;
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
		public IList<${ClassName}Model> GetPageList(List<string> whereList, string orderBy, int pageIndex, int pageSize, out long total){
            int skip =  pageIndex > 0 ?(pageIndex - 1) * pageSize : 0;
			string whereStr = whereList != null && whereList.Count > 0 ? $" WHERE {string.Join("AND ", whereList.ToArray())}" : " ";
			StringBuilder sb = new StringBuilder();
			sb.Append($"SELECT COUNT(1) FROM ${ClassName} {whereStr};\");
			sb.Append($"SELECT ${FliedArr} FROM ${ClassName} {whereStr} {orderBy} LIMIT {skip},{pageSize};");
			var reader = connection.QueryMultiple(sb.ToString());
			total = reader.ReadFirst<long>();
			IList<${ClassName}Model> ${ClassNameCamel}List = reader.Read<${ClassName}Model>().ToList();
			return ${ClassNameCamel}List;
		}
		
		#endregion

		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}