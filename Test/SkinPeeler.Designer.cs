namespace Test
{
    partial class SkinPeeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkinPeeler));
            this.lsbSkins = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSkinCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbSkins
            // 
            this.lsbSkins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbSkins.FormattingEnabled = true;
            this.lsbSkins.ItemHeight = 12;
            this.lsbSkins.Location = new System.Drawing.Point(0, 25);
            this.lsbSkins.Name = "lsbSkins";
            this.lsbSkins.Size = new System.Drawing.Size(184, 286);
            this.lsbSkins.TabIndex = 0;
            this.lsbSkins.SelectedIndexChanged += new System.EventHandler(this.lsbSkins_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSkinCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 25);
            this.panel1.TabIndex = 1;
            // 
            // lblSkinCount
            // 
            this.lblSkinCount.AutoSize = true;
            this.lblSkinCount.Location = new System.Drawing.Point(4, 7);
            this.lblSkinCount.Name = "lblSkinCount";
            this.lblSkinCount.Size = new System.Drawing.Size(59, 12);
            this.lblSkinCount.TabIndex = 2;
            this.lblSkinCount.Text = "共0个皮肤";
            // 
            // SkinPeeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 311);
            this.Controls.Add(this.lsbSkins);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SkinPeeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "换肤";
            this.Load += new System.EventHandler(this.SkinPeeler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbSkins;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSkinCount;
    }
}