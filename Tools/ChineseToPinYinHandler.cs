using Microsoft.International.Converters.PinYinConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Tools
{
    public class ChineseToPinYinHandler
    {
        /// <summary>
        ///     构造函数
        /// </summary>
        public ChineseToPinYinHandler()
        { }

        /// <summary>
        ///     字符串的简拼
        /// </summary>
        /// <param name="str_InputText"></param>
        /// <returns></returns>
        public static string P_GetSimplePinYin(string str_InputText)
        {
            string str_Result = "";
            if (!string.IsNullOrEmpty(str_InputText) && !string.IsNullOrEmpty(str_InputText.Trim()))
            {
                foreach (char c in str_InputText.Trim())
                {
                    ChineseChar chineseChar = new ChineseChar(c);
                    str_Result += chineseChar.Pinyins[0].Substring(0, 1);
                }
            }
            return str_Result;
        }

        /// <summary>
        ///     字符串的全拼
        /// </summary>
        /// <param name="str_InputText"></param>
        /// <returns></returns>
        public static string P_GetAllPinYin(string str_InputText)
        {
            string str_Result = "";
            if (!string.IsNullOrEmpty(str_InputText) && !string.IsNullOrEmpty(str_InputText.Trim()))
            {
                foreach (char c in str_InputText.Trim())
                {
                    try
                    {
                        if ((c > 64 && c < 91) || (c > 96 && c < 122) || (c > 47 && c < 58))
                        {
                            str_Result += c;
                        }
                        else
                        {
                           ChineseChar chineseChar = new ChineseChar(c);
                            str_Result += chineseChar.Pinyins[0].Substring(0, chineseChar.Pinyins[0].Length - 1);
                        }
                    }
                    catch
                    {
                        str_Result += c;
                    }
                }
            }
            return str_Result;
        }

        /// <summary>
        ///     获取单个汉字的所有的多音字的拼音的list
        /// </summary>
        /// <param name="str_InputText"></param>
        /// <returns></returns>
        public static List<string> P_GetSingleStringAllPinYin(string str_InputText)
        {
            List<string> list_Result = new List<string>();
            if (!string.IsNullOrEmpty(str_InputText) && !string.IsNullOrEmpty(str_InputText.Trim()) && str_InputText.Trim().Length.Equals(1))
            {
                foreach (char c in str_InputText.Trim())
                {
                    ChineseChar chineseChar = new ChineseChar(c);
                    for (int i = 0; i < chineseChar.Pinyins.Count; i++)
                    {
                        if (string.IsNullOrEmpty(chineseChar.Pinyins[i]))
                        {
                            break;
                        }
                        list_Result.Add(chineseChar.Pinyins[i].Substring(0, chineseChar.Pinyins[i].Length - 1));
                    }
                }
            }
            return list_Result;
        }

        /// <summary>
        ///     获取单个汉字的所有的多音字的拼音和音调的list
        /// </summary>
        /// <param name="str_InputText"></param>
        /// <returns></returns>
        public static List<string> P_GetSingleStringAllPinYinAndTone(string str_InputText)
        {
            List<string> list_Result = new List<string>();
            if (!string.IsNullOrEmpty(str_InputText) && !string.IsNullOrEmpty(str_InputText.Trim()) && str_InputText.Trim().Length.Equals(1))
            {
                foreach (char c in str_InputText.Trim())
                {
                    ChineseChar chineseChar = new ChineseChar(c);
                    for (int i = 0; i < chineseChar.Pinyins.Count; i++)
                    {
                        if (string.IsNullOrEmpty(chineseChar.Pinyins[i]))
                        {
                            break;
                        }
                        list_Result.Add(chineseChar.Pinyins[i]);
                    }
                }
            }
            return list_Result;
        }
    }
}
