/*  
* ───────────────────────────────────
* 功 能： N/A
* 类 名： ${ClassNameSpace}.DAL
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

using Dapper;
using ${ClassNameSpace}.IDAL;
using ${ClassNameSpace}.DAL.Providers;
using ${ClassNameSpace}.Model;

namespace ${ClassNameSpace}.MySqlDAL
{
	public sealed class ${ClassName.ToPascal()}DAL : ${ClassName.ToPascal()}CRUD<MySQLProvider> { }
	
	public class ${ClassName.ToPascal()}CRUD<TProvider> : DbProvider<TProvider>, I${ClassName.ToPascal()} where TProvider : DatabaseProvider
	{
		#region  BasicMethod
		
		/// <summary>
        /// 插入实体对象
        /// </summary>
        /// <param name="model">实体对象</param>
        /// <returns></returns>
		public bool Insert${ClassName.ToPascal()}(${ClassName.ToPascal()}Model model){
			string sqlInsert = $"INSERT INTO `${TableName.Name}` (${FliedArr}) VALUES (${FliedParmArr});";
			var execRst = connection.Execute(sqlInsert, model) > 0;
            return execRst;
		}
		
		/// <summary>
        /// 删除实体对象
        /// </summary>
        /// <param name="model">实体对象</param>
        /// <returns></returns>
		public bool Delete${ClassName.ToPascal()}(${ClassName.ToPascal()}Model model){
			string sqlDelete = $"DELETE FROM `${TableName.Name}` WHERE ${PrimaryKey.Column.ToCamel()} = ${ParmPrefix}${PrimaryKey.Column.ToPascal()};";
			var execRst = connection.Execute(sqlDelete, new { ${PrimaryKey.Column.ToPascal()} = model.${PrimaryKey.Column.ToPascal()} }) > 0;
            return execRst;
		}
		
		/// <summary>
        /// 修改实体对象
        /// </summary>
        /// <param name="model">实体对象</param>
        /// <returns></returns>
		public bool Modify${ClassName.ToPascal()}(${ClassName.ToPascal()}Model model){
			string sqlUpdate = $"UPDATE `${TableName.Name}` SET ${FliedModifyParmArr} WHERE ${PrimaryKey.Column.ToCamel()} = ${ParmPrefix}${PrimaryKey.Column.ToPascal()};";
			var execRst = connection.Execute(sqlUpdate, new { ${PrimaryKey.Column.ToPascal()} = model.${PrimaryKey.Column.ToPascal()} }) > 0;
            return execRst;
		}
		
		/// <summary>
        /// 根据主键查询单个实体
        /// </summary>
 		/// <param name="whereList">条件</param>
		/// <param name="orderBy">排序</param>
        /// <returns></returns>
		public ${ClassName.ToPascal()}Model Get${ClassName.ToPascal()}(List<string> whereList = null, WhereOperatorEnum whereOperator = WhereOperatorEnum.And){
			string whereStr = whereList != null && whereList.Count > 0 ? $" WHERE {string.Join(whereOperator.ToString(), whereList.ToArray())}" : " ";
			string sqlSelect = $"SELECT ${FliedArr} FROM `${TableName.Name}` {whereStr} LIMIT 1;";
			${ClassName.ToPascal()}Model ${ClassName.ToCamel()}Model = connection.Query<${ClassName.ToPascal()}Model>(sqlSelect).FirstOrDefault();
            return ${ClassName.ToCamel()}Model;
		}
		
		/// <summary>
        /// 查询实体集合
        /// </summary>
		/// <param name="whereList">条件</param>
        /// <param name="whereOperator">条件操作符</param>
		/// <param name="orderBy">排序</param>
        /// <returns>实体集合</returns>
		public IList<${ClassName.ToPascal()}Model> Get${ClassName.ToPascal()}List(List<string> whereList = null, WhereOperatorEnum whereOperator = WhereOperatorEnum.And, string orderBy = ""){
			string whereStr = whereList != null && whereList.Count > 0 ? $" WHERE {string.Join(whereOperator.ToString(), whereList.ToArray())}" : " ";
			string sqlSelect = $"SELECT ${FliedArr} FROM `${TableName.Name}` {whereStr} {orderBy};";
			IList<${ClassName.ToPascal()}Model> ${ClassName.ToCamel()}List = connection.Query<${ClassName.ToPascal()}Model>(sqlSelect).ToList();
            return ${ClassName.ToCamel()}List;
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
		public IList<${ClassName.ToPascal()}Model> Get${ClassName.ToPascal()}PageList(out long totalRecord, out long totalPage
			, List<string> whereList = null, WhereOperatorEnum whereOperator = WhereOperatorEnum.And
			, string orderBy = "", int pageIndex = 1, int pageSize = 20){
            int skip =  pageIndex > 0 ?(pageIndex - 1) * pageSize : 0;
			string whereStr = whereList != null && whereList.Count > 0 ? $" WHERE {string.Join(whereOperator.ToString(), whereList.ToArray())}" : " ";
			StringBuilder sb = new StringBuilder();
			sb.Append($"SELECT COUNT(1) FROM `${TableName.Name}` {whereStr};");
			sb.Append($"SELECT ${FliedArr} FROM `${TableName.Name}` {whereStr} {orderBy} LIMIT {skip},{pageSize};");
			var reader = connection.QueryMultiple(sb.ToString());
			totalRecord = reader.ReadFirst<long>();
			totalPage = totalRecord % pageSize == 0 ? totalRecord / pageSize : totalRecord / pageSize + 1;
			IList<${ClassName.ToPascal()}Model> ${ClassName.ToCamel()}List = reader.Read<${ClassName.ToPascal()}Model>().ToList();
			return ${ClassName.ToCamel()}List;
		}
		
		#endregion

		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}