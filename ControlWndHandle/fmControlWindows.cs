using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using EP.Systems;

namespace ControlWndHandle
{
    public partial class fmControlWindows : Form
    {
        IntPtr testhWnd = new IntPtr(0);
        bool isMouseUp = false;
        POINTAPI pi = new POINTAPI();


        public fmControlWindows()
        {
            InitializeComponent();
        }


        private void btnRunSoftware_Click(object sender, EventArgs e)
        {
            testhWnd = new IntPtr(0);
            Thread.Sleep(500);
            testhWnd = User32Utils.FindWindow(txthWindClassName.Text, null);
            if (testhWnd == IntPtr.Zero)
            {
                testhWnd = User32Utils.FindWindow(null, txthWindClassName.Text);
            }
            ShowWinInfo(testhWnd);
        }

        private void btnnMoveUp_Click(object sender, EventArgs e)
        {
            if (testhWnd != IntPtr.Zero)
            {
                RECT rect = new RECT();
                User32Utils.GetWindowRect(testhWnd, out rect);
                int width = rect.Right - rect.Left; /* 高 */
                int height = rect.Bottom - rect.Top; /* 宽 */
                RECT rectNew = new RECT(rect.Left, rect.Top - 10, rect.Right, rect.Bottom);
                User32Utils.MoveWindow(testhWnd, rectNew.Left, rectNew.Top, rect.Width, rect.Height, true);
            }
        }

        private void btnnMoveDown_Click(object sender, EventArgs e)
        {
            if (testhWnd != IntPtr.Zero)
            {
                RECT rect = new RECT();
                User32Utils.GetWindowRect(testhWnd, out rect);
                int width = rect.Right - rect.Left; /* 高 */
                int height = rect.Bottom - rect.Top; /* 宽 */
                RECT rectNew = new RECT(rect.Left, rect.Top + 10, rect.Right, rect.Bottom);
                User32Utils.MoveWindow(testhWnd, rectNew.Left, rectNew.Top, rect.Width, rect.Height, true);
            }

        }

        private void btnnMoveLeft_Click(object sender, EventArgs e)
        {
            if (testhWnd != IntPtr.Zero)
            {
                RECT rect = new RECT();
                User32Utils.GetWindowRect(testhWnd, out rect);
                int width = rect.Right - rect.Left; /* 高 */
                int height = rect.Bottom - rect.Top; /* 宽 */
                RECT rectNew = new RECT(rect.Left - 10, rect.Top, rect.Right, rect.Bottom);
                User32Utils.MoveWindow(testhWnd, rectNew.Left, rectNew.Top, rect.Width, rect.Height, true);
            }
        }

        private void btnnMoveRight_Click(object sender, EventArgs e)
        {
            if (testhWnd != IntPtr.Zero)
            {
                RECT rect = new RECT();
                User32Utils.GetWindowRect(testhWnd, out rect);
                int width = rect.Right - rect.Left; /* 高 */
                int height = rect.Bottom - rect.Top; /* 宽 */
                RECT rectNew = new RECT(rect.Left + 10, rect.Top, rect.Right, rect.Bottom);
                User32Utils.MoveWindow(testhWnd, rectNew.Left, rectNew.Top, rect.Width, rect.Height, true);
            }
        }


        private void btnFindWindow_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseUp = true;//鼠标左右键被按下
            Cursor = Cursors.Cross; //改变鼠标样式为十字架
        }

        private void btnFindWindow_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseUp = false;//鼠标左右键被弹起
            Cursor = Cursors.Default;//改变鼠标样式为默认
        }

        private void btnFindWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseUp)//左键是否被按下
            {
                User32Utils.GetCursorPos(ref pi); //获取鼠标坐标值
                lblLocation.Text = "坐标：X=" + pi.X + "  |  Y=" + pi.Y; //label1显示鼠标坐标值的x值与y值
                testhWnd = User32Utils.WindowFromPoint(pi);
                ShowWinInfo(testhWnd);
            }
        }

        private void ShowWinInfo(IntPtr hWnd)
        {
            StringBuilder lpString = new StringBuilder(256);

            txtMainWindowHandle.Text = testhWnd.ToString();

            User32Utils.GetWindowText(testhWnd, lpString, 256);
            txtTitle.Text = lpString.ToString();

            User32Utils.GetClassName(testhWnd, lpString, 256);
            txtClassName.Text = lpString.ToString();
        }

        private void btnTopMost_Click(object sender, EventArgs e)
        {
            if (testhWnd != IntPtr.Zero)
            {
                User32Utils.SetWindowPos(testhWnd, (int)hWndInsertAfterType.HWND_TOPMOST, 0, 0, 0, 0, 1 | 2);

            }
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            if (testhWnd != IntPtr.Zero)
            {
                User32Utils.SetWindowPos(testhWnd, (int)hWndInsertAfterType.HWND_BOTTOM, 0, 0, 0, 0, 1 | 2);
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (testhWnd != IntPtr.Zero)
            {
                User32Utils.ShowWindow(testhWnd, 3);//隐藏本dos窗体, 0: 后台执行;1:正常启动;2:最小化到任务栏;3:最大化
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (testhWnd != IntPtr.Zero)
            {
                User32Utils.ShowWindow(testhWnd, 2);//隐藏本dos窗体, 0: 后台执行;1:正常启动;2:最小化到任务栏;3:最大化
            }
        }

        private void fmControlWindows_Load(object sender, EventArgs e)
        {

        }
    }
}
