#region 使用方法:

/*
 * =================================================================
 *  Velocity 模板引擎使用示例
 *  https://github.com/castleproject/NVelocity
 * =================================================================

    VelocityHelper templateEngine = new VelocityHelper();
    templateEngine.Init(@"templates/abc.cs");//指定模板文件的相对路径
    templateEngine.Add("name", "员工信息");
    templateEngine.Add("age","12");
    templateEngine.OutPut("abc.cs");

 * =================================================================
 * NVelocity 语法
 * https://github.com/castleproject/NVelocity/blob/master/docs/nvelocity.md
 * 单行注释             ##注释操作
 * 多行注释             #* ...abc123... *#
 * 参数赋值             #set($abc = false)、 #set( $efg = ["name", "address"] )
 * 变量声明 以$开头,如  $abc、${abc}、 $user.name
 * 键/值对              #component(ComponentName with "age=1")
 *                      #blockcomponent(SecurityComponent with "role=admin")
                            this will only be rendered if the current user is in the specified role
                        #end
 * 分支判断             #if(${ModelInfo.Description}=="")${ModelInfo.Description}#else${ClassName}#end #end ##endif #end
 * feach循环            #foreach($ColumnInfo in ${TableInfo.ColumnList.Values}) 
 *                          ${ColumnInfo.Name.Alias.ToCapit() ="123".${ColumnInfo.Name} 
 *                      #end
 * 
 * 内容脚本 #macro      声明方法如下
 *                      #macro( d )
                            <tr><td></td></tr>
                        #end

                        调用方法如下
                        #d()
 * 
*/

#endregion

using System;
using System.Web;
using System.Collections.Generic;
using System.Text;
using System.IO;

using NVelocity;
using NVelocity.App;
using NVelocity.Context;
using NVelocity.App.Tools;
using NVelocity.Runtime;
using NVelocity.Exception;
using Commons.Collections;

namespace DBLite
{
    /// <summary>
    ///  NVelocity模板工具类 VelocityHelper
    /// </summary>
    public class VelocityHelper
    {
        private VelocityEngine velocityEngine = null;
        private IContext context = null;
        protected string templateFile;

        /// <summary>
        /// 构造函数
        /// </summary>
        public VelocityHelper(string templatePath)
        {
            Init(templatePath);
        }

        /// <summary>
        /// 初始话NVelocity模块
        /// </summary>
        /// <param name="templatDir">模板文件夹路径</param>
        private void Init(string templatDir)
        {
            try
            {
                //创建VelocityEngine实例对象
                velocityEngine = new VelocityEngine();
                //使用设置初始化VelocityEngine
                ExtendedProperties velocityProperty = new ExtendedProperties();
                velocityProperty.AddProperty(RuntimeConstants.RESOURCE_LOADER, "file");
                //如果设置了FILE_RESOURCE_LOADER_PATH属性，那么模板文件的基础路径就是基于这个设置的目录，否则默认当前运行目录
                //  BS 程序生成路径
                //velocityProperty.AddProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, HttpContext.Current.Server.MapPath("~/Template/"));
                //  CS 程序生成路径
                velocityProperty.AddProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, templatDir);
                velocityProperty.AddProperty(RuntimeConstants.INPUT_ENCODING, "utf-8");
                velocityProperty.AddProperty(RuntimeConstants.OUTPUT_ENCODING, "utf-8");

                //模板的缓存设置
                velocityProperty.AddProperty(RuntimeConstants.FILE_RESOURCE_LOADER_CACHE, true);             //是否缓存
                velocityProperty.AddProperty("file.resource.loader.modificationCheckInterval", (Int64)5);    //缓存时间(秒)

                velocityEngine.Init(velocityProperty);

                //为模板变量赋值
                context = new VelocityContext();
                context.Put("formatter", new VelocityFormatter(context));
            }
            catch (ResourceNotFoundException re)
            {
                string error = string.Format("Cannot find template " + templateFile);

                throw new Exception(error, re);
            }
            catch (ParseErrorException pee)
            {
                string error = string.Format("Syntax error in template " + templateFile + ":" + pee.StackTrace);
                throw new Exception(error, pee);
            }
        }

        /// <summary>
        /// 给模板变量赋值
        /// </summary>
        /// <param name="key">模板变量</param>
        /// <param name="value">模板变量值</param>
        public void Add(string key, object value)
        {
            if (context == null)
            {
                context = new VelocityContext();

            }
            context.Put(key, value);
        }

        /// <summary>
        /// 模板和数据合并
        /// </summary>
        /// <param name="templatFileName">模板文件名</param>
        public string OutPut(string templatFileName)
        {
            //从文件中读取模板
            Template template = velocityEngine.GetTemplate(templatFileName, "UTF-8");
            //合并模板
            var templateDataStr = "";
            using (StringWriter writer = new StringWriter())
            {
                template.Merge(context, writer);
                templateDataStr = writer.GetStringBuilder().ToString();
            }
            return templateDataStr;
        }


    }
}
