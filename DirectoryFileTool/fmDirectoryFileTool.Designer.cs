namespace DirectoryFileTool
{
    partial class fmDirectoryFileTool
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
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtDirectoryList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Location = new System.Drawing.Point(532, 12);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(104, 23);
            this.btnSelectDirectory.TabIndex = 0;
            this.btnSelectDirectory.Text = "选择文件夹目录";
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(26, 12);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(500, 21);
            this.txtDirectory.TabIndex = 1;
            // 
            // txtDirectoryList
            // 
            this.txtDirectoryList.Location = new System.Drawing.Point(26, 41);
            this.txtDirectoryList.Multiline = true;
            this.txtDirectoryList.Name = "txtDirectoryList";
            this.txtDirectoryList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDirectoryList.Size = new System.Drawing.Size(610, 323);
            this.txtDirectoryList.TabIndex = 2;
            // 
            // fmFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 376);
            this.Controls.Add(this.txtDirectoryList);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.btnSelectDirectory);
            this.Name = "fmFile";
            this.Text = "选择文件目录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtDirectoryList;
    }
}