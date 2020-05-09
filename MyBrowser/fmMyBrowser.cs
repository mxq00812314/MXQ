using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrowser
{
    public partial class fmMyBrowser : Form
    {
        public fmMyBrowser()
        {
            InitializeComponent();
            wb.ScriptErrorsSuppressed = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setIE_Version();
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //HtmlElement txtName = wb.Document.GetElementById("user_email");
            //HtmlElement txtPwd = wb.Document.GetElementById("user_password");
            //txtName.SetAttribute("value", "1184678282@qq.com");
            //txtPwd.SetAttribute("value", "2601752");

            //HtmlElement form = wb.Document.GetElementById("new_user");
            //form.InvokeMember("submit");
        }

        public void setIE_Version()
        {
            String appname = Process.GetCurrentProcess().ProcessName + ".exe";
            RegistryKey RK8 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", RegistryKeyPermissionCheck.ReadWriteSubTree);
            var value = 11000;// IE11:11000 IE10:10000  IE9:9000  IE8:8000 IE7:7000 
            if (RK8 != null)
            {
                try
                {
                    RK8.SetValue(appname, value, RegistryValueKind.DWord);
                    RK8.Close();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);  
                }
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            wb.GoBack();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            wb.GoHome();
        }

        private void btnGoForward_Click(object sender, EventArgs e)
        {
            wb.GoForward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            wb.Refresh();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrl.Text))
            {
                wb.Navigate(txtUrl.Text);
            }
        }

        private void wb_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if ((e.CurrentProgress > 0) && (e.MaximumProgress > 0))
            {
                pgsb.Maximum = Convert.ToInt32(e.MaximumProgress);
                pgsb.Step = Convert.ToInt32(e.CurrentProgress);
                pgsb.PerformStep();
            }
            else if (wb.ReadyState == WebBrowserReadyState.Complete)
            {
                pgsb.Value = 0;
            }
        }

        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                wb.Navigate(txtUrl.Text);
            }
        }
    }
}
