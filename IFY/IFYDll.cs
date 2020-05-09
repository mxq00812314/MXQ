using System;
using System.IO;
using System.Runtime.InteropServices;

namespace IFY
{
    #region TTS 枚举错误代码

    /// <summary>
    /// 枚举错误代码
    /// </summary>
    public enum ErrorCode
    {
        MSP_SUCCESS = 0,
        MSP_ERROR_FAIL = -1,
        MSP_ERROR_EXCEPTION = -2,

        /* General errors 10100(0x2774) */
        MSP_ERROR_GENERAL = 10100,     /* 0x2774 */
        MSP_ERROR_OUT_OF_MEMORY = 10101,     /* 0x2775 */
        MSP_ERROR_FILE_NOT_FOUND = 10102,     /* 0x2776 */
        MSP_ERROR_NOT_SUPPORT = 10103,     /* 0x2777 */
        MSP_ERROR_NOT_IMPLEMENT = 10104,     /* 0x2778 */
        MSP_ERROR_ACCESS = 10105,     /* 0x2779 */
        MSP_ERROR_INVALID_PARA = 10106,     /* 0x277A */
        MSP_ERROR_INVALID_PARA_VALUE = 10107,     /* 0x277B */
        MSP_ERROR_INVALID_HANDLE = 10108,     /* 0x277C */
        MSP_ERROR_INVALID_DATA = 10109,     /* 0x277D */
        MSP_ERROR_NO_LICENSE = 10110,     /* 0x277E */
        MSP_ERROR_NOT_INIT = 10111,     /* 0x277F */
        MSP_ERROR_NULL_HANDLE = 10112,     /* 0x2780 */
        MSP_ERROR_OVERFLOW = 10113,     /* 0x2781 */
        MSP_ERROR_TIME_OUT = 10114,     /* 0x2782 */
        MSP_ERROR_OPEN_FILE = 10115,     /* 0x2783 */
        MSP_ERROR_NOT_FOUND = 10116,     /* 0x2784 */
        MSP_ERROR_NO_ENOUGH_BUFFER = 10117,     /* 0x2785 */
        MSP_ERROR_NO_DATA = 10118,     /* 0x2786 */
        MSP_ERROR_NO_MORE_DATA = 10119,     /* 0x2787 */
        MSP_ERROR_SKIPPED = 10120,     /* 0x2788 */
        MSP_ERROR_ALREADY_EXIST = 10121,     /* 0x2789 */
        MSP_ERROR_LOAD_MODULE = 10122,     /* 0x278A */
        MSP_ERROR_BUSY = 10123,     /* 0x278B */
        MSP_ERROR_INVALID_CONFIG = 10124,     /* 0x278C */
        MSP_ERROR_VERSION_CHECK = 10125,     /* 0x278D */
        MSP_ERROR_CANCELED = 10126,     /* 0x278E */
        MSP_ERROR_INVALID_MEDIA_TYPE = 10127,     /* 0x278F */
        MSP_ERROR_CONFIG_INITIALIZE = 10128,     /* 0x2790 */
        MSP_ERROR_CREATE_HANDLE = 10129,     /* 0x2791 */
        MSP_ERROR_CODING_LIB_NOT_LOAD = 10130,     /* 0x2792 */

        /* Error codes of network 10200(0x27D8)*/
        MSP_ERROR_NET_GENERAL = 10200,     /* 0x27D8 */
        MSP_ERROR_NET_OPENSOCK = 10201,     /* 0x27D9 */   /* Open socket */
        MSP_ERROR_NET_CONNECTSOCK = 10202,     /* 0x27DA */   /* Connect socket */
        MSP_ERROR_NET_ACCEPTSOCK = 10203,     /* 0x27DB */   /* Accept socket */
        MSP_ERROR_NET_SENDSOCK = 10204,     /* 0x27DC */   /* Send socket data */
        MSP_ERROR_NET_RECVSOCK = 10205,     /* 0x27DD */   /* Recv socket data */
        MSP_ERROR_NET_INVALIDSOCK = 10206,     /* 0x27DE */   /* Invalid socket handle */
        MSP_ERROR_NET_BADADDRESS = 10207,     /* 0x27EF */   /* Bad network address */
        MSP_ERROR_NET_BINDSEQUENCE = 10208,     /* 0x27E0 */   /* Bind after listen/connect */
        MSP_ERROR_NET_NOTOPENSOCK = 10209,     /* 0x27E1 */   /* Socket is not opened */
        MSP_ERROR_NET_NOTBIND = 10210,     /* 0x27E2 */   /* Socket is not bind to an address */
        MSP_ERROR_NET_NOTLISTEN = 10211,     /* 0x27E3 */   /* Socket is not listenning */
        MSP_ERROR_NET_CONNECTCLOSE = 10212,     /* 0x27E4 */   /* The other side of connection is closed */
        MSP_ERROR_NET_NOTDGRAMSOCK = 10213,     /* 0x27E5 */   /* The socket is not datagram type */

        /* Error codes of mssp message 10300(0x283C) */
        MSP_ERROR_MSG_GENERAL = 10300,     /* 0x283C */
        MSP_ERROR_MSG_PARSE_ERROR = 10301,     /* 0x283D */
        MSP_ERROR_MSG_BUILD_ERROR = 10302,     /* 0x283E */
        MSP_ERROR_MSG_PARAM_ERROR = 10303,     /* 0x283F */
        MSP_ERROR_MSG_CONTENT_EMPTY = 10304,     /* 0x2840 */
        MSP_ERROR_MSG_INVALID_CONTENT_TYPE = 10305,     /* 0x2841 */
        MSP_ERROR_MSG_INVALID_CONTENT_LENGTH = 10306,     /* 0x2842 */
        MSP_ERROR_MSG_INVALID_CONTENT_ENCODE = 10307,     /* 0x2843 */
        MSP_ERROR_MSG_INVALID_KEY = 10308,     /* 0x2844 */
        MSP_ERROR_MSG_KEY_EMPTY = 10309,     /* 0x2845 */
        MSP_ERROR_MSG_SESSION_ID_EMPTY = 10310,     /* 0x2846 */
        MSP_ERROR_MSG_LOGIN_ID_EMPTY = 10311,     /* 0x2847 */
        MSP_ERROR_MSG_SYNC_ID_EMPTY = 10312,     /* 0x2848 */
        MSP_ERROR_MSG_APP_ID_EMPTY = 10313,     /* 0x2849 */
        MSP_ERROR_MSG_EXTERN_ID_EMPTY = 10314,     /* 0x284A */
        MSP_ERROR_MSG_INVALID_CMD = 10315,     /* 0x284B */
        MSP_ERROR_MSG_INVALID_SUBJECT = 10316,     /* 0x284C */
        MSP_ERROR_MSG_INVALID_VERSION = 10317,     /* 0x284D */
        MSP_ERROR_MSG_NO_CMD = 10318,     /* 0x284E */
        MSP_ERROR_MSG_NO_SUBJECT = 10319,     /* 0x284F */
        MSP_ERROR_MSG_NO_VERSION = 10320,     /* 0x2850 */
        MSP_ERROR_MSG_MSSP_EMPTY = 10321,     /* 0x2851 */
        MSP_ERROR_MSG_NEW_RESPONSE = 10322,     /* 0x2852 */
        MSP_ERROR_MSG_NEW_CONTENT = 10323,     /* 0x2853 */
        MSP_ERROR_MSG_INVALID_SESSION_ID = 10324,     /* 0x2854 */

        /* Error codes of DataBase 10400(0x28A0)*/
        MSP_ERROR_DB_GENERAL = 10400,     /* 0x28A0 */
        MSP_ERROR_DB_EXCEPTION = 10401,     /* 0x28A1 */
        MSP_ERROR_DB_NO_RESULT = 10402,     /* 0x28A2 */
        MSP_ERROR_DB_INVALID_USER = 10403,     /* 0x28A3 */
        MSP_ERROR_DB_INVALID_PWD = 10404,     /* 0x28A4 */
        MSP_ERROR_DB_CONNECT = 10405,     /* 0x28A5 */
        MSP_ERROR_DB_INVALID_SQL = 10406,     /* 0x28A6 */
        MSP_ERROR_DB_INVALID_APPID = 10407,    /* 0x28A7 */

        /* Error codes of Resource 10500(0x2904)*/
        MSP_ERROR_RES_GENERAL = 10500,     /* 0x2904 */
        MSP_ERROR_RES_LOAD = 10501,     /* 0x2905 */   /* Load resource */
        MSP_ERROR_RES_FREE = 10502,     /* 0x2906 */   /* Free resource */
        MSP_ERROR_RES_MISSING = 10503,     /* 0x2907 */   /* Resource File Missing */
        MSP_ERROR_RES_INVALID_NAME = 10504,     /* 0x2908 */   /* Invalid resource file name */
        MSP_ERROR_RES_INVALID_ID = 10505,     /* 0x2909 */   /* Invalid resource ID */
        MSP_ERROR_RES_INVALID_IMG = 10506,     /* 0x290A */   /* Invalid resource image pointer */
        MSP_ERROR_RES_WRITE = 10507,     /* 0x290B */   /* Write read-only resource */
        MSP_ERROR_RES_LEAK = 10508,     /* 0x290C */   /* Resource leak out */
        MSP_ERROR_RES_HEAD = 10509,     /* 0x290D */   /* Resource head currupt */
        MSP_ERROR_RES_DATA = 10510,     /* 0x290E */   /* Resource data currupt */
        MSP_ERROR_RES_SKIP = 10511,     /* 0x290F */   /* Resource file skipped */

        /* Error codes of TTS 10600(0x2968)*/
        MSP_ERROR_TTS_GENERAL = 10600,     /* 0x2968 */
        MSP_ERROR_TTS_TEXTEND = 10601,     /* 0x2969 */  /* Meet text end */
        MSP_ERROR_TTS_TEXT_EMPTY = 10602,     /* 0x296A */  /* no synth text */

        /* Error codes of Recognizer 10700(0x29CC) */
        MSP_ERROR_REC_GENERAL = 10700,     /* 0x29CC */
        MSP_ERROR_REC_INACTIVE = 10701,     /* 0x29CD */
        MSP_ERROR_REC_GRAMMAR_ERROR = 10702,     /* 0x29CE */
        MSP_ERROR_REC_NO_ACTIVE_GRAMMARS = 10703,     /* 0x29CF */
        MSP_ERROR_REC_DUPLICATE_GRAMMAR = 10704,     /* 0x29D0 */
        MSP_ERROR_REC_INVALID_MEDIA_TYPE = 10705,     /* 0x29D1 */
        MSP_ERROR_REC_INVALID_LANGUAGE = 10706,     /* 0x29D2 */
        MSP_ERROR_REC_URI_NOT_FOUND = 10707,     /* 0x29D3 */
        MSP_ERROR_REC_URI_TIMEOUT = 10708,     /* 0x29D4 */
        MSP_ERROR_REC_URI_FETCH_ERROR = 10709,     /* 0x29D5 */

        /* Error codes of Speech Detector 10800(0x2A30) */
        MSP_ERROR_EP_GENERAL = 10800,     /* 0x2A30 */
        MSP_ERROR_EP_NO_SESSION_NAME = 10801,     /* 0x2A31 */
        MSP_ERROR_EP_INACTIVE = 10802,     /* 0x2A32 */
        MSP_ERROR_EP_INITIALIZED = 10803,     /* 0x2A33 */

        /* Error codes of TUV */
        MSP_ERROR_TUV_GENERAL = 10900,     /* 0x2A94 */
        MSP_ERROR_TUV_GETHIDPARAM = 10901,     /* 0x2A95 */   /* Get Busin Param huanid*/
        MSP_ERROR_TUV_TOKEN = 10902,     /* 0x2A96 */   /* Get Token */
        MSP_ERROR_TUV_CFGFILE = 10903,     /* 0x2A97 */   /* Open cfg file */
        MSP_ERROR_TUV_RECV_CONTENT = 10904,     /* 0x2A98 */   /* received content is error */
        MSP_ERROR_TUV_VERFAIL = 10905,     /* 0x2A99 */   /* Verify failure */

        /* Error codes of IMTV */
        MSP_ERROR_IMTV_SUCCESS = 11000,     /* 0x2AF8 */   /* 成功 */
        MSP_ERROR_IMTV_NO_LICENSE = 11001,     /* 0x2AF9 */   /* 试用次数结束，用户需要付费 */
        MSP_ERROR_IMTV_SESSIONID_INVALID = 11002,     /* 0x2AFA */   /* SessionId失效，需要重新登录通行证 */
        MSP_ERROR_IMTV_SESSIONID_ERROR = 11003,     /* 0x2AFB */   /* SessionId为空，或者非法 */
        MSP_ERROR_IMTV_UNLOGIN = 11004,     /* 0x2AFC */   /* 未登录通行证 */
        MSP_ERROR_IMTV_SYSTEM_ERROR = 11005,     /* 0x2AFD */   /* 系统错误 */

        /* Error codes of HCR */
        MSP_ERROR_HCR_GENERAL = 11100,
        MSP_ERROR_HCR_RESOURCE_NOT_EXIST = 11101,

        /* Error codes of http 12000(0x2EE0) */
        MSP_ERROR_HTTP_BASE = 12000,    /* 0x2EE0 */

        /*Error codes of ISV */
        MSP_ERROR_ISV_NO_USER = 13000,    /* 32C8 */    /* the user doesn't exist */
    }

    #endregion

    #region TTS枚举常量  

    /// <summary>  
    /// vol参数的枚举常量  
    /// </summary>  
    public enum EnuVol
    {
        x_soft,
        soft,
        medium,
        loud,
        x_loud
    }

    /// <summary>  
    /// speed语速参数的枚举常量  
    /// </summary>  
    public enum EnuSpeed
    {
        x_slow,
        slow,
        medium,
        fast,
        x_fast
    }

    /// <summary>  
    /// speeker朗读者枚举常量  
    /// </summary>  
    public enum EnuSpeeker
    {
        小燕_青年女声_中英文_普通话 = 0,
        小宇_青年男声_中英文_普通话 = 1,
        凯瑟琳_青年女声_英语 = 2,
        亨利_青年男声_英语 = 3,
        玛丽_青年女声_英语 = 4,
        小研_青年女声_中英文_普通话 = 5,
        小琪_青年女声_中英文_普通话 = 6,
        小峰_青年男声_中英文_普通话 = 7,
        小梅_青年女声_中英文_粤语 = 8,
        小莉_青年女声_中英文_台普 = 9,
        小蓉_青年女声_汉语_四川话 = 10,
        小芸_青年女声_汉语_东北话 = 11,
        小坤_青年男声_汉语_河南话 = 12,
        小强_青年男声_汉语_湖南话 = 13,
        小莹_青年女声_汉语_陕西话 = 14,
        小新_童年男声_汉语_普通话 = 15,
        楠楠_童年女声_汉语_普通话 = 16,
        老孙_老年男声_汉语_普通话 = 17
    }

    /// <summary>
    /// 音频状态
    /// </summary>
    public enum SynthStatus
    {
        MSP_TTS_FLAG_STILL_HAVE_DATA = 1,//音频还没取完,还有后续音频
        MSP_TTS_FLAG_DATA_END = 2,//音频已经取完
        MSP_TTS_FLAG_CMD_CANCELED = 3//保留
    }

    /// <summary>
    /// 用来告知MSC音频发送是否完成
    /// </summary>
    public enum AudioStatus
    {
        MSP_AUDIO_SAMPLE_READY = -1,// 就绪
        MSP_AUDIO_SAMPLE_FIRST = 1,//  第一块音频
        MSP_AUDIO_SAMPLE_CONTINUE = 2,//   还有后继音频
        MSP_AUDIO_SAMPLE_LAST = 4,//   最后一块音频
    }

    /// <summary>
    /// 识别器返回的状态，提醒用户及时开始\停止获取识别结果。
    /// </summary>
    public enum ResultStatus
    {
        MSP_REC_STATUS_SUCCESS = 0,//  身份验证成功，有结果返回
        MSP_REC_STATUS_NO_MATCH = 1,// 身份验证结束，没有结果
        MSP_REC_STATUS_INCOMPLETE = 2,//   正在身份验证
        MSP_REC_STATUS_COMPLETE = 5,// 身份验证结束，有结果返回
    }

    /// <summary>
    /// 端点检测（End-point detected）器所处的状态
    /// </summary>
    public enum EpStatus
    {
        MSP_EP_LOOKING_FOR_READY = -1,// 就绪
        MSP_EP_LOOKING_FOR_SPEECH = 0,//   还没有检测到音频的前端点。
        MSP_EP_IN_SPEECH = 1,//    已经检测到了音频前端点，正在进行正常的音频处理。
        MSP_EP_AFTER_SPEECH = 3,// 检测到音频的后端点，后继的音频会被MSC忽略。
        MSP_EP_TIMEOUT = 4,//  超时。
        MSP_EP_ERROR = 5,//    出现错误。
        MSP_EP_MAX_SPEECH = 6,//   音频过大。
    }

    /// <summary>
    /// 识别器返回的状态，提醒用户及时开始\停止获取识别结果
    /// </summary>
    public enum RsltStatus
    {
        MSP_REC_STATUS_FOR_READY = -1,// 就绪
        MSP_REC_STATUS_SUCCESS = 0,//  识别成功，此时用户可以调用QISRGetResult来获取（部分）结果。
        MSP_REC_STATUS_NO_MATCH = 1,// 识别结束，没有识别结果。
        MSP_REC_STATUS_INCOMPLETE = 2,//   正在识别中。
        MSP_REC_STATUS_COMPLETE = 5,// 识别结束。
    }

    #endregion

    /// <summary>
    /// 科大讯飞 SDK 封装
    /// </summary>
    public static class IFYDll
    {
        public static string GetSpeekerCode(int speekerIndex)
        {
            var speekerCodeStr = "";
            switch (speekerIndex)
            {
                case 0: speekerCodeStr = "xiaoyan"; break;
                case 1: speekerCodeStr = "xiaoyu"; break;
                case 2: speekerCodeStr = "kaiselin"; break;
                case 3: speekerCodeStr = "hengli"; break;
                case 4: speekerCodeStr = "mali"; break;
                case 5: speekerCodeStr = "xiaoyan"; break;
                case 6: speekerCodeStr = "xiaoqi"; break;
                case 7: speekerCodeStr = "xiaofeng"; break;
                case 8: speekerCodeStr = "xiaomei"; break;
                case 9: speekerCodeStr = "xialli"; break;
                case 10: speekerCodeStr = "xiaorong"; break;
                case 11: speekerCodeStr = "xiaoyun"; break;
                case 12: speekerCodeStr = "xiaokun"; break;
                case 13: speekerCodeStr = "xiaoqiang"; break;
                case 14: speekerCodeStr = "xiaoying"; break;
                case 15: speekerCodeStr = "xiaoxin"; break;
                case 16: speekerCodeStr = "nanan"; break;
                case 17: speekerCodeStr = "laosun"; break;
            }
            return speekerCodeStr;

        }

        #region 引用 讯飞 SDK DLL

        private const string mscdll = "msc.dll";

        /// <summary>
        ///  动态引x86 或 x64的DLL
        /// </summary>
        static IFYDll()
        {
            var dllFile = Path.Combine(Environment.Is64BitProcess ? "x64" : "x86", mscdll);
            if (System.IO.Directory.GetCurrentDirectory() != null)
            {
                dllFile = Path.Combine(System.IO.Directory.GetCurrentDirectory(), dllFile);
            }
            IFYDll.LoadLibraryA(dllFile);
        }

        [DllImport("kernel32")]
        private static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.LPStr)] string fileName);

        #endregion

        #region 会员登录, 登录接口
        /*
         * msp_cmn.h 文件参考
         */

        /// <summary>
        ///  讯飞SDK 登录
        /// </summary>
        /// <param name="user">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="configs">登录参数:appid=XXXX</param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int MSPLogin(string user, string password, string configs);

        /// <summary>
        /// 用户数据上传。
        /// </summary>
        /// <param name="dataName"></param>
        /// <param name="data"></param>
        /// <param name="dataLen"></param>
        /// <param name="_params"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr MSPUploadData(string dataName, IntPtr data, uint dataLen, string _params, ref int errorCode);

        /// <summary>
        /// AIUI开放平台文本语义。
        /// </summary>
        /// <param name="dataName"></param>
        /// <param name="data"></param>
        /// <param name="dataLen"></param>
        /// <param name="_params"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr MSPSearch(string _params, string text, uint dataLen, ref int errorCode);

        /// <summary>
        /// 讯飞SDK 注销登录
        /// </summary>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int MSPLogout();

        /// <summary>
        /// 获取MSC的设置信息参数设置接口、离线引擎初始化接口。
        /// </summary>
        /// <param name="verName"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int MSPSetParam(string paramName, string paramValue);

        /// <summary>
        /// 获取MSC的设置信息
        /// </summary>
        /// <param name="verName"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int MSPGetParam(string paramName, string paramValue, uint valueLen);


        /// <summary>
        /// 获取MSC或本地引擎版本信息
        /// </summary>
        /// <param name="verName"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr MSPGetVersion(string verName, ref int errorCode);


        #endregion

        #region 语音 评测

        /**
        * 1.调用 MSPLogin(...)接口登入，可以只登入一次，但是必须保证在调用其他接口前先登入；
        * 2.调用 QISESessionBegin(...)开始一次语音听写；
        * 3.调用 QISETextPut(...) 分块写入音频数据
        * 4.循环调用 QISEAudioWrite(...) 接口返回听写结果
        * 5.循环调用 QISEGetResult(...) 接口返回听写结果
        * 6.调用 QISESessionEnd(...) 主动结束本次听写
        * 7.不再使用服务的时候 调用MSPLogout()登出。
        */

        /// <summary>
        /// 开始一次语评测。
        /// </summary>
        /// <param name="_params"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr QISESessionBegin(string _params, string userModelId, ref int errorCode);

        /// <summary>
        /// 写入待评测的文本。
        /// </summary>
        /// <param name="sessionID">由QISESessionBegin返回的句柄</param>
        /// <param name="textString"></param>
        /// <param name="textLen"></param>
        /// <param name="_params"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int QISETextPut(string sessionID, string textString, uint textLen, string _params);

        /// <summary>
        /// 写入本次评测的音频。
        /// </summary>
        /// <param name="sessionID">由QISESessionBegin返回的句柄</param>
        /// <param name="audioLen"></param>
        /// <param name="synthStatus"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int QISEAudioWrite(string sessionID, IntPtr waveData, ref uint waveLen, ref AudioStatus audioStatus, ref EpStatus epStatus, ref int Status);

        /// <summary>
        /// 获取评测结果。
        /// </summary>
        /// <param name="sessionID">由QISESessionBegin返回的句柄</param>
        /// <param name="rsltLen">评测结果长度，单位字节。</param>
        /// <param name="rsltStatus">评测结果的状态,其取值范围和含义请参考QISEAudioWrite的参数recogStatus</param>
        /// <param name="errorCode">函数调用成功返回MSP_SUCCESS，否则返回错误代码</param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr QISEGetResult(string sessionID, ref uint rsltLen, ref RsltStatus rsltStatus, ref int errorCode);

        /// <summary>
        /// 结束本次语音评测。
        /// </summary>
        /// <param name="sessionID">由QISESessionBegin返回的句柄</param>
        /// <param name="hints"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int QISESessionEnd(string sessionID, string hints);

        #endregion

        #region 语音 识别


        /**
        * 1.调用 MSPLogin(...)接口登入，可以只登入一次，但是必须保证在调用其他接口前先登入；
        * 2.调用 QISRSessionBegin(...)开始一次语音听写；
        * 3.调用 QISRAudioWrite(...) 分块写入音频数据
        * 4.循环调用 QISRGetResult(...) 接口返回听写结果
        * 5.调用 QISRSessionEnd(...) 主动结束本次听写
        * 6.不再使用服务的时候 调用MSPLogout()登出。
        * ---------------------------------------------------------------------------
        * QISRGetParam(...) 获取当次语音识别信息，如上行流量、下行流量等
        * QISRBuildGrammar(...) 构建语法，生成语法ID
        * QISRBuildGrammar(...) 更新本地语法词典
        */


        /// <summary>
        /// 开始一次语音识别。
        /// </summary>
        /// <param name="grammarList"></param>
        /// <param name="_params"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr QISRSessionBegin(string grammarList, string _params, ref int errorCode);

        /// <summary>
        /// 写入本次识别的音频。
        /// </summary>
        /// <param name="sessionID">由QISESessionBegin返回的句柄</param>
        /// <param name="waveData"></param>
        /// <param name="waveLen"></param>
        /// <param name="audioStatus"></param>
        /// <param name="epStatus"></param>
        /// <param name="recogStatus"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int QISRAudioWrite(string sessionID, IntPtr waveData, uint waveLen, AudioStatus audioStatus, ref EpStatus epStatus, ref RsltStatus recogStatus);

        /// <summary>
        /// 获取识别结果。
        /// </summary>
        /// <param name="sessionID">由QISESessionBegin返回的句柄</param>
        /// <param name="rsltStatus"></param>
        /// <param name="waitTime"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr QISRGetResult(string sessionID, ref RsltStatus rsltStatus, int waitTime, ref int errorCode);

        /// <summary>
        /// 结束本次语音识别。
        /// </summary>
        /// <param name="sessionID">由QISESessionBegin返回的句柄</param>
        /// <param name="hints"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int QISRSessionEnd(string sessionID, string hints);

        /// <summary>
        /// 获取当次语音识别信息，如上行流量、下行流量等。
        /// </summary>
        /// <param name="sessionID">由QISESessionBegin返回的句柄</param>
        /// <param name="paramName"></param>
        /// <param name="paramValue"></param>
        /// <param name="valueLen"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int QISRGetParam(string sessionID, string paramName, ref string paramValue, ref uint valueLen);

        /// <summary>
        /// 构建语法，生成语法ID。
        /// </summary>
        /// <param name="grammarType"></param>
        /// <param name="grammarContent"></param>
        /// <param name="grammarLength"></param>
        /// <param name="_params"></param>
        /// <param name="callback"></param>
        /// <param name="userData"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int QISRBuildGrammar(string grammarType, string grammarContent, uint grammarLength, string _params, IntPtr callback, ref IntPtr userData);

        /// <summary>
        /// 更新本地语法词典。
        /// </summary>
        /// <param name="grammarType"></param>
        /// <param name="grammarContent"></param>
        /// <param name="grammarLength"></param>
        /// <param name="_params"></param>
        /// <param name="callback"></param>
        /// <param name="userData"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int QISRUpdateLexicon(string lexiconName, string lexiconContent, uint lexiconLength, string _params, IntPtr callback, ref IntPtr userData);

        #endregion

        #region 语音 身份验证
        /**
         * qmfv.h 文件参考
         * 1.调用 MSPLogin(...)接口登入，可以只登入一次，但是必须保证在调用其他接口前先登入；
         * 2.调用 QMFVSessionBegin(...)开始一次语音听写；
         * 3.调用 QMFVDataWrite(...) 写入本次身份验证的数据
         * 4.循环调用 QMFVGetResult(...) 接口获取身份验证结果
         * 5.循环调用 QMFVGetParam(...) 接口获取当次身份验证信息，如上行流量、下行流量等
         * 6.调用 QMFVSessionEnd(...) 主动结束本次身份验证
         * 7.不再使用服务的时候 调用MSPLogout()登出。
         */


        /// <summary>
        /// 开始一次身份验证。
        /// </summary>
        /// <param name="_params"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr QMFVSessionBegin(string _params, ref int errorCode);

        /// <summary>
        /// 写入本次身份验证的数
        /// </summary>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int QMFVDataWrite(string sessionID, string _params, IntPtr data, uint dataLen, ref ResultStatus resultStatus);

        /// <summary>
        /// 获取身份验证结果
        /// </summary>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr QMFVGetResult(string sessionID, ref uint resultLen, ref ResultStatus resultStatus, ref int errorCode);

        /// <summary>
        /// 获取当次身份验证信息，如上行流量、下行流量等
        /// </summary>
        /// <param name="sessionID">由QISESessionBegin返回的句柄</param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int QMFVGetParam(string sessionID, string parmsName, ref string paramValue, ref uint valueLen);

        /// <summary>
        /// 结束本次身份验证。
        /// </summary>
        /// <param name="sessionID">由QISESessionBegin返回的句柄</param>
        /// <param name="hints"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int QMFVSessionEnd(string sessionID, string hints);

        #endregion

        #region 语音 合成

        /**
        *  qtts.h 文件参考
        * 1.调用 MSPLogin(...)接口登入，可以只登入一次，但是必须保证在调用其他接口前先登入；
        * 2.调用 QTTSSessionBegin(...)开始一次音频合成；
        * 3.调用 QTTSTextPut(...) 分块写入文本数据
        * 4.循环调用 QTTSAudioGet(...) 接口返回合成音频结果
        * 5.调用 QTTSSessionEnd(...) 主动结束本次音频合成
        * 6.不再使用服务的时候 调用MSPLogout()登出。
        */

        /// <summary>
        /// 开始一次语音合成，分配语音合成资源。
        /// </summary>
        /// <param name="_params"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr QTTSSessionBegin(string _params, ref int errorCode);

        /// <summary>
        /// 写入要合成的文本
        /// </summary>
        /// <param name="sessionID">由QISESessionBegin返回的句柄</param>
        /// <param name="textString"></param>
        /// <param name="textLen"></param>
        /// <param name="_params"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int QTTSTextPut(string sessionID, string textString, uint textLen, string _params);

        /// <summary>
        /// 获取合成音频
        /// </summary>
        /// <param name="sessionID">由QISESessionBegin返回的句柄</param>
        /// <param name="audioLen"></param>
        /// <param name="synthStatus"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr QTTSAudioGet(string sessionID, ref uint audioLen, ref SynthStatus synthStatus, ref int errorCode);

        /// <summary>
        /// 结束本次语音合成
        /// </summary>
        /// <param name="sessionID">由QISESessionBegin返回的句柄</param>
        /// <param name="hints"></param>
        /// <returns></returns>
        [DllImport("msc.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int QTTSSessionEnd(string sessionID, string hints);

        #endregion

    }
}
