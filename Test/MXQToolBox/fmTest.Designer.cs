namespace Test
{
    partial class fmTest
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numDpiY = new System.Windows.Forms.NumericUpDown();
            this.numDpiX = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDpiY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDpiX)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "DpiX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "DpiY";
            // 
            // numDpiY
            // 
            this.numDpiY.Location = new System.Drawing.Point(224, 1);
            this.numDpiY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDpiY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDpiY.Name = "numDpiY";
            this.numDpiY.Size = new System.Drawing.Size(120, 21);
            this.numDpiY.TabIndex = 12;
            this.numDpiY.Value = new decimal(new int[] {
            102,
            0,
            0,
            0});
            // 
            // numDpiX
            // 
            this.numDpiX.Location = new System.Drawing.Point(47, 1);
            this.numDpiX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDpiX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDpiX.Name = "numDpiX";
            this.numDpiX.Size = new System.Drawing.Size(120, 21);
            this.numDpiX.TabIndex = 11;
            this.numDpiX.Value = new decimal(new int[] {
            102,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDpiY);
            this.Controls.Add(this.numDpiX);
            this.Controls.Add(this.button1);
            this.Name = "fmTest";
            this.Text = "fmTest";
            this.Load += new System.EventHandler(this.fmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDpiY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDpiX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDpiY;
        private System.Windows.Forms.NumericUpDown numDpiX;
        private System.Windows.Forms.Button button1;
    }
}