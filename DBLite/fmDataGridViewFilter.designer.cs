namespace DBLite
{
    partial class fmDataGridViewFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDataGridViewFilter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tvDataGridViewFilterItem = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLeftlogicOr = new System.Windows.Forms.Button();
            this.btnLeftlogicAnd = new System.Windows.Forms.Button();
            this.btnRightBrackets = new System.Windows.Forms.Button();
            this.btnLeftBrackets = new System.Windows.Forms.Button();
            this.btnDataGridViewAppendFilterDel = new System.Windows.Forms.Button();
            this.btnDataGridViewAppendFilter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboRightBrackets = new System.Windows.Forms.ComboBox();
            this.cboLogicOpStr = new System.Windows.Forms.ComboBox();
            this.cboLeftBrackets = new System.Windows.Forms.ComboBox();
            this.cboDataGridViewFilterField = new System.Windows.Forms.ComboBox();
            this.lblDataGridViewFilterFieldOperate = new System.Windows.Forms.Label();
            this.cboDataGridViewFilterFieldOperate = new System.Windows.Forms.ComboBox();
            this.txtDataGridViewFilterValue = new System.Windows.Forms.TextBox();
            this.lblDataGridViewFilterValue = new System.Windows.Forms.Label();
            this.lblDataGridViewFilterField = new System.Windows.Forms.Label();
            this.btnDataGridViewFilterYes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tvDataGridViewFilterItem);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 321);
            this.panel1.TabIndex = 12;
            // 
            // tvDataGridViewFilterItem
            // 
            this.tvDataGridViewFilterItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDataGridViewFilterItem.Location = new System.Drawing.Point(0, 54);
            this.tvDataGridViewFilterItem.Name = "tvDataGridViewFilterItem";
            this.tvDataGridViewFilterItem.Size = new System.Drawing.Size(512, 267);
            this.tvDataGridViewFilterItem.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLeftlogicOr);
            this.panel3.Controls.Add(this.btnLeftlogicAnd);
            this.panel3.Controls.Add(this.btnRightBrackets);
            this.panel3.Controls.Add(this.btnLeftBrackets);
            this.panel3.Controls.Add(this.btnDataGridViewAppendFilterDel);
            this.panel3.Controls.Add(this.btnDataGridViewAppendFilter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(512, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(87, 267);
            this.panel3.TabIndex = 19;
            // 
            // btnLeftlogicOr
            // 
            this.btnLeftlogicOr.Location = new System.Drawing.Point(6, 139);
            this.btnLeftlogicOr.Name = "btnLeftlogicOr";
            this.btnLeftlogicOr.Size = new System.Drawing.Size(75, 23);
            this.btnLeftlogicOr.TabIndex = 22;
            this.btnLeftlogicOr.Text = "OR";
            this.btnLeftlogicOr.UseVisualStyleBackColor = true;
            this.btnLeftlogicOr.Click += new System.EventHandler(this.btnLeftlogicOr_Click);
            // 
            // btnLeftlogicAnd
            // 
            this.btnLeftlogicAnd.Location = new System.Drawing.Point(6, 113);
            this.btnLeftlogicAnd.Name = "btnLeftlogicAnd";
            this.btnLeftlogicAnd.Size = new System.Drawing.Size(75, 23);
            this.btnLeftlogicAnd.TabIndex = 21;
            this.btnLeftlogicAnd.Text = " AND";
            this.btnLeftlogicAnd.UseVisualStyleBackColor = true;
            this.btnLeftlogicAnd.Click += new System.EventHandler(this.btnLeftlogicAnd_Click);
            // 
            // btnRightBrackets
            // 
            this.btnRightBrackets.Location = new System.Drawing.Point(6, 71);
            this.btnRightBrackets.Name = "btnRightBrackets";
            this.btnRightBrackets.Size = new System.Drawing.Size(75, 23);
            this.btnRightBrackets.TabIndex = 20;
            this.btnRightBrackets.Text = "  ) ";
            this.btnRightBrackets.UseVisualStyleBackColor = true;
            this.btnRightBrackets.Click += new System.EventHandler(this.btnRightBrackets_Click);
            // 
            // btnLeftBrackets
            // 
            this.btnLeftBrackets.Location = new System.Drawing.Point(6, 45);
            this.btnLeftBrackets.Name = "btnLeftBrackets";
            this.btnLeftBrackets.Size = new System.Drawing.Size(75, 23);
            this.btnLeftBrackets.TabIndex = 19;
            this.btnLeftBrackets.Text = " ( ";
            this.btnLeftBrackets.UseVisualStyleBackColor = true;
            this.btnLeftBrackets.Click += new System.EventHandler(this.btnLeftBrackets_Click);
            // 
            // btnDataGridViewAppendFilterDel
            // 
            this.btnDataGridViewAppendFilterDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDataGridViewAppendFilterDel.Location = new System.Drawing.Point(6, 241);
            this.btnDataGridViewAppendFilterDel.Name = "btnDataGridViewAppendFilterDel";
            this.btnDataGridViewAppendFilterDel.Size = new System.Drawing.Size(75, 23);
            this.btnDataGridViewAppendFilterDel.TabIndex = 18;
            this.btnDataGridViewAppendFilterDel.Text = "删除";
            this.btnDataGridViewAppendFilterDel.UseVisualStyleBackColor = true;
            this.btnDataGridViewAppendFilterDel.Click += new System.EventHandler(this.btnDataGridViewAppendFilterDel_Click);
            // 
            // btnDataGridViewAppendFilter
            // 
            this.btnDataGridViewAppendFilter.Location = new System.Drawing.Point(6, 7);
            this.btnDataGridViewAppendFilter.Name = "btnDataGridViewAppendFilter";
            this.btnDataGridViewAppendFilter.Size = new System.Drawing.Size(75, 23);
            this.btnDataGridViewAppendFilter.TabIndex = 16;
            this.btnDataGridViewAppendFilter.Text = "追加筛选";
            this.btnDataGridViewAppendFilter.UseVisualStyleBackColor = true;
            this.btnDataGridViewAppendFilter.Click += new System.EventHandler(this.btnDataGridViewAppendFilter_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboRightBrackets);
            this.panel2.Controls.Add(this.cboLogicOpStr);
            this.panel2.Controls.Add(this.cboLeftBrackets);
            this.panel2.Controls.Add(this.cboDataGridViewFilterField);
            this.panel2.Controls.Add(this.lblDataGridViewFilterFieldOperate);
            this.panel2.Controls.Add(this.cboDataGridViewFilterFieldOperate);
            this.panel2.Controls.Add(this.txtDataGridViewFilterValue);
            this.panel2.Controls.Add(this.lblDataGridViewFilterValue);
            this.panel2.Controls.Add(this.lblDataGridViewFilterField);
            this.panel2.Controls.Add(this.btnDataGridViewFilterYes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 54);
            this.panel2.TabIndex = 17;
            // 
            // cboRightBrackets
            // 
            this.cboRightBrackets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRightBrackets.FormattingEnabled = true;
            this.cboRightBrackets.Items.AddRange(new object[] {
            ")"});
            this.cboRightBrackets.Location = new System.Drawing.Point(455, 24);
            this.cboRightBrackets.Name = "cboRightBrackets";
            this.cboRightBrackets.Size = new System.Drawing.Size(45, 20);
            this.cboRightBrackets.TabIndex = 18;
            this.cboRightBrackets.SelectedIndexChanged += new System.EventHandler(this.cboRightBrackets_SelectedIndexChanged);
            // 
            // cboLogicOpStr
            // 
            this.cboLogicOpStr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLogicOpStr.FormattingEnabled = true;
            this.cboLogicOpStr.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cboLogicOpStr.Location = new System.Drawing.Point(54, 24);
            this.cboLogicOpStr.Name = "cboLogicOpStr";
            this.cboLogicOpStr.Size = new System.Drawing.Size(45, 20);
            this.cboLogicOpStr.TabIndex = 17;
            // 
            // cboLeftBrackets
            // 
            this.cboLeftBrackets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLeftBrackets.FormattingEnabled = true;
            this.cboLeftBrackets.Items.AddRange(new object[] {
            "("});
            this.cboLeftBrackets.Location = new System.Drawing.Point(6, 24);
            this.cboLeftBrackets.Name = "cboLeftBrackets";
            this.cboLeftBrackets.Size = new System.Drawing.Size(45, 20);
            this.cboLeftBrackets.TabIndex = 16;
            this.cboLeftBrackets.SelectedIndexChanged += new System.EventHandler(this.cboLeftBrackets_SelectedIndexChanged);
            // 
            // cboDataGridViewFilterField
            // 
            this.cboDataGridViewFilterField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataGridViewFilterField.FormattingEnabled = true;
            this.cboDataGridViewFilterField.Location = new System.Drawing.Point(104, 24);
            this.cboDataGridViewFilterField.Name = "cboDataGridViewFilterField";
            this.cboDataGridViewFilterField.Size = new System.Drawing.Size(156, 20);
            this.cboDataGridViewFilterField.TabIndex = 9;
            // 
            // lblDataGridViewFilterFieldOperate
            // 
            this.lblDataGridViewFilterFieldOperate.AutoSize = true;
            this.lblDataGridViewFilterFieldOperate.Location = new System.Drawing.Point(264, 8);
            this.lblDataGridViewFilterFieldOperate.Name = "lblDataGridViewFilterFieldOperate";
            this.lblDataGridViewFilterFieldOperate.Size = new System.Drawing.Size(29, 12);
            this.lblDataGridViewFilterFieldOperate.TabIndex = 13;
            this.lblDataGridViewFilterFieldOperate.Text = "条件";
            // 
            // cboDataGridViewFilterFieldOperate
            // 
            this.cboDataGridViewFilterFieldOperate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataGridViewFilterFieldOperate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboDataGridViewFilterFieldOperate.FormattingEnabled = true;
            this.cboDataGridViewFilterFieldOperate.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            "LIKE",
            "<>",
            ">=",
            "<="});
            this.cboDataGridViewFilterFieldOperate.Location = new System.Drawing.Point(266, 24);
            this.cboDataGridViewFilterFieldOperate.Name = "cboDataGridViewFilterFieldOperate";
            this.cboDataGridViewFilterFieldOperate.Size = new System.Drawing.Size(70, 20);
            this.cboDataGridViewFilterFieldOperate.TabIndex = 12;
            // 
            // txtDataGridViewFilterValue
            // 
            this.txtDataGridViewFilterValue.Location = new System.Drawing.Point(345, 24);
            this.txtDataGridViewFilterValue.Name = "txtDataGridViewFilterValue";
            this.txtDataGridViewFilterValue.Size = new System.Drawing.Size(104, 21);
            this.txtDataGridViewFilterValue.TabIndex = 14;
            // 
            // lblDataGridViewFilterValue
            // 
            this.lblDataGridViewFilterValue.AutoSize = true;
            this.lblDataGridViewFilterValue.Location = new System.Drawing.Point(343, 8);
            this.lblDataGridViewFilterValue.Name = "lblDataGridViewFilterValue";
            this.lblDataGridViewFilterValue.Size = new System.Drawing.Size(17, 12);
            this.lblDataGridViewFilterValue.TabIndex = 15;
            this.lblDataGridViewFilterValue.Text = "值";
            // 
            // lblDataGridViewFilterField
            // 
            this.lblDataGridViewFilterField.AutoSize = true;
            this.lblDataGridViewFilterField.Location = new System.Drawing.Point(104, 8);
            this.lblDataGridViewFilterField.Name = "lblDataGridViewFilterField";
            this.lblDataGridViewFilterField.Size = new System.Drawing.Size(29, 12);
            this.lblDataGridViewFilterField.TabIndex = 11;
            this.lblDataGridViewFilterField.Text = "字段";
            // 
            // btnDataGridViewFilterYes
            // 
            this.btnDataGridViewFilterYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDataGridViewFilterYes.Location = new System.Drawing.Point(516, 23);
            this.btnDataGridViewFilterYes.Name = "btnDataGridViewFilterYes";
            this.btnDataGridViewFilterYes.Size = new System.Drawing.Size(75, 23);
            this.btnDataGridViewFilterYes.TabIndex = 10;
            this.btnDataGridViewFilterYes.Text = "筛选";
            this.btnDataGridViewFilterYes.UseVisualStyleBackColor = true;
            this.btnDataGridViewFilterYes.Click += new System.EventHandler(this.btnDataGridViewFilterYes_Click);
            // 
            // fmDataGridViewFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 321);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(615, 360);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(615, 360);
            this.Name = "fmDataGridViewFilter";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "表数据过滤";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmDataGridViewFilter_FormClosed);
            this.Load += new System.EventHandler(this.fmDataGridViewFilter_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboDataGridViewFilterFieldOperate;
        private System.Windows.Forms.Label lblDataGridViewFilterValue;
        private System.Windows.Forms.Button btnDataGridViewFilterYes;
        private System.Windows.Forms.ComboBox cboDataGridViewFilterField;
        private System.Windows.Forms.Label lblDataGridViewFilterField;
        private System.Windows.Forms.TextBox txtDataGridViewFilterValue;
        private System.Windows.Forms.Label lblDataGridViewFilterFieldOperate;
        private System.Windows.Forms.Button btnDataGridViewAppendFilter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tvDataGridViewFilterItem;
        private System.Windows.Forms.Button btnDataGridViewAppendFilterDel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboRightBrackets;
        private System.Windows.Forms.ComboBox cboLogicOpStr;
        private System.Windows.Forms.ComboBox cboLeftBrackets;
        private System.Windows.Forms.Button btnRightBrackets;
        private System.Windows.Forms.Button btnLeftBrackets;
        private System.Windows.Forms.Button btnLeftlogicOr;
        private System.Windows.Forms.Button btnLeftlogicAnd;
    }
}