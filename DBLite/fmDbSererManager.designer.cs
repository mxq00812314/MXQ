namespace DBLite
{
    partial class fmDbSererManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDbSererManager));
            this.btnDbServerConnection = new System.Windows.Forms.Button();
            this.cboDbServerList = new System.Windows.Forms.ComboBox();
            this.lblDbServerList = new System.Windows.Forms.Label();
            this.lblDbServerHost = new System.Windows.Forms.Label();
            this.lblDbServerUserId = new System.Windows.Forms.Label();
            this.lblDbServerUserPwd = new System.Windows.Forms.Label();
            this.txtDbServerHost = new System.Windows.Forms.TextBox();
            this.txtDbServerUserId = new System.Windows.Forms.TextBox();
            this.txtDbServerUserPwd = new System.Windows.Forms.TextBox();
            this.btnDbServerNewCreate = new System.Windows.Forms.Button();
            this.btnDbServerDel = new System.Windows.Forms.Button();
            this.lblDbServerPort = new System.Windows.Forms.Label();
            this.txtDbServerPort = new System.Windows.Forms.TextBox();
            this.txtDbServerDataBase = new System.Windows.Forms.TextBox();
            this.lblDbServerDataBase = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDbSessionTimeOutCustomUnit = new System.Windows.Forms.Label();
            this.txtDbSessionTimeOutCustom = new System.Windows.Forms.TextBox();
            this.rdoDbSessionTimeOutCustom = new System.Windows.Forms.RadioButton();
            this.rdoDbSessionTimeOutDefault = new System.Windows.Forms.RadioButton();
            this.btnDbServerSave = new System.Windows.Forms.Button();
            this.txtDbServerName = new System.Windows.Forms.TextBox();
            this.lblDbServerName = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstlblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDbServerOpenConfig = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDbServerConnection
            // 
            this.btnDbServerConnection.Location = new System.Drawing.Point(154, 290);
            this.btnDbServerConnection.Name = "btnDbServerConnection";
            this.btnDbServerConnection.Size = new System.Drawing.Size(75, 23);
            this.btnDbServerConnection.TabIndex = 0;
            this.btnDbServerConnection.Text = "连接";
            this.btnDbServerConnection.UseVisualStyleBackColor = true;
            this.btnDbServerConnection.Click += new System.EventHandler(this.btnDbServerConnection_Click);
            // 
            // cboDbServerList
            // 
            this.cboDbServerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDbServerList.FormattingEnabled = true;
            this.cboDbServerList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboDbServerList.Location = new System.Drawing.Point(235, 47);
            this.cboDbServerList.Name = "cboDbServerList";
            this.cboDbServerList.Size = new System.Drawing.Size(261, 20);
            this.cboDbServerList.TabIndex = 1;
            this.cboDbServerList.SelectedIndexChanged += new System.EventHandler(this.cboDbServerList_SelectedIndexChanged);
            this.cboDbServerList.Enter += new System.EventHandler(this.cboDbServerList_Enter);
            // 
            // lblDbServerList
            // 
            this.lblDbServerList.AutoSize = true;
            this.lblDbServerList.Location = new System.Drawing.Point(154, 50);
            this.lblDbServerList.Name = "lblDbServerList";
            this.lblDbServerList.Size = new System.Drawing.Size(65, 12);
            this.lblDbServerList.TabIndex = 2;
            this.lblDbServerList.Text = "保存的连接";
            // 
            // lblDbServerHost
            // 
            this.lblDbServerHost.AutoSize = true;
            this.lblDbServerHost.Location = new System.Drawing.Point(154, 104);
            this.lblDbServerHost.Name = "lblDbServerHost";
            this.lblDbServerHost.Size = new System.Drawing.Size(53, 12);
            this.lblDbServerHost.TabIndex = 3;
            this.lblDbServerHost.Text = "主机地址";
            // 
            // lblDbServerUserId
            // 
            this.lblDbServerUserId.AutoSize = true;
            this.lblDbServerUserId.Location = new System.Drawing.Point(154, 131);
            this.lblDbServerUserId.Name = "lblDbServerUserId";
            this.lblDbServerUserId.Size = new System.Drawing.Size(53, 12);
            this.lblDbServerUserId.TabIndex = 4;
            this.lblDbServerUserId.Text = "用户帐号";
            // 
            // lblDbServerUserPwd
            // 
            this.lblDbServerUserPwd.AutoSize = true;
            this.lblDbServerUserPwd.Location = new System.Drawing.Point(154, 158);
            this.lblDbServerUserPwd.Name = "lblDbServerUserPwd";
            this.lblDbServerUserPwd.Size = new System.Drawing.Size(53, 12);
            this.lblDbServerUserPwd.TabIndex = 5;
            this.lblDbServerUserPwd.Text = "用户密码";
            // 
            // txtDbServerHost
            // 
            this.txtDbServerHost.Location = new System.Drawing.Point(235, 100);
            this.txtDbServerHost.Name = "txtDbServerHost";
            this.txtDbServerHost.Size = new System.Drawing.Size(261, 21);
            this.txtDbServerHost.TabIndex = 6;
            // 
            // txtDbServerUserId
            // 
            this.txtDbServerUserId.Location = new System.Drawing.Point(235, 127);
            this.txtDbServerUserId.Name = "txtDbServerUserId";
            this.txtDbServerUserId.Size = new System.Drawing.Size(261, 21);
            this.txtDbServerUserId.TabIndex = 7;
            // 
            // txtDbServerUserPwd
            // 
            this.txtDbServerUserPwd.Location = new System.Drawing.Point(235, 154);
            this.txtDbServerUserPwd.Name = "txtDbServerUserPwd";
            this.txtDbServerUserPwd.Size = new System.Drawing.Size(120, 21);
            this.txtDbServerUserPwd.TabIndex = 8;
            // 
            // btnDbServerNewCreate
            // 
            this.btnDbServerNewCreate.Location = new System.Drawing.Point(154, 12);
            this.btnDbServerNewCreate.Name = "btnDbServerNewCreate";
            this.btnDbServerNewCreate.Size = new System.Drawing.Size(75, 23);
            this.btnDbServerNewCreate.TabIndex = 10;
            this.btnDbServerNewCreate.Text = "新建";
            this.btnDbServerNewCreate.UseVisualStyleBackColor = true;
            this.btnDbServerNewCreate.Click += new System.EventHandler(this.btnDbServerNewCreate_Click);
            // 
            // btnDbServerDel
            // 
            this.btnDbServerDel.Location = new System.Drawing.Point(421, 12);
            this.btnDbServerDel.Name = "btnDbServerDel";
            this.btnDbServerDel.Size = new System.Drawing.Size(75, 23);
            this.btnDbServerDel.TabIndex = 11;
            this.btnDbServerDel.Text = "删除";
            this.btnDbServerDel.UseVisualStyleBackColor = true;
            this.btnDbServerDel.Click += new System.EventHandler(this.btnDbServerDel_Click);
            // 
            // lblDbServerPort
            // 
            this.lblDbServerPort.AutoSize = true;
            this.lblDbServerPort.Location = new System.Drawing.Point(154, 185);
            this.lblDbServerPort.Name = "lblDbServerPort";
            this.lblDbServerPort.Size = new System.Drawing.Size(53, 12);
            this.lblDbServerPort.TabIndex = 12;
            this.lblDbServerPort.Text = "主机端口";
            // 
            // txtDbServerPort
            // 
            this.txtDbServerPort.Location = new System.Drawing.Point(235, 181);
            this.txtDbServerPort.Name = "txtDbServerPort";
            this.txtDbServerPort.Size = new System.Drawing.Size(120, 21);
            this.txtDbServerPort.TabIndex = 13;
            this.txtDbServerPort.Text = "3306";
            // 
            // txtDbServerDataBase
            // 
            this.txtDbServerDataBase.Location = new System.Drawing.Point(235, 208);
            this.txtDbServerDataBase.Name = "txtDbServerDataBase";
            this.txtDbServerDataBase.Size = new System.Drawing.Size(261, 21);
            this.txtDbServerDataBase.TabIndex = 15;
            // 
            // lblDbServerDataBase
            // 
            this.lblDbServerDataBase.AutoSize = true;
            this.lblDbServerDataBase.Location = new System.Drawing.Point(154, 212);
            this.lblDbServerDataBase.Name = "lblDbServerDataBase";
            this.lblDbServerDataBase.Size = new System.Drawing.Size(41, 12);
            this.lblDbServerDataBase.TabIndex = 14;
            this.lblDbServerDataBase.Text = "数据库";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDbSessionTimeOutCustomUnit);
            this.groupBox1.Controls.Add(this.txtDbSessionTimeOutCustom);
            this.groupBox1.Controls.Add(this.rdoDbSessionTimeOutCustom);
            this.groupBox1.Controls.Add(this.rdoDbSessionTimeOutDefault);
            this.groupBox1.Location = new System.Drawing.Point(156, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 47);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "会话空闲超时";
            // 
            // lblDbSessionTimeOutCustomUnit
            // 
            this.lblDbSessionTimeOutCustomUnit.AutoSize = true;
            this.lblDbSessionTimeOutCustomUnit.Location = new System.Drawing.Point(129, 22);
            this.lblDbSessionTimeOutCustomUnit.Name = "lblDbSessionTimeOutCustomUnit";
            this.lblDbSessionTimeOutCustomUnit.Size = new System.Drawing.Size(41, 12);
            this.lblDbSessionTimeOutCustomUnit.TabIndex = 3;
            this.lblDbSessionTimeOutCustomUnit.Text = "（秒）";
            // 
            // txtDbSessionTimeOutCustom
            // 
            this.txtDbSessionTimeOutCustom.Location = new System.Drawing.Point(79, 17);
            this.txtDbSessionTimeOutCustom.Name = "txtDbSessionTimeOutCustom";
            this.txtDbSessionTimeOutCustom.ReadOnly = true;
            this.txtDbSessionTimeOutCustom.Size = new System.Drawing.Size(47, 21);
            this.txtDbSessionTimeOutCustom.TabIndex = 2;
            this.txtDbSessionTimeOutCustom.Text = "28800";
            this.txtDbSessionTimeOutCustom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDbSessionTimeOutCustom_KeyPress);
            // 
            // rdoDbSessionTimeOutCustom
            // 
            this.rdoDbSessionTimeOutCustom.AutoSize = true;
            this.rdoDbSessionTimeOutCustom.Location = new System.Drawing.Point(59, 20);
            this.rdoDbSessionTimeOutCustom.Name = "rdoDbSessionTimeOutCustom";
            this.rdoDbSessionTimeOutCustom.Size = new System.Drawing.Size(14, 13);
            this.rdoDbSessionTimeOutCustom.TabIndex = 1;
            this.rdoDbSessionTimeOutCustom.UseVisualStyleBackColor = true;
            this.rdoDbSessionTimeOutCustom.CheckedChanged += new System.EventHandler(this.rdoDbSessionTimeOutCustom_CheckedChanged);
            // 
            // rdoDbSessionTimeOutDefault
            // 
            this.rdoDbSessionTimeOutDefault.AutoSize = true;
            this.rdoDbSessionTimeOutDefault.Checked = true;
            this.rdoDbSessionTimeOutDefault.Location = new System.Drawing.Point(6, 20);
            this.rdoDbSessionTimeOutDefault.Name = "rdoDbSessionTimeOutDefault";
            this.rdoDbSessionTimeOutDefault.Size = new System.Drawing.Size(47, 16);
            this.rdoDbSessionTimeOutDefault.TabIndex = 0;
            this.rdoDbSessionTimeOutDefault.TabStop = true;
            this.rdoDbSessionTimeOutDefault.Text = "默认";
            this.rdoDbSessionTimeOutDefault.UseVisualStyleBackColor = true;
            this.rdoDbSessionTimeOutDefault.CheckedChanged += new System.EventHandler(this.rdoDbSessionTimeOutDefault_CheckedChanged);
            // 
            // btnDbServerSave
            // 
            this.btnDbServerSave.Location = new System.Drawing.Point(235, 12);
            this.btnDbServerSave.Name = "btnDbServerSave";
            this.btnDbServerSave.Size = new System.Drawing.Size(75, 23);
            this.btnDbServerSave.TabIndex = 17;
            this.btnDbServerSave.Text = "保存";
            this.btnDbServerSave.UseVisualStyleBackColor = true;
            this.btnDbServerSave.Click += new System.EventHandler(this.btnDbServerSave_Click);
            // 
            // txtDbServerName
            // 
            this.txtDbServerName.Location = new System.Drawing.Point(235, 73);
            this.txtDbServerName.Name = "txtDbServerName";
            this.txtDbServerName.Size = new System.Drawing.Size(261, 21);
            this.txtDbServerName.TabIndex = 19;
            // 
            // lblDbServerName
            // 
            this.lblDbServerName.AutoSize = true;
            this.lblDbServerName.Location = new System.Drawing.Point(154, 77);
            this.lblDbServerName.Name = "lblDbServerName";
            this.lblDbServerName.Size = new System.Drawing.Size(53, 12);
            this.lblDbServerName.TabIndex = 18;
            this.lblDbServerName.Text = "连接名称";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstlblMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 319);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(519, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tstlblMsg
            // 
            this.tstlblMsg.Name = "tstlblMsg";
            this.tstlblMsg.Size = new System.Drawing.Size(32, 17);
            this.tstlblMsg.Text = "就绪";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 300);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnDbServerOpenConfig
            // 
            this.btnDbServerOpenConfig.Location = new System.Drawing.Point(317, 11);
            this.btnDbServerOpenConfig.Name = "btnDbServerOpenConfig";
            this.btnDbServerOpenConfig.Size = new System.Drawing.Size(98, 23);
            this.btnDbServerOpenConfig.TabIndex = 21;
            this.btnDbServerOpenConfig.Text = "打开配置文件";
            this.btnDbServerOpenConfig.UseVisualStyleBackColor = true;
            this.btnDbServerOpenConfig.Click += new System.EventHandler(this.btnDbServerOpenConfig_Click);
            // 
            // fmDbSererManager
            // 
            this.AcceptButton = this.btnDbServerConnection;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 341);
            this.Controls.Add(this.btnDbServerOpenConfig);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtDbServerName);
            this.Controls.Add(this.lblDbServerName);
            this.Controls.Add(this.btnDbServerSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDbServerDataBase);
            this.Controls.Add(this.lblDbServerDataBase);
            this.Controls.Add(this.txtDbServerPort);
            this.Controls.Add(this.lblDbServerPort);
            this.Controls.Add(this.btnDbServerDel);
            this.Controls.Add(this.btnDbServerNewCreate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDbServerUserPwd);
            this.Controls.Add(this.txtDbServerUserId);
            this.Controls.Add(this.txtDbServerHost);
            this.Controls.Add(this.lblDbServerUserPwd);
            this.Controls.Add(this.lblDbServerUserId);
            this.Controls.Add(this.lblDbServerHost);
            this.Controls.Add(this.lblDbServerList);
            this.Controls.Add(this.cboDbServerList);
            this.Controls.Add(this.btnDbServerConnection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmDbSererManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "连接到我的DB_Server主机";
            this.Load += new System.EventHandler(this.fmDbSererManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDbServerConnection;
        private System.Windows.Forms.ComboBox cboDbServerList;
        private System.Windows.Forms.Label lblDbServerList;
        private System.Windows.Forms.Label lblDbServerHost;
        private System.Windows.Forms.Label lblDbServerUserId;
        private System.Windows.Forms.Label lblDbServerUserPwd;
        private System.Windows.Forms.TextBox txtDbServerHost;
        private System.Windows.Forms.TextBox txtDbServerUserId;
        private System.Windows.Forms.TextBox txtDbServerUserPwd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDbServerNewCreate;
        private System.Windows.Forms.Button btnDbServerDel;
        private System.Windows.Forms.Label lblDbServerPort;
        private System.Windows.Forms.TextBox txtDbServerPort;
        private System.Windows.Forms.TextBox txtDbServerDataBase;
        private System.Windows.Forms.Label lblDbServerDataBase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDbSessionTimeOutCustom;
        private System.Windows.Forms.RadioButton rdoDbSessionTimeOutDefault;
        private System.Windows.Forms.Label lblDbSessionTimeOutCustomUnit;
        private System.Windows.Forms.TextBox txtDbSessionTimeOutCustom;
        private System.Windows.Forms.Button btnDbServerSave;
        private System.Windows.Forms.TextBox txtDbServerName;
        private System.Windows.Forms.Label lblDbServerName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tstlblMsg;
        private System.Windows.Forms.Button btnDbServerOpenConfig;
    }
}