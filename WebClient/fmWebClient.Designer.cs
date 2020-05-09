namespace WebClientTool
{
    partial class fmWebClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmWebClient));
            this.txtPostUrl = new System.Windows.Forms.TextBox();
            this.txtPostResult = new System.Windows.Forms.TextBox();
            this.btnSendPost = new System.Windows.Forms.Button();
            this.lblPostData = new System.Windows.Forms.Label();
            this.txtPostData = new System.Windows.Forms.TextBox();
            this.lblPostUrl = new System.Windows.Forms.Label();
            this.txtGetResult = new System.Windows.Forms.TextBox();
            this.btnSendGet = new System.Windows.Forms.Button();
            this.lblGetData = new System.Windows.Forms.Label();
            this.txtGetData = new System.Windows.Forms.TextBox();
            this.lblGetUrl = new System.Windows.Forms.Label();
            this.txtGetUrl = new System.Windows.Forms.TextBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabGet = new System.Windows.Forms.TabPage();
            this.tabGetResponse = new System.Windows.Forms.TabControl();
            this.tpGetResponseText = new System.Windows.Forms.TabPage();
            this.tsGetToolBar = new System.Windows.Forms.ToolStrip();
            this.tsbRemoveSpecialchar = new System.Windows.Forms.ToolStripButton();
            this.tsbFormmat = new System.Windows.Forms.ToolStripButton();
            this.tgGetJsonView = new System.Windows.Forms.TabPage();
            this.tvGetJsonView = new System.Windows.Forms.TreeView();
            this.pnlGetRequest = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPostResponse = new System.Windows.Forms.TabControl();
            this.tpPostResponseText = new System.Windows.Forms.TabPage();
            this.tsPostToolBar = new System.Windows.Forms.ToolStrip();
            this.tsbPostRemoveSpecialChar = new System.Windows.Forms.ToolStripButton();
            this.tsbPostFormmat = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tvPostJsonView = new System.Windows.Forms.TreeView();
            this.pnlPostRequst = new System.Windows.Forms.Panel();
            this.tabMain.SuspendLayout();
            this.tabGet.SuspendLayout();
            this.tabGetResponse.SuspendLayout();
            this.tpGetResponseText.SuspendLayout();
            this.tsGetToolBar.SuspendLayout();
            this.tgGetJsonView.SuspendLayout();
            this.pnlGetRequest.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPostResponse.SuspendLayout();
            this.tpPostResponseText.SuspendLayout();
            this.tsPostToolBar.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlPostRequst.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPostUrl
            // 
            this.txtPostUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPostUrl.Location = new System.Drawing.Point(60, 15);
            this.txtPostUrl.Name = "txtPostUrl";
            this.txtPostUrl.Size = new System.Drawing.Size(811, 21);
            this.txtPostUrl.TabIndex = 0;
            // 
            // txtPostResult
            // 
            this.txtPostResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPostResult.Location = new System.Drawing.Point(3, 28);
            this.txtPostResult.Multiline = true;
            this.txtPostResult.Name = "txtPostResult";
            this.txtPostResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPostResult.Size = new System.Drawing.Size(856, 472);
            this.txtPostResult.TabIndex = 5;
            // 
            // btnSendPost
            // 
            this.btnSendPost.Location = new System.Drawing.Point(60, 120);
            this.btnSendPost.Name = "btnSendPost";
            this.btnSendPost.Size = new System.Drawing.Size(75, 23);
            this.btnSendPost.TabIndex = 4;
            this.btnSendPost.Text = "Send Post";
            this.btnSendPost.UseVisualStyleBackColor = true;
            this.btnSendPost.Click += new System.EventHandler(this.btnSendPost_Click);
            // 
            // lblPostData
            // 
            this.lblPostData.AutoSize = true;
            this.lblPostData.Location = new System.Drawing.Point(17, 43);
            this.lblPostData.Name = "lblPostData";
            this.lblPostData.Size = new System.Drawing.Size(29, 12);
            this.lblPostData.TabIndex = 3;
            this.lblPostData.Text = "Data";
            // 
            // txtPostData
            // 
            this.txtPostData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPostData.Location = new System.Drawing.Point(60, 41);
            this.txtPostData.Multiline = true;
            this.txtPostData.Name = "txtPostData";
            this.txtPostData.Size = new System.Drawing.Size(811, 74);
            this.txtPostData.TabIndex = 2;
            // 
            // lblPostUrl
            // 
            this.lblPostUrl.AutoSize = true;
            this.lblPostUrl.Location = new System.Drawing.Point(17, 17);
            this.lblPostUrl.Name = "lblPostUrl";
            this.lblPostUrl.Size = new System.Drawing.Size(23, 12);
            this.lblPostUrl.TabIndex = 1;
            this.lblPostUrl.Text = "URL";
            // 
            // txtGetResult
            // 
            this.txtGetResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGetResult.Location = new System.Drawing.Point(3, 28);
            this.txtGetResult.Multiline = true;
            this.txtGetResult.Name = "txtGetResult";
            this.txtGetResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGetResult.Size = new System.Drawing.Size(856, 472);
            this.txtGetResult.TabIndex = 6;
            // 
            // btnSendGet
            // 
            this.btnSendGet.Location = new System.Drawing.Point(60, 120);
            this.btnSendGet.Name = "btnSendGet";
            this.btnSendGet.Size = new System.Drawing.Size(75, 23);
            this.btnSendGet.TabIndex = 5;
            this.btnSendGet.Text = "Send Get";
            this.btnSendGet.UseVisualStyleBackColor = true;
            this.btnSendGet.Click += new System.EventHandler(this.btnSendGet_Click);
            // 
            // lblGetData
            // 
            this.lblGetData.AutoSize = true;
            this.lblGetData.Location = new System.Drawing.Point(17, 45);
            this.lblGetData.Name = "lblGetData";
            this.lblGetData.Size = new System.Drawing.Size(29, 12);
            this.lblGetData.TabIndex = 3;
            this.lblGetData.Text = "Data";
            // 
            // txtGetData
            // 
            this.txtGetData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGetData.Location = new System.Drawing.Point(60, 41);
            this.txtGetData.Multiline = true;
            this.txtGetData.Name = "txtGetData";
            this.txtGetData.Size = new System.Drawing.Size(804, 74);
            this.txtGetData.TabIndex = 2;
            // 
            // lblGetUrl
            // 
            this.lblGetUrl.AutoSize = true;
            this.lblGetUrl.Location = new System.Drawing.Point(17, 17);
            this.lblGetUrl.Name = "lblGetUrl";
            this.lblGetUrl.Size = new System.Drawing.Size(23, 12);
            this.lblGetUrl.TabIndex = 1;
            this.lblGetUrl.Text = "URL";
            // 
            // txtGetUrl
            // 
            this.txtGetUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGetUrl.Location = new System.Drawing.Point(60, 15);
            this.txtGetUrl.Name = "txtGetUrl";
            this.txtGetUrl.Size = new System.Drawing.Size(804, 21);
            this.txtGetUrl.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabGet);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(884, 711);
            this.tabMain.TabIndex = 5;
            // 
            // tabGet
            // 
            this.tabGet.Controls.Add(this.tabGetResponse);
            this.tabGet.Controls.Add(this.pnlGetRequest);
            this.tabGet.Location = new System.Drawing.Point(4, 22);
            this.tabGet.Name = "tabGet";
            this.tabGet.Padding = new System.Windows.Forms.Padding(3);
            this.tabGet.Size = new System.Drawing.Size(876, 685);
            this.tabGet.TabIndex = 0;
            this.tabGet.Text = "Get Request";
            this.tabGet.UseVisualStyleBackColor = true;
            // 
            // tabGetResponse
            // 
            this.tabGetResponse.Controls.Add(this.tpGetResponseText);
            this.tabGetResponse.Controls.Add(this.tgGetJsonView);
            this.tabGetResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGetResponse.Location = new System.Drawing.Point(3, 153);
            this.tabGetResponse.Name = "tabGetResponse";
            this.tabGetResponse.SelectedIndex = 0;
            this.tabGetResponse.Size = new System.Drawing.Size(870, 529);
            this.tabGetResponse.TabIndex = 7;
            this.tabGetResponse.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabGetResponse_Selected);
            // 
            // tpGetResponseText
            // 
            this.tpGetResponseText.Controls.Add(this.txtGetResult);
            this.tpGetResponseText.Controls.Add(this.tsGetToolBar);
            this.tpGetResponseText.Location = new System.Drawing.Point(4, 22);
            this.tpGetResponseText.Name = "tpGetResponseText";
            this.tpGetResponseText.Padding = new System.Windows.Forms.Padding(3);
            this.tpGetResponseText.Size = new System.Drawing.Size(862, 503);
            this.tpGetResponseText.TabIndex = 0;
            this.tpGetResponseText.Text = "Get Text";
            this.tpGetResponseText.UseVisualStyleBackColor = true;
            // 
            // tsGetToolBar
            // 
            this.tsGetToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRemoveSpecialchar,
            this.tsbFormmat});
            this.tsGetToolBar.Location = new System.Drawing.Point(3, 3);
            this.tsGetToolBar.Name = "tsGetToolBar";
            this.tsGetToolBar.Size = new System.Drawing.Size(856, 25);
            this.tsGetToolBar.TabIndex = 7;
            this.tsGetToolBar.Text = "toolStrip1";
            // 
            // tsbRemoveSpecialchar
            // 
            this.tsbRemoveSpecialchar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRemoveSpecialchar.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveSpecialchar.Image")));
            this.tsbRemoveSpecialchar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveSpecialchar.Name = "tsbRemoveSpecialchar";
            this.tsbRemoveSpecialchar.Size = new System.Drawing.Size(48, 22);
            this.tsbRemoveSpecialchar.Text = "去转义";
            this.tsbRemoveSpecialchar.Click += new System.EventHandler(this.tsbRemoveSpecialchar_Click);
            // 
            // tsbFormmat
            // 
            this.tsbFormmat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbFormmat.Image = ((System.Drawing.Image)(resources.GetObject("tsbFormmat.Image")));
            this.tsbFormmat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFormmat.Name = "tsbFormmat";
            this.tsbFormmat.Size = new System.Drawing.Size(64, 22);
            this.tsbFormmat.Text = "Formmat";
            this.tsbFormmat.Click += new System.EventHandler(this.tsbGetFormmat_Click);
            // 
            // tgGetJsonView
            // 
            this.tgGetJsonView.Controls.Add(this.tvGetJsonView);
            this.tgGetJsonView.Location = new System.Drawing.Point(4, 22);
            this.tgGetJsonView.Name = "tgGetJsonView";
            this.tgGetJsonView.Padding = new System.Windows.Forms.Padding(3);
            this.tgGetJsonView.Size = new System.Drawing.Size(862, 503);
            this.tgGetJsonView.TabIndex = 1;
            this.tgGetJsonView.Text = "Get JsonView";
            this.tgGetJsonView.UseVisualStyleBackColor = true;
            // 
            // tvGetJsonView
            // 
            this.tvGetJsonView.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.tvGetJsonView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvGetJsonView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvGetJsonView.Location = new System.Drawing.Point(3, 3);
            this.tvGetJsonView.Name = "tvGetJsonView";
            this.tvGetJsonView.Size = new System.Drawing.Size(856, 497);
            this.tvGetJsonView.TabIndex = 0;
            // 
            // pnlGetRequest
            // 
            this.pnlGetRequest.Controls.Add(this.txtGetData);
            this.pnlGetRequest.Controls.Add(this.txtGetUrl);
            this.pnlGetRequest.Controls.Add(this.btnSendGet);
            this.pnlGetRequest.Controls.Add(this.lblGetUrl);
            this.pnlGetRequest.Controls.Add(this.lblGetData);
            this.pnlGetRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGetRequest.Location = new System.Drawing.Point(3, 3);
            this.pnlGetRequest.Name = "pnlGetRequest";
            this.pnlGetRequest.Size = new System.Drawing.Size(870, 150);
            this.pnlGetRequest.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabPostResponse);
            this.tabPage2.Controls.Add(this.pnlPostRequst);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 685);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Post Request";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPostResponse
            // 
            this.tabPostResponse.Controls.Add(this.tpPostResponseText);
            this.tabPostResponse.Controls.Add(this.tabPage3);
            this.tabPostResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPostResponse.Location = new System.Drawing.Point(3, 153);
            this.tabPostResponse.Name = "tabPostResponse";
            this.tabPostResponse.SelectedIndex = 0;
            this.tabPostResponse.Size = new System.Drawing.Size(870, 529);
            this.tabPostResponse.TabIndex = 7;
            this.tabPostResponse.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabPostResponse_Selected);
            // 
            // tpPostResponseText
            // 
            this.tpPostResponseText.Controls.Add(this.txtPostResult);
            this.tpPostResponseText.Controls.Add(this.tsPostToolBar);
            this.tpPostResponseText.Location = new System.Drawing.Point(4, 22);
            this.tpPostResponseText.Name = "tpPostResponseText";
            this.tpPostResponseText.Padding = new System.Windows.Forms.Padding(3);
            this.tpPostResponseText.Size = new System.Drawing.Size(862, 503);
            this.tpPostResponseText.TabIndex = 0;
            this.tpPostResponseText.Text = "Text";
            this.tpPostResponseText.UseVisualStyleBackColor = true;
            // 
            // tsPostToolBar
            // 
            this.tsPostToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPostRemoveSpecialChar,
            this.tsbPostFormmat});
            this.tsPostToolBar.Location = new System.Drawing.Point(3, 3);
            this.tsPostToolBar.Name = "tsPostToolBar";
            this.tsPostToolBar.Size = new System.Drawing.Size(856, 25);
            this.tsPostToolBar.TabIndex = 6;
            this.tsPostToolBar.Text = "toolStrip1";
            // 
            // tsbPostRemoveSpecialChar
            // 
            this.tsbPostRemoveSpecialChar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPostRemoveSpecialChar.Image = ((System.Drawing.Image)(resources.GetObject("tsbPostRemoveSpecialChar.Image")));
            this.tsbPostRemoveSpecialChar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPostRemoveSpecialChar.Name = "tsbPostRemoveSpecialChar";
            this.tsbPostRemoveSpecialChar.Size = new System.Drawing.Size(48, 22);
            this.tsbPostRemoveSpecialChar.Text = "去转义";
            // 
            // tsbPostFormmat
            // 
            this.tsbPostFormmat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPostFormmat.Image = ((System.Drawing.Image)(resources.GetObject("tsbPostFormmat.Image")));
            this.tsbPostFormmat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPostFormmat.Name = "tsbPostFormmat";
            this.tsbPostFormmat.Size = new System.Drawing.Size(64, 22);
            this.tsbPostFormmat.Text = "Formmat";
            this.tsbPostFormmat.Click += new System.EventHandler(this.tsbPostFormmat_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tvPostJsonView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(862, 503);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Json View";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tvPostJsonView
            // 
            this.tvPostJsonView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvPostJsonView.Location = new System.Drawing.Point(3, 3);
            this.tvPostJsonView.Name = "tvPostJsonView";
            this.tvPostJsonView.Size = new System.Drawing.Size(856, 497);
            this.tvPostJsonView.TabIndex = 0;
            // 
            // pnlPostRequst
            // 
            this.pnlPostRequst.Controls.Add(this.txtPostUrl);
            this.pnlPostRequst.Controls.Add(this.lblPostUrl);
            this.pnlPostRequst.Controls.Add(this.btnSendPost);
            this.pnlPostRequst.Controls.Add(this.txtPostData);
            this.pnlPostRequst.Controls.Add(this.lblPostData);
            this.pnlPostRequst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPostRequst.Location = new System.Drawing.Point(3, 3);
            this.pnlPostRequst.Name = "pnlPostRequst";
            this.pnlPostRequst.Size = new System.Drawing.Size(870, 150);
            this.pnlPostRequst.TabIndex = 6;
            // 
            // fmWebClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 711);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmWebClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebClient";
            this.tabMain.ResumeLayout(false);
            this.tabGet.ResumeLayout(false);
            this.tabGetResponse.ResumeLayout(false);
            this.tpGetResponseText.ResumeLayout(false);
            this.tpGetResponseText.PerformLayout();
            this.tsGetToolBar.ResumeLayout(false);
            this.tsGetToolBar.PerformLayout();
            this.tgGetJsonView.ResumeLayout(false);
            this.pnlGetRequest.ResumeLayout(false);
            this.pnlGetRequest.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPostResponse.ResumeLayout(false);
            this.tpPostResponseText.ResumeLayout(false);
            this.tpPostResponseText.PerformLayout();
            this.tsPostToolBar.ResumeLayout(false);
            this.tsPostToolBar.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.pnlPostRequst.ResumeLayout(false);
            this.pnlPostRequst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPostUrl;
        private System.Windows.Forms.Button btnSendPost;
        private System.Windows.Forms.Label lblPostData;
        private System.Windows.Forms.TextBox txtPostData;
        private System.Windows.Forms.Label lblPostUrl;
        private System.Windows.Forms.Button btnSendGet;
        private System.Windows.Forms.Label lblGetData;
        private System.Windows.Forms.TextBox txtGetData;
        private System.Windows.Forms.Label lblGetUrl;
        private System.Windows.Forms.TextBox txtGetUrl;
        private System.Windows.Forms.TextBox txtPostResult;
        private System.Windows.Forms.TextBox txtGetResult;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabGet;
        private System.Windows.Forms.TabControl tabGetResponse;
        private System.Windows.Forms.TabPage tpGetResponseText;
        private System.Windows.Forms.TabPage tgGetJsonView;
        private System.Windows.Forms.TreeView tvGetJsonView;
        private System.Windows.Forms.Panel pnlGetRequest;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabPostResponse;
        private System.Windows.Forms.TabPage tpPostResponseText;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnlPostRequst;
        private System.Windows.Forms.TreeView tvPostJsonView;
        private System.Windows.Forms.ToolStrip tsGetToolBar;
        private System.Windows.Forms.ToolStripButton tsbRemoveSpecialchar;
        private System.Windows.Forms.ToolStripButton tsbFormmat;
        private System.Windows.Forms.ToolStrip tsPostToolBar;
        private System.Windows.Forms.ToolStripButton tsbPostRemoveSpecialChar;
        private System.Windows.Forms.ToolStripButton tsbPostFormmat;
    }
}