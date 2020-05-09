/*  
* ───────────────────────────────────
* 功 能： N/A
* 类 名： ${ClassNameSpace}.Model
* ───────────────────────────────────
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  ${CreateDateTime.ToString("yyyy-MM-dd HH:mm:ss")}   N/A    初版
*
* ───────────────────────────────────
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ${ClassNameSpace}.Model
{
	[Serializable]
	public class ${ClassName.ToPascal()}Model
	{

		#region 基本字段
		#foreach($Flied in ${FliedCollection})
		
		/// <summary>
		///  ${Flied.FliedDescription}
		/// </summary>
		[DisplayName("${Flied.ColumnDescription}")]
		public ${Flied.FliedDataType} ${Flied.Column.ToPascal()} { get; set; }
		#end

		#endregion

		#region 扩展字段
		
		#endregion
	}
}