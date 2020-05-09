namespace APIClientTest
{
    partial class fmAPI
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

            this.pnlTop = new System.Windows.Forms.Panel();
            this.gbApiInterface = new System.Windows.Forms.GroupBox();
            this.rdoBizSectionName = new System.Windows.Forms.RadioButton();
            this.rdoSectionName = new System.Windows.Forms.RadioButton();
            this.rdoBrand = new System.Windows.Forms.RadioButton();
            this.rdoHotelKeyWord = new System.Windows.Forms.RadioButton();
            this.rdoAlbum = new System.Windows.Forms.RadioButton();
            this.radioCheckPolicyPrice = new System.Windows.Forms.RadioButton();
            this.rdoModifyOrder = new System.Windows.Forms.RadioButton();
            this.rdoCannelOrder = new System.Windows.Forms.RadioButton();
            this.rdoList = new System.Windows.Forms.RadioButton();
            this.rdoDetails = new System.Windows.Forms.RadioButton();
            this.rdoCreatedOrder = new System.Windows.Forms.RadioButton();
            this.rdoRate = new System.Windows.Forms.RadioButton();
            this.gbApiServer = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoGet = new System.Windows.Forms.RadioButton();
            this.rdoPost = new System.Windows.Forms.RadioButton();
            this.rdoLocalhost28 = new System.Windows.Forms.RadioButton();
            this.rdoLocalhost = new System.Windows.Forms.RadioButton();
            this.rdoTest = new System.Windows.Forms.RadioButton();
            this.rdoJiMei = new System.Windows.Forms.RadioButton();
            this.rdoHuaWei = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTimeCost = new System.Windows.Forms.Label();
            this.pnlSetUserInfo = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSetUserInfo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetUserInfoClose = new System.Windows.Forms.Button();
            this.btnSetUserInfoYes = new System.Windows.Forms.Button();
            this.btnCreateAppendOrderParms = new System.Windows.Forms.Button();
            this.ckAutoFormat = new System.Windows.Forms.CheckBox();
            this.lblPostData = new System.Windows.Forms.Label();
            this.txtPostData = new System.Windows.Forms.TextBox();
            this.txtHotelParmsFormat = new System.Windows.Forms.TextBox();
            this.txtHotelAPIUrlParms = new System.Windows.Forms.TextBox();
            this.txtHotelAPIUrl = new System.Windows.Forms.TextBox();
            this.txtHotelResult = new System.Windows.Forms.TextBox();
            this.txtHotelUrl = new System.Windows.Forms.TextBox();
            this.btnFormmatResult = new System.Windows.Forms.Button();
            this.lblHotelParmsFormat = new System.Windows.Forms.Label();
            this.lblHotelResult = new System.Windows.Forms.Label();
            this.lblHotelAPIUrlParms = new System.Windows.Forms.Label();
            this.lblHotelAPIUrl = new System.Windows.Forms.Label();
            this.btnHotelClear = new System.Windows.Forms.Button();
            this.lblHotelUrl = new System.Windows.Forms.Label();
            this.btnHotelSend = new System.Windows.Forms.Button();
            this.tabAPIMain = new System.Windows.Forms.TabControl();
            this.rdoHuaWeiBate = new System.Windows.Forms.RadioButton();
            this.pnlTop.SuspendLayout();
            this.gbApiInterface.SuspendLayout();
            this.gbApiServer.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlSetUserInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabAPIMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.gbApiInterface);
            this.pnlTop.Controls.Add(this.gbApiServer);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1244, 116);
            this.pnlTop.TabIndex = 1;
            // 
            // gbApiInterface
            // 
            this.gbApiInterface.Controls.Add(this.rdoBizSectionName);
            this.gbApiInterface.Controls.Add(this.rdoSectionName);
            this.gbApiInterface.Controls.Add(this.rdoBrand);
            this.gbApiInterface.Controls.Add(this.rdoHotelKeyWord);
            this.gbApiInterface.Controls.Add(this.rdoAlbum);
            this.gbApiInterface.Controls.Add(this.radioCheckPolicyPrice);
            this.gbApiInterface.Controls.Add(this.rdoModifyOrder);
            this.gbApiInterface.Controls.Add(this.rdoCannelOrder);
            this.gbApiInterface.Controls.Add(this.rdoList);
            this.gbApiInterface.Controls.Add(this.rdoDetails);
            this.gbApiInterface.Controls.Add(this.rdoCreatedOrder);
            this.gbApiInterface.Controls.Add(this.rdoRate);
            this.gbApiInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbApiInterface.Location = new System.Drawing.Point(0, 54);
            this.gbApiInterface.Name = "gbApiInterface";
            this.gbApiInterface.Size = new System.Drawing.Size(1244, 62);
            this.gbApiInterface.TabIndex = 22;
            this.gbApiInterface.TabStop = false;
            this.gbApiInterface.Text = "API 接口方法";
            // 
            // rdoBizSectionName
            // 
            this.rdoBizSectionName.AutoSize = true;
            this.rdoBizSectionName.Location = new System.Drawing.Point(184, 28);
            this.rdoBizSectionName.Name = "rdoBizSectionName";
            this.rdoBizSectionName.Size = new System.Drawing.Size(59, 16);
            this.rdoBizSectionName.TabIndex = 15;
            this.rdoBizSectionName.TabStop = true;
            this.rdoBizSectionName.Text = "商业区";
            this.rdoBizSectionName.UseVisualStyleBackColor = true;
            this.rdoBizSectionName.CheckedChanged += new System.EventHandler(this.rdoBizSectionName_CheckedChanged);
            // 
            // rdoSectionName
            // 
            this.rdoSectionName.AutoSize = true;
            this.rdoSectionName.Location = new System.Drawing.Point(121, 28);
            this.rdoSectionName.Name = "rdoSectionName";
            this.rdoSectionName.Size = new System.Drawing.Size(59, 16);
            this.rdoSectionName.TabIndex = 14;
            this.rdoSectionName.TabStop = true;
            this.rdoSectionName.Text = "行政区";
            this.rdoSectionName.UseVisualStyleBackColor = true;
            this.rdoSectionName.CheckedChanged += new System.EventHandler(this.rdoSectionName_CheckedChanged);
            // 
            // rdoBrand
            // 
            this.rdoBrand.AutoSize = true;
            this.rdoBrand.Location = new System.Drawing.Point(247, 28);
            this.rdoBrand.Name = "rdoBrand";
            this.rdoBrand.Size = new System.Drawing.Size(47, 16);
            this.rdoBrand.TabIndex = 13;
            this.rdoBrand.TabStop = true;
            this.rdoBrand.Text = "品牌";
            this.rdoBrand.UseVisualStyleBackColor = true;
            this.rdoBrand.CheckedChanged += new System.EventHandler(this.rdoBrand_CheckedChanged);
            // 
            // rdoHotelKeyWord
            // 
            this.rdoHotelKeyWord.AutoSize = true;
            this.rdoHotelKeyWord.Location = new System.Drawing.Point(58, 28);
            this.rdoHotelKeyWord.Name = "rdoHotelKeyWord";
            this.rdoHotelKeyWord.Size = new System.Drawing.Size(59, 16);
            this.rdoHotelKeyWord.TabIndex = 12;
            this.rdoHotelKeyWord.TabStop = true;
            this.rdoHotelKeyWord.Text = "关键字";
            this.rdoHotelKeyWord.UseVisualStyleBackColor = true;
            this.rdoHotelKeyWord.CheckedChanged += new System.EventHandler(this.rdoHotelKeyWord_CheckedChanged);
            // 
            // rdoAlbum
            // 
            this.rdoAlbum.AutoSize = true;
            this.rdoAlbum.Location = new System.Drawing.Point(400, 28);
            this.rdoAlbum.Name = "rdoAlbum";
            this.rdoAlbum.Size = new System.Drawing.Size(47, 16);
            this.rdoAlbum.TabIndex = 11;
            this.rdoAlbum.TabStop = true;
            this.rdoAlbum.Text = "相册";
            this.rdoAlbum.UseVisualStyleBackColor = true;
            this.rdoAlbum.CheckedChanged += new System.EventHandler(this.rdoAlbum_CheckedChanged);
            // 
            // radioCheckPolicyPrice
            // 
            this.radioCheckPolicyPrice.AutoSize = true;
            this.radioCheckPolicyPrice.Location = new System.Drawing.Point(1118, 28);
            this.radioCheckPolicyPrice.Name = "radioCheckPolicyPrice";
            this.radioCheckPolicyPrice.Size = new System.Drawing.Size(95, 16);
            this.radioCheckPolicyPrice.TabIndex = 10;
            this.radioCheckPolicyPrice.TabStop = true;
            this.radioCheckPolicyPrice.Text = "验证星级价格";
            this.radioCheckPolicyPrice.UseVisualStyleBackColor = true;
            this.radioCheckPolicyPrice.CheckedChanged += new System.EventHandler(this.radioCheckPolicyPrice_CheckedChanged);
            // 
            // rdoModifyOrder
            // 
            this.rdoModifyOrder.AutoSize = true;
            this.rdoModifyOrder.Location = new System.Drawing.Point(877, 20);
            this.rdoModifyOrder.Name = "rdoModifyOrder";
            this.rdoModifyOrder.Size = new System.Drawing.Size(71, 16);
            this.rdoModifyOrder.TabIndex = 9;
            this.rdoModifyOrder.Text = "修改订单";
            this.rdoModifyOrder.UseVisualStyleBackColor = true;
            this.rdoModifyOrder.CheckedChanged += new System.EventHandler(this.rdoModifyOrder_CheckedChanged);
            // 
            // rdoCannelOrder
            // 
            this.rdoCannelOrder.AutoSize = true;
            this.rdoCannelOrder.Location = new System.Drawing.Point(1041, 28);
            this.rdoCannelOrder.Name = "rdoCannelOrder";
            this.rdoCannelOrder.Size = new System.Drawing.Size(71, 16);
            this.rdoCannelOrder.TabIndex = 8;
            this.rdoCannelOrder.Text = "取消订单";
            this.rdoCannelOrder.UseVisualStyleBackColor = true;
            this.rdoCannelOrder.CheckedChanged += new System.EventHandler(this.rdoCannelOrder_CheckedChanged);
            // 
            // rdoList
            // 
            this.rdoList.AutoSize = true;
            this.rdoList.Checked = true;
            this.rdoList.Location = new System.Drawing.Point(7, 28);
            this.rdoList.Name = "rdoList";
            this.rdoList.Size = new System.Drawing.Size(47, 16);
            this.rdoList.TabIndex = 7;
            this.rdoList.TabStop = true;
            this.rdoList.Text = "列表";
            this.rdoList.UseVisualStyleBackColor = true;
            this.rdoList.CheckedChanged += new System.EventHandler(this.rdoList_CheckedChanged);
            // 
            // rdoDetails
            // 
            this.rdoDetails.AutoSize = true;
            this.rdoDetails.Location = new System.Drawing.Point(298, 28);
            this.rdoDetails.Name = "rdoDetails";
            this.rdoDetails.Size = new System.Drawing.Size(47, 16);
            this.rdoDetails.TabIndex = 6;
            this.rdoDetails.Text = "详情";
            this.rdoDetails.UseVisualStyleBackColor = true;
            this.rdoDetails.CheckedChanged += new System.EventHandler(this.rdoDetails_CheckedChanged);
            // 
            // rdoCreatedOrder
            // 
            this.rdoCreatedOrder.AutoSize = true;
            this.rdoCreatedOrder.Location = new System.Drawing.Point(800, 20);
            this.rdoCreatedOrder.Name = "rdoCreatedOrder";
            this.rdoCreatedOrder.Size = new System.Drawing.Size(71, 16);
            this.rdoCreatedOrder.TabIndex = 5;
            this.rdoCreatedOrder.Text = "创建订单";
            this.rdoCreatedOrder.UseVisualStyleBackColor = true;
            this.rdoCreatedOrder.CheckedChanged += new System.EventHandler(this.rdoCreatedOrder_CheckedChanged);
            // 
            // rdoRate
            // 
            this.rdoRate.AutoSize = true;
            this.rdoRate.Location = new System.Drawing.Point(349, 28);
            this.rdoRate.Name = "rdoRate";
            this.rdoRate.Size = new System.Drawing.Size(47, 16);
            this.rdoRate.TabIndex = 4;
            this.rdoRate.Text = "报价";
            this.rdoRate.UseVisualStyleBackColor = true;
            this.rdoRate.CheckedChanged += new System.EventHandler(this.rdoRate_CheckedChanged);
            // 
            // gbApiServer
            // 
            this.gbApiServer.Controls.Add(this.rdoHuaWeiBate);
            this.gbApiServer.Controls.Add(this.groupBox3);
            this.gbApiServer.Controls.Add(this.rdoLocalhost28);
            this.gbApiServer.Controls.Add(this.rdoLocalhost);
            this.gbApiServer.Controls.Add(this.rdoTest);
            this.gbApiServer.Controls.Add(this.rdoJiMei);
            this.gbApiServer.Controls.Add(this.rdoHuaWei);
            this.gbApiServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbApiServer.Location = new System.Drawing.Point(0, 0);
            this.gbApiServer.Name = "gbApiServer";
            this.gbApiServer.Size = new System.Drawing.Size(1244, 54);
            this.gbApiServer.TabIndex = 21;
            this.gbApiServer.TabStop = false;
            this.gbApiServer.Text = "API 地址";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoGet);
            this.groupBox3.Controls.Add(this.rdoPost);
            this.groupBox3.Location = new System.Drawing.Point(1011, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 42);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "请求模式";
            // 
            // rdoGet
            // 
            this.rdoGet.AutoSize = true;
            this.rdoGet.Location = new System.Drawing.Point(29, 16);
            this.rdoGet.Name = "rdoGet";
            this.rdoGet.Size = new System.Drawing.Size(83, 16);
            this.rdoGet.TabIndex = 7;
            this.rdoGet.Text = "Get Reuest";
            this.rdoGet.UseVisualStyleBackColor = true;
            // 
            // rdoPost
            // 
            this.rdoPost.AutoSize = true;
            this.rdoPost.Checked = true;
            this.rdoPost.Location = new System.Drawing.Point(121, 16);
            this.rdoPost.Name = "rdoPost";
            this.rdoPost.Size = new System.Drawing.Size(95, 16);
            this.rdoPost.TabIndex = 6;
            this.rdoPost.TabStop = true;
            this.rdoPost.Text = "Post Request";
            this.rdoPost.UseVisualStyleBackColor = true;
            // 
            // rdoLocalhost28
            // 
            this.rdoLocalhost28.AutoSize = true;
            this.rdoLocalhost28.Location = new System.Drawing.Point(80, 24);
            this.rdoLocalhost28.Name = "rdoLocalhost28";
            this.rdoLocalhost28.Size = new System.Drawing.Size(83, 16);
            this.rdoLocalhost28.TabIndex = 7;
            this.rdoLocalhost28.Text = "内网28 API";
            this.rdoLocalhost28.UseVisualStyleBackColor = true;

            // 
            // rdoLocalhost
            // 
            this.rdoLocalhost.AutoSize = true;
            this.rdoLocalhost.Location = new System.Drawing.Point(7, 24);
            this.rdoLocalhost.Name = "rdoLocalhost";
            this.rdoLocalhost.Size = new System.Drawing.Size(65, 16);
            this.rdoLocalhost.TabIndex = 3;
            this.rdoLocalhost.Text = "本地API";
            this.rdoLocalhost.UseVisualStyleBackColor = true;

            // 
            // rdoTest
            // 
            this.rdoTest.AutoSize = true;
            this.rdoTest.Location = new System.Drawing.Point(171, 24);
            this.rdoTest.Name = "rdoTest";
            this.rdoTest.Size = new System.Drawing.Size(65, 16);
            this.rdoTest.TabIndex = 2;
            this.rdoTest.Text = "测试API";
            this.rdoTest.UseVisualStyleBackColor = true;

            // 
            // rdoJiMei
            // 
            this.rdoJiMei.AutoSize = true;
            this.rdoJiMei.Location = new System.Drawing.Point(244, 24);
            this.rdoJiMei.Name = "rdoJiMei";
            this.rdoJiMei.Size = new System.Drawing.Size(65, 16);
            this.rdoJiMei.TabIndex = 0;
            this.rdoJiMei.Text = "吉媒API";
            this.rdoJiMei.UseVisualStyleBackColor = true;

            // 
            // rdoHuaWei
            // 
            this.rdoHuaWei.AutoSize = true;
            this.rdoHuaWei.Checked = true;
            this.rdoHuaWei.Location = new System.Drawing.Point(432, 24);
            this.rdoHuaWei.Name = "rdoHuaWei";
            this.rdoHuaWei.Size = new System.Drawing.Size(77, 16);
            this.rdoHuaWei.TabIndex = 1;
            this.rdoHuaWei.Text = "华为云API";
            this.rdoHuaWei.UseVisualStyleBackColor = true;

            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTimeCost);
            this.tabPage2.Controls.Add(this.pnlSetUserInfo);
            this.tabPage2.Controls.Add(this.btnCreateAppendOrderParms);
            this.tabPage2.Controls.Add(this.ckAutoFormat);
            this.tabPage2.Controls.Add(this.lblPostData);
            this.tabPage2.Controls.Add(this.txtPostData);
            this.tabPage2.Controls.Add(this.txtHotelParmsFormat);
            this.tabPage2.Controls.Add(this.txtHotelAPIUrlParms);
            this.tabPage2.Controls.Add(this.txtHotelAPIUrl);
            this.tabPage2.Controls.Add(this.txtHotelResult);
            this.tabPage2.Controls.Add(this.txtHotelUrl);
            this.tabPage2.Controls.Add(this.btnFormmatResult);
            this.tabPage2.Controls.Add(this.lblHotelParmsFormat);
            this.tabPage2.Controls.Add(this.lblHotelResult);
            this.tabPage2.Controls.Add(this.lblHotelAPIUrlParms);
            this.tabPage2.Controls.Add(this.lblHotelAPIUrl);
            this.tabPage2.Controls.Add(this.btnHotelClear);
            this.tabPage2.Controls.Add(this.lblHotelUrl);
            this.tabPage2.Controls.Add(this.btnHotelSend);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1236, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "API Request";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTimeCost
            // 
            this.lblTimeCost.AutoSize = true;
            this.lblTimeCost.Location = new System.Drawing.Point(77, 349);
            this.lblTimeCost.Name = "lblTimeCost";
            this.lblTimeCost.Size = new System.Drawing.Size(83, 12);
            this.lblTimeCost.TabIndex = 25;
            this.lblTimeCost.Text = "耗时:00:00:00";
            // 
            // pnlSetUserInfo
            // 
            this.pnlSetUserInfo.Controls.Add(this.groupBox2);
            this.pnlSetUserInfo.Controls.Add(this.groupBox1);
            this.pnlSetUserInfo.Location = new System.Drawing.Point(550, 215);
            this.pnlSetUserInfo.Name = "pnlSetUserInfo";
            this.pnlSetUserInfo.Size = new System.Drawing.Size(377, 298);
            this.pnlSetUserInfo.TabIndex = 24;
            this.pnlSetUserInfo.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSetUserInfo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 254);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单会员操作员信息";
            // 
            // txtSetUserInfo
            // 
            this.txtSetUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSetUserInfo.Location = new System.Drawing.Point(3, 17);
            this.txtSetUserInfo.Multiline = true;
            this.txtSetUserInfo.Name = "txtSetUserInfo";
            this.txtSetUserInfo.Size = new System.Drawing.Size(371, 234);
            this.txtSetUserInfo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetUserInfoClose);
            this.groupBox1.Controls.Add(this.btnSetUserInfoYes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 44);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置订单会员信息";
            // 
            // btnSetUserInfoClose
            // 
            this.btnSetUserInfoClose.Location = new System.Drawing.Point(253, 15);
            this.btnSetUserInfoClose.Name = "btnSetUserInfoClose";
            this.btnSetUserInfoClose.Size = new System.Drawing.Size(118, 23);
            this.btnSetUserInfoClose.TabIndex = 1;
            this.btnSetUserInfoClose.Text = "关闭";
            this.btnSetUserInfoClose.UseVisualStyleBackColor = true;
            this.btnSetUserInfoClose.Click += new System.EventHandler(this.btnSetUserInfoClose_Click);
            // 
            // btnSetUserInfoYes
            // 
            this.btnSetUserInfoYes.Location = new System.Drawing.Point(3, 15);
            this.btnSetUserInfoYes.Name = "btnSetUserInfoYes";
            this.btnSetUserInfoYes.Size = new System.Drawing.Size(169, 23);
            this.btnSetUserInfoYes.TabIndex = 0;
            this.btnSetUserInfoYes.Text = "确定";
            this.btnSetUserInfoYes.UseVisualStyleBackColor = true;
            this.btnSetUserInfoYes.Click += new System.EventHandler(this.btnSetUserInfoYes_Click);
            // 
            // btnCreateAppendOrderParms
            // 
            this.btnCreateAppendOrderParms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateAppendOrderParms.Location = new System.Drawing.Point(550, 214);
            this.btnCreateAppendOrderParms.Name = "btnCreateAppendOrderParms";
            this.btnCreateAppendOrderParms.Size = new System.Drawing.Size(125, 23);
            this.btnCreateAppendOrderParms.TabIndex = 23;
            this.btnCreateAppendOrderParms.Text = "追加订单会员";
            this.btnCreateAppendOrderParms.UseVisualStyleBackColor = true;
            this.btnCreateAppendOrderParms.Click += new System.EventHandler(this.btnCreateAppendOrderParms_Click);
            // 
            // ckAutoFormat
            // 
            this.ckAutoFormat.AutoSize = true;
            this.ckAutoFormat.Checked = true;
            this.ckAutoFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAutoFormat.Location = new System.Drawing.Point(257, 218);
            this.ckAutoFormat.Name = "ckAutoFormat";
            this.ckAutoFormat.Size = new System.Drawing.Size(84, 16);
            this.ckAutoFormat.TabIndex = 22;
            this.ckAutoFormat.Text = "AutoFormat";
            this.ckAutoFormat.UseVisualStyleBackColor = true;
            // 
            // lblPostData
            // 
            this.lblPostData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPostData.AutoSize = true;
            this.lblPostData.Location = new System.Drawing.Point(615, 71);
            this.lblPostData.Name = "lblPostData";
            this.lblPostData.Size = new System.Drawing.Size(65, 12);
            this.lblPostData.TabIndex = 21;
            this.lblPostData.Text = "Post Parms";
            // 
            // txtPostData
            // 
            this.txtPostData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPostData.Location = new System.Drawing.Point(681, 67);
            this.txtPostData.Multiline = true;
            this.txtPostData.Name = "txtPostData";
            this.txtPostData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPostData.Size = new System.Drawing.Size(547, 170);
            this.txtPostData.TabIndex = 20;
            // 
            // txtHotelParmsFormat
            // 
            this.txtHotelParmsFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotelParmsFormat.Location = new System.Drawing.Point(74, 71);
            this.txtHotelParmsFormat.Multiline = true;
            this.txtHotelParmsFormat.Name = "txtHotelParmsFormat";
            this.txtHotelParmsFormat.ReadOnly = true;
            this.txtHotelParmsFormat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHotelParmsFormat.Size = new System.Drawing.Size(535, 138);
            this.txtHotelParmsFormat.TabIndex = 11;
            // 
            // txtHotelAPIUrlParms
            // 
            this.txtHotelAPIUrlParms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotelAPIUrlParms.Location = new System.Drawing.Point(74, 292);
            this.txtHotelAPIUrlParms.Multiline = true;
            this.txtHotelAPIUrlParms.Name = "txtHotelAPIUrlParms";
            this.txtHotelAPIUrlParms.ReadOnly = true;
            this.txtHotelAPIUrlParms.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHotelAPIUrlParms.Size = new System.Drawing.Size(1154, 40);
            this.txtHotelAPIUrlParms.TabIndex = 10;
            // 
            // txtHotelAPIUrl
            // 
            this.txtHotelAPIUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotelAPIUrl.Location = new System.Drawing.Point(74, 242);
            this.txtHotelAPIUrl.Multiline = true;
            this.txtHotelAPIUrl.Name = "txtHotelAPIUrl";
            this.txtHotelAPIUrl.ReadOnly = true;
            this.txtHotelAPIUrl.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHotelAPIUrl.Size = new System.Drawing.Size(1154, 40);
            this.txtHotelAPIUrl.TabIndex = 9;
            // 
            // txtHotelResult
            // 
            this.txtHotelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotelResult.Location = new System.Drawing.Point(74, 368);
            this.txtHotelResult.Multiline = true;
            this.txtHotelResult.Name = "txtHotelResult";
            this.txtHotelResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHotelResult.Size = new System.Drawing.Size(1154, 261);
            this.txtHotelResult.TabIndex = 8;
            // 
            // txtHotelUrl
            // 
            this.txtHotelUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotelUrl.Location = new System.Drawing.Point(74, 19);
            this.txtHotelUrl.Multiline = true;
            this.txtHotelUrl.Name = "txtHotelUrl";
            this.txtHotelUrl.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHotelUrl.Size = new System.Drawing.Size(1154, 40);
            this.txtHotelUrl.TabIndex = 4;
            // 
            // btnFormmatResult
            // 
            this.btnFormmatResult.Location = new System.Drawing.Point(347, 214);
            this.btnFormmatResult.Name = "btnFormmatResult";
            this.btnFormmatResult.Size = new System.Drawing.Size(95, 23);
            this.btnFormmatResult.TabIndex = 19;
            this.btnFormmatResult.Text = "JSON Formmat";
            this.btnFormmatResult.UseVisualStyleBackColor = true;
            this.btnFormmatResult.Click += new System.EventHandler(this.btnFormmatResult_Click);
            // 
            // lblHotelParmsFormat
            // 
            this.lblHotelParmsFormat.AutoSize = true;
            this.lblHotelParmsFormat.Location = new System.Drawing.Point(9, 74);
            this.lblHotelParmsFormat.Name = "lblHotelParmsFormat";
            this.lblHotelParmsFormat.Size = new System.Drawing.Size(47, 12);
            this.lblHotelParmsFormat.TabIndex = 17;
            this.lblHotelParmsFormat.Text = "API参数";
            // 
            // lblHotelResult
            // 
            this.lblHotelResult.AutoSize = true;
            this.lblHotelResult.Location = new System.Drawing.Point(6, 349);
            this.lblHotelResult.Name = "lblHotelResult";
            this.lblHotelResult.Size = new System.Drawing.Size(53, 12);
            this.lblHotelResult.TabIndex = 16;
            this.lblHotelResult.Text = "API 结果";
            // 
            // lblHotelAPIUrlParms
            // 
            this.lblHotelAPIUrlParms.AutoSize = true;
            this.lblHotelAPIUrlParms.Location = new System.Drawing.Point(9, 298);
            this.lblHotelAPIUrlParms.Name = "lblHotelAPIUrlParms";
            this.lblHotelAPIUrlParms.Size = new System.Drawing.Size(59, 12);
            this.lblHotelAPIUrlParms.TabIndex = 15;
            this.lblHotelAPIUrlParms.Text = "API Parms";
            // 
            // lblHotelAPIUrl
            // 
            this.lblHotelAPIUrl.AutoSize = true;
            this.lblHotelAPIUrl.Location = new System.Drawing.Point(9, 247);
            this.lblHotelAPIUrl.Name = "lblHotelAPIUrl";
            this.lblHotelAPIUrl.Size = new System.Drawing.Size(47, 12);
            this.lblHotelAPIUrl.TabIndex = 14;
            this.lblHotelAPIUrl.Text = "API URL";
            // 
            // btnHotelClear
            // 
            this.btnHotelClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHotelClear.Location = new System.Drawing.Point(448, 214);
            this.btnHotelClear.Name = "btnHotelClear";
            this.btnHotelClear.Size = new System.Drawing.Size(75, 23);
            this.btnHotelClear.TabIndex = 12;
            this.btnHotelClear.Text = "Clear";
            this.btnHotelClear.UseVisualStyleBackColor = true;
            this.btnHotelClear.Click += new System.EventHandler(this.btnHotelDetailsClear_Click);
            // 
            // lblHotelUrl
            // 
            this.lblHotelUrl.AutoSize = true;
            this.lblHotelUrl.Location = new System.Drawing.Point(9, 25);
            this.lblHotelUrl.Name = "lblHotelUrl";
            this.lblHotelUrl.Size = new System.Drawing.Size(23, 12);
            this.lblHotelUrl.TabIndex = 6;
            this.lblHotelUrl.Text = "URL";
            // 
            // btnHotelSend
            // 
            this.btnHotelSend.Location = new System.Drawing.Point(74, 214);
            this.btnHotelSend.Name = "btnHotelSend";
            this.btnHotelSend.Size = new System.Drawing.Size(75, 23);
            this.btnHotelSend.TabIndex = 5;
            this.btnHotelSend.Text = "Send";
            this.btnHotelSend.UseVisualStyleBackColor = true;
            this.btnHotelSend.Click += new System.EventHandler(this.btnHotelDetailsSend_Click);
            // 
            // tabAPIMain
            // 
            this.tabAPIMain.Controls.Add(this.tabPage2);
            this.tabAPIMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAPIMain.Location = new System.Drawing.Point(0, 116);
            this.tabAPIMain.Name = "tabAPIMain";
            this.tabAPIMain.SelectedIndex = 0;
            this.tabAPIMain.Size = new System.Drawing.Size(1244, 667);
            this.tabAPIMain.TabIndex = 0;
            // 
            // rdoHuaWeiBate
            // 
            this.rdoHuaWeiBate.AutoSize = true;
            this.rdoHuaWeiBate.Location = new System.Drawing.Point(319, 24);
            this.rdoHuaWeiBate.Name = "rdoHuaWeiBate";
            this.rdoHuaWeiBate.Size = new System.Drawing.Size(107, 16);
            this.rdoHuaWeiBate.TabIndex = 9;
            this.rdoHuaWeiBate.Text = "华为云Bate_API";
            this.rdoHuaWeiBate.UseVisualStyleBackColor = true;
            // 
            // fmTMC3API
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 783);
            this.Controls.Add(this.tabAPIMain);
            this.Controls.Add(this.pnlTop);
            this.Name = "fmTMC3API";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TMC V3 酒店 API 测试";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTop.ResumeLayout(false);
            this.gbApiInterface.ResumeLayout(false);
            this.gbApiInterface.PerformLayout();
            this.gbApiServer.ResumeLayout(false);
            this.gbApiServer.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnlSetUserInfo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabAPIMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.RadioButton rdoHuaWei;
        private System.Windows.Forms.RadioButton rdoJiMei;
        private System.Windows.Forms.GroupBox gbApiServer;
        private System.Windows.Forms.RadioButton rdoTest;
        private System.Windows.Forms.RadioButton rdoLocalhost;
        private System.Windows.Forms.GroupBox gbApiInterface;
        private System.Windows.Forms.RadioButton rdoModifyOrder;
        private System.Windows.Forms.RadioButton rdoCannelOrder;
        private System.Windows.Forms.RadioButton rdoList;
        private System.Windows.Forms.RadioButton rdoDetails;
        private System.Windows.Forms.RadioButton rdoCreatedOrder;
        private System.Windows.Forms.RadioButton rdoRate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox ckAutoFormat;
        private System.Windows.Forms.Label lblPostData;
        private System.Windows.Forms.TextBox txtPostData;
        private System.Windows.Forms.TextBox txtHotelParmsFormat;
        private System.Windows.Forms.TextBox txtHotelAPIUrlParms;
        private System.Windows.Forms.TextBox txtHotelAPIUrl;
        private System.Windows.Forms.TextBox txtHotelResult;
        private System.Windows.Forms.TextBox txtHotelUrl;
        private System.Windows.Forms.Button btnFormmatResult;
        private System.Windows.Forms.Label lblHotelParmsFormat;
        private System.Windows.Forms.Label lblHotelResult;
        private System.Windows.Forms.Label lblHotelAPIUrlParms;
        private System.Windows.Forms.Label lblHotelAPIUrl;
        private System.Windows.Forms.Button btnHotelClear;
        private System.Windows.Forms.Label lblHotelUrl;
        private System.Windows.Forms.Button btnHotelSend;
        private System.Windows.Forms.TabControl tabAPIMain;
        private System.Windows.Forms.Button btnCreateAppendOrderParms;
        private System.Windows.Forms.Panel pnlSetUserInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSetUserInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSetUserInfoYes;
        private System.Windows.Forms.Button btnSetUserInfoClose;
        private System.Windows.Forms.RadioButton radioCheckPolicyPrice;
        private System.Windows.Forms.Label lblTimeCost;
        private System.Windows.Forms.RadioButton rdoAlbum;
        private System.Windows.Forms.RadioButton rdoLocalhost28;
        private System.Windows.Forms.RadioButton rdoHotelKeyWord;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoGet;
        private System.Windows.Forms.RadioButton rdoPost;
        private System.Windows.Forms.RadioButton rdoBrand;
        private System.Windows.Forms.RadioButton rdoBizSectionName;
        private System.Windows.Forms.RadioButton rdoSectionName;
        private System.Windows.Forms.RadioButton rdoHuaWeiBate;
    }
}