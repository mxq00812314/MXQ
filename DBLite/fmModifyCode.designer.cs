namespace DBLite
{
    partial class fmModifyCode
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
            this.dgvTableStructure = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckIsValueLowerChar = new System.Windows.Forms.CheckBox();
            this.rdoMofifyReverSide = new System.Windows.Forms.RadioButton();
            this.rdoMofifyFaceSide = new System.Windows.Forms.RadioButton();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableStructure)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTableStructure
            // 
            this.dgvTableStructure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTableStructure.Location = new System.Drawing.Point(0, 88);
            this.dgvTableStructure.Name = "dgvTableStructure";
            this.dgvTableStructure.RowTemplate.Height = 23;
            this.dgvTableStructure.Size = new System.Drawing.Size(851, 516);
            this.dgvTableStructure.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 88);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckIsValueLowerChar);
            this.groupBox1.Controls.Add(this.rdoMofifyReverSide);
            this.groupBox1.Controls.Add(this.rdoMofifyFaceSide);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 79);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选项";
            // 
            // ckIsValueLowerChar
            // 
            this.ckIsValueLowerChar.AutoSize = true;
            this.ckIsValueLowerChar.Checked = true;
            this.ckIsValueLowerChar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckIsValueLowerChar.Location = new System.Drawing.Point(25, 20);
            this.ckIsValueLowerChar.Name = "ckIsValueLowerChar";
            this.ckIsValueLowerChar.Size = new System.Drawing.Size(174, 16);
            this.ckIsValueLowerChar.TabIndex = 1;
            this.ckIsValueLowerChar.Text = "编辑时赋值value的字段小写";
            this.ckIsValueLowerChar.UseVisualStyleBackColor = true;
            // 
            // rdoMofifyReverSide
            // 
            this.rdoMofifyReverSide.AutoSize = true;
            this.rdoMofifyReverSide.Location = new System.Drawing.Point(78, 43);
            this.rdoMofifyReverSide.Name = "rdoMofifyReverSide";
            this.rdoMofifyReverSide.Size = new System.Drawing.Size(47, 16);
            this.rdoMofifyReverSide.TabIndex = 3;
            this.rdoMofifyReverSide.Text = "反选";
            this.rdoMofifyReverSide.UseVisualStyleBackColor = true;
            // 
            // rdoMofifyFaceSide
            // 
            this.rdoMofifyFaceSide.AutoSize = true;
            this.rdoMofifyFaceSide.Checked = true;
            this.rdoMofifyFaceSide.Location = new System.Drawing.Point(25, 43);
            this.rdoMofifyFaceSide.Name = "rdoMofifyFaceSide";
            this.rdoMofifyFaceSide.Size = new System.Drawing.Size(47, 16);
            this.rdoMofifyFaceSide.TabIndex = 2;
            this.rdoMofifyFaceSide.TabStop = true;
            this.rdoMofifyFaceSide.Text = "正选";
            this.rdoMofifyFaceSide.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(580, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(268, 79);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // fmModifyCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 604);
            this.Controls.Add(this.dgvTableStructure);
            this.Controls.Add(this.panel1);
            this.Name = "fmModifyCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = ".NET 维护代码CRUD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableStructure)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTableStructure;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox ckIsValueLowerChar;
        private System.Windows.Forms.RadioButton rdoMofifyReverSide;
        private System.Windows.Forms.RadioButton rdoMofifyFaceSide;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}