using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FileWatcher
{
    public partial class Form1 : Form
    {
        FileSystemWatcher watcher = new FileSystemWatcher();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnWatchStart.Enabled = true;
            btnWatchStop.Enabled = false;
            WatchProductInfoInit();
        }

        private void WatchProductInfoInit()
        {
            watcher.Path = @"D:\Temp_Files";
            /*监视LastAcceSS和LastWrite时间的更改以及文件或目录的重命名*/
            watcher.NotifyFilter =  NotifyFilters.LastWrite;
            //只监视文本文件
            watcher.Filter = "*.*";
            //添加事件句柄
            //当由FileSystemWatcher所指定的路径中的文件或目录的
            //大小、系统属性、最后写时间、最后访问时间或安全权限
            //发生更改时，更改事件就会发生
            watcher.Changed += new FileSystemEventHandler(OnChanged);
        }

        private void btnWatchStart_Click(object sender, EventArgs e)
        {
            btnWatchStart.Enabled = false;
            btnWatchStop.Enabled = true;
            //开始监视
            watcher.EnableRaisingEvents = true;
        }
        //定义事件处理程序
        public void OnChanged(object sender, FileSystemEventArgs e)
        {
            //指定当文件被更改、创建或删除时要做的事
            OutputFileChangeLog($"{e.ChangeType}\t{e.FullPath}");
        }
        public void OnRenamed(object sender, RenamedEventArgs e)
        {
            //指定当文件被重命名时发生的动作
            OutputFileChangeLog($"重命名\t{e.OldFullPath} ==> {e.FullPath}");
        }
        private delegate void OutputFileChangeLogDelegate(string logMsg);
        public void OutputFileChangeLog(string logMsg)
        {
            if (this.textBox1.InvokeRequired) //判断是否跨线程
            {
                this.textBox1.Invoke(new OutputFileChangeLogDelegate(OutputFileChangeLog), new object[] { logMsg });  //使用委托将方法封送到UI主线程处理
            }
            else
            {
                textBox1.AppendText($"{DateTime.Now.ToString("HH:mm:ss.fff")}\t{logMsg}\r\n");
            }
        }

        private void btnWatchStop_Click(object sender, EventArgs e)
        {
            btnWatchStart.Enabled = true;
            btnWatchStop.Enabled = false;
            watcher.EnableRaisingEvents = false;
        }
    }
}
