namespace WordToVoice
{
    partial class fmIFY
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTextToVoice = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboSpeeker = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenVoice = new System.Windows.Forms.Button();
            this.lblSpeaker = new System.Windows.Forms.Label();
            this.btnLocalVoiceRecognitionResult = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLocalVoiceRecognitionResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTextToVoice
            // 
            this.btnTextToVoice.Location = new System.Drawing.Point(35, 279);
            this.btnTextToVoice.Name = "btnTextToVoice";
            this.btnTextToVoice.Size = new System.Drawing.Size(184, 44);
            this.btnTextToVoice.TabIndex = 0;
            this.btnTextToVoice.Text = "播放语音";
            this.btnTextToVoice.UseVisualStyleBackColor = true;
            this.btnTextToVoice.Click += new System.EventHandler(this.btnTextToVoice_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(35, 40);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInput.Size = new System.Drawing.Size(311, 233);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "欢迎使用";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 546);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(29, 12);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "就绪";
            // 
            // cboSpeeker
            // 
            this.cboSpeeker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpeeker.FormattingEnabled = true;
            this.cboSpeeker.Items.AddRange(new object[] {
            "小燕_青年女声_中英文_普通话",
            "小宇_青年男声_中英文_普通话",
            "凯瑟琳_青年女声_英语",
            "亨利_青年男声_英语",
            "玛丽_青年女声_英语",
            "小研_青年女声_中英文_普通话",
            "小琪_青年女声_中英文_普通话",
            "小峰_青年男声_中英文_普通话",
            "小梅_青年女声_中英文_粤语",
            "小莉_青年女声_中英文_台普",
            "小蓉_青年女声_汉语_四川话",
            "小芸_青年女声_汉语_东北话",
            "小坤_青年男声_汉语_河南话",
            "小强_青年男声_汉语_湖南话",
            "小莹_青年女声_汉语_陕西话",
            "小新_童年男声_汉语_普通话",
            "楠楠_童年女声_汉语_普通话",
            "老孙_老年男声_汉语_普通话"});
            this.cboSpeeker.Location = new System.Drawing.Point(106, 329);
            this.cboSpeeker.Name = "cboSpeeker";
            this.cboSpeeker.Size = new System.Drawing.Size(240, 20);
            this.cboSpeeker.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenVoice);
            this.groupBox1.Controls.Add(this.lblSpeaker);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.cboSpeeker);
            this.groupBox1.Controls.Add(this.btnTextToVoice);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 366);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "语音合成";
            // 
            // btnOpenVoice
            // 
            this.btnOpenVoice.Location = new System.Drawing.Point(271, 279);
            this.btnOpenVoice.Name = "btnOpenVoice";
            this.btnOpenVoice.Size = new System.Drawing.Size(75, 44);
            this.btnOpenVoice.TabIndex = 5;
            this.btnOpenVoice.Text = "打开";
            this.btnOpenVoice.UseVisualStyleBackColor = true;
            this.btnOpenVoice.Click += new System.EventHandler(this.btnOpenVoice_Click);
            // 
            // lblSpeaker
            // 
            this.lblSpeaker.AutoSize = true;
            this.lblSpeaker.Location = new System.Drawing.Point(35, 336);
            this.lblSpeaker.Name = "lblSpeaker";
            this.lblSpeaker.Size = new System.Drawing.Size(65, 12);
            this.lblSpeaker.TabIndex = 4;
            this.lblSpeaker.Text = "语音朗读人";
            // 
            // btnLocalVoiceRecognitionResult
            // 
            this.btnLocalVoiceRecognitionResult.Location = new System.Drawing.Point(41, 40);
            this.btnLocalVoiceRecognitionResult.Name = "btnLocalVoiceRecognitionResult";
            this.btnLocalVoiceRecognitionResult.Size = new System.Drawing.Size(311, 40);
            this.btnLocalVoiceRecognitionResult.TabIndex = 6;
            this.btnLocalVoiceRecognitionResult.Text = "语音识别";
            this.btnLocalVoiceRecognitionResult.UseVisualStyleBackColor = true;
            this.btnLocalVoiceRecognitionResult.Click += new System.EventHandler(this.btnLocalVoice_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLocalVoiceRecognitionResult);
            this.groupBox3.Controls.Add(this.btnLocalVoiceRecognitionResult);
            this.groupBox3.Location = new System.Drawing.Point(455, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 366);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "本地语音识别";
            // 
            // txtLocalVoiceRecognitionResult
            // 
            this.txtLocalVoiceRecognitionResult.Location = new System.Drawing.Point(41, 87);
            this.txtLocalVoiceRecognitionResult.Multiline = true;
            this.txtLocalVoiceRecognitionResult.Name = "txtLocalVoiceRecognitionResult";
            this.txtLocalVoiceRecognitionResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLocalVoiceRecognitionResult.Size = new System.Drawing.Size(311, 262);
            this.txtLocalVoiceRecognitionResult.TabIndex = 7;
            // 
            // fmIFY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 393);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStatus);
            this.Name = "fmIFY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "讯飞SDK语音处理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTextToVoice;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboSpeeker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSpeaker;
        private System.Windows.Forms.Button btnLocalVoiceRecognitionResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLocalVoiceRecognitionResult;
        private System.Windows.Forms.Button btnOpenVoice;
    }
}

