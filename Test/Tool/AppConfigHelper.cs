using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;


namespace Test.Tool
{
    /// <summary>
    /// 读取config配置文件节点信息
    /// </summary>
    public static class AppConfigHelper
    {
        #region Methods
        public static AppSettingsSection GetSectionSettings(string sectionName)
        {
            return ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).GetSection(sectionName) as AppSettingsSection ;
        }

        #endregion
    }
}