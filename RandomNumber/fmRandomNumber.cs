using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumber
{
    public partial class fmRandomNumber : Form
    {
        private IList<string> sourcelist = new List<string>();
        private IList<string> rstList = new List<string>();
        private bool isrun = false;
        public fmRandomNumber()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(runMethod);
            t.Name = "test";
            t.Start();
        }


        private void runMethod()
        {
            sourcelist = txtSource.Lines.ToList<string>();
            if (btnRandom.Text == "开始")
            {
                isrun = true;
                BeginInvoke((MethodInvoker)delegate () { btnRandom.Text = "暂停"; });
            }
            else
            {
                isrun = false;
                BeginInvoke((MethodInvoker)delegate () { btnRandom.Text = "开始"; });
            }
            Random r = new Random();
            while (isrun)
            {
                int ran_int = r.Next(0, sourcelist.Count - 1);
                BeginInvoke((MethodInvoker)delegate () { lblRandomIngNumber.Text = sourcelist[ran_int]; });
                Thread.Sleep(50);
            }

            if (!rstList.Contains(lblRandomIngNumber.Text))
            {
                BeginInvoke((MethodInvoker)delegate ()
                {
                    rstList.Add(lblRandomIngNumber.Text);
                    listBox2.DataSource = rstList;
                });
            }

        }

        private void btnRandomClear_Click(object sender, EventArgs e)
        {
            rstList = new List<string>();
            listBox2.DataSource = new List<string>();
        }
    }
}
