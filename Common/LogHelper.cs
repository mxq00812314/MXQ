using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Common
{
    public static class LogHelper
    {
        private static readonly log4net.ILog loginfo = log4net.LogManager.GetLogger("loginfo");
        private static readonly log4net.ILog logerror = log4net.LogManager.GetLogger("logerror");
        private static readonly log4net.ILog logdebug = log4net.LogManager.GetLogger("logdebug");
        private static readonly log4net.ILog logwarn = log4net.LogManager.GetLogger("logwarn");
        private static readonly log4net.ILog logfatal = log4net.LogManager.GetLogger("logfatal");

        /// <summary>
        ///     记录一般信息
        /// </summary>
        /// <param name="info"></param>
        public static void Info(string info)
        {
            if (loginfo.IsInfoEnabled)
            {
                loginfo.Info(info);
            }
        }


        /// <summary>
        ///     记录一般错误日志
        /// </summary>
        /// <param name="info"></param>
        /// <param name="ex"></param>
        public static void Error(string info)
        {
            if (logerror.IsErrorEnabled)
            {
                logerror.Error(info);
            }
        }


        /// <summary>
        ///     记录一般错误日志
        /// </summary>
        /// <param name="info"></param>
        /// <param name="ex"></param>
        public static void Error(string info, Exception ex)
        {
            if (logerror.IsErrorEnabled)
            {
                logerror.Error(info, ex);
            }
        }

        /// <summary>
        ///     记录调试信息
        /// </summary>
        /// <param name="info"></param>
        /// <param name="ex"></param>
        public static void Debug(string info)
        {
            if (logdebug.IsDebugEnabled)
            {
                logdebug.Debug(info);
            }
        }

        /// <summary>
        ///     记录警告信息
        /// </summary>
        /// <param name="info"></param>
        /// <param name="ex"></param>
        private static void Warn(string info, Exception ex)
        {
            if (logwarn.IsWarnEnabled)
            {
                logwarn.Warn(info, ex);
            }
        }

        /// <summary>
        ///     记录致命错误
        /// </summary>
        /// <param name="info"></param>
        /// <param name="ex"></param>
        private static void Fatal(string info, Exception ex)
        {
            if (logfatal.IsFatalEnabled)
            {
                logfatal.Fatal(info, ex);
            }
        }
    }
}