using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EP.Common;

namespace EP.YSDZP.Local.Realization
{

    public static class LocalCache
    {
        private static IniFileHelper iniFile = new IniFileHelper(System.Environment.CurrentDirectory + @"\EntityCache.ini");

        public static EntityCache GetEntityCache()
        {
            EntityCache entityCache = new EntityCache();
            string[] dbCustomerArr = iniFile.GetSectionValues("EntityCache");
            if (dbCustomerArr == null)
            {
                return null;
            }
            string jsonStr = string.Join("", dbCustomerArr);
            if (string.IsNullOrWhiteSpace(jsonStr))
            {
                return null;
            }
            entityCache = StringHelper.ToObject<EntityCache>(jsonStr);
            return entityCache;
        }
        public static void SetEntityCache(EntityCache entityCache)
        {
            iniFile.DelSection("EntityCache");
            if (entityCache != null)
                iniFile.SetSectionValue("EntityCache", StringHelper.ToViewJSON(entityCache));
        }
    }

    public class EntityCache
    {
        public string NameSpace { get; set; } = "";

        public string EntityName { get; set; } = "";
    }
}
