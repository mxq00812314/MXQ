using EP.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace APIClientTest
{
    public partial class fmAPI : Form
    {
        DateTime tBegin = new DateTime();
        DateTime tEnd = new DateTime();
        System.Windows.Forms.Timer tClock = new System.Windows.Forms.Timer();
        public fmAPI()
        {
            InitializeComponent();
            tClock.Interval = 1;
            tClock.Tick += RunTimer;
            //TMC3_1HotelUrlCenter.ServerCode = "huawei";
        }

        #region 选则 API 接口

        //列表
        private void rdoList_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoList.Checked)
                rdoPost.Checked = true;
        }

        //关键字
        private void rdoHotelKeyWord_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHotelKeyWord.Checked)
                rdoGet.Checked = true;
        }

        //行政区
        private void rdoSectionName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSectionName.Checked)
                rdoGet.Checked = true;
        }

        //商业区
        private void rdoBizSectionName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBizSectionName.Checked)
                rdoGet.Checked = true;
        }

        //品牌
        private void rdoBrand_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBrand.Checked)
                rdoGet.Checked = true;
        }

        //详情
        private void rdoDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDetails.Checked)
                rdoGet.Checked = true;
        }

        //报价
        private void rdoRate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRate.Checked)
                rdoGet.Checked = true;
        }

        //相册
        private void rdoAlbum_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAlbum.Checked)
                rdoGet.Checked = true;
        }

        //创建订单
        private void rdoCreatedOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCreatedOrder.Checked)
                rdoPost.Checked = true;
        }

        //修改订单
        private void rdoModifyOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoModifyOrder.Checked)
                rdoPost.Checked = true;
        }

        //取消订单
        private void rdoCannelOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCannelOrder.Checked)
                rdoPost.Checked = true;
        }

        //验证星级价格
        private void radioCheckPolicyPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCheckPolicyPrice.Checked)
                rdoGet.Checked = true;
        }

        #endregion

        #region 窗体事件

        //Get选中时
        private void rdoGet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGet.Checked)
            {
                txtPostData.Enabled = false;
                txtPostData.Text = "";
            }
        }

        //Post 选中时
        private void rdoPost_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPost.Checked)
                txtPostData.Enabled = true;
        }

        //弹出创建订单会员层
        private void btnCreateAppendOrderParms_Click(object sender, EventArgs e)
        {
            pnlSetUserInfo.Visible = true;

            pnlSetUserInfo.Location = btnCreateAppendOrderParms.Location;
        }

        //解析订单会员
        private void btnSetUserInfoYes_Click(object sender, EventArgs e)
        {
            var crmStr = txtSetUserInfo.Text;
            if (string.IsNullOrWhiteSpace(crmStr))
            {
                MessageBox.Show("没有输入会员信息");
                txtSetUserInfo.Focus();
                return;
            }


        }

        //隐藏创建订单会员层
        private void btnSetUserInfoClose_Click(object sender, EventArgs e)
        {
            pnlSetUserInfo.Visible = false;
        }

        //清空
        private void btnHotelDetailsClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        //格式化结果
        private void btnFormmatResult_Click(object sender, EventArgs e)
        {
            FormateResult();
        }

        #endregion

        #region 调用API

        //发送请求
        private void btnHotelDetailsSend_Click(object sender, EventArgs e)
        {
            tBegin = DateTime.Now;
            tClock.Start();
            RunAsyncGetData();
        }

        //计时器计时
        private void RunTimer(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                tEnd = DateTime.Now;
                lblTimeCost.Text = $"耗时:{ tEnd - tBegin} 计时中";
            });
        }

        //执行API
        private void RunAsyncGetData()
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                //清理上次查询结果
                ClearText();
                //设置URL
                SetRequestUrl();
                //执行方法
                if (rdoList.Checked)
                    RunApiMethod("list");
                if (rdoSectionName.Checked)
                    RunApiMethod("sectionName");
                if (rdoBizSectionName.Checked)
                    RunApiMethod("bizSectionName");
                if (rdoBrand.Checked)
                    RunApiMethod("brand");
                if (rdoDetails.Checked)
                    RunApiMethod("details");
                if (rdoRate.Checked)
                    RunApiMethod("rate");
                if (rdoAlbum.Checked)
                    RunApiMethod("album");
                if (rdoHotelKeyWord.Checked)
                    RunApiMethod("keyword");
                if (rdoCreatedOrder.Checked)
                    RunApiMethod("created");
                if (rdoModifyOrder.Checked)
                    RunApiMethod("modify");
                if (radioCheckPolicyPrice.Checked)
                    RunApiMethod("checkPolicyPrice");
                //自动格式JSON
                if (!string.IsNullOrWhiteSpace(txtHotelResult.Text) && ckAutoFormat.Checked)
                    FormateResult();
            });
        }

        //设置API参数
        public void SetApiParms(string parmItem, string ApiParmName, ref List<string> queryParms, string parmReName = "")
        {
            if (!string.IsNullOrWhiteSpace(parmItem) && parmItem.IndexOf('=') != -1)
            {
                var parmItemArr = parmItem.Split('=');

                var parmName = parmItemArr[0];
                var parmVal = parmItemArr[1];
                // Url参数 与 接口参数一致
                if (parmName.ToLower() == ApiParmName.ToLower())
                    queryParms.Add(ApiParmName + "=" + parmVal);

                // Url参数 与 接口参数 不一致
                if (parmName.ToLower() == parmReName.ToLower())
                    queryParms.Add(ApiParmName + "=" + parmVal);
            }
        }

        //执行API参数
        public void RunApiMethod(string methodCode)
        {
            var detailsUrl = "";
            var detailsUrlParms = "";

            detailsUrl = txtHotelUrl.Text;

            if (string.IsNullOrWhiteSpace(detailsUrl))
            {
                MessageBox.Show("URL 为空"); ;
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtPostData.Text))
            {
                detailsUrlParms = string.Join("&", txtPostData.Lines).Replace(":", "=");
            }
            else
            {
                detailsUrlParms = detailsUrl.Substring(detailsUrl.IndexOf("?", 0) + 1);
            }
            if ((methodCode == "created" || methodCode == "modify") && (detailsUrlParms.IndexOf("+") != -1 || detailsUrlParms.IndexOf("%2B") != -1))
                detailsUrlParms = StringHelper.ReplaceSpecialString(detailsUrlParms, @"\+", "＋");
            var parmArr = detailsUrlParms.Split('&');

            List<string> queryParms = new List<string>();


            switch (methodCode)
            {
                case "list":
                    for (var i = 0; i < parmArr.Length; i++)
                    {
                        var parmItem = parmArr[i];

                        SetApiParms(parmItem, "CityId", ref queryParms);
                        SetApiParms(parmItem, "CheckIn", ref queryParms);
                        SetApiParms(parmItem, "CheckOut", ref queryParms);
                        SetApiParms(parmItem, "KeyWord", ref queryParms);

                        SetApiParms(parmItem, "HotelName", ref queryParms);
                        SetApiParms(parmItem, "HotelTgId", ref queryParms);
                        SetApiParms(parmItem, "Longitude", ref queryParms);
                        SetApiParms(parmItem, "Latitude", ref queryParms);

                        SetApiParms(parmItem, "SectionName", ref queryParms);
                        SetApiParms(parmItem, "StarRatedId", ref queryParms);
                        SetApiParms(parmItem, "LowestPrice", ref queryParms);
                        SetApiParms(parmItem, "HighestPrice", ref queryParms);
                        SetApiParms(parmItem, "ChainName", ref queryParms);
                        SetApiParms(parmItem, "PageNumber", ref queryParms);
                        SetApiParms(parmItem, "PageSize", ref queryParms);
                        SetApiParms(parmItem, "OrderName", ref queryParms);
                        SetApiParms(parmItem, "OrderBy", ref queryParms);
                        SetApiParms(parmItem, "User_Code", ref queryParms);
                        SetApiParms(parmItem, "QueryType", ref queryParms);
                        SetApiParms(parmItem, "Kilometre", ref queryParms);


                        SetApiParms(parmItem, "BizsectionName", ref queryParms);
                        SetApiParms(parmItem, "Client_id", ref queryParms);
                        SetApiParms(parmItem, "Org_id", ref queryParms);
                        SetApiParms(parmItem, "Channel", ref queryParms);
                        SetApiParms(parmItem, "Guarantee", ref queryParms);
                        SetApiParms(parmItem, "Guarantee", ref queryParms);
                        SetApiParms(parmItem, "InvoiceType", ref queryParms);
                        SetApiParms(parmItem, "PaymentType", ref queryParms);
                        SetApiParms(parmItem, "IsSpecialChannel", ref queryParms);
                    }
                    break;
            }
        }

        #endregion

        #region  辅助方法

        //清空值
        public void ClearText()
        {
            txtHotelParmsFormat.Text = "";
            txtHotelAPIUrlParms.Text = "";
            txtHotelAPIUrl.Text = "";
            txtHotelResult.Text = "";
        }

        // JSON格式话文本
        private void FormateResult()
        {
            txtHotelResult.Text = StringHelper.FormatJsonString(txtHotelResult.Text);
        }

        //设置url base地址
        private void SetRequestUrl()
        {
            if (rdoJiMei.Checked && rdoPost.Checked)
            {
                if (rdoList.Checked)
                    txtHotelUrl.Text = "http://tmc3.tripg.com/HotelAjax/GetHotelList";

                if (rdoDetails.Checked)
                    txtHotelUrl.Text = "http://tmc3.tripg.com/HotelAjax/GetHotelRoomType";

                if (rdoRate.Checked)
                    txtHotelUrl.Text = "http://tmc3.tripg.com/HotelAjax/QueryRatePlan";

                if (rdoCreatedOrder.Checked)
                    txtHotelUrl.Text = "http://tmc3.tripg.com/HotelAjax/SubmitHotelOrder";

            }

            if (rdoHuaWeiBate.Checked && rdoPost.Checked)
            {
                if (rdoList.Checked)
                    txtHotelUrl.Text = "http://bate.tripg.com/HotelAjax/GetHotelList";

                if (rdoDetails.Checked)
                    txtHotelUrl.Text = "http://bate.tripg.com/HotelAjax/GetHotelRoomType";

                if (rdoRate.Checked)
                    txtHotelUrl.Text = "http://bate.tripg.com/HotelAjax/QueryRatePlan";

                if (rdoCreatedOrder.Checked)
                    txtHotelUrl.Text = "http://bate.tripg.com/HotelAjax/SubmitHotelOrder";
            }

            if (rdoHuaWei.Checked && rdoPost.Checked)
            {
                if (rdoList.Checked)
                    txtHotelUrl.Text = "http://s.tripg.com/HotelAjax/GetHotelList";

                if (rdoDetails.Checked)
                    txtHotelUrl.Text = "http://s.tripg.com/HotelAjax/GetHotelRoomType";

                if (rdoRate.Checked)
                    txtHotelUrl.Text = "http://s.tripg.com/HotelAjax/QueryRatePlan";

                if (rdoCreatedOrder.Checked)
                    txtHotelUrl.Text = "http://s.tripg.com/HotelAjax/SubmitHotelOrder";
            }
        }

        #endregion


    }
}
