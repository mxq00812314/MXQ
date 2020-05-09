using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DBManager;
using System.IO;
using EP.Common;
using Common;
using Aspose.Cells;
using EP.YSDZP.Local.Realization;
using DB;

namespace DBLite
{
    public partial class fmMySql : Form
    {
        MySqlDBHelper sh = null;
        IniFileHelper iniFile = new IniFileHelper();
        TreeNode CacheTreeNodeCollection = null;
        TreeNode CacheSelectedNode = null;
        Timer tvFilterTimer = new Timer();
        fmDataGridViewFilter dataFilter;
        fmModifyCode modifyCode;

        public fmMySql(DbServer server)
        {
            InitializeComponent();

            #region 设置标题

            this.Text = $"[{server.DbServerName} - {server.DbServerName}@{server.DbServerHost}]";

            #endregion

            #region 数据库设置

            sh = new MySqlDBHelper(server.DbServerConnection);

            #endregion

            #region 表结构 复选框初始化

            new Common.DataGridViewEx(dgvResult);
            this.dgvResult.EditMode = DataGridViewEditMode.EditProgrammatically;
            #endregion

            #region 表数据 复选框初始化

            new Common.DataGridViewEx(dgvDataResult);

            #endregion

            #region TreeView表过滤执行间隔 初始化

            this.tvFilterTimer.Interval = 300;
            this.tvFilterTimer.Tick += TreeView_FilterIng;

            #endregion

            #region 筛选插件数据-->初始化

            this.dataFilter = new fmDataGridViewFilter(new List<string>());

            #endregion

            #region 维护代码插件数据-->初始化

            this.modifyCode = new fmModifyCode(new DataTable());

            #endregion
        }

        private void fmMySql_Load(object sender, EventArgs e)
        {
            tv_bind();
            tsddbcboMode.SelectedIndex = 0;
        }

        #region  TreeView 事件处理

        /// <summary>
        ///  TreeView 展开 前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvMySql_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Name == "DataBases")
                tvClearSelected();
        }

        /// <summary>
        ///  TreeView 选中 前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvMySql_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Name == "DataBases")
                tvClearSelected();
        }

        /// <summary>
        /// TreeView 展开 后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvMySql_AfterExpand(object sender, TreeViewEventArgs e)
        {
            var tnNode = e.Node;
            tvMySql.BeginUpdate();

            switch (tnNode.Name)
            {
                case "DataBases":
                    tvNodeSelected(tnNode);
                    tnNode.ImageIndex = 5;
                    tnNode.SelectedImageIndex = 5;
                    break;
                case "Tables":
                    tnNode.ImageIndex = 6;
                    tnNode.SelectedImageIndex = 6;
                    if (tnNode.GetNodeCount(true) == 1)
                    {
                        BeginInvoke((MethodInvoker)delegate ()
                        {
                            tnNode.Nodes.Clear();
                            bind_DataTables(tnNode);
                        });
                    }
                    break;
                case "Views":
                    tnNode.ImageIndex = 6;
                    tnNode.SelectedImageIndex = 6;
                    if (tnNode.GetNodeCount(true) == 1)
                    {
                        BeginInvoke((MethodInvoker)delegate ()
                        {
                            tnNode.Nodes.Clear();
                            bind_DataViews(tnNode);
                        });
                    }
                    break;
                case "Procs":
                    tnNode.ImageIndex = 6;
                    tnNode.SelectedImageIndex = 6;
                    if (tnNode.GetNodeCount(true) == 1)
                    {
                        BeginInvoke((MethodInvoker)delegate ()
                        {
                            tnNode.Nodes.Clear();
                            bind_DataStoredProcedures(tnNode);
                        });
                    }
                    break;

            }
            tvMySql.EndUpdate();
            tvMySql.Update();
        }

        /// <summary>
        ///  TreeView 折叠 后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvMySql_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            var tnNode = e.Node;
            switch (tnNode.Name)
            {
                case "DataBases":
                    break;
                case "Tables":
                    tnNode.ImageIndex = 3;
                    break;
                case "Views":
                    break;
                case "Procs":
                    break;
                case "TableItem":
                    break;
                case "ViewItem":
                    break;
                case "ProcItem":
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// TreeView 选中 后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvMySql_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var tnNode = e.Node;
            switch (tnNode.Name)
            {
                case "DataBases":
                    tvNodeSelected(tnNode);
                    break;
                case "Tables":
                    break;
                case "Views":
                    break;
                case "Procs":
                    break;
                case "TableItem":
                    break;
                case "ViewItem":
                    break;
                case "ProcItem":
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// TreeView 双击选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvMySql_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tabResult.SelectedIndex = 2;
            txtResult.Text = "";
            DataTable dt = new DataTable();
            TreeView t = sender as TreeView;
            TreeNode tn = new TreeNode();
            TreeNode tnDataBaseNode = new TreeNode();
            tn = t.SelectedNode;
            lblDbName.Text = tn.Tag != null ? ((DbModel)tn.Tag).DatabaseName : "";
            DataGridViewDbSource.DbName = lblDbName.Text;
            switch (tn.Name)
            {
                case "TableItem":
                    BeginInvoke((MethodInvoker)delegate ()
                    {
                        tsbPagerSetEnabled("init");
                        tsbFilterSetEnabled("cannel");

                        DataGridViewDbSource.DataGrivViewPageIndex = 1;
                        DataGridViewDbSource.DataGrivViewPageSize = 100;

                        if (((DbModel)tn.Tag).TableRows % DataGridViewDbSource.DataGrivViewPageSize == 0)
                            DataGridViewDbSource.DataGrivViewMaxPage = ((DbModel)tn.Tag).TableRows / DataGridViewDbSource.DataGrivViewPageSize;
                        else
                            DataGridViewDbSource.DataGrivViewMaxPage = (((DbModel)tn.Tag).TableRows / DataGridViewDbSource.DataGrivViewPageSize) + 1;

                        DataGridViewDbSource.DbName = ((DbModel)tn.Tag).DatabaseName;
                        DataGridViewDbSource.DbTableName = ((DbModel)tn.Tag).TableName;
                        DataGridViewDbSource.DbTableComment = ((DbModel)tn.Tag).TableComment;
                        DataGridViewDbSource.DbSource = sh.getTableInfo(((DbModel)tn.Tag).DatabaseName, ((DbModel)tn.Tag).TableName);
                        DataGridViewDbSource.DbOrderByFiled = string.Join(",", GetDataTableOrderByFlied(DataGridViewDbSource.DbSource).ToArray());
                        txtResult.Text = sh.getTableTop100_ToSql(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC");
                        DataGridViewDbSource.DbDataSource = sh.getTableTop100(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC");

                        lblTableName.Text = ((DbModel)tn.Tag).TableName;
                        tsbtxtPagerIndex.Text = string.Format("{0}", DataGridViewDbSource.DataGrivViewPageIndex);
                        dgvResult.DataSource = DataGridViewDbSource.DbSource;
                        dgvDataResult.DataSource = DataGridViewDbSource.DbDataSource;
                        tsbBtnPagerLblPageNumber.Text = $"{DataGridViewDbSource.DataGrivViewPageIndex }/{DataGridViewDbSource.DataGrivViewMaxPage }";

                        EntityCache entityCache = LocalCache.GetEntityCache();
                        txtNameSpace.Text = entityCache?.NameSpace;
                        txtEntityName.Text = ((DbModel)tn.Tag).TableName;
                    });

                    break;
                case "ViewItem":
                    txtResult.Text = "";
                    DataTable dt1 = sh.getViewInfo(((DbModel)tn.Tag).DatabaseName, ((DbModel)tn.Tag).ViewName);
                    foreach (DataRow dt_dr in dt1.Rows)
                    {
                        txtResult.Text += dt_dr["text"];
                    }
                    break;
                case "ProcItem":
                    txtResult.Text = "";
                    txtResult.Dock = DockStyle.Fill;
                    DataTable dt2 = sh.getViewInfo(((DbModel)tn.Tag).DatabaseName, ((DbModel)tn.Tag).ProcName);
                    foreach (DataRow dt_dr in dt2.Rows)
                    {
                        txtResult.Text += dt_dr["text"];
                    }
                    break;
            }
        }

        /// <summary>
        /// TreeView 取消选中 加粗
        /// </summary>
        private void tvClearSelected()
        {
            if (CacheSelectedNode == null)
                return;
            var tvNode = CacheSelectedNode;
            tvNode.NodeFont = new System.Drawing.Font("宋体", 9, FontStyle.Regular);
            tvNode.Checked = false;
            tvNode.ImageIndex = 2;
            CacheSelectedNode = null;
        }

        /// <summary>
        /// TreeView 选中 加粗文字
        /// </summary>
        /// <param name="tvNode"></param>
        private void tvNodeSelected(TreeNode tvNode)
        {
            if (tvNode != null)
            {
                switch (tvNode.Name)
                {
                    case "DataBases":
                        tvNode.NodeFont = new System.Drawing.Font("宋体", 9, FontStyle.Bold);
                        lblDbName.Text = ((DbModel)tvNode.Tag).DatabaseName;
                        lblTableName.Text = "";
                        CacheSelectedNode = tvNode;
                        break;
                    case "TableItem":
                        lblDbName.Text = ((DbModel)tvNode.Tag).DatabaseName;
                        lblTableName.Text = ((DbModel)tvNode.Tag).TableName;
                        break;
                    case "ViewItem":
                        break;
                    case "ProcItem":
                        break;
                }
            }
        }

        #endregion

        #region 左侧导航 功能区

        //绑定treeView
        public void tv_bind()
        {
            TreeView tv = tvMySql;
            TreeNode tnMain = new TreeNode();
            tnMain.Text = "数据库";
            tnMain.ToolTipText = "数据库";
            tnMain.ImageIndex = 1;
            tnMain.SelectedImageIndex = 1;
            tnMain.Name = "Root";

            tv.Scrollable = true;
            tv.TopNode = tnMain;
            tv.Nodes.Add(tnMain);

            bind_DataBase(tnMain);

            tv.Nodes[0].Expand();
        }

        // 表初始化
        private static void TableInit(TreeNode tn)
        {
            TreeNode tnTables = new TreeNode();
            tnTables.Text = "表";
            tnTables.ToolTipText = "表";
            tnTables.ImageIndex = 3;
            tnTables.SelectedImageIndex = 3;
            tnTables.Tag = new DbModel()
            {
                DatabaseName = ((DbModel)tn.Tag).DatabaseName
            };
            tnTables.Name = "Tables";

            tnTables.Nodes.Add("");

            tn.Nodes.Add(tnTables);
        }

        //视图初始化
        private static void ViewInit(TreeNode tn)
        {
            TreeNode tnViews = new TreeNode();
            tnViews.Text = "视图";
            tnViews.ToolTipText = "视图";
            tnViews.ImageIndex = 3;
            tnViews.SelectedImageIndex = 3;
            tnViews.Tag = new DbModel()
            {
                DatabaseName = ((DbModel)tn.Tag).DatabaseName
            };
            tnViews.Name = "Views";
            tnViews.Nodes.Add("");

            tn.Nodes.Add(tnViews);
        }

        //存储过程初始化
        private static void ProcInit(TreeNode tn)
        {
            TreeNode tnProcs = new TreeNode();
            tnProcs.Text = "存储过程";
            tnProcs.ToolTipText = "存储过程";
            tnProcs.ImageIndex = 3;
            tnProcs.SelectedImageIndex = 3;
            tnProcs.Tag = new DbModel()
            {
                DatabaseName = ((DbModel)tn.Tag).DatabaseName
            };
            tnProcs.Name = "Procs";

            tnProcs.Nodes.Add("");

            tn.Nodes.Add(tnProcs);
        }

        //绑定 数据库
        public void bind_DataBase(TreeNode node)
        {
            DataTable dt = sh.DataBaseBind();
            foreach (DataRow dt_dr in dt.Rows)
            {
                TreeNode tn = new TreeNode();
                tn.Text = dt_dr["Database"].ToString();
                tn.ToolTipText = "DataBases"; //dt_dr["Database"].ToString();
                tn.Name = "DataBases";
                tn.ImageIndex = 2;
                tn.SelectedImageIndex = 2;
                tn.Tag = new DbModel()
                {
                    DatabaseName = tn.Text,
                };

                TableInit(tn);

                ViewInit(tn);

                ProcInit(tn);

                node.Nodes.Add(tn);
            }
        }

        //绑定表
        public void bind_DataTables(TreeNode node)
        {
            DataTable dt = sh.DataTableBind(((DbModel)node.Tag).DatabaseName);
            foreach (DataRow dt_dr in dt.Rows)
            {
                if (dt_dr["Comment"].ToString() == "VIEW")
                    continue;
                TreeNode tn = new TreeNode();
                tn.Text = dt_dr["NAME"].ToString();
                tn.ToolTipText = dt_dr["NAME"].ToString()
                    + "\r" + dt_dr["Comment"].ToString()
                    + "\rRows:" + Convert.ToInt32(dt_dr["Rows"] ?? 0);
                tn.ImageIndex = 4;
                tn.SelectedImageIndex = 4;
                tn.Tag = new DbModel()
                {
                    DatabaseName = ((DbModel)node.Tag).DatabaseName,
                    TableName = dt_dr["NAME"].ToString(),
                    TableComment = dt_dr["Comment"].ToString(),
                    TableRows = Convert.ToInt32(dt_dr["Rows"] ?? 0)
                };
                tn.Name = "TableItem";
                node.Nodes.Add(tn);
            }
        }

        //绑定视图
        public void bind_DataViews(TreeNode node)
        {
            DataTable dt = sh.DataViewBind(((DbModel)node.Tag).DatabaseName);
            foreach (DataRow dt_dr in dt.Rows)
            {
                TreeNode tn = new TreeNode();
                tn.Text = dt_dr["TABLE_NAME"].ToString();
                tn.ToolTipText = dt_dr["TABLE_NAME"].ToString();
                tn.ImageIndex = 4;
                tn.SelectedImageIndex = 4;
                tn.Tag = new DbModel()
                {
                    DatabaseName = ((DbModel)node.Tag).DatabaseName,
                    ViewName = dt_dr["TABLE_NAME"].ToString()
                };
                tn.Name = "ViewItem";
                node.Nodes.Add(tn);
            }
        }

        //绑定存储过程
        public void bind_DataStoredProcedures(TreeNode node)
        {
            DataTable dt = sh.DataStoredProcedureBind(((DbModel)node.Tag).DatabaseName);
            foreach (DataRow dt_dr in dt.Rows)
            {
                TreeNode tn = new TreeNode();
                tn.Text = dt_dr["NAME"].ToString();
                tn.ToolTipText = dt_dr["NAME"].ToString();
                tn.ImageIndex = 4;
                tn.SelectedImageIndex = 4;
                tn.Tag = new DbModel()
                {
                    DatabaseName = ((DbModel)node.Tag).DatabaseName,
                    ProcName = dt_dr["NAME"].ToString()
                };
                tn.Name = "ProcItem";
                node.Nodes.Add(tn);
            }
        }

        /// <summary>
        /// 获取.NET 数据类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string GetFiledType(string type)
        {
            string rst = "";
            switch (type)
            {
                case "tinyint":
                    rst = "Int16";
                    break;
                case "smallint":
                    rst = "short";
                    break;
                case "double":
                    rst = "double";
                    break;
                case "decimal":
                    rst = "decimal";
                    break;
                case "float":
                    rst = "float";
                    break;
                case "bit":
                    rst = "bool";
                    break;
                case "int":
                    rst = "int";
                    break;
                case "bigint":
                    rst = "long";
                    break;
                case "varchar":
                case "char":
                    rst = "string";
                    break;
                case "nvarchar":
                    rst = "string";
                    break;
                case "datetime":
                case "timestamp":
                case "date":
                    rst = "DateTime";
                    break;
                case "text":
                    rst = "string";
                    break;
                default:
                    rst = type;
                    break;
            }
            return rst;
        }

        /// <summary>
        /// 获取MySql 数据类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string GetSqlType(string type)
        {
            string rst = "";
            switch (type)
            {
                case "int":
                    rst = "MySqlDbType.Int32";
                    break;
                case "bigint":
                    rst = "MySqlDbType.Int64";
                    break;
                case "varchar":
                case "char":
                    rst = "MySqlDbType.VarChar";
                    break;
                case "nvarchar":
                    rst = "MySqlDbType.VarChar";
                    break;
                case "datetime":
                case "timestamp":
                    rst = "MySqlDbType.DateTime";
                    break;
                case "date":
                    rst = "MySqlDbType.Date";
                    break;
                case "text":
                    rst = "MySqlDbType.Text";
                    break;
                case "bit":
                    rst = "MySqlDbType.Bit";
                    break;
                case "byte":
                    rst = "MySqlDbType.Byte";
                    break;
                case "double":
                    rst = "MySqlDbType.Double";
                    break;
                case "decimal":
                    rst = "MySqlDbType.Decimal";
                    break;
                case "float":
                    rst = "MySqlDbType.Float";
                    break;
                case "tinyint":
                case "smallint":
                    rst = "MySqlDbType.Int16";
                    break;
                default:
                    rst = "unknow";
                    break;
            }
            return rst;
        }

        /// <summary>
        /// 复制到剪贴板
        /// </summary>
        /// <param name="CopyStr"></param>
        private void CopyMethod(string CopyStr)
        {
            if (!string.IsNullOrEmpty(CopyStr))
            {
                Clipboard.SetText(CopyStr);
            }
        }

        #endregion

        #region 右侧功能 功能区


        /// <summary>
        /// 生成实体类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateModelLibrary_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewDbSource.DbSource;
            if (dt == null) return;
            if (cboTemplates.SelectedItem == null) return;
            if (DataGridViewDbSource.DbTableName == null) return;

            string tableName = DataGridViewDbSource.DbTableName.ToString();
            string classNameStr = !string.IsNullOrWhiteSpace(txtEntityName.Text.Trim()) ? txtEntityName.Text.Trim() : tableName;
            DataTableStruct tableStruct = dt.ToModel(txtNameSpace.Text.Trim(), classNameStr, tableName, "?");
            var templateFile = cboTemplates.SelectedItem.ToString();
            var templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "templates");
            var templateFilePath = Path.Combine(templatePath, templateFile);
            if (!Directory.Exists(templatePath)) { MessageBox.Show("模板文件夹不存在！"); return; }
            if (!File.Exists(templateFilePath)) { MessageBox.Show("模板文件不存在！"); return; }

            VelocityHelper velocityEngine = new VelocityHelper(templatePath);
            velocityEngine.Add($"CreateDateTime", tableStruct.CreateDateTime);
            velocityEngine.Add($"ParmPrefix", tableStruct.ParmPrefix);
            velocityEngine.Add($"ClassNameSpace", $"{tableStruct.ClassNameSpace}");
            velocityEngine.Add($"ClassName", tableStruct.ClassName);
            velocityEngine.Add($"TableName", tableStruct.Table);
            velocityEngine.Add($"PrimaryKey", tableStruct.PrimaryKeyColumn != null ? tableStruct.PrimaryKeyColumn : tableStruct.FirstColumn);
            velocityEngine.Add($"FliedCollection", tableStruct.DataColumnCollection);
            velocityEngine.Add($"FliedArr", string.Join(", ", tableStruct.DataColumnCollection.Select(n => n.Column.ToPascal()).ToArray()));
            velocityEngine.Add($"FliedParmArr", string.Join(", ", tableStruct.DataColumnCollection.Select(n => $"{tableStruct.ParmPrefix}{n.Column.ToPascal()}").ToArray()));
            velocityEngine.Add($"FliedModifyParmArr", string.Join(", ", (tableStruct.DataColumnCollection.Where(n => n.IsPrimaryKey == false)).Select(n => $"{n.Column.ToPascal()} = {tableStruct.ParmPrefix}{n.Column.ToPascal()}").ToArray()));
            string sb = velocityEngine.OutPut($"\\{templateFile}");
            txtResult.Text = sb.ToString();
            tabResult.SelectedIndex = 1;
        }

        /// <summary>
        /// 表结构
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFieldArr_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewDbSource.DbSource;
            if (dt == null) return;
            var ckedFileList = Common.DataGridViewEx.DataGridViewSelectedFliedList(dgvResult, 0);
            StringBuilder sb = new StringBuilder();
            #region 基础数据
            var tablename = DataGridViewDbSource.DbTableName;
            var tableComment = DataGridViewDbSource.DbTableComment;
            var count = dt.Rows.Count;
            #endregion

            Workbook workbook = new Workbook();
            Worksheet sheet = (Worksheet)workbook.Worksheets[0];

            sheet.Cells.Merge(0, 0, 1, 5);
            sheet.Cells[0, 0].PutValue(tablename + tableComment + "表结构");

            #region 表结构表头
            if (ckVertical.Checked)
            {
                sheet.Cells[1, 0].PutValue("字段");
                sheet.Cells[1, 1].PutValue("描述");
                if (ckDbFiledType.Checked)
                {
                    sheet.Cells[1, 2].PutValue("类型");
                    sheet.Cells[1, 3].PutValue("长度");
                    sheet.Cells[1, 4].PutValue("是否必填");
                }
            }
            else
            {

            }

            #endregion
            var j = 0;
            for (int i = 0; i < count; i++)
            {
                var fliedClassName = dt.Rows[i]["列名"].ToString();
                var fliedName = dt.Rows[i]["列名"].ToString();
                var fliedtype = dt.Rows[i]["数据类型"].ToString();
                var len = dt.Rows[i]["长度"].ToString();
                var IsNull = dt.Rows[i]["IsNull"].ToString();
                var info = dt.Rows[i]["说明"].ToString();
                var displayName = dt.Rows[i]["说明"].ToString();

                #region 正选/反选处理

                if (rdoFaceSide.Checked)
                {
                    if (ckedFileList.Count > 0 && !ckedFileList.Contains(fliedClassName))
                        continue;
                }
                if (rdoReverSide.Checked)
                {
                    if (ckedFileList.Count > 0 && ckedFileList.Contains(fliedClassName))
                        continue;
                }
                #endregion

                sb.Append(fliedClassName + "|" + info + ",\r\n");
                //垂直顺序
                if (ckVertical.Checked)
                {
                    //写入标题
                    sheet.Cells[j + 2, 0].PutValue(fliedClassName);
                    //写入数值
                    sheet.Cells[j + 2, 1].PutValue(info);
                    //写入数据类型
                    if (ckDbFiledType.Checked)
                    {
                        sheet.Cells[j + 2, 2].PutValue(fliedtype);
                        sheet.Cells[j + 2, 3].PutValue(len);
                        sheet.Cells[j + 2, 4].PutValue(IsNull);
                    }
                }
                else
                {

                    //写入标题
                    sheet.Cells[1, j + 1].PutValue(fliedClassName);
                    //写入数值
                    sheet.Cells[2, j + 1].PutValue(info);

                    //写入数据类型
                    if (ckDbFiledType.Checked)
                    {
                        sheet.Cells[3, j + 1].PutValue(fliedtype);
                        sheet.Cells[4, j + 1].PutValue(len);
                        sheet.Cells[5, j + 1].PutValue(IsNull);
                    }
                }
                j++;
            }
            sheet.AutoFitRows();
            sheet.AutoFitColumns();
            string saveFilePath = System.Environment.CurrentDirectory, fileName = tablename + tableComment + "_表结构_" + DateTime.Now.ToString("HHmmss");
            string saveFileName = Path.Combine(saveFilePath, fileName + ".xls");
            workbook.Save(saveFileName);
            System.Diagnostics.Process.Start("explorer.exe", @"/select," + saveFileName);
            txtResult.Text = sb.ToString().TrimEnd(',');
            tabResult.SelectedIndex = 1;
        }

        
        /// <summary>
        /// 过滤表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblDbName.Text) || lblDbName.Text == "lblDbName")
                return;

            if (!tvFilterTimer.Enabled)
                tvFilterTimer.Start();
            else
            {
                tvFilterTimer.Stop();
                tvFilterTimer.Start();
            }
        }

        public void TreeView_FilterIng(object sender, EventArgs e)
        {
            tvFilterTimer.Stop();
            tvMySql.BeginUpdate();
            var filter = txtFilter.Text;
            List<TreeNode> TempFilterRstNodeList = new List<TreeNode>();

            foreach (TreeNode tvNode in tvMySql.Nodes[0].Nodes)
            {
                //找到选中的数据库
                if (tvNode.Text == lblDbName.Text)
                {
                    foreach (TreeNode subNode in tvNode.Nodes)
                    {
                        //找到数据库下的表容器
                        if (subNode.Name == "Tables")
                        {
                            if (string.IsNullOrWhiteSpace(filter))
                            {
                                if (CacheTreeNodeCollection == null)
                                    return;
                                subNode.Nodes.Clear();
                                foreach (TreeNode tableItemNode in CacheTreeNodeCollection.Nodes)
                                    subNode.Nodes.Add(tableItemNode);
                                CacheTreeNodeCollection = null;
                                txtMiddleTopInput.Text = "";
                                break;
                            }
                            else if (!string.IsNullOrWhiteSpace(filter) && CacheTreeNodeCollection == null)
                                CacheTreeNodeCollection = (TreeNode)subNode.Clone();


                            var nodeArr = subNode.Nodes;
                            if (CacheTreeNodeCollection != null)
                                nodeArr = CacheTreeNodeCollection.Nodes;

                            foreach (TreeNode subTableItemNode in nodeArr)
                            {
                                if (subTableItemNode != null && subTableItemNode.Text.IndexOf(filter) != -1)
                                    TempFilterRstNodeList.Add(subTableItemNode);
                            }
                            if (TempFilterRstNodeList.Count > 0)
                            {
                                subNode.Nodes.Clear();
                                foreach (TreeNode tableItemNode in TempFilterRstNodeList)
                                    subNode.Nodes.Add(tableItemNode);
                                TempFilterRstNodeList = new List<TreeNode>();
                                break;
                            }
                        }
                    }
                    break;
                }
            }



            tvMySql.EndUpdate();
        }

        /// <summary>
        /// 复制到剪贴板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopyMethod(txtResult.Text);
        }

        /// <summary>
        /// 生成数组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewDbSource.DbSource;
            var ckedFileList = Common.DataGridViewEx.DataGridViewSelectedFliedList(dgvResult, 0);
            if (dt == null) return;
            #region
            var tablename = DataGridViewDbSource.DbTableName;
            var count = dt.Rows.Count;
            #endregion
            string flieds = "";

            for (int i = 0; i < count; i++)
            {
                var fliedDataName = dt.Rows[i]["列名"].ToString();
                var tempDataName = "";
                #region 正选/反选处理

                if (rdoFaceSide.Checked)
                {
                    if (ckedFileList.Count > 0 && !ckedFileList.Contains(fliedDataName))
                        continue;
                }
                if (rdoReverSide.Checked)
                {
                    if (ckedFileList.Count > 0 && ckedFileList.Contains(fliedDataName))
                        continue;
                }
                #endregion

                #region 字段外包裹字符处理
                if (ckStringInclude.Checked)
                {
                    tempDataName = txtStringIncludeBefor.Text + fliedDataName + txtStringIncludeAfter.Text + ", ";
                }
                else
                {
                    tempDataName = fliedDataName + ", ";
                }
                #endregion

                #region 数组格式模式 JSON数据处理

                if (rdoJsonArray.Checked)
                {
                    if (ckStringInclude.Checked)
                    {
                        tempDataName = "\t" + txtStringIncludeBefor.Text + fliedDataName + txtStringIncludeAfter.Text;
                        tempDataName += " : " + fliedDataName + ", \r\n";
                    }
                    else
                    {
                        tempDataName = "\t" + fliedDataName + " : " + fliedDataName + ", \r\n";
                    }
                }

                #endregion

                flieds += tempDataName;
            }
            #region 去掉最后的 逗号 ","

            flieds = flieds.TrimEnd(' ');
            flieds = flieds.TrimEnd(',');

            #endregion

            #region 小写处理
            if (rdoStringLower.Checked)
            {
                flieds = flieds.ToLower();
            }
            #endregion

            #region 大写处理
            if (rdoStringUpper.Checked)
            {
                flieds = flieds.ToUpper();
            }
            #endregion

            #region 分隔符处理
            if (ckStringSplit.Checked)
            {
                flieds = flieds.Replace(',', Char.Parse(txtStringSplit.Text));
            }
            #endregion

            #region 数组格式模式 还是JSON数据处理 首位 大括号
            if (rdoJsonArray.Checked)
            {
                flieds = "{\r\n" + flieds + "}";
            }
            #endregion

            txtResult.Text = flieds;
            tabResult.SelectedIndex = 1;
        }

        #endregion

        #region 中间上部 功能区

        /// <summary>
        /// 执行T_SQL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbTopRunSql_Click(object sender, EventArgs e)
        {
            var inputT_Sql = txtMiddleTopInput.Text;
            if (string.IsNullOrWhiteSpace(inputT_Sql))
            {
                txtResult.Text = "请输入要执行的T_SQL语句";
                tabResult.SelectedIndex = 1;
                return;
            }
            tsbTopRunSql.Enabled = true;
            StringBuilder T_Sql = new StringBuilder();
            T_Sql.Append($"BEGIN ");
            T_Sql.Append($"\r\n");
            T_Sql.Append(inputT_Sql);

            if (inputT_Sql.ToLower().IndexOf("limit") == -1)
            {
                inputT_Sql = inputT_Sql.TrimEnd(' ');
                inputT_Sql = inputT_Sql.TrimEnd(';');
                inputT_Sql = inputT_Sql + "\r\n Limit 0, 100;";
            }
            T_Sql.Append($"\r\n");
            T_Sql.Append($"ROLLBACK ");

            BeginInvoke((MethodInvoker)delegate ()
             {
                 try
                 {

                     LogHelper.Error(T_Sql.ToString());
                     var rst = sh.runT_Sql(T_Sql.ToString());
                     if (rst.DbResultType == DbResultType.db_DataTable)
                     {
                         dgvDataResult.DataSource = rst.DbResultData;
                         txtResult.Text = "执行完成:\r\n" + inputT_Sql;
                         tabResult.SelectedIndex = 2;
                     }
                     else
                     {
                         txtResult.Text = rst.DbResultData.ToString();
                         tabResult.SelectedIndex = 1;
                     }
                 }
                 catch
                 {
                     tsbTopRunSql.Enabled = false;
                 }
             });
        }

        #endregion

        #region 中间下部 功能区

        #region 表数据-->功能

        /// <summary>
        ///  表数据-->筛选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBtnFilter_Click(object sender, EventArgs e)
        {
            tsbBtnFilter.Enabled = false;
            var fliedList = GetDataTableAllFlied((DataTable)dgvResult.DataSource);
            this.dataFilter = new fmDataGridViewFilter(fliedList);

            this.dataFilter.FilterYes += new fmDataGridViewFilter.DataGridViewFilterEventHandler(dataFilter_FilterYes);
            this.dataFilter.FilterClose += new fmDataGridViewFilter.DataGridViewFilterCloserEventHandler(dataFilter_Close);

            this.dataFilter.StartPosition = FormStartPosition.Manual;
            this.dataFilter.Location = Control.MousePosition;
            this.dataFilter.BringToFront();
            this.dataFilter.TopMost = true;
            this.dataFilter.Show();
        }

        /// <summary>
        ///  表数据-->筛选处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void dataFilter_FilterYes(object sender, EventArgs e)
        {
            tsbPagerSetEnabled("init");

            tsbFilterSetEnabled("run");

            tsbtxtPagerIndex.Text = string.Format("{0}", 1);
            DataGridViewDbSource.DataGrivViewPageIndex = 1;
            txtResult.Text = sh.getTableTop100_ToSql(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC", 1, DataGridViewDbSource.DataGrivViewPageSize);
            DataGridViewDbSource.DbDataSource = sh.getTableTop100(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC", 1, DataGridViewDbSource.DataGrivViewPageSize);
            dgvDataResult.DataSource = DataGridViewDbSource.DbDataSource;
            tsbBtnPagerLblPageNumber.Text = $"{DataGridViewDbSource.DataGrivViewPageIndex }/{DataGridViewDbSource.DataGrivViewMaxPage }";
        }
        /// <summary>
        /// 表数据-->筛选关闭
        /// </summary>
        /// <param name="sender"></param>
        public void dataFilter_Close(object sender)
        {
            tsbPagerSetEnabled("init");
            tsbFilterSetEnabled("clear");
            tsbtxtPagerIndex.Text = string.Format("{0}", 1);
            DataGridViewDbSource.DataGrivViewPageIndex = 1;
            txtResult.Text = sh.getTableTop100_ToSql(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC", DataGridViewDbSource.DataGrivViewPageIndex, DataGridViewDbSource.DataGrivViewPageSize);
            DataGridViewDbSource.DbDataSource = sh.getTableTop100(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC", DataGridViewDbSource.DataGrivViewPageIndex, DataGridViewDbSource.DataGrivViewPageSize);
            dgvDataResult.DataSource = DataGridViewDbSource.DbDataSource;
            tsbBtnPagerLblPageNumber.Text = $"{DataGridViewDbSource.DataGrivViewPageIndex }/{DataGridViewDbSource.DataGrivViewMaxPage }";
        }

        /// <summary>
        ///  表数据-->清除筛选条件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBtnFilterCannel_Click(object sender, EventArgs e)
        {
            tsbPagerSetEnabled("init");
            tsbFilterSetEnabled("clear");
            tsbtxtPagerIndex.Text = string.Format("{0}", 1);
            DataGridViewDbSource.DataGrivViewPageIndex = 1;
            txtResult.Text = sh.getTableTop100_ToSql(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC", DataGridViewDbSource.DataGrivViewPageIndex, DataGridViewDbSource.DataGrivViewPageSize);
            DataGridViewDbSource.DbDataSource = sh.getTableTop100(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC", DataGridViewDbSource.DataGrivViewPageIndex, DataGridViewDbSource.DataGrivViewPageSize);
            dgvDataResult.DataSource = DataGridViewDbSource.DbDataSource;
            tsbBtnPagerLblPageNumber.Text = $"{DataGridViewDbSource.DataGrivViewPageIndex }/{DataGridViewDbSource.DataGrivViewMaxPage }";
        }

        /// <summary>
        ///  表数据-->刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBtnPagerReLoad_Click(object sender, EventArgs e)
        {
            tsbFilterSetEnabled("clear");
            tsbtxtPagerIndex.Text = string.Format("{0}", DataGridViewDbSource.DataGrivViewPageIndex);
            txtResult.Text = sh.getTableTop100_ToSql(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC", DataGridViewDbSource.DataGrivViewPageIndex, DataGridViewDbSource.DataGrivViewPageSize);
            DataGridViewDbSource.DbDataSource = sh.getTableTop100(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC", DataGridViewDbSource.DataGrivViewPageIndex, DataGridViewDbSource.DataGrivViewPageSize);
            dgvDataResult.DataSource = DataGridViewDbSource.DbDataSource;
            tsbBtnPagerLblPageNumber.Text = $"{DataGridViewDbSource.DataGrivViewPageIndex }/{DataGridViewDbSource.DataGrivViewMaxPage }";
        }

        /// <summary>
        ///  表数据-->首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBtnPagerTop_Click(object sender, EventArgs e)
        {
            tsbPagerSetEnabled("home");
            tsbtxtPagerIndex.Text = string.Format("{0}", 1);
            txtResult.Text = sh.getTableTop100_ToSql(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC", 1, DataGridViewDbSource.DataGrivViewPageSize);
            DataGridViewDbSource.DbDataSource = sh.getTableTop100(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC", 1, DataGridViewDbSource.DataGrivViewPageSize);
            dgvDataResult.DataSource = DataGridViewDbSource.DbDataSource;
            tsbBtnPagerLblPageNumber.Text = $"{DataGridViewDbSource.DataGrivViewPageIndex }/{DataGridViewDbSource.DataGrivViewMaxPage }";
        }

        /// <summary>
        ///  表数据-->上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBtnPagerPrev_Click(object sender, EventArgs e)
        {
            DataGridViewDbSource.DataGrivViewPageIndex--;
            if (DataGridViewDbSource.DataGrivViewPageIndex <= 1)
            {
                DataGridViewDbSource.DataGrivViewPageIndex = 1;
                tsbPagerSetEnabled("home");
            }
            else
            {
                tsbPagerSetEnabled("prev");
            }
            tsbtxtPagerIndex.Text = string.Format("{0}", DataGridViewDbSource.DataGrivViewPageIndex);
            txtResult.Text = sh.getTableTop100_ToSql(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC", DataGridViewDbSource.DataGrivViewPageIndex, DataGridViewDbSource.DataGrivViewPageSize);
            DataGridViewDbSource.DbDataSource = sh.getTableTop100(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC", DataGridViewDbSource.DataGrivViewPageIndex, DataGridViewDbSource.DataGrivViewPageSize);
            dgvDataResult.DataSource = DataGridViewDbSource.DbDataSource;
            tsbBtnPagerLblPageNumber.Text = $"{DataGridViewDbSource.DataGrivViewPageIndex }/{DataGridViewDbSource.DataGrivViewMaxPage }";
        }

        /// <summary>
        ///  表数据-->下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBtnPagerNext_Click(object sender, EventArgs e)
        {
            DataGridViewDbSource.DataGrivViewPageIndex++;
            if (DataGridViewDbSource.DataGrivViewPageIndex < DataGridViewDbSource.DataGrivViewMaxPage)
            {
                tsbPagerSetEnabled("next");
            }
            else
            {
                tsbPagerSetEnabled("last");
                DataGridViewDbSource.DataGrivViewPageIndex = DataGridViewDbSource.DataGrivViewMaxPage;
            }
            tsbtxtPagerIndex.Text = string.Format("{0}", DataGridViewDbSource.DataGrivViewPageIndex);
            txtResult.Text = sh.getTableTop100_ToSql(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC", DataGridViewDbSource.DataGrivViewPageIndex, DataGridViewDbSource.DataGrivViewPageSize);
            DataGridViewDbSource.DbDataSource = sh.getTableTop100(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC", DataGridViewDbSource.DataGrivViewPageIndex, DataGridViewDbSource.DataGrivViewPageSize);
            dgvDataResult.DataSource = DataGridViewDbSource.DbDataSource;
            tsbBtnPagerLblPageNumber.Text = $"{DataGridViewDbSource.DataGrivViewPageIndex }/{DataGridViewDbSource.DataGrivViewMaxPage }";
        }

        /// <summary>
        ///  表数据-->尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBtnPagerLast_Click(object sender, EventArgs e)
        {
            tsbPagerSetEnabled("last");
            DataGridViewDbSource.DataGrivViewPageIndex = DataGridViewDbSource.DataGrivViewMaxPage;
            tsbtxtPagerIndex.Text = string.Format("{0}", DataGridViewDbSource.DataGrivViewPageIndex);
            txtResult.Text = sh.getTableTop100_ToSql(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC", DataGridViewDbSource.DataGrivViewPageIndex, DataGridViewDbSource.DataGrivViewPageSize);
            DataGridViewDbSource.DbDataSource = sh.getTableTop100(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC", DataGridViewDbSource.DataGrivViewPageIndex, DataGridViewDbSource.DataGrivViewPageSize);
            dgvDataResult.DataSource = DataGridViewDbSource.DbDataSource;
            tsbBtnPagerLblPageNumber.Text = $"{DataGridViewDbSource.DataGrivViewPageIndex }/{DataGridViewDbSource.DataGrivViewMaxPage }";
        }

        /// <summary>
        ///  表数据-->跳转页数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbbtnPagerIndexGo_Click(object sender, EventArgs e)
        {
            var tempPageIndex = tsbtxtPagerIndex.Text;
            DataGridViewDbSource.DataGrivViewPageIndex = Convert.ToInt32(tempPageIndex);
            txtResult.Text = sh.getTableTop100_ToSql(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC", DataGridViewDbSource.DataGrivViewPageIndex, DataGridViewDbSource.DataGrivViewPageSize);
            DataGridViewDbSource.DbDataSource = sh.getTableTop100(DataGridViewDbSource.DbName, DataGridViewDbSource.DbTableName, dataFilter.SelectedFiledValue, DataGridViewDbSource.DbOrderByFiled, "DESC", DataGridViewDbSource.DataGrivViewPageIndex, DataGridViewDbSource.DataGrivViewPageSize);
            dgvDataResult.DataSource = DataGridViewDbSource.DbDataSource;
            tsbBtnPagerLblPageNumber.Text = $"{DataGridViewDbSource.DataGrivViewPageIndex }/{DataGridViewDbSource.DataGrivViewMaxPage }";
        }

        /// <summary>
        /// 表数据-->分页状态设置
        /// </summary>
        private void tsbPagerSetEnabled(string pageStatus)
        {
            switch (pageStatus)
            {
                case "init":
                case "home":
                    tsbBtnPagerTop.Enabled = false;
                    tsbBtnPagerPrev.Enabled = false;
                    tsbBtnPagerNext.Enabled = true;
                    tsbBtnPagerLast.Enabled = true;
                    break;
                case "prev":
                case "next":
                    tsbBtnPagerTop.Enabled = true;
                    tsbBtnPagerPrev.Enabled = true;
                    tsbBtnPagerNext.Enabled = true;
                    tsbBtnPagerLast.Enabled = true;
                    break;
                case "last":
                    tsbBtnPagerTop.Enabled = true;
                    tsbBtnPagerPrev.Enabled = true;
                    tsbBtnPagerNext.Enabled = false;
                    tsbBtnPagerLast.Enabled = false;
                    break;
                default:
                    tsbBtnPagerTop.Enabled = false;
                    tsbBtnPagerPrev.Enabled = false;
                    tsbBtnPagerNext.Enabled = true;
                    tsbBtnPagerLast.Enabled = true;
                    break;

            }
        }

        /// <summary>
        /// 表数据-->筛选状态设置
        /// </summary>
        /// <param name="filterStatus"></param>
        private void tsbFilterSetEnabled(string filterStatus)
        {
            switch (filterStatus)
            {
                case "run":
                    tsbBtnFilter.Enabled = true;
                    tsbBtnFilterCannel.Enabled = true;
                    break;
                case "init":
                case "clear":
                    tsbBtnFilterCannel.Enabled = false;
                    tsbBtnFilter.Enabled = true;
                    dataFilter.SelectedFiledValue = "";
                    break;
                default:
                    break;

            }
        }

        #endregion

        #region 表结构-->功能

        /// <summary>
        /// 获取DataTable 中的排序字段
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private List<string> GetDataTableOrderByFlied(DataTable dt)
        {

            List<string> resultFliedList = new List<string>();
            if (dt == null)
                return resultFliedList;
            List<string> tempFlagList = new List<string>();
            List<string> tempFirstList = new List<string>();
            List<string> tempDateList = new List<string>();
            foreach (DataRow dt_dr in dt.Rows)
            {
                if (dt_dr["标识列"].ToString() == "auto_increment")
                {
                    tempFlagList.Add(dt_dr["列名"].ToString());
                }

                if (tempFirstList.Count < 2)
                {
                    tempFirstList.Add(dt_dr["列名"].ToString());
                }

                if (tempDateList.Count < 2)
                {
                    var fliedName = dt_dr["列名"].ToString().ToLower();
                    if (fliedName.IndexOf("date") != -1 || fliedName.IndexOf("time") != -1)
                    {
                        tempDateList.Add(dt_dr["列名"].ToString());
                    }
                }
            }

            if (tempDateList.Count > 0)
            {
                resultFliedList = tempFirstList;
            }

            if (tempFlagList.Count > 0)
            {
                resultFliedList = tempFlagList;
            }

            if (tempDateList.Count == 0 && tempFlagList.Count == 0 && tempFirstList.Count > 0)
            {
                resultFliedList = tempFirstList;
            }

            return resultFliedList;
        }

        /// <summary>
        /// 表结构-->获取所有列名
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private List<string> GetDataTableAllFlied(DataTable dt)
        {
            List<string> resultFliedList = new List<string>();
            if (dt == null)
                return resultFliedList;
            foreach (DataRow dt_dr in dt.Rows)
            {
                resultFliedList.Add(dt_dr["列名"].ToString());
            }
            return resultFliedList;
        }

        #endregion

        #region DataGridView 公共方法

        /// <summary>
        /// 检测容器里是否存在控件
        /// </summary>
        /// <param name="subControlName">子空间Name</param>
        /// <param name="objParentConentControl">父控件容器</param>
        /// <returns>结果:存在:true,不存:false</returns>
        private Boolean ParentContentIsExitSubControl(string subControlName, Object objParentConentControl)
        {
            //遍历选项卡判断是否存在该子窗体
            foreach (Control con in ((Control)objParentConentControl).Controls)
            {
                if (con.Name == subControlName)
                {
                    return true;//存在
                }
            }
            return false;//不存在
        }

        /// <summary>
        /// 点击单元格 选中复选框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDataResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cell_Click(sender, e, 0);
        }

        /// <summary>
        /// 点击单元格 选中复选框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cell_Click(sender, e, 0);
        }

        /// <summary>
        /// 复选框 选中/非选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="CellIndex"></param>
        public void Cell_Click(object sender, DataGridViewCellEventArgs e, int CellIndex = 0)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == CellIndex)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)((DataGridView)sender).Rows[e.RowIndex].Cells[CellIndex];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {
                    checkCell.Value = false;
                }
                else
                {
                    checkCell.Value = true;
                }
            }
        }

        #endregion

        #endregion

        #region 顶部菜单 功能区
        private void tsmiNewDbConnection_Click(object sender, EventArgs e)
        {
            fmDbSererManager fm = new fmDbSererManager();
            fm.Show();
        }



        #endregion

        private void btnCreateHtmlOrJonData_Click(object sender, EventArgs e)
        {
            this.modifyCode = new fmModifyCode((DataTable)dgvResult.DataSource);
            this.modifyCode.McYes += new fmModifyCode.ModifyCodeEventHandler(ModifyCode_Yes);
            this.modifyCode.StartPosition = FormStartPosition.Manual;
            this.modifyCode.Location = new Point(this.Location.X + 200, this.Location.Y + 50);
            this.modifyCode.BringToFront();
            this.modifyCode.TopMost = true;
            this.modifyCode.Show();
        }

        private void ModifyCode_Yes(object sender, EventArgs e)
        {
            txtResult.Text = this.modifyCode.RstModifyCodeString;
            tabResult.SelectedIndex = 1;
            this.modifyCode.Hide();
        }

        private void dgvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ColumnIndex = e.ColumnIndex;
            int RowIndex = e.RowIndex;
            if (RowIndex > -1 && ColumnIndex > -1)
            {

                this.dgvResult.Columns[e.ColumnIndex].ReadOnly = false;
                this.dgvResult.Rows[e.RowIndex].ReadOnly = false;
                this.dgvResult.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = false;
                this.dgvResult.CurrentCell = this.dgvResult.Rows[e.RowIndex].Cells[e.ColumnIndex];//获取当前单元格
                this.dgvResult.BeginEdit(false);//将单元格设为编辑状态
            }
        }

        private void fmMySql_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }

    /// <summary>
    /// DataGridView 数据源对象
    /// </summary>
    public static class DataGridViewDbSource
    {
        /// <summary>
        /// 分页当前页索引
        /// </summary>
        public static int DataGrivViewPageIndex = 1;

        /// <summary>
        /// 分页每页大小
        /// </summary>

        public static int DataGrivViewPageSize = 20;

        /// <summary>
        /// 分页最大页数
        /// </summary>

        public static int DataGrivViewMaxPage = 0;

        /// <summary>
        /// 数据库名称
        /// </summary>
        public static string DbName { get; set; }

        /// <summary>
        /// 数据表名称
        /// </summary>
        public static string DbTableName { get; set; }

        /// <summary>
        /// 数据表备注
        /// </summary>
        public static string DbTableComment { get; set; }

        /// <summary>
        /// 查询条件
        /// </summary>
        public static string DbWhere { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        public static string DbOrderByFiled { get; set; }

        /// <summary>
        /// 排序模式
        /// </summary>
        public static string DbSortMode { get; set; }

        /// <summary>
        /// 表结构
        /// </summary>
        public static DataTable DbSource { get; set; } = new DataTable();

        /// <summary>
        /// 数据列表
        /// </summary>
        public static DataTable DbDataSource { get; set; } = new DataTable();

        /// <summary>
        /// 重置
        /// </summary>
        public static void clearSource()
        {
            DbName = "";
            DbTableName = "";
            DbTableComment = "";
            DbWhere = "";
            DbOrderByFiled = "";
            DbSortMode = "DESC";
            DbSource = new DataTable();
            DbDataSource = new DataTable();
        }
    }
}

