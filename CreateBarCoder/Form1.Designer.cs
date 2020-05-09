namespace CreateBarCoder
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
            this.components = new System.ComponentModel.Container();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numTop = new System.Windows.Forms.NumericUpDown();
            this.numLeft = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnBarCoderPrint = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxAspectRatio = new System.Windows.Forms.TextBox();
            this.textBoxBarWidth = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkGenerateLabel = new System.Windows.Forms.CheckBox();
            this.cbLabelLocation = new System.Windows.Forms.ComboBox();
            this.lblLabelLocation = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbRotateFlip = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEncoded = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.cbBarcodeAlign = new System.Windows.Forms.ComboBox();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEncodingTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEncodeType = new System.Windows.Forms.ComboBox();
            this.gbxBarCoder = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnEncodeQRCoder = new System.Windows.Forms.Button();
            this.btnQRCoderPrint = new System.Windows.Forms.Button();
            this.gbxQRCoder = new System.Windows.Forms.GroupBox();
            this.numPixelsPerModule = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSaveQRCoder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPixelsPerModule)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("宋体", 18F);
            this.txtContent.Location = new System.Drawing.Point(7, 20);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(767, 35);
            this.txtContent.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numTop);
            this.groupBox1.Controls.Add(this.numLeft);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtContent);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 99);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "标签内容";
            // 
            // numTop
            // 
            this.numTop.Font = new System.Drawing.Font("宋体", 12F);
            this.numTop.Location = new System.Drawing.Point(329, 67);
            this.numTop.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numTop.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numTop.Name = "numTop";
            this.numTop.Size = new System.Drawing.Size(120, 26);
            this.numTop.TabIndex = 53;
            this.numTop.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numLeft
            // 
            this.numLeft.Font = new System.Drawing.Font("宋体", 12F);
            this.numLeft.Location = new System.Drawing.Point(143, 67);
            this.numLeft.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numLeft.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numLeft.Name = "numLeft";
            this.numLeft.Size = new System.Drawing.Size(120, 26);
            this.numLeft.TabIndex = 52;
            this.numLeft.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(267, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "上边距";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.Location = new System.Drawing.Point(5, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 16);
            this.label11.TabIndex = 50;
            this.label11.Text = "打印位置  左边距";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "条码工具";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnBarCoderPrint);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.cbRotateFlip);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.btnEncode);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtEncoded);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.btnBackColor);
            this.splitContainer1.Panel1.Controls.Add(this.cbBarcodeAlign);
            this.splitContainer1.Panel1.Controls.Add(this.btnForeColor);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.lblEncodingTime);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.cbEncodeType);
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbxBarCoder);
            this.splitContainer1.Size = new System.Drawing.Size(786, 339);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 38;
            // 
            // btnBarCoderPrint
            // 
            this.btnBarCoderPrint.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBarCoderPrint.FlatAppearance.BorderSize = 0;
            this.btnBarCoderPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarCoderPrint.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBarCoderPrint.ForeColor = System.Drawing.Color.White;
            this.btnBarCoderPrint.Location = new System.Drawing.Point(8, 289);
            this.btnBarCoderPrint.Margin = new System.Windows.Forms.Padding(0);
            this.btnBarCoderPrint.Name = "btnBarCoderPrint";
            this.btnBarCoderPrint.Size = new System.Drawing.Size(238, 47);
            this.btnBarCoderPrint.TabIndex = 79;
            this.btnBarCoderPrint.Text = "打印";
            this.btnBarCoderPrint.UseVisualStyleBackColor = false;
            this.btnBarCoderPrint.Click += new System.EventHandler(this.btnBarCoderPrint_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxAspectRatio);
            this.groupBox4.Controls.Add(this.textBoxBarWidth);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtWidth);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtHeight);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(136, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(110, 112);
            this.groupBox4.TabIndex = 78;
            this.groupBox4.TabStop = false;
            // 
            // textBoxAspectRatio
            // 
            this.textBoxAspectRatio.Location = new System.Drawing.Point(59, 71);
            this.textBoxAspectRatio.Name = "textBoxAspectRatio";
            this.textBoxAspectRatio.Size = new System.Drawing.Size(35, 21);
            this.textBoxAspectRatio.TabIndex = 55;
            // 
            // textBoxBarWidth
            // 
            this.textBoxBarWidth.Location = new System.Drawing.Point(16, 71);
            this.textBoxBarWidth.Name = "textBoxBarWidth";
            this.textBoxBarWidth.Size = new System.Drawing.Size(35, 21);
            this.textBoxBarWidth.TabIndex = 54;
            this.textBoxBarWidth.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 53;
            this.label13.Text = "纵横比";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 52;
            this.label12.Text = "净宽";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(16, 27);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(35, 21);
            this.txtWidth.TabIndex = 43;
            this.txtWidth.Text = "300";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 41;
            this.label7.Text = "宽";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 42;
            this.label6.Text = "高";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(59, 27);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(35, 21);
            this.txtHeight.TabIndex = 44;
            this.txtHeight.Text = "150";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 51;
            this.label9.Text = "x";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkGenerateLabel);
            this.groupBox3.Controls.Add(this.cbLabelLocation);
            this.groupBox3.Controls.Add(this.lblLabelLocation);
            this.groupBox3.Location = new System.Drawing.Point(136, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 79);
            this.groupBox3.TabIndex = 77;
            this.groupBox3.TabStop = false;
            // 
            // chkGenerateLabel
            // 
            this.chkGenerateLabel.AutoSize = true;
            this.chkGenerateLabel.Checked = true;
            this.chkGenerateLabel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenerateLabel.Location = new System.Drawing.Point(6, 15);
            this.chkGenerateLabel.Name = "chkGenerateLabel";
            this.chkGenerateLabel.Size = new System.Drawing.Size(72, 16);
            this.chkGenerateLabel.TabIndex = 40;
            this.chkGenerateLabel.Text = "包含标签";
            this.chkGenerateLabel.UseVisualStyleBackColor = true;
            // 
            // cbLabelLocation
            // 
            this.cbLabelLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLabelLocation.FormattingEnabled = true;
            this.cbLabelLocation.Items.AddRange(new object[] {
            "BottomCenter",
            "BottomLeft",
            "BottomRight",
            "TopCenter",
            "TopLeft",
            "TopRight"});
            this.cbLabelLocation.Location = new System.Drawing.Point(6, 55);
            this.cbLabelLocation.Name = "cbLabelLocation";
            this.cbLabelLocation.Size = new System.Drawing.Size(90, 20);
            this.cbLabelLocation.TabIndex = 0;
            // 
            // lblLabelLocation
            // 
            this.lblLabelLocation.AutoSize = true;
            this.lblLabelLocation.Location = new System.Drawing.Point(3, 40);
            this.lblLabelLocation.Name = "lblLabelLocation";
            this.lblLabelLocation.Size = new System.Drawing.Size(77, 12);
            this.lblLabelLocation.TabIndex = 48;
            this.lblLabelLocation.Text = "条码标签位置";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 76;
            this.label10.Text = "旋转";
            // 
            // cbRotateFlip
            // 
            this.cbRotateFlip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRotateFlip.FormattingEnabled = true;
            this.cbRotateFlip.Items.AddRange(new object[] {
            "Center",
            "Left",
            "Right"});
            this.cbRotateFlip.Location = new System.Drawing.Point(7, 64);
            this.cbRotateFlip.Name = "cbRotateFlip";
            this.cbRotateFlip.Size = new System.Drawing.Size(108, 20);
            this.cbRotateFlip.TabIndex = 75;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(177, 243);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 42);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 74;
            this.label8.Text = "对齐";
            // 
            // btnEncode
            // 
            this.btnEncode.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEncode.FlatAppearance.BorderSize = 0;
            this.btnEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEncode.ForeColor = System.Drawing.Color.White;
            this.btnEncode.Location = new System.Drawing.Point(7, 243);
            this.btnEncode.Margin = new System.Windows.Forms.Padding(0);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(159, 42);
            this.btnEncode.TabIndex = 60;
            this.btnEncode.Text = "输出条码";
            this.btnEncode.UseVisualStyleBackColor = false;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 68;
            this.label4.Text = "颜色";
            // 
            // txtEncoded
            // 
            this.txtEncoded.Location = new System.Drawing.Point(7, 204);
            this.txtEncoded.Multiline = true;
            this.txtEncoded.Name = "txtEncoded";
            this.txtEncoded.ReadOnly = true;
            this.txtEncoded.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncoded.Size = new System.Drawing.Size(238, 34);
            this.txtEncoded.TabIndex = 62;
            this.txtEncoded.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 69;
            this.label5.Text = "背景色";
            // 
            // btnBackColor
            // 
            this.btnBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackColor.Location = new System.Drawing.Point(72, 143);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(58, 21);
            this.btnBackColor.TabIndex = 67;
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // cbBarcodeAlign
            // 
            this.cbBarcodeAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBarcodeAlign.FormattingEnabled = true;
            this.cbBarcodeAlign.Items.AddRange(new object[] {
            "Center",
            "Left",
            "Right"});
            this.cbBarcodeAlign.Location = new System.Drawing.Point(7, 103);
            this.cbBarcodeAlign.Name = "cbBarcodeAlign";
            this.cbBarcodeAlign.Size = new System.Drawing.Size(107, 20);
            this.cbBarcodeAlign.TabIndex = 73;
            // 
            // btnForeColor
            // 
            this.btnForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForeColor.Location = new System.Drawing.Point(7, 143);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(58, 21);
            this.btnForeColor.TabIndex = 66;
            this.btnForeColor.UseVisualStyleBackColor = true;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 64;
            this.label2.Text = "Encoded Value";
            // 
            // lblEncodingTime
            // 
            this.lblEncodingTime.AutoSize = true;
            this.lblEncodingTime.Location = new System.Drawing.Point(83, 171);
            this.lblEncodingTime.Name = "lblEncodingTime";
            this.lblEncodingTime.Size = new System.Drawing.Size(0, 12);
            this.lblEncodingTime.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 65;
            this.label3.Text = "编码类型";
            // 
            // cbEncodeType
            // 
            this.cbEncodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncodeType.FormattingEnabled = true;
            this.cbEncodeType.ItemHeight = 12;
            this.cbEncodeType.Items.AddRange(new object[] {
            "UPC-A",
            "UPC-E",
            "UPC 2 Digit Ext.",
            "UPC 5 Digit Ext.",
            "EAN-13",
            "JAN-13",
            "EAN-8",
            "ITF-14",
            "Interleaved 2 of 5",
            "Standard 2 of 5",
            "Codabar",
            "PostNet",
            "Bookland/ISBN",
            "Code 11",
            "Code 39",
            "Code 39 Extended",
            "Code 39 Mod 43",
            "Code 93",
            "Code 128",
            "Code 128-A",
            "Code 128-B",
            "Code 128-C",
            "LOGMARS",
            "MSI",
            "Telepen",
            "FIM",
            "Pharmacode"});
            this.cbEncodeType.Location = new System.Drawing.Point(7, 25);
            this.cbEncodeType.Name = "cbEncodeType";
            this.cbEncodeType.Size = new System.Drawing.Size(108, 20);
            this.cbEncodeType.TabIndex = 59;
            // 
            // gbxBarCoder
            // 
            this.gbxBarCoder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbxBarCoder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxBarCoder.Location = new System.Drawing.Point(0, 0);
            this.gbxBarCoder.Name = "gbxBarCoder";
            this.gbxBarCoder.Size = new System.Drawing.Size(521, 339);
            this.gbxBarCoder.TabIndex = 36;
            this.gbxBarCoder.TabStop = false;
            this.gbxBarCoder.Text = "条码图片";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 393);
            this.tabControl1.TabIndex = 56;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "二维码工具";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnSaveQRCoder);
            this.splitContainer2.Panel1.Controls.Add(this.label14);
            this.splitContainer2.Panel1.Controls.Add(this.numPixelsPerModule);
            this.splitContainer2.Panel1.Controls.Add(this.btnEncodeQRCoder);
            this.splitContainer2.Panel1.Controls.Add(this.btnQRCoderPrint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbxQRCoder);
            this.splitContainer2.Size = new System.Drawing.Size(786, 339);
            this.splitContainer2.SplitterDistance = 262;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnEncodeQRCoder
            // 
            this.btnEncodeQRCoder.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEncodeQRCoder.FlatAppearance.BorderSize = 0;
            this.btnEncodeQRCoder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncodeQRCoder.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEncodeQRCoder.ForeColor = System.Drawing.Color.White;
            this.btnEncodeQRCoder.Location = new System.Drawing.Point(6, 84);
            this.btnEncodeQRCoder.Margin = new System.Windows.Forms.Padding(0);
            this.btnEncodeQRCoder.Name = "btnEncodeQRCoder";
            this.btnEncodeQRCoder.Size = new System.Drawing.Size(159, 42);
            this.btnEncodeQRCoder.TabIndex = 81;
            this.btnEncodeQRCoder.Text = "输出条码";
            this.btnEncodeQRCoder.UseVisualStyleBackColor = false;
            this.btnEncodeQRCoder.Click += new System.EventHandler(this.btnEncodeQRCoder_Click);
            // 
            // btnQRCoderPrint
            // 
            this.btnQRCoderPrint.BackColor = System.Drawing.Color.DarkOrange;
            this.btnQRCoderPrint.FlatAppearance.BorderSize = 0;
            this.btnQRCoderPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQRCoderPrint.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQRCoderPrint.ForeColor = System.Drawing.Color.White;
            this.btnQRCoderPrint.Location = new System.Drawing.Point(6, 135);
            this.btnQRCoderPrint.Margin = new System.Windows.Forms.Padding(0);
            this.btnQRCoderPrint.Name = "btnQRCoderPrint";
            this.btnQRCoderPrint.Size = new System.Drawing.Size(238, 47);
            this.btnQRCoderPrint.TabIndex = 80;
            this.btnQRCoderPrint.Text = "打印";
            this.btnQRCoderPrint.UseVisualStyleBackColor = false;
            this.btnQRCoderPrint.Click += new System.EventHandler(this.btnQRCoderPrint_Click);
            // 
            // gbxQRCoder
            // 
            this.gbxQRCoder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbxQRCoder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxQRCoder.Location = new System.Drawing.Point(0, 0);
            this.gbxQRCoder.Name = "gbxQRCoder";
            this.gbxQRCoder.Size = new System.Drawing.Size(520, 339);
            this.gbxQRCoder.TabIndex = 37;
            this.gbxQRCoder.TabStop = false;
            this.gbxQRCoder.Text = "条码图片";
            // 
            // numPixelsPerModule
            // 
            this.numPixelsPerModule.Font = new System.Drawing.Font("宋体", 12F);
            this.numPixelsPerModule.Location = new System.Drawing.Point(7, 40);
            this.numPixelsPerModule.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPixelsPerModule.Name = "numPixelsPerModule";
            this.numPixelsPerModule.Size = new System.Drawing.Size(120, 26);
            this.numPixelsPerModule.TabIndex = 82;
            this.numPixelsPerModule.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F);
            this.label14.Location = new System.Drawing.Point(5, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 16);
            this.label14.TabIndex = 83;
            this.label14.Text = "二维码像素大小";
            // 
            // btnSaveQRCoder
            // 
            this.btnSaveQRCoder.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSaveQRCoder.FlatAppearance.BorderSize = 0;
            this.btnSaveQRCoder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveQRCoder.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveQRCoder.ForeColor = System.Drawing.Color.White;
            this.btnSaveQRCoder.Location = new System.Drawing.Point(175, 84);
            this.btnSaveQRCoder.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveQRCoder.Name = "btnSaveQRCoder";
            this.btnSaveQRCoder.Size = new System.Drawing.Size(69, 42);
            this.btnSaveQRCoder.TabIndex = 84;
            this.btnSaveQRCoder.Text = "保存";
            this.btnSaveQRCoder.UseVisualStyleBackColor = false;
            this.btnSaveQRCoder.Click += new System.EventHandler(this.btnSaveQRCoder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "条码、二维码小工具V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPixelsPerModule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnBarCoderPrint;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxAspectRatio;
        private System.Windows.Forms.TextBox textBoxBarWidth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkGenerateLabel;
        private System.Windows.Forms.ComboBox cbLabelLocation;
        private System.Windows.Forms.Label lblLabelLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbRotateFlip;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEncoded;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.ComboBox cbBarcodeAlign;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEncodingTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEncodeType;
        private System.Windows.Forms.GroupBox gbxBarCoder;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numTop;
        private System.Windows.Forms.NumericUpDown numLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnQRCoderPrint;
        private System.Windows.Forms.Button btnEncodeQRCoder;
        private System.Windows.Forms.GroupBox gbxQRCoder;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numPixelsPerModule;
        private System.Windows.Forms.Button btnSaveQRCoder;
    }
}

