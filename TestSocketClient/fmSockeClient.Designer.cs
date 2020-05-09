namespace TestSocketClient
{
    partial class fmSockeClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSockeClient));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.btnClientSend = new System.Windows.Forms.Button();
            this.btnSaveSocket = new System.Windows.Forms.Button();
            this.btnClientConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.ForeColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(6, 128);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(745, 389);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(745, 77);
            this.textBox1.TabIndex = 5;
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(77, 11);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(149, 21);
            this.txtServerIP.TabIndex = 8;
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(309, 11);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(72, 21);
            this.txtServerPort.TabIndex = 9;
            // 
            // btnClientSend
            // 
            this.btnClientSend.BackColor = System.Drawing.SystemColors.Control;
            this.btnClientSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClientSend.BackgroundImage")));
            this.btnClientSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientSend.FlatAppearance.BorderSize = 0;
            this.btnClientSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientSend.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClientSend.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnClientSend.Location = new System.Drawing.Point(757, 45);
            this.btnClientSend.Name = "btnClientSend";
            this.btnClientSend.Size = new System.Drawing.Size(90, 25);
            this.btnClientSend.TabIndex = 37;
            this.btnClientSend.Text = "发送";
            this.btnClientSend.UseVisualStyleBackColor = false;
            this.btnClientSend.Click += new System.EventHandler(this.btnClientSend_Click);
            // 
            // btnSaveSocket
            // 
            this.btnSaveSocket.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveSocket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveSocket.BackgroundImage")));
            this.btnSaveSocket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveSocket.FlatAppearance.BorderSize = 0;
            this.btnSaveSocket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSocket.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveSocket.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSaveSocket.Location = new System.Drawing.Point(396, 11);
            this.btnSaveSocket.Name = "btnSaveSocket";
            this.btnSaveSocket.Size = new System.Drawing.Size(79, 25);
            this.btnSaveSocket.TabIndex = 36;
            this.btnSaveSocket.Text = "保存Socket配置";
            this.btnSaveSocket.UseVisualStyleBackColor = false;
            this.btnSaveSocket.Click += new System.EventHandler(this.btnSaveSocket_Click);
            // 
            // btnClientConnect
            // 
            this.btnClientConnect.BackColor = System.Drawing.SystemColors.Control;
            this.btnClientConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClientConnect.BackgroundImage")));
            this.btnClientConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientConnect.FlatAppearance.BorderSize = 0;
            this.btnClientConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientConnect.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClientConnect.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClientConnect.Location = new System.Drawing.Point(757, 124);
            this.btnClientConnect.Name = "btnClientConnect";
            this.btnClientConnect.Size = new System.Drawing.Size(101, 71);
            this.btnClientConnect.TabIndex = 38;
            this.btnClientConnect.Text = "连接Socket服务器";
            this.btnClientConnect.UseVisualStyleBackColor = false;
            this.btnClientConnect.Click += new System.EventHandler(this.btnClientConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 39;
            this.label1.Text = "Server IP：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 40;
            this.label2.Text = "Server Port：";
            // 
            // fmSockeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 520);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClientConnect);
            this.Controls.Add(this.btnClientSend);
            this.Controls.Add(this.btnSaveSocket);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmSockeClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socke Client V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmSockeClient_FormClosing);
            this.Load += new System.EventHandler(this.fmSockeClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Button btnClientSend;
        private System.Windows.Forms.Button btnSaveSocket;
        private System.Windows.Forms.Button btnClientConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}