namespace FileWatcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnWatchStart = new System.Windows.Forms.Button();
            this.btnWatchStop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWatchStart
            // 
            this.btnWatchStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnWatchStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWatchStart.BackgroundImage")));
            this.btnWatchStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWatchStart.FlatAppearance.BorderSize = 0;
            this.btnWatchStart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnWatchStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWatchStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnWatchStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatchStart.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Bold);
            this.btnWatchStart.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnWatchStart.Location = new System.Drawing.Point(30, 6);
            this.btnWatchStart.Name = "btnWatchStart";
            this.btnWatchStart.Size = new System.Drawing.Size(141, 59);
            this.btnWatchStart.TabIndex = 51;
            this.btnWatchStart.Text = "开始监控";
            this.btnWatchStart.UseVisualStyleBackColor = false;
            this.btnWatchStart.Click += new System.EventHandler(this.btnWatchStart_Click);
            // 
            // btnWatchStop
            // 
            this.btnWatchStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnWatchStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWatchStop.BackgroundImage")));
            this.btnWatchStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWatchStop.FlatAppearance.BorderSize = 0;
            this.btnWatchStop.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnWatchStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWatchStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnWatchStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatchStop.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Bold);
            this.btnWatchStop.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnWatchStop.Location = new System.Drawing.Point(195, 6);
            this.btnWatchStop.Name = "btnWatchStop";
            this.btnWatchStop.Size = new System.Drawing.Size(141, 59);
            this.btnWatchStop.TabIndex = 52;
            this.btnWatchStop.Text = "停止监控";
            this.btnWatchStop.UseVisualStyleBackColor = false;
            this.btnWatchStop.Click += new System.EventHandler(this.btnWatchStop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(526, 425);
            this.textBox1.TabIndex = 53;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnWatchStop);
            this.panel1.Controls.Add(this.btnWatchStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 73);
            this.panel1.TabIndex = 54;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 498);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件监控";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWatchStart;
        private System.Windows.Forms.Button btnWatchStop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

