namespace CreateMouseCursor
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
            this.btnSelectIcon = new System.Windows.Forms.Button();
            this.btnCreateMouseCursor = new System.Windows.Forms.Button();
            this.gbxPre = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.picMouseImage = new System.Windows.Forms.PictureBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMouseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectIcon
            // 
            this.btnSelectIcon.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelectIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectIcon.BackgroundImage")));
            this.btnSelectIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectIcon.FlatAppearance.BorderSize = 0;
            this.btnSelectIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectIcon.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectIcon.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSelectIcon.Location = new System.Drawing.Point(106, 3);
            this.btnSelectIcon.Name = "btnSelectIcon";
            this.btnSelectIcon.Size = new System.Drawing.Size(119, 63);
            this.btnSelectIcon.TabIndex = 45;
            this.btnSelectIcon.Text = "选择图标文件";
            this.btnSelectIcon.UseVisualStyleBackColor = false;
            this.btnSelectIcon.Click += new System.EventHandler(this.btnSelectIcon_Click);
            // 
            // btnCreateMouseCursor
            // 
            this.btnCreateMouseCursor.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreateMouseCursor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateMouseCursor.BackgroundImage")));
            this.btnCreateMouseCursor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateMouseCursor.FlatAppearance.BorderSize = 0;
            this.btnCreateMouseCursor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMouseCursor.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreateMouseCursor.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateMouseCursor.Location = new System.Drawing.Point(447, 3);
            this.btnCreateMouseCursor.Name = "btnCreateMouseCursor";
            this.btnCreateMouseCursor.Size = new System.Drawing.Size(159, 63);
            this.btnCreateMouseCursor.TabIndex = 43;
            this.btnCreateMouseCursor.Text = "生成";
            this.btnCreateMouseCursor.UseVisualStyleBackColor = false;
            this.btnCreateMouseCursor.Click += new System.EventHandler(this.btnCreateMouseCursor_Click);
            // 
            // gbxPre
            // 
            this.gbxPre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbxPre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxPre.Location = new System.Drawing.Point(0, 100);
            this.gbxPre.Name = "gbxPre";
            this.gbxPre.Size = new System.Drawing.Size(637, 368);
            this.gbxPre.TabIndex = 46;
            this.gbxPre.TabStop = false;
            this.gbxPre.Text = "预览";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPath);
            this.panel1.Controls.Add(this.btnSelectDirectory);
            this.panel1.Controls.Add(this.picMouseImage);
            this.panel1.Controls.Add(this.btnCreateMouseCursor);
            this.panel1.Controls.Add(this.btnSelectIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 100);
            this.panel1.TabIndex = 47;
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelectDirectory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectDirectory.BackgroundImage")));
            this.btnSelectDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectDirectory.FlatAppearance.BorderSize = 0;
            this.btnSelectDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectDirectory.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectDirectory.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSelectDirectory.Location = new System.Drawing.Point(259, 3);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(119, 63);
            this.btnSelectDirectory.TabIndex = 47;
            this.btnSelectDirectory.Text = "选择文件夹";
            this.btnSelectDirectory.UseVisualStyleBackColor = false;
            this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // picMouseImage
            // 
            this.picMouseImage.Location = new System.Drawing.Point(3, 4);
            this.picMouseImage.Name = "picMouseImage";
            this.picMouseImage.Size = new System.Drawing.Size(78, 60);
            this.picMouseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMouseImage.TabIndex = 46;
            this.picMouseImage.TabStop = false;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(13, 71);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(71, 12);
            this.lblPath.TabIndex = 48;
            this.lblPath.Text = "选中路径：/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 468);
            this.Controls.Add(this.gbxPre);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMouseImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectIcon;
        private System.Windows.Forms.Button btnCreateMouseCursor;
        private System.Windows.Forms.GroupBox gbxPre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picMouseImage;
        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.Label lblPath;
    }
}

