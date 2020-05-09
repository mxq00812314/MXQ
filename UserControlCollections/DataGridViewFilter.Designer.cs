namespace UserControlCollections
{
    partial class DataGridViewFilter
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDataGridViewFilterClose = new System.Windows.Forms.Button();
            this.pnlDataGridViewFilterTitle = new System.Windows.Forms.Panel();
            this.lblDataGridViewFilterTitleName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboDataGridViewFilterFieldOperate = new System.Windows.Forms.ComboBox();
            this.lblDataGridViewFilterValue = new System.Windows.Forms.Label();
            this.btnDataGridViewFilterYes = new System.Windows.Forms.Button();
            this.cboDataGridViewFilterField = new System.Windows.Forms.ComboBox();
            this.lblDataGridViewFilterField = new System.Windows.Forms.Label();
            this.txtDataGridViewFilterValue = new System.Windows.Forms.TextBox();
            this.lblDataGridViewFilterFieldOperate = new System.Windows.Forms.Label();
            this.pnlDataGridViewFilterTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDataGridViewFilterClose
            // 
            this.btnDataGridViewFilterClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDataGridViewFilterClose.Location = new System.Drawing.Point(264, 60);
            this.btnDataGridViewFilterClose.Name = "btnDataGridViewFilterClose";
            this.btnDataGridViewFilterClose.Size = new System.Drawing.Size(44, 23);
            this.btnDataGridViewFilterClose.TabIndex = 3;
            this.btnDataGridViewFilterClose.Text = "关闭";
            this.btnDataGridViewFilterClose.UseVisualStyleBackColor = true;
            this.btnDataGridViewFilterClose.Click += new System.EventHandler(this.btnDataGridViewFilterClose_Click);
            // 
            // pnlDataGridViewFilterTitle
            // 
            this.pnlDataGridViewFilterTitle.Controls.Add(this.lblDataGridViewFilterTitleName);
            this.pnlDataGridViewFilterTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlDataGridViewFilterTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDataGridViewFilterTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlDataGridViewFilterTitle.Name = "pnlDataGridViewFilterTitle";
            this.pnlDataGridViewFilterTitle.Size = new System.Drawing.Size(400, 27);
            this.pnlDataGridViewFilterTitle.TabIndex = 10;
            // 
            // lblDataGridViewFilterTitleName
            // 
            this.lblDataGridViewFilterTitleName.AutoSize = true;
            this.lblDataGridViewFilterTitleName.Location = new System.Drawing.Point(3, 6);
            this.lblDataGridViewFilterTitleName.Name = "lblDataGridViewFilterTitleName";
            this.lblDataGridViewFilterTitleName.Size = new System.Drawing.Size(65, 12);
            this.lblDataGridViewFilterTitleName.TabIndex = 4;
            this.lblDataGridViewFilterTitleName.Text = "表数据过滤";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboDataGridViewFilterFieldOperate);
            this.panel1.Controls.Add(this.btnDataGridViewFilterClose);
            this.panel1.Controls.Add(this.lblDataGridViewFilterValue);
            this.panel1.Controls.Add(this.btnDataGridViewFilterYes);
            this.panel1.Controls.Add(this.cboDataGridViewFilterField);
            this.panel1.Controls.Add(this.lblDataGridViewFilterField);
            this.panel1.Controls.Add(this.txtDataGridViewFilterValue);
            this.panel1.Controls.Add(this.lblDataGridViewFilterFieldOperate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 96);
            this.panel1.TabIndex = 11;
            // 
            // cboDataGridViewFilterFieldOperate
            // 
            this.cboDataGridViewFilterFieldOperate.FormattingEnabled = true;
            this.cboDataGridViewFilterFieldOperate.Items.AddRange(new object[] {
            "=",
            "<>",
            ">",
            ">=",
            "<",
            "<=",
            "LIKE"});
            this.cboDataGridViewFilterFieldOperate.Location = new System.Drawing.Point(185, 33);
            this.cboDataGridViewFilterFieldOperate.Name = "cboDataGridViewFilterFieldOperate";
            this.cboDataGridViewFilterFieldOperate.Size = new System.Drawing.Size(70, 20);
            this.cboDataGridViewFilterFieldOperate.TabIndex = 12;
            this.cboDataGridViewFilterFieldOperate.Text = "=";
            // 
            // lblDataGridViewFilterValue
            // 
            this.lblDataGridViewFilterValue.AutoSize = true;
            this.lblDataGridViewFilterValue.Location = new System.Drawing.Point(262, 17);
            this.lblDataGridViewFilterValue.Name = "lblDataGridViewFilterValue";
            this.lblDataGridViewFilterValue.Size = new System.Drawing.Size(17, 12);
            this.lblDataGridViewFilterValue.TabIndex = 15;
            this.lblDataGridViewFilterValue.Text = "值";
            // 
            // btnDataGridViewFilterYes
            // 
            this.btnDataGridViewFilterYes.Location = new System.Drawing.Point(311, 60);
            this.btnDataGridViewFilterYes.Name = "btnDataGridViewFilterYes";
            this.btnDataGridViewFilterYes.Size = new System.Drawing.Size(75, 23);
            this.btnDataGridViewFilterYes.TabIndex = 10;
            this.btnDataGridViewFilterYes.Text = "确定";
            this.btnDataGridViewFilterYes.UseVisualStyleBackColor = true;
            this.btnDataGridViewFilterYes.Click += new System.EventHandler(this.btnDataGridViewFilterYes_Click_1);
            // 
            // cboDataGridViewFilterField
            // 
            this.cboDataGridViewFilterField.FormattingEnabled = true;
            this.cboDataGridViewFilterField.Location = new System.Drawing.Point(6, 33);
            this.cboDataGridViewFilterField.Name = "cboDataGridViewFilterField";
            this.cboDataGridViewFilterField.Size = new System.Drawing.Size(170, 20);
            this.cboDataGridViewFilterField.TabIndex = 9;
            // 
            // lblDataGridViewFilterField
            // 
            this.lblDataGridViewFilterField.AutoSize = true;
            this.lblDataGridViewFilterField.Location = new System.Drawing.Point(6, 17);
            this.lblDataGridViewFilterField.Name = "lblDataGridViewFilterField";
            this.lblDataGridViewFilterField.Size = new System.Drawing.Size(29, 12);
            this.lblDataGridViewFilterField.TabIndex = 11;
            this.lblDataGridViewFilterField.Text = "字段";
            // 
            // txtDataGridViewFilterValue
            // 
            this.txtDataGridViewFilterValue.Location = new System.Drawing.Point(264, 33);
            this.txtDataGridViewFilterValue.Name = "txtDataGridViewFilterValue";
            this.txtDataGridViewFilterValue.Size = new System.Drawing.Size(122, 21);
            this.txtDataGridViewFilterValue.TabIndex = 14;
            // 
            // lblDataGridViewFilterFieldOperate
            // 
            this.lblDataGridViewFilterFieldOperate.AutoSize = true;
            this.lblDataGridViewFilterFieldOperate.Location = new System.Drawing.Point(183, 17);
            this.lblDataGridViewFilterFieldOperate.Name = "lblDataGridViewFilterFieldOperate";
            this.lblDataGridViewFilterFieldOperate.Size = new System.Drawing.Size(29, 12);
            this.lblDataGridViewFilterFieldOperate.TabIndex = 13;
            this.lblDataGridViewFilterFieldOperate.Text = "条件";
            // 
            // DataGridViewFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDataGridViewFilterTitle);
            this.Name = "DataGridViewFilter";
            this.Size = new System.Drawing.Size(400, 123);
            this.pnlDataGridViewFilterTitle.ResumeLayout(false);
            this.pnlDataGridViewFilterTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDataGridViewFilterClose;
        private System.Windows.Forms.Panel pnlDataGridViewFilterTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboDataGridViewFilterFieldOperate;
        private System.Windows.Forms.Label lblDataGridViewFilterValue;
        private System.Windows.Forms.Button btnDataGridViewFilterYes;
        private System.Windows.Forms.ComboBox cboDataGridViewFilterField;
        private System.Windows.Forms.Label lblDataGridViewFilterField;
        private System.Windows.Forms.TextBox txtDataGridViewFilterValue;
        private System.Windows.Forms.Label lblDataGridViewFilterFieldOperate;
        private System.Windows.Forms.Label lblDataGridViewFilterTitleName;
    }
}
