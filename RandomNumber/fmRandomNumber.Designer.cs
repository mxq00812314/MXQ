namespace RandomNumber
{
    partial class fmRandomNumber
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
            this.btnRandom = new System.Windows.Forms.Button();
            this.lblRandomIngNumber = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnRandomClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("宋体", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRandom.Location = new System.Drawing.Point(2, 418);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(1017, 86);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "开始";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lblRandomIngNumber
            // 
            this.lblRandomIngNumber.AutoSize = true;
            this.lblRandomIngNumber.Font = new System.Drawing.Font("宋体", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRandomIngNumber.Location = new System.Drawing.Point(429, 149);
            this.lblRandomIngNumber.Name = "lblRandomIngNumber";
            this.lblRandomIngNumber.Size = new System.Drawing.Size(163, 67);
            this.lblRandomIngNumber.TabIndex = 1;
            this.lblRandomIngNumber.Text = "就绪";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(791, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(229, 400);
            this.listBox2.TabIndex = 3;
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(3, 2);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(229, 400);
            this.txtSource.TabIndex = 4;
            this.txtSource.Text = "1\r\n2\r\n3\r\n4\r\n5\r\na\r\nb\r\nc\r\nd";
            // 
            // btnRandomClear
            // 
            this.btnRandomClear.Location = new System.Drawing.Point(348, 526);
            this.btnRandomClear.Name = "btnRandomClear";
            this.btnRandomClear.Size = new System.Drawing.Size(325, 44);
            this.btnRandomClear.TabIndex = 5;
            this.btnRandomClear.Text = "清空";
            this.btnRandomClear.UseVisualStyleBackColor = true;
            this.btnRandomClear.Click += new System.EventHandler(this.btnRandomClear_Click);
            // 
            // fmRandomNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 578);
            this.Controls.Add(this.btnRandomClear);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lblRandomIngNumber);
            this.Controls.Add(this.btnRandom);
            this.Name = "fmRandomNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fmRandomNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label lblRandomIngNumber;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnRandomClear;
    }
}