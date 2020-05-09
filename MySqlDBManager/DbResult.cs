using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DBManager
{
    
    public enum DbResultType
    {
        db_Boolean,
        db_String,
        db_Int32,
        db_Float,
        db_Double,
        db_Decimal,
        db_DateTime,
        db_DataTable,
        db_List,
        db_Array,
        db_Hash,
        db_Dictionary,
        db_Object
    };

    public class DbResult
    {
        public DbResultType DbResultType { get; set; }
        public object DbResultData { get; set; }
    }
}
