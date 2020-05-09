namespace StringTool
{
    partial class fmStringToolBox
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
            this.tabStringCompare = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.txtLeftStr = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtSplitByCustomStr = new System.Windows.Forms.TextBox();
            this.ckSplitByCustom = new System.Windows.Forms.CheckBox();
            this.lblleftData = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.txtLeftNotEqualStr = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblLeftMoreThenRightData = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.txtRightStr = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblRightData = new System.Windows.Forms.Label();
            this.txtRightNotEqualStr = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblRightMoreThenLeftData = new System.Windows.Forms.Label();
            this.txtEqualStr = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblEqualData = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtInputStr = new System.Windows.Forms.TextBox();
            this.gpTop = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFormmatJson = new System.Windows.Forms.Button();
            this.btnCreateArray = new System.Windows.Forms.Button();
            this.gpStringArray = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoStringDefault = new System.Windows.Forms.RadioButton();
            this.ckStringSplit = new System.Windows.Forms.CheckBox();
            this.txtStringSplit = new System.Windows.Forms.TextBox();
            this.rdoStringLower = new System.Windows.Forms.RadioButton();
            this.rdoStringUpper = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ckRowSplitChar = new System.Windows.Forms.CheckBox();
            this.txtRowSplitNewChar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRowSplitOldChar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ckDouHao = new System.Windows.Forms.CheckBox();
            this.ckXieGang = new System.Windows.Forms.CheckBox();
            this.ckShuangYin = new System.Windows.Forms.CheckBox();
            this.ckDanYin = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJsonVal = new System.Windows.Forms.TextBox();
            this.lblArrayFormateMode = new System.Windows.Forms.Label();
            this.rdoJsonArray = new System.Windows.Forms.RadioButton();
            this.rdoNormalArray = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtStringIncludeBefor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStringIncludeAfter = new System.Windows.Forms.TextBox();
            this.lblStringIncludeBefor = new System.Windows.Forms.Label();
            this.ckStringInclude = new System.Windows.Forms.CheckBox();
            this.tabDiff = new System.Windows.Forms.TabControl();
            this.ckIsSort = new System.Windows.Forms.CheckBox();
            this.tabStringCompare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpTop.SuspendLayout();
            this.gpStringArray.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabDiff.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabStringCompare
            // 
            this.tabStringCompare.Controls.Add(this.splitContainer1);
            this.tabStringCompare.Location = new System.Drawing.Point(4, 22);
            this.tabStringCompare.Name = "tabStringCompare";
            this.tabStringCompare.Padding = new System.Windows.Forms.Padding(3);
            this.tabStringCompare.Size = new System.Drawing.Size(1051, 718);
            this.tabStringCompare.TabIndex = 2;
            this.tabStringCompare.Text = "字符串比较";
            this.tabStringCompare.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtEqualStr);
            this.splitContainer1.Panel2.Controls.Add(this.panel10);
            this.splitContainer1.Size = new System.Drawing.Size(1045, 712);
            this.splitContainer1.SplitterDistance = 813;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(813, 712);
            this.splitContainer2.SplitterDistance = 418;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.txtLeftStr);
            this.splitContainer3.Panel1.Controls.Add(this.panel8);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.txtLeftNotEqualStr);
            this.splitContainer3.Panel2.Controls.Add(this.panel6);
            this.splitContainer3.Size = new System.Drawing.Size(418, 712);
            this.splitContainer3.SplitterDistance = 330;
            this.splitContainer3.TabIndex = 0;
            // 
            // txtLeftStr
            // 
            this.txtLeftStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLeftStr.Location = new System.Drawing.Point(0, 51);
            this.txtLeftStr.Multiline = true;
            this.txtLeftStr.Name = "txtLeftStr";
            this.txtLeftStr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLeftStr.Size = new System.Drawing.Size(418, 279);
            this.txtLeftStr.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.ckIsSort);
            this.panel8.Controls.Add(this.txtSplitByCustomStr);
            this.panel8.Controls.Add(this.ckSplitByCustom);
            this.panel8.Controls.Add(this.lblleftData);
            this.panel8.Controls.Add(this.btnCompare);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(418, 51);
            this.panel8.TabIndex = 3;
            // 
            // txtSplitByCustomStr
            // 
            this.txtSplitByCustomStr.Enabled = false;
            this.txtSplitByCustomStr.Location = new System.Drawing.Point(190, 11);
            this.txtSplitByCustomStr.MaxLength = 50;
            this.txtSplitByCustomStr.Name = "txtSplitByCustomStr";
            this.txtSplitByCustomStr.Size = new System.Drawing.Size(100, 21);
            this.txtSplitByCustomStr.TabIndex = 4;
            this.txtSplitByCustomStr.Text = ",";
            // 
            // ckSplitByCustom
            // 
            this.ckSplitByCustom.AutoSize = true;
            this.ckSplitByCustom.Location = new System.Drawing.Point(86, 13);
            this.ckSplitByCustom.Name = "ckSplitByCustom";
            this.ckSplitByCustom.Size = new System.Drawing.Size(96, 16);
            this.ckSplitByCustom.TabIndex = 3;
            this.ckSplitByCustom.Text = "自定义分隔符";
            this.ckSplitByCustom.UseVisualStyleBackColor = true;
            this.ckSplitByCustom.CheckedChanged += new System.EventHandler(this.ckSplitByCustom_CheckedChanged);
            // 
            // lblleftData
            // 
            this.lblleftData.AutoSize = true;
            this.lblleftData.Location = new System.Drawing.Point(3, 33);
            this.lblleftData.Name = "lblleftData";
            this.lblleftData.Size = new System.Drawing.Size(71, 12);
            this.lblleftData.TabIndex = 1;
            this.lblleftData.Text = "左边数据：0";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(3, 10);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 0;
            this.btnCompare.Text = "比较";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // txtLeftNotEqualStr
            // 
            this.txtLeftNotEqualStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLeftNotEqualStr.Location = new System.Drawing.Point(0, 51);
            this.txtLeftNotEqualStr.Multiline = true;
            this.txtLeftNotEqualStr.Name = "txtLeftNotEqualStr";
            this.txtLeftNotEqualStr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLeftNotEqualStr.Size = new System.Drawing.Size(418, 327);
            this.txtLeftNotEqualStr.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblLeftMoreThenRightData);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(418, 51);
            this.panel6.TabIndex = 2;
            // 
            // lblLeftMoreThenRightData
            // 
            this.lblLeftMoreThenRightData.AutoSize = true;
            this.lblLeftMoreThenRightData.Location = new System.Drawing.Point(5, 36);
            this.lblLeftMoreThenRightData.Name = "lblLeftMoreThenRightData";
            this.lblLeftMoreThenRightData.Size = new System.Drawing.Size(119, 12);
            this.lblLeftMoreThenRightData.TabIndex = 2;
            this.lblLeftMoreThenRightData.Text = "左边比右边多数据：0";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.txtRightStr);
            this.splitContainer4.Panel1.Controls.Add(this.panel9);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.txtRightNotEqualStr);
            this.splitContainer4.Panel2.Controls.Add(this.panel7);
            this.splitContainer4.Size = new System.Drawing.Size(391, 712);
            this.splitContainer4.SplitterDistance = 330;
            this.splitContainer4.TabIndex = 1;
            // 
            // txtRightStr
            // 
            this.txtRightStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRightStr.Location = new System.Drawing.Point(0, 51);
            this.txtRightStr.Multiline = true;
            this.txtRightStr.Name = "txtRightStr";
            this.txtRightStr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRightStr.Size = new System.Drawing.Size(391, 279);
            this.txtRightStr.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lblRightData);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(391, 51);
            this.panel9.TabIndex = 3;
            // 
            // lblRightData
            // 
            this.lblRightData.AutoSize = true;
            this.lblRightData.Location = new System.Drawing.Point(3, 33);
            this.lblRightData.Name = "lblRightData";
            this.lblRightData.Size = new System.Drawing.Size(95, 12);
            this.lblRightData.TabIndex = 2;
            this.lblRightData.Text = "右边右侧数据：0";
            // 
            // txtRightNotEqualStr
            // 
            this.txtRightNotEqualStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRightNotEqualStr.Location = new System.Drawing.Point(0, 51);
            this.txtRightNotEqualStr.Multiline = true;
            this.txtRightNotEqualStr.Name = "txtRightNotEqualStr";
            this.txtRightNotEqualStr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRightNotEqualStr.Size = new System.Drawing.Size(391, 327);
            this.txtRightNotEqualStr.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblRightMoreThenLeftData);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(391, 51);
            this.panel7.TabIndex = 3;
            // 
            // lblRightMoreThenLeftData
            // 
            this.lblRightMoreThenLeftData.AutoSize = true;
            this.lblRightMoreThenLeftData.Location = new System.Drawing.Point(3, 39);
            this.lblRightMoreThenLeftData.Name = "lblRightMoreThenLeftData";
            this.lblRightMoreThenLeftData.Size = new System.Drawing.Size(119, 12);
            this.lblRightMoreThenLeftData.TabIndex = 2;
            this.lblRightMoreThenLeftData.Text = "右边比左边多数据：0";
            // 
            // txtEqualStr
            // 
            this.txtEqualStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEqualStr.Location = new System.Drawing.Point(0, 51);
            this.txtEqualStr.Multiline = true;
            this.txtEqualStr.Name = "txtEqualStr";
            this.txtEqualStr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEqualStr.Size = new System.Drawing.Size(228, 661);
            this.txtEqualStr.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lblEqualData);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(228, 51);
            this.panel10.TabIndex = 3;
            // 
            // lblEqualData
            // 
            this.lblEqualData.AutoSize = true;
            this.lblEqualData.Location = new System.Drawing.Point(3, 33);
            this.lblEqualData.Name = "lblEqualData";
            this.lblEqualData.Size = new System.Drawing.Size(95, 12);
            this.lblEqualData.TabIndex = 2;
            this.lblEqualData.Text = "左右相同的值：0";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtResult);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1051, 718);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "结果";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 3);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(1045, 712);
            this.txtResult.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtInputStr);
            this.tabPage1.Controls.Add(this.gpTop);
            this.tabPage1.Controls.Add(this.gpStringArray);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1051, 718);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "字符串";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtInputStr
            // 
            this.txtInputStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputStr.Location = new System.Drawing.Point(3, 51);
            this.txtInputStr.Multiline = true;
            this.txtInputStr.Name = "txtInputStr";
            this.txtInputStr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInputStr.Size = new System.Drawing.Size(916, 664);
            this.txtInputStr.TabIndex = 0;
            // 
            // gpTop
            // 
            this.gpTop.Controls.Add(this.btnClear);
            this.gpTop.Controls.Add(this.btnFormmatJson);
            this.gpTop.Controls.Add(this.btnCreateArray);
            this.gpTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpTop.Location = new System.Drawing.Point(3, 3);
            this.gpTop.Name = "gpTop";
            this.gpTop.Size = new System.Drawing.Size(916, 48);
            this.gpTop.TabIndex = 24;
            this.gpTop.TabStop = false;
            this.gpTop.Text = "功能区";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(835, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFormmatJson
            // 
            this.btnFormmatJson.Location = new System.Drawing.Point(4, 14);
            this.btnFormmatJson.Name = "btnFormmatJson";
            this.btnFormmatJson.Size = new System.Drawing.Size(75, 23);
            this.btnFormmatJson.TabIndex = 1;
            this.btnFormmatJson.Text = "格式化Json";
            this.btnFormmatJson.UseVisualStyleBackColor = true;
            this.btnFormmatJson.Click += new System.EventHandler(this.btnFormmatJson_Click_1);
            // 
            // btnCreateArray
            // 
            this.btnCreateArray.Location = new System.Drawing.Point(86, 14);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(115, 23);
            this.btnCreateArray.TabIndex = 7;
            this.btnCreateArray.Text = "生成Array";
            this.btnCreateArray.UseVisualStyleBackColor = true;
            this.btnCreateArray.Click += new System.EventHandler(this.btnCreateArray_Click_2);
            // 
            // gpStringArray
            // 
            this.gpStringArray.Controls.Add(this.panel1);
            this.gpStringArray.Controls.Add(this.panel5);
            this.gpStringArray.Controls.Add(this.panel2);
            this.gpStringArray.Controls.Add(this.panel3);
            this.gpStringArray.Controls.Add(this.panel4);
            this.gpStringArray.Dock = System.Windows.Forms.DockStyle.Right;
            this.gpStringArray.Location = new System.Drawing.Point(919, 3);
            this.gpStringArray.Name = "gpStringArray";
            this.gpStringArray.Size = new System.Drawing.Size(129, 712);
            this.gpStringArray.TabIndex = 23;
            this.gpStringArray.TabStop = false;
            this.gpStringArray.Text = "字符串数组";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoStringDefault);
            this.panel1.Controls.Add(this.ckStringSplit);
            this.panel1.Controls.Add(this.txtStringSplit);
            this.panel1.Controls.Add(this.rdoStringLower);
            this.panel1.Controls.Add(this.rdoStringUpper);
            this.panel1.Location = new System.Drawing.Point(2, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 92);
            this.panel1.TabIndex = 27;
            // 
            // rdoStringDefault
            // 
            this.rdoStringDefault.AutoSize = true;
            this.rdoStringDefault.Checked = true;
            this.rdoStringDefault.Location = new System.Drawing.Point(4, 4);
            this.rdoStringDefault.Name = "rdoStringDefault";
            this.rdoStringDefault.Size = new System.Drawing.Size(47, 16);
            this.rdoStringDefault.TabIndex = 17;
            this.rdoStringDefault.TabStop = true;
            this.rdoStringDefault.Text = "默认";
            this.rdoStringDefault.UseVisualStyleBackColor = true;
            // 
            // ckStringSplit
            // 
            this.ckStringSplit.AutoSize = true;
            this.ckStringSplit.Checked = true;
            this.ckStringSplit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckStringSplit.Location = new System.Drawing.Point(4, 57);
            this.ckStringSplit.Name = "ckStringSplit";
            this.ckStringSplit.Size = new System.Drawing.Size(60, 16);
            this.ckStringSplit.TabIndex = 9;
            this.ckStringSplit.Text = "分割符";
            this.ckStringSplit.UseVisualStyleBackColor = true;
            // 
            // txtStringSplit
            // 
            this.txtStringSplit.Location = new System.Drawing.Point(78, 54);
            this.txtStringSplit.MaxLength = 1;
            this.txtStringSplit.Name = "txtStringSplit";
            this.txtStringSplit.Size = new System.Drawing.Size(38, 21);
            this.txtStringSplit.TabIndex = 10;
            this.txtStringSplit.Text = ",";
            // 
            // rdoStringLower
            // 
            this.rdoStringLower.AutoSize = true;
            this.rdoStringLower.Location = new System.Drawing.Point(4, 30);
            this.rdoStringLower.Name = "rdoStringLower";
            this.rdoStringLower.Size = new System.Drawing.Size(47, 16);
            this.rdoStringLower.TabIndex = 18;
            this.rdoStringLower.Text = "小写";
            this.rdoStringLower.UseVisualStyleBackColor = true;
            // 
            // rdoStringUpper
            // 
            this.rdoStringUpper.AutoSize = true;
            this.rdoStringUpper.Location = new System.Drawing.Point(69, 30);
            this.rdoStringUpper.Name = "rdoStringUpper";
            this.rdoStringUpper.Size = new System.Drawing.Size(47, 16);
            this.rdoStringUpper.TabIndex = 19;
            this.rdoStringUpper.Text = "大写";
            this.rdoStringUpper.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ckRowSplitChar);
            this.panel5.Controls.Add(this.txtRowSplitNewChar);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtRowSplitOldChar);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(2, 391);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(127, 92);
            this.panel5.TabIndex = 26;
            // 
            // ckRowSplitChar
            // 
            this.ckRowSplitChar.AutoSize = true;
            this.ckRowSplitChar.Location = new System.Drawing.Point(4, 8);
            this.ckRowSplitChar.Name = "ckRowSplitChar";
            this.ckRowSplitChar.Size = new System.Drawing.Size(72, 16);
            this.ckRowSplitChar.TabIndex = 25;
            this.ckRowSplitChar.Text = "行分隔符";
            this.ckRowSplitChar.UseVisualStyleBackColor = true;
            // 
            // txtRowSplitNewChar
            // 
            this.txtRowSplitNewChar.Location = new System.Drawing.Point(27, 49);
            this.txtRowSplitNewChar.Name = "txtRowSplitNewChar";
            this.txtRowSplitNewChar.Size = new System.Drawing.Size(89, 21);
            this.txtRowSplitNewChar.TabIndex = 23;
            this.txtRowSplitNewChar.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 54);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "新";
            // 
            // txtRowSplitOldChar
            // 
            this.txtRowSplitOldChar.Location = new System.Drawing.Point(27, 26);
            this.txtRowSplitOldChar.Name = "txtRowSplitOldChar";
            this.txtRowSplitOldChar.Size = new System.Drawing.Size(89, 21);
            this.txtRowSplitOldChar.TabIndex = 21;
            this.txtRowSplitOldChar.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 31);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "原";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ckDouHao);
            this.panel2.Controls.Add(this.ckXieGang);
            this.panel2.Controls.Add(this.ckShuangYin);
            this.panel2.Controls.Add(this.ckDanYin);
            this.panel2.Location = new System.Drawing.Point(2, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 92);
            this.panel2.TabIndex = 25;
            // 
            // ckDouHao
            // 
            this.ckDouHao.AutoSize = true;
            this.ckDouHao.Location = new System.Drawing.Point(4, 70);
            this.ckDouHao.Name = "ckDouHao";
            this.ckDouHao.Size = new System.Drawing.Size(78, 16);
            this.ckDouHao.TabIndex = 13;
            this.ckDouHao.Text = "半角\'转义";
            this.ckDouHao.UseVisualStyleBackColor = true;
            // 
            // ckXieGang
            // 
            this.ckXieGang.AutoSize = true;
            this.ckXieGang.Location = new System.Drawing.Point(4, 48);
            this.ckXieGang.Name = "ckXieGang";
            this.ckXieGang.Size = new System.Drawing.Size(78, 16);
            this.ckXieGang.TabIndex = 12;
            this.ckXieGang.Text = "半角\\转义";
            this.ckXieGang.UseVisualStyleBackColor = true;
            // 
            // ckShuangYin
            // 
            this.ckShuangYin.AutoSize = true;
            this.ckShuangYin.Location = new System.Drawing.Point(4, 26);
            this.ckShuangYin.Name = "ckShuangYin";
            this.ckShuangYin.Size = new System.Drawing.Size(78, 16);
            this.ckShuangYin.TabIndex = 11;
            this.ckShuangYin.Text = "半角\"转义";
            this.ckShuangYin.UseVisualStyleBackColor = true;
            // 
            // ckDanYin
            // 
            this.ckDanYin.AutoSize = true;
            this.ckDanYin.Location = new System.Drawing.Point(4, 4);
            this.ckDanYin.Name = "ckDanYin";
            this.ckDanYin.Size = new System.Drawing.Size(78, 16);
            this.ckDanYin.TabIndex = 10;
            this.ckDanYin.Text = "半角\'转义";
            this.ckDanYin.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtJsonVal);
            this.panel3.Controls.Add(this.lblArrayFormateMode);
            this.panel3.Controls.Add(this.rdoJsonArray);
            this.panel3.Controls.Add(this.rdoNormalArray);
            this.panel3.Location = new System.Drawing.Point(2, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 92);
            this.panel3.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 51);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "值";
            // 
            // txtJsonVal
            // 
            this.txtJsonVal.Location = new System.Drawing.Point(27, 48);
            this.txtJsonVal.Name = "txtJsonVal";
            this.txtJsonVal.Size = new System.Drawing.Size(89, 21);
            this.txtJsonVal.TabIndex = 3;
            // 
            // lblArrayFormateMode
            // 
            this.lblArrayFormateMode.AutoSize = true;
            this.lblArrayFormateMode.Location = new System.Drawing.Point(4, 4);
            this.lblArrayFormateMode.Name = "lblArrayFormateMode";
            this.lblArrayFormateMode.Size = new System.Drawing.Size(53, 12);
            this.lblArrayFormateMode.TabIndex = 2;
            this.lblArrayFormateMode.Text = "数组格式";
            // 
            // rdoJsonArray
            // 
            this.rdoJsonArray.AutoSize = true;
            this.rdoJsonArray.Location = new System.Drawing.Point(69, 25);
            this.rdoJsonArray.Name = "rdoJsonArray";
            this.rdoJsonArray.Size = new System.Drawing.Size(47, 16);
            this.rdoJsonArray.TabIndex = 1;
            this.rdoJsonArray.Text = "JSON";
            this.rdoJsonArray.UseVisualStyleBackColor = true;
            // 
            // rdoNormalArray
            // 
            this.rdoNormalArray.AutoSize = true;
            this.rdoNormalArray.Checked = true;
            this.rdoNormalArray.Location = new System.Drawing.Point(4, 25);
            this.rdoNormalArray.Name = "rdoNormalArray";
            this.rdoNormalArray.Size = new System.Drawing.Size(47, 16);
            this.rdoNormalArray.TabIndex = 0;
            this.rdoNormalArray.TabStop = true;
            this.rdoNormalArray.Text = "普通";
            this.rdoNormalArray.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtStringIncludeBefor);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtStringIncludeAfter);
            this.panel4.Controls.Add(this.lblStringIncludeBefor);
            this.panel4.Controls.Add(this.ckStringInclude);
            this.panel4.Location = new System.Drawing.Point(2, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(127, 92);
            this.panel4.TabIndex = 22;
            // 
            // txtStringIncludeBefor
            // 
            this.txtStringIncludeBefor.Location = new System.Drawing.Point(27, 29);
            this.txtStringIncludeBefor.Name = "txtStringIncludeBefor";
            this.txtStringIncludeBefor.Size = new System.Drawing.Size(89, 21);
            this.txtStringIncludeBefor.TabIndex = 12;
            this.txtStringIncludeBefor.Text = "\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 61);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "后";
            // 
            // txtStringIncludeAfter
            // 
            this.txtStringIncludeAfter.Location = new System.Drawing.Point(27, 56);
            this.txtStringIncludeAfter.Name = "txtStringIncludeAfter";
            this.txtStringIncludeAfter.Size = new System.Drawing.Size(89, 21);
            this.txtStringIncludeAfter.TabIndex = 14;
            this.txtStringIncludeAfter.Text = "\"";
            // 
            // lblStringIncludeBefor
            // 
            this.lblStringIncludeBefor.AutoSize = true;
            this.lblStringIncludeBefor.Location = new System.Drawing.Point(4, 34);
            this.lblStringIncludeBefor.Name = "lblStringIncludeBefor";
            this.lblStringIncludeBefor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStringIncludeBefor.Size = new System.Drawing.Size(17, 12);
            this.lblStringIncludeBefor.TabIndex = 20;
            this.lblStringIncludeBefor.Text = "前";
            // 
            // ckStringInclude
            // 
            this.ckStringInclude.AutoSize = true;
            this.ckStringInclude.Location = new System.Drawing.Point(4, 7);
            this.ckStringInclude.Name = "ckStringInclude";
            this.ckStringInclude.Size = new System.Drawing.Size(48, 16);
            this.ckStringInclude.TabIndex = 15;
            this.ckStringInclude.Text = "包裹";
            this.ckStringInclude.UseVisualStyleBackColor = true;
            // 
            // tabDiff
            // 
            this.tabDiff.Controls.Add(this.tabPage1);
            this.tabDiff.Controls.Add(this.tabPage2);
            this.tabDiff.Controls.Add(this.tabStringCompare);
            this.tabDiff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDiff.Location = new System.Drawing.Point(0, 0);
            this.tabDiff.Name = "tabDiff";
            this.tabDiff.SelectedIndex = 0;
            this.tabDiff.Size = new System.Drawing.Size(1059, 744);
            this.tabDiff.TabIndex = 1;
            // 
            // ckIsSort
            // 
            this.ckIsSort.AutoSize = true;
            this.ckIsSort.Location = new System.Drawing.Point(296, 13);
            this.ckIsSort.Name = "ckIsSort";
            this.ckIsSort.Size = new System.Drawing.Size(96, 16);
            this.ckIsSort.TabIndex = 5;
            this.ckIsSort.Text = "对比结果排序";
            this.ckIsSort.UseVisualStyleBackColor = true;
            // 
            // fmStringToolBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 744);
            this.Controls.Add(this.tabDiff);
            this.Name = "fmStringToolBox";
            this.Text = "字符串工具箱";
            this.tabStringCompare.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gpTop.ResumeLayout(false);
            this.gpStringArray.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabDiff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabStringCompare;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox txtLeftStr;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtSplitByCustomStr;
        private System.Windows.Forms.CheckBox ckSplitByCustom;
        private System.Windows.Forms.Label lblleftData;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox txtLeftNotEqualStr;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblLeftMoreThenRightData;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TextBox txtRightStr;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblRightData;
        private System.Windows.Forms.TextBox txtRightNotEqualStr;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblRightMoreThenLeftData;
        private System.Windows.Forms.TextBox txtEqualStr;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblEqualData;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtInputStr;
        private System.Windows.Forms.GroupBox gpTop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFormmatJson;
        private System.Windows.Forms.Button btnCreateArray;
        private System.Windows.Forms.GroupBox gpStringArray;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoStringDefault;
        private System.Windows.Forms.CheckBox ckStringSplit;
        private System.Windows.Forms.TextBox txtStringSplit;
        private System.Windows.Forms.RadioButton rdoStringLower;
        private System.Windows.Forms.RadioButton rdoStringUpper;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox ckRowSplitChar;
        private System.Windows.Forms.TextBox txtRowSplitNewChar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRowSplitOldChar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ckDouHao;
        private System.Windows.Forms.CheckBox ckXieGang;
        private System.Windows.Forms.CheckBox ckShuangYin;
        private System.Windows.Forms.CheckBox ckDanYin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJsonVal;
        private System.Windows.Forms.Label lblArrayFormateMode;
        private System.Windows.Forms.RadioButton rdoJsonArray;
        private System.Windows.Forms.RadioButton rdoNormalArray;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtStringIncludeBefor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStringIncludeAfter;
        private System.Windows.Forms.Label lblStringIncludeBefor;
        private System.Windows.Forms.CheckBox ckStringInclude;
        private System.Windows.Forms.TabControl tabDiff;
        private System.Windows.Forms.CheckBox ckIsSort;
    }
}