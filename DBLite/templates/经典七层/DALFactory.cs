using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ${NameSpace}
{
	[Serializable]
	public class ${ClassName}
	{

		#region 基本字段
		#foreach($Flied in ${FliedCollection})
		
		/// <summary>
		///  ${Flied.FliedDesc}
		/// </summary>
		[DisplayName("${Flied.FliedDesc}")]
		public ${Flied.FliedDataType} ${Flied.ClassFliedName} { get; set; }
		#end

		#endregion

		#region 扩展字段
		
		#endregion
	}
}