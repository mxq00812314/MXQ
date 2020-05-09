namespace Test
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ntyMsg = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNtyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tMainTimer = new System.Windows.Forms.Timer(this.components);
            this.btnRunCmd = new System.Windows.Forms.Button();
            this.txtCmdStr = new System.Windows.Forms.TextBox();
            this.gbNpm = new System.Windows.Forms.GroupBox();
            this.lblSftpState = new System.Windows.Forms.Label();
            this.btnOpenSFTP = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOpenSnipping = new System.Windows.Forms.Button();
            this.btnOpenMsTsc = new System.Windows.Forms.Button();
            this.btnOpenMsPaint = new System.Windows.Forms.Button();
            this.btnOpenNotepad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtWeekWorkLog = new System.Windows.Forms.TextBox();
            this.gpWeekWorkLog = new System.Windows.Forms.GroupBox();
            this.btnWorkLogOpen = new System.Windows.Forms.Button();
            this.btnWorkLogSave = new System.Windows.Forms.Button();
            this.txtWorkLog = new System.Windows.Forms.TextBox();
            this.lblRest = new System.Windows.Forms.Label();
            this.lblGF = new System.Windows.Forms.Label();
            this.lblMarryDate = new System.Windows.Forms.Label();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsddbTool = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiTMC3API测试 = new System.Windows.Forms.ToolStripMenuItem();
            this.更新插件数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newKey验证ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHotelOneKeyRefund = new System.Windows.Forms.ToolStripMenuItem();
            this.广告一键支付ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.myBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myWebClicentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySqlBangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStringHelperBox = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRandomStr = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFmVoice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.换肤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.目录工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsNtyMenu.SuspendLayout();
            this.gbNpm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gpWeekWorkLog.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ntyMsg
            // 
            this.ntyMsg.ContextMenuStrip = this.cmsNtyMenu;
            resources.ApplyResources(this.ntyMsg, "ntyMsg");
            // 
            // cmsNtyMenu
            // 
            this.cmsNtyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.tsmExit});
            this.cmsNtyMenu.Name = "cmsNtyMenu";
            resources.ApplyResources(this.cmsNtyMenu, "cmsNtyMenu");
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            resources.ApplyResources(this.关于ToolStripMenuItem, "关于ToolStripMenuItem");
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            resources.ApplyResources(this.tsmExit, "tsmExit");
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tMainTimer
            // 
            this.tMainTimer.Interval = 1000;
            this.tMainTimer.Tick += new System.EventHandler(this.tMainTimer_Tick);
            // 
            // btnRunCmd
            // 
            resources.ApplyResources(this.btnRunCmd, "btnRunCmd");
            this.btnRunCmd.Name = "btnRunCmd";
            this.btnRunCmd.UseVisualStyleBackColor = true;
            this.btnRunCmd.Click += new System.EventHandler(this.btnRunCmd_Click_1);
            // 
            // txtCmdStr
            // 
            resources.ApplyResources(this.txtCmdStr, "txtCmdStr");
            this.txtCmdStr.Name = "txtCmdStr";
            // 
            // gbNpm
            // 
            resources.ApplyResources(this.gbNpm, "gbNpm");
            this.gbNpm.Controls.Add(this.lblSftpState);
            this.gbNpm.Controls.Add(this.btnOpenSFTP);
            this.gbNpm.Controls.Add(this.button3);
            this.gbNpm.Controls.Add(this.pictureBox1);
            this.gbNpm.Controls.Add(this.pictureBox2);
            this.gbNpm.Controls.Add(this.button2);
            this.gbNpm.Controls.Add(this.button1);
            this.gbNpm.Controls.Add(this.textBox2);
            this.gbNpm.Controls.Add(this.textBox1);
            this.gbNpm.Controls.Add(this.btnOpenSnipping);
            this.gbNpm.Controls.Add(this.btnOpenMsTsc);
            this.gbNpm.Controls.Add(this.btnOpenMsPaint);
            this.gbNpm.Controls.Add(this.btnOpenNotepad);
            this.gbNpm.Name = "gbNpm";
            this.gbNpm.TabStop = false;
            // 
            // lblSftpState
            // 
            resources.ApplyResources(this.lblSftpState, "lblSftpState");
            this.lblSftpState.Name = "lblSftpState";
            // 
            // btnOpenSFTP
            // 
            resources.ApplyResources(this.btnOpenSFTP, "btnOpenSFTP");
            this.btnOpenSFTP.Name = "btnOpenSFTP";
            this.btnOpenSFTP.UseVisualStyleBackColor = true;
            this.btnOpenSFTP.Click += new System.EventHandler(this.btnOpenSFTP_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Test.Properties.Resources.sider;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // btnOpenSnipping
            // 
            resources.ApplyResources(this.btnOpenSnipping, "btnOpenSnipping");
            this.btnOpenSnipping.Name = "btnOpenSnipping";
            this.btnOpenSnipping.UseVisualStyleBackColor = true;
            this.btnOpenSnipping.Click += new System.EventHandler(this.btnOpenSnipping_Click);
            // 
            // btnOpenMsTsc
            // 
            resources.ApplyResources(this.btnOpenMsTsc, "btnOpenMsTsc");
            this.btnOpenMsTsc.Name = "btnOpenMsTsc";
            this.btnOpenMsTsc.UseVisualStyleBackColor = true;
            this.btnOpenMsTsc.Click += new System.EventHandler(this.btnOpenMsTsc_Click);
            // 
            // btnOpenMsPaint
            // 
            resources.ApplyResources(this.btnOpenMsPaint, "btnOpenMsPaint");
            this.btnOpenMsPaint.Name = "btnOpenMsPaint";
            this.btnOpenMsPaint.UseVisualStyleBackColor = true;
            this.btnOpenMsPaint.Click += new System.EventHandler(this.btnOpenMsPaint_Click);
            // 
            // btnOpenNotepad
            // 
            resources.ApplyResources(this.btnOpenNotepad, "btnOpenNotepad");
            this.btnOpenNotepad.Name = "btnOpenNotepad";
            this.btnOpenNotepad.UseVisualStyleBackColor = true;
            this.btnOpenNotepad.Click += new System.EventHandler(this.btnOpenNotepad_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gpWeekWorkLog);
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtWeekWorkLog);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // txtWeekWorkLog
            // 
            resources.ApplyResources(this.txtWeekWorkLog, "txtWeekWorkLog");
            this.txtWeekWorkLog.Name = "txtWeekWorkLog";
            this.txtWeekWorkLog.ReadOnly = true;
            // 
            // gpWeekWorkLog
            // 
            this.gpWeekWorkLog.Controls.Add(this.btnWorkLogOpen);
            this.gpWeekWorkLog.Controls.Add(this.btnWorkLogSave);
            this.gpWeekWorkLog.Controls.Add(this.txtWorkLog);
            resources.ApplyResources(this.gpWeekWorkLog, "gpWeekWorkLog");
            this.gpWeekWorkLog.Name = "gpWeekWorkLog";
            this.gpWeekWorkLog.TabStop = false;
            // 
            // btnWorkLogOpen
            // 
            resources.ApplyResources(this.btnWorkLogOpen, "btnWorkLogOpen");
            this.btnWorkLogOpen.Name = "btnWorkLogOpen";
            this.btnWorkLogOpen.UseVisualStyleBackColor = true;
            this.btnWorkLogOpen.Click += new System.EventHandler(this.btnWorkLogOpen_Click);
            // 
            // btnWorkLogSave
            // 
            resources.ApplyResources(this.btnWorkLogSave, "btnWorkLogSave");
            this.btnWorkLogSave.Name = "btnWorkLogSave";
            this.btnWorkLogSave.UseVisualStyleBackColor = true;
            this.btnWorkLogSave.Click += new System.EventHandler(this.btnWorkLogSave_Click);
            // 
            // txtWorkLog
            // 
            resources.ApplyResources(this.txtWorkLog, "txtWorkLog");
            this.txtWorkLog.Name = "txtWorkLog";
            // 
            // lblRest
            // 
            resources.ApplyResources(this.lblRest, "lblRest");
            this.lblRest.BackColor = System.Drawing.Color.Transparent;
            this.lblRest.Name = "lblRest";
            // 
            // lblGF
            // 
            resources.ApplyResources(this.lblGF, "lblGF");
            this.lblGF.BackColor = System.Drawing.Color.Transparent;
            this.lblGF.Name = "lblGF";
            // 
            // lblMarryDate
            // 
            resources.ApplyResources(this.lblMarryDate, "lblMarryDate");
            this.lblMarryDate.BackColor = System.Drawing.Color.Transparent;
            this.lblMarryDate.Name = "lblMarryDate";
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbTool,
            this.toolStripDropDownButton1,
            this.toolStripLabel1});
            resources.ApplyResources(this.tsMain, "tsMain");
            this.tsMain.Name = "tsMain";
            // 
            // tsddbTool
            // 
            this.tsddbTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTMC3API测试,
            this.更新插件数据ToolStripMenuItem,
            this.newKey验证ToolStripMenuItem,
            this.tsmiHotelOneKeyRefund,
            this.广告一键支付ToolStripMenuItem});
            resources.ApplyResources(this.tsddbTool, "tsddbTool");
            this.tsddbTool.Name = "tsddbTool";
            // 
            // tsmiTMC3API测试
            // 
            this.tsmiTMC3API测试.Name = "tsmiTMC3API测试";
            resources.ApplyResources(this.tsmiTMC3API测试, "tsmiTMC3API测试");

            // 
            // 更新插件数据ToolStripMenuItem
            // 
            this.更新插件数据ToolStripMenuItem.Name = "更新插件数据ToolStripMenuItem";
            resources.ApplyResources(this.更新插件数据ToolStripMenuItem, "更新插件数据ToolStripMenuItem");

            // 
            // newKey验证ToolStripMenuItem
            // 
            this.newKey验证ToolStripMenuItem.Name = "newKey验证ToolStripMenuItem";
            resources.ApplyResources(this.newKey验证ToolStripMenuItem, "newKey验证ToolStripMenuItem");

            // 
            // tsmiHotelOneKeyRefund
            // 
            this.tsmiHotelOneKeyRefund.Name = "tsmiHotelOneKeyRefund";
            resources.ApplyResources(this.tsmiHotelOneKeyRefund, "tsmiHotelOneKeyRefund");

            // 广告一键支付ToolStripMenuItem
            // 
            this.广告一键支付ToolStripMenuItem.Name = "广告一键支付ToolStripMenuItem";
            resources.ApplyResources(this.广告一键支付ToolStripMenuItem, "广告一键支付ToolStripMenuItem");

            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myBrowserToolStripMenuItem,
            this.myWebClicentToolStripMenuItem,
            this.mySqlBangToolStripMenuItem,
            this.tsmiStringHelperBox,
            this.tsmiRandomStr,
            this.tsmiFmVoice,
            this.目录工具ToolStripMenuItem});
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            // 
            // myBrowserToolStripMenuItem
            // 
            this.myBrowserToolStripMenuItem.Name = "myBrowserToolStripMenuItem";
            resources.ApplyResources(this.myBrowserToolStripMenuItem, "myBrowserToolStripMenuItem");

            // 
            // myWebClicentToolStripMenuItem
            // 
            this.myWebClicentToolStripMenuItem.Name = "myWebClicentToolStripMenuItem";
            resources.ApplyResources(this.myWebClicentToolStripMenuItem, "myWebClicentToolStripMenuItem");

            // 
            // mySqlBangToolStripMenuItem
            // 
            this.mySqlBangToolStripMenuItem.Name = "mySqlBangToolStripMenuItem";
            resources.ApplyResources(this.mySqlBangToolStripMenuItem, "mySqlBangToolStripMenuItem");

            // 
            // tsmiStringHelperBox
            // 
            this.tsmiStringHelperBox.Name = "tsmiStringHelperBox";
            resources.ApplyResources(this.tsmiStringHelperBox, "tsmiStringHelperBox");

            // 
            // tsmiRandomStr
            // 
            this.tsmiRandomStr.Name = "tsmiRandomStr";
            resources.ApplyResources(this.tsmiRandomStr, "tsmiRandomStr");

            // 
            // tsmiFmVoice
            // 
            this.tsmiFmVoice.Name = "tsmiFmVoice";
            resources.ApplyResources(this.tsmiFmVoice, "tsmiFmVoice");

            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.换肤ToolStripMenuItem});
            this.toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            // 
            // 换肤ToolStripMenuItem
            // 
            this.换肤ToolStripMenuItem.Name = "换肤ToolStripMenuItem";
            resources.ApplyResources(this.换肤ToolStripMenuItem, "换肤ToolStripMenuItem");
            this.换肤ToolStripMenuItem.Click += new System.EventHandler(this.换肤ToolStripMenuItem_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Name = "label1";
            // 
            // lblMsg
            // 
            resources.ApplyResources(this.lblMsg, "lblMsg");
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMsg.Name = "lblMsg";
            // 
            // 目录工具ToolStripMenuItem
            // 
            this.目录工具ToolStripMenuItem.Name = "目录工具ToolStripMenuItem";
            resources.ApplyResources(this.目录工具ToolStripMenuItem, "目录工具ToolStripMenuItem");

            // 
            // Main
            // 
            this.AcceptButton = this.btnWorkLogSave;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Test.Properties.Resources.sider;
            this.Controls.Add(this.txtCmdStr);
            this.Controls.Add(this.btnRunCmd);
            this.Controls.Add(this.gbNpm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRest);
            this.Controls.Add(this.lblGF);
            this.Controls.Add(this.lblMarryDate);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.cmsNtyMenu.ResumeLayout(false);
            this.gbNpm.ResumeLayout(false);
            this.gbNpm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gpWeekWorkLog.ResumeLayout(false);
            this.gpWeekWorkLog.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.NotifyIcon ntyMsg;
        private System.Windows.Forms.ContextMenuStrip cmsNtyMenu;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.Timer tMainTimer;
        private System.Windows.Forms.ToolStripDropDownButton tsddbTool;
        private System.Windows.Forms.ToolStripMenuItem tsmiTMC3API测试;
        private System.Windows.Forms.ToolStripMenuItem 更新插件数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem myBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myWebClicentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newKey验证ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem 换肤ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMarryDate;
        private System.Windows.Forms.Label lblGF;
        private System.Windows.Forms.Label lblRest;
        private System.Windows.Forms.ToolStripMenuItem mySqlBangToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtWeekWorkLog;
        private System.Windows.Forms.TextBox txtWorkLog;
        private System.Windows.Forms.Button btnWorkLogSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gpWeekWorkLog;
        private System.Windows.Forms.Button btnWorkLogOpen;
        private System.Windows.Forms.GroupBox gbNpm;
        private System.Windows.Forms.ToolStripMenuItem tsmiStringHelperBox;
        private System.Windows.Forms.Button btnRunCmd;
        private System.Windows.Forms.TextBox txtCmdStr;
        private System.Windows.Forms.Button btnOpenSnipping;
        private System.Windows.Forms.Button btnOpenMsTsc;
        private System.Windows.Forms.Button btnOpenMsPaint;
        private System.Windows.Forms.Button btnOpenNotepad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHotelOneKeyRefund;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem tsmiRandomStr;
        private System.Windows.Forms.ToolStripMenuItem tsmiFmVoice;
        private System.Windows.Forms.ToolStripMenuItem 广告一键支付ToolStripMenuItem;
        private System.Windows.Forms.Button btnOpenSFTP;
        private System.Windows.Forms.Label lblSftpState;
        private System.Windows.Forms.ToolStripMenuItem 目录工具ToolStripMenuItem;
    }
}