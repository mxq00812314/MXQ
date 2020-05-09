namespace TimeSpanTool
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
            this.xPanel31 = new EP.WF.UI.Extend.XPanel3();
            this.xSwitch1 = new EP.WF.UI.Extend.XSwitch();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnFormat = new EP.WF.UI.Extend.XButton();
            this.xPanel32 = new EP.WF.UI.Extend.XPanel3();
            this.txtOutPut = new System.Windows.Forms.TextBox();
            this.xPanel31.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.xPanel32.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel31
            // 
            this.xPanel31.BackColorAlpha = 10;
            this.xPanel31.Controls.Add(this.xSwitch1);
            this.xPanel31.Controls.Add(this.numericUpDown1);
            this.xPanel31.Controls.Add(this.btnFormat);
            this.xPanel31.Dock = System.Windows.Forms.DockStyle.Top;
            this.xPanel31.Location = new System.Drawing.Point(20, 20);
            this.xPanel31.MainBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.xPanel31.Name = "xPanel31";
            this.xPanel31.Size = new System.Drawing.Size(504, 88);
            this.xPanel31.TabIndex = 0;
            // 
            // xSwitch1
            // 
            this.xSwitch1.Checked = true;
            this.xSwitch1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(163)))), ((int)(((byte)(169)))));
            this.xSwitch1.Font = new System.Drawing.Font("黑体", 14F);
            this.xSwitch1.Location = new System.Drawing.Point(48, 33);
            this.xSwitch1.Name = "xSwitch1";
            this.xSwitch1.Size = new System.Drawing.Size(59, 23);
            this.xSwitch1.SwitchType = EP.WF.UI.Extend.SwitchType.Ellipse;
            this.xSwitch1.TabIndex = 2;
            this.xSwitch1.Text = null;
            this.xSwitch1.Texts = new string[] {
        "秒",
        "毫秒"};
            this.xSwitch1.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(122)))), ((int)(((byte)(126)))));
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("黑体", 14F);
            this.numericUpDown1.Location = new System.Drawing.Point(123, 30);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(214, 29);
            this.numericUpDown1.TabIndex = 1;
            // 
            // btnFormat
            // 
            this.btnFormat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFormat.BackImage = ((System.Drawing.Image)(resources.GetObject("btnFormat.BackImage")));
            this.btnFormat.BackImageRepeatDirection = System.Windows.Forms.Orientation.Horizontal;
            this.btnFormat.ButtonImageCount = 4;
            this.btnFormat.ButtonImageSplitSize = 0;
            this.btnFormat.Font = new System.Drawing.Font("黑体", 14F);
            this.btnFormat.Location = new System.Drawing.Point(343, 30);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(105, 29);
            this.btnFormat.Status = EP.WF.UI.Extend.XButton.ElementStatus.Normal;
            this.btnFormat.TabIndex = 0;
            this.btnFormat.Text = "转换";
            this.btnFormat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFormat.TransparentKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // xPanel32
            // 
            this.xPanel32.BackColor = System.Drawing.Color.Transparent;
            this.xPanel32.BackColorAlpha = 10;
            this.xPanel32.Controls.Add(this.txtOutPut);
            this.xPanel32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel32.Location = new System.Drawing.Point(20, 108);
            this.xPanel32.MainBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.xPanel32.Name = "xPanel32";
            this.xPanel32.Padding = new System.Windows.Forms.Padding(20);
            this.xPanel32.Size = new System.Drawing.Size(504, 266);
            this.xPanel32.TabIndex = 1;
            // 
            // txtOutPut
            // 
            this.txtOutPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtOutPut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutPut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutPut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtOutPut.Location = new System.Drawing.Point(20, 20);
            this.txtOutPut.Multiline = true;
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutPut.Size = new System.Drawing.Size(464, 226);
            this.txtOutPut.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(544, 394);
            this.Controls.Add(this.xPanel32);
            this.Controls.Add(this.xPanel31);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "秒格式化";
            this.xPanel31.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.xPanel32.ResumeLayout(false);
            this.xPanel32.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EP.WF.UI.Extend.XPanel3 xPanel31;
        private EP.WF.UI.Extend.XSwitch xSwitch1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private EP.WF.UI.Extend.XButton btnFormat;
        private EP.WF.UI.Extend.XPanel3 xPanel32;
        private System.Windows.Forms.TextBox txtOutPut;
    }
}

