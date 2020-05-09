using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeSpanTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            txtOutPut.Text = "";
            var outStr = xSwitch1.Checked
                ? $"{FormaterTimeSpanStr((double)numericUpDown1.Value)}"
                : $"{FormaterTimeSpanStr((double)numericUpDown1.Value / 1000)}";


            var timeSpan = xSwitch1.Checked
                ? ShowTimeSpanStr((double)numericUpDown1.Value)
                : ShowTimeSpanStr((double)numericUpDown1.Value / 1000);

            txtOutPut.AppendText($"{outStr} \r\n");
            txtOutPut.AppendText($"\r\n");
            txtOutPut.AppendText($"天：\t{timeSpan.TotalDays} \r\n\r\n");
            txtOutPut.AppendText($"时：\t{timeSpan.TotalHours} \r\n\r\n");
            txtOutPut.AppendText($"分：\t{timeSpan.TotalMinutes} \r\n\r\n");
            txtOutPut.AppendText($"秒：\t{timeSpan.TotalSeconds} \r\n\r\n");
            txtOutPut.AppendText($"毫秒：\t{timeSpan.TotalMilliseconds} \r\n\r\n");
        }

        /// <summary>
        /// 计算时间差 返回时间差格式：0时0分0秒
        /// </summary>
        /// <param name="beginTimer">开始时间</param>
        /// <param name="dateTime">结束时间</param>
        /// <returns>返回时间差格式：0时0分0秒</returns>
        private TimeSpan DateDiff(DateTime beginTimer, DateTime dateTime)
        {
            string dateDiffStr = $"0时0分钟0秒";
            TimeSpan ts1 = new TimeSpan(beginTimer.Ticks);
            TimeSpan ts2 = new TimeSpan(dateTime.Ticks);
            TimeSpan ts = ts1.Subtract(ts2).Duration();
            return ts;
        }

        /// <summary>
        /// 毫秒数格式化为时间戳字符"0时0分0秒"
        /// </summary>
        /// <returns></returns>
        private TimeSpan ShowTimeSpanStr(double _taskRuntimeLength)
        {
            var currentTaskBeginTime = DateTime.Now;
            currentTaskBeginTime = currentTaskBeginTime.AddSeconds(-1 * _taskRuntimeLength);
            TimeSpan ts = DateDiff(currentTaskBeginTime, DateTime.Now);
            return ts;
        }

        /// <summary>
        /// 毫秒数格式化为时间戳字符"0时0分0秒"
        /// </summary>
        /// <returns></returns>
        private string FormaterTimeSpanStr(double _taskRuntimeLength)
        {
            var currentTaskBeginTime = DateTime.Now;
            currentTaskBeginTime = currentTaskBeginTime.AddSeconds(-1 * _taskRuntimeLength);
            TimeSpan ts = DateDiff(currentTaskBeginTime, DateTime.Now);
            string formaterTimeSpanStr = $"{(ts.Days > 0 ? $"{ts.Days}天" : "")}" + $"{ts.Hours}时{ts.Minutes}分{ts.Seconds}秒";
            return formaterTimeSpanStr;
        }
    }
}
