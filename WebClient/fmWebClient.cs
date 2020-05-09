using EP.Common;
using EP.PlugIn;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WebClientTool
{
    public partial class fmWebClient : Form
    {
        public fmWebClient()
        {
            InitializeComponent();

            var url = "";
            var data = "";


            //url = "http://tmc3.tripg.com/HotelAjax/GetHotelRoomType"; ;
            //data = "HotelTgId=523115&HotelName=%E5%8C%97%E4%BA%AC%E7%BC%98%E4%BA%91%E9%98%81%E6%97%85%E9%A6%86&CityId=71559&CityName=%E5%8C%97%E4%BA%AC&CheckIn=2017-04-10&CheckOut=2017-04-11&PayOption=SelfPay%2CPrePay&Guarantee=true&Client_id=1&Org_id=0&TravelType=3";

            txtGetUrl.Text = url;
            txtGetData.Text = data;
            txtPostUrl.Text = url;
            txtPostData.Text = data;
        }

        /// <summary>
        /// 发送Get 请求
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendGet_Click(object sender, EventArgs e)
        {
            txtGetResult.Text = "";
            string url = txtGetUrl.Text;
            string data = txtGetData.Text;

            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Get Url 未填写");
                return;
            }

            var getResultStr = "";
            LoadingHelper.ShowLoading("请求数据中,请耐心等待......", this, o =>
            {
                getResultStr = GetMethod(url, data);
            });
            txtGetResult.Text = getResultStr;

        }

        /// <summary>
        /// 发送Post 请求
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendPost_Click(object sender, EventArgs e)
        {
            txtPostResult.Text = "";
            string url = txtPostUrl.Text;
            string data = txtPostData.Text;

            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Post Url 未填写");
                return;
            }

            if (string.IsNullOrWhiteSpace(data))
            {
                MessageBox.Show("Post Data 未填写");
                return;
            }

            var postResultStr = "";
            LoadingHelper.ShowLoading("请求数据中,请耐心等待......", this, o =>
            {
                postResultStr = PostMethod(url, data);
            });
            //txtPostResult.Text = JsonConvert.SerializeObject(postResultStr);
            txtPostResult.Text = postResultStr;
        }

        /// <summary>
        /// Get 去掉转义字符
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbRemoveSpecialchar_Click(object sender, EventArgs e)
        {
            txtGetResult.Text = StringHelper.RemoveSpecialChar(txtGetResult.Text);
        }

        /// <summary>
        /// Post 去掉转义字符
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbPostRemoveSpecialChar_Click(object sender, EventArgs e)
        {
            txtPostResult.Text = StringHelper.RemoveSpecialChar(txtPostResult.Text);
        }

        /// <summary>
        /// Get 格式化 JSON 串
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbGetFormmat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGetResult.Text)) { MessageBox.Show("请输入Json串"); return; }
            txtGetResult.Text = StringHelper.FormatJsonString(StringHelper.RemoveSpecialChar(txtGetResult.Text));
        }

        /// <summary>
        /// Post 格式化 JSON 串
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbPostFormmat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPostResult.Text)) { MessageBox.Show("请输入Json串"); return; }
            txtPostResult.Text = StringHelper.FormatJsonString(StringHelper.RemoveSpecialChar(txtPostResult.Text));
        }

        /// <summary>
        ///  Post提交方法
        /// </summary>
        /// <param name="url">路径</param>
        /// <param name="data">数据</param>
        /// <returns></returns>
        public string PostMethod(string url, string data)
        {
            if (StringHelper.IsErrorUrl(url))
            {
                MessageBox.Show("请输入正确的Url");
                return "";
            }

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    string requestUrl = url + "?" + data;
                    data = data.Replace("+", "%2B");
                    //编码，尤其是汉字，事先要看下抓取网页的编码方式  
                    byte[] postData = Encoding.GetEncoding("UTF-8").GetBytes(data);
                    //采取POST方式必须加的header，如果改为GET方式的话就去掉这句话即可  
                    webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                    //得到返回字符流  
                    byte[] responseData = webClient.UploadData(url, "POST", postData);
                    //解码 
                    string srcString = Encoding.GetEncoding("UTF-8").GetString(responseData);
                    return srcString;
                }
                catch (Exception ex)
                {
                    return $"{ex.Message}";
                }
            }
        }

        /// <summary>
        ///  Get提交方法
        /// </summary>
        /// <param name="url">路径</param>
        /// <param name="data">数据</param>
        /// <returns></returns>
        public string GetMethod(string url, string data)
        {

            if (StringHelper.IsErrorUrl(url))
            {
                MessageBox.Show("请输入正确的Url");
                return "";
            }

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    var t1 = DateTime.Now;
                    webClient.Encoding = Encoding.UTF8;
                    string requestUrl = url;
                    if (!string.IsNullOrWhiteSpace(data))
                    {
                        requestUrl = url + "?" + data;
                    }
                    string srcString = webClient.DownloadString(requestUrl);
                    var t2 = DateTime.Now;
                    var tCons = t2 - t1;
                    return srcString;
                }
                catch (Exception ex)
                {
                    string exStr = ex.Message;
                    return string.Format("{\"Code\":{0},\"Message\":\"{1}\",\"ReTime\":\"\",\"Result\":null}",
                       1220, "API接口服务器异常");
                }
            }
        }

        /// <summary>
        /// Get JsonView 视图切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabGetResponse_Selected(object sender, TabControlEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGetResult.Text)) { MessageBox.Show("请输入Json串"); return; }
            JsonToTreeView(tvGetJsonView, StringHelper.RemoveSpecialChar(txtGetResult.Text));
            tvGetJsonView.Nodes[0].Expand();
        }

        /// <summary>
        /// Post JsonView 视图切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPostResponse_Selected(object sender, TabControlEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtPostResult.Text)) { MessageBox.Show("请输入Json串"); return; }
            JsonToTreeView(tvPostJsonView, StringHelper.RemoveSpecialChar(txtPostResult.Text));
            tvPostJsonView.Nodes[0].Expand();
        }

        /// <summary>
        /// Json 转TreeView 对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        public TreeView JsonToTreeView(object sender, string jsonStr)
        {
            TreeView tv = (TreeView)sender;
            tv.Nodes.Clear();
            TreeNode rootNode = new TreeNode();
            rootNode.Tag = "JSON";
            rootNode.Text = "JSON";
            tv.Nodes.Add(rootNode);
            var tempDatas = JsonConvert.DeserializeObject<object>(jsonStr);
            CreateSubNode(jsonStr, rootNode);
            return tv;
        }

        /// <summary>
        /// 绑定TreeView子节点对象
        /// </summary>
        /// <param name="jsonStr"></param>
        /// <param name="parentNode"></param>
        public void CreateSubNode(string jsonStr, TreeNode parentNode, int viewType = 1)
        {
            JObject tempObj = null;
            try
            {
                tempObj = JObject.Parse(jsonStr);
            }
            catch { }

            if (viewType == 2)
            {
                if (jsonStr.IndexOf("{") == -1 && jsonStr.IndexOf("}") == -1)
                {
                    TreeNode node = new TreeNode();
                    node.Tag = jsonStr;
                    node.Text = $" \"{jsonStr}\"";
                    parentNode.Nodes.Add(node);
                    return;
                }
            }

            var ps = tempObj.Properties();
            foreach (var p in ps)
            {
                var name = p.Name;
                var value = p.Value;
                var type = value.Type;

                TreeNode node = new TreeNode();
                node.Tag = name;
                switch (type)
                {
                    case JTokenType.Object:
                        node.Text = $" {name}";
                        break;
                    case JTokenType.Array:
                        node.Text = $" [{value.Count()}]{name}";
                        break;
                    case JTokenType.Integer:
                    case JTokenType.Boolean:
                    case JTokenType.Float:
                        node.Text = $" {name} : {value}";
                        break;
                    default:
                        if (value != null && value.ToString() == "")
                        {
                            node.Text = $" {name} : <null>";
                        }
                        else
                        {
                            node.Text = $" {name} : \"{value}\"";
                        }
                        break;
                }
                parentNode.Nodes.Add(node);

                if (type == JTokenType.Object)
                {
                    CreateSubNode(value.ToString(), node);
                }

                if (type == JTokenType.Array)
                {
                    var i = 0;
                    foreach (var item in value)
                    {
                        if (item.Type == JTokenType.Object)
                        {
                            TreeNode subNode = new TreeNode();
                            subNode.Tag = name;
                            subNode.Text = $"[{i}]";
                            node.Nodes.Add(subNode);
                            CreateSubNode(item.ToString(), subNode);
                        }
                        else
                        {
                            CreateSubNode(item.ToString(), node, 2);
                        }
                        i++;
                    }
                }

            }
        }
    }
}


