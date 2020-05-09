namespace MakeEffect
{
    partial class fmEffect
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.LblANumber = new System.Windows.Forms.Label();
            this.LblRNumber = new System.Windows.Forms.Label();
            this.BarAmount = new System.Windows.Forms.TrackBar();
            this.LblAmount = new System.Windows.Forms.Label();
            this.RadSharp = new System.Windows.Forms.RadioButton();
            this.RadBlur = new System.Windows.Forms.RadioButton();
            this.LblRadius = new System.Windows.Forms.Label();
            this.ChkExpandEdge = new System.Windows.Forms.CheckBox();
            this.BarRadius = new System.Windows.Forms.TrackBar();
            this.CmdOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.btnImageSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BarAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarRadius)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(19, 105);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(59, 12);
            this.lblInfo.TabIndex = 24;
            this.lblInfo.Text = "耗时：0ms";
            // 
            // LblANumber
            // 
            this.LblANumber.AutoSize = true;
            this.LblANumber.Location = new System.Drawing.Point(804, 75);
            this.LblANumber.Name = "LblANumber";
            this.LblANumber.Size = new System.Drawing.Size(17, 12);
            this.LblANumber.TabIndex = 23;
            this.LblANumber.Text = "50";
            // 
            // LblRNumber
            // 
            this.LblRNumber.AutoSize = true;
            this.LblRNumber.Location = new System.Drawing.Point(804, 28);
            this.LblRNumber.Name = "LblRNumber";
            this.LblRNumber.Size = new System.Drawing.Size(17, 12);
            this.LblRNumber.TabIndex = 22;
            this.LblRNumber.Text = "10";
            // 
            // BarAmount
            // 
            this.BarAmount.Location = new System.Drawing.Point(286, 69);
            this.BarAmount.Maximum = 100;
            this.BarAmount.Name = "BarAmount";
            this.BarAmount.Size = new System.Drawing.Size(514, 45);
            this.BarAmount.TabIndex = 21;
            this.BarAmount.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BarAmount.Value = 50;
            this.BarAmount.Scroll += new System.EventHandler(this.BarAmount_Scroll);
            this.BarAmount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BarAmount_MouseUp);
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Location = new System.Drawing.Point(251, 80);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(29, 12);
            this.LblAmount.TabIndex = 20;
            this.LblAmount.Text = "数量";
            // 
            // RadSharp
            // 
            this.RadSharp.AutoSize = true;
            this.RadSharp.Location = new System.Drawing.Point(160, 78);
            this.RadSharp.Name = "RadSharp";
            this.RadSharp.Size = new System.Drawing.Size(65, 16);
            this.RadSharp.TabIndex = 19;
            this.RadSharp.TabStop = true;
            this.RadSharp.Text = "USM锐化";
            this.RadSharp.UseVisualStyleBackColor = true;
            this.RadSharp.CheckedChanged += new System.EventHandler(this.RadSharp_CheckedChanged);
            // 
            // RadBlur
            // 
            this.RadBlur.AutoSize = true;
            this.RadBlur.Checked = true;
            this.RadBlur.Location = new System.Drawing.Point(160, 27);
            this.RadBlur.Name = "RadBlur";
            this.RadBlur.Size = new System.Drawing.Size(71, 16);
            this.RadBlur.TabIndex = 18;
            this.RadBlur.TabStop = true;
            this.RadBlur.Text = "高斯模糊";
            this.RadBlur.UseVisualStyleBackColor = true;
            this.RadBlur.CheckedChanged += new System.EventHandler(this.RadBlur_CheckedChanged);
            // 
            // LblRadius
            // 
            this.LblRadius.AutoSize = true;
            this.LblRadius.Location = new System.Drawing.Point(251, 29);
            this.LblRadius.Name = "LblRadius";
            this.LblRadius.Size = new System.Drawing.Size(29, 12);
            this.LblRadius.TabIndex = 17;
            this.LblRadius.Text = "半径";
            // 
            // ChkExpandEdge
            // 
            this.ChkExpandEdge.AutoSize = true;
            this.ChkExpandEdge.Location = new System.Drawing.Point(21, 80);
            this.ChkExpandEdge.Name = "ChkExpandEdge";
            this.ChkExpandEdge.Size = new System.Drawing.Size(72, 16);
            this.ChkExpandEdge.TabIndex = 16;
            this.ChkExpandEdge.Text = "扩展边界";
            this.ChkExpandEdge.UseVisualStyleBackColor = true;
            // 
            // BarRadius
            // 
            this.BarRadius.Location = new System.Drawing.Point(286, 24);
            this.BarRadius.Maximum = 255;
            this.BarRadius.Name = "BarRadius";
            this.BarRadius.Size = new System.Drawing.Size(512, 45);
            this.BarRadius.TabIndex = 15;
            this.BarRadius.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BarRadius.Value = 10;
            this.BarRadius.Scroll += new System.EventHandler(this.BarRadius_Scroll);
            this.BarRadius.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BarRadius_MouseUp);
            // 
            // CmdOpen
            // 
            this.CmdOpen.Location = new System.Drawing.Point(21, 13);
            this.CmdOpen.Name = "CmdOpen";
            this.CmdOpen.Size = new System.Drawing.Size(85, 29);
            this.CmdOpen.TabIndex = 13;
            this.CmdOpen.Text = "打开";
            this.CmdOpen.UseVisualStyleBackColor = true;
            this.CmdOpen.Click += new System.EventHandler(this.CmdOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImageSave);
            this.groupBox1.Controls.Add(this.CmdOpen);
            this.groupBox1.Controls.Add(this.BarRadius);
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.LblANumber);
            this.groupBox1.Controls.Add(this.ChkExpandEdge);
            this.groupBox1.Controls.Add(this.LblRNumber);
            this.groupBox1.Controls.Add(this.LblRadius);
            this.groupBox1.Controls.Add(this.BarAmount);
            this.groupBox1.Controls.Add(this.RadBlur);
            this.groupBox1.Controls.Add(this.LblAmount);
            this.groupBox1.Controls.Add(this.RadSharp);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 122);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Pic);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(922, 567);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "预览";
            // 
            // Pic
            // 
            this.Pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic.Location = new System.Drawing.Point(3, 17);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(916, 547);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pic.TabIndex = 15;
            this.Pic.TabStop = false;
            // 
            // btnImageSave
            // 
            this.btnImageSave.Location = new System.Drawing.Point(21, 45);
            this.btnImageSave.Name = "btnImageSave";
            this.btnImageSave.Size = new System.Drawing.Size(85, 29);
            this.btnImageSave.TabIndex = 25;
            this.btnImageSave.Text = "保存";
            this.btnImageSave.UseVisualStyleBackColor = true;
            this.btnImageSave.Click += new System.EventHandler(this.btnImageSave_Click);
            // 
            // fmEffect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 689);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmEffect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "高斯模糊 & USM锐化";
            this.Load += new System.EventHandler(this.fmEffect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarRadius)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label LblANumber;
        private System.Windows.Forms.Label LblRNumber;
        private System.Windows.Forms.TrackBar BarAmount;
        private System.Windows.Forms.Label LblAmount;
        private System.Windows.Forms.RadioButton RadSharp;
        private System.Windows.Forms.RadioButton RadBlur;
        private System.Windows.Forms.Label LblRadius;
        private System.Windows.Forms.CheckBox ChkExpandEdge;
        private System.Windows.Forms.TrackBar BarRadius;
        private System.Windows.Forms.Button CmdOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.Button btnImageSave;
    }
}