namespace jyxcsjl2
{
    partial class BF_FRM_EQUIPMENT_INFO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BF_FRM_EQUIPMENT_INFO));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gcFault = new DevExpress.XtraGrid.GridControl();
            this.gvFault = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnModifyFault = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelFault = new DevExpress.XtraEditors.SimpleButton();
            this.btnExpFault = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFaultCon = new System.Windows.Forms.TextBox();
            this.btnAddFault = new DevExpress.XtraEditors.SimpleButton();
            this.btnQueryFault = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeEquip = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn9 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn10 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn11 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn12 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn13 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnExp = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tboxCondition = new System.Windows.Forms.TextBox();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFault)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeEquip)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1610, 791);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gcFault);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(808, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(799, 785);
            this.panel3.TabIndex = 1;
            // 
            // gcFault
            // 
            this.gcFault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFault.Location = new System.Drawing.Point(0, 48);
            this.gcFault.MainView = this.gvFault;
            this.gcFault.Name = "gcFault";
            this.gcFault.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gcFault.Size = new System.Drawing.Size(799, 737);
            this.gcFault.TabIndex = 12;
            this.gcFault.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFault});
            // 
            // gvFault
            // 
            this.gvFault.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvFault.GridControl = this.gcFault;
            this.gvFault.Name = "gvFault";
            this.gvFault.OptionsBehavior.Editable = false;
            this.gvFault.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gvFault.OptionsView.ColumnAutoWidth = false;
            this.gvFault.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "故障编码";
            this.gridColumn2.FieldName = "FAULT_ID";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "故障描述";
            this.gridColumn3.FieldName = "FAULT_DES";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "故障类型";
            this.gridColumn4.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.gridColumn4.FieldName = "FAULT_TYPE";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "PLC点名";
            this.gridColumn5.FieldName = "TAG_NAME";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 94;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnModifyFault);
            this.panel4.Controls.Add(this.btnDelFault);
            this.panel4.Controls.Add(this.btnExpFault);
            this.panel4.Controls.Add(this.labelControl2);
            this.panel4.Controls.Add(this.txtFaultCon);
            this.panel4.Controls.Add(this.btnAddFault);
            this.panel4.Controls.Add(this.btnQueryFault);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(799, 48);
            this.panel4.TabIndex = 11;
            // 
            // btnModifyFault
            // 
            this.btnModifyFault.Appearance.Options.UseFont = true;
            this.btnModifyFault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModifyFault.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnModifyFault.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyFault.ImageOptions.Image")));
            this.btnModifyFault.Location = new System.Drawing.Point(467, 9);
            this.btnModifyFault.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifyFault.Name = "btnModifyFault";
            this.btnModifyFault.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnModifyFault.Size = new System.Drawing.Size(93, 30);
            this.btnModifyFault.TabIndex = 25;
            this.btnModifyFault.Text = "修改";
            this.btnModifyFault.Click += new System.EventHandler(this.btnModifyFault_Click);
            // 
            // btnDelFault
            // 
            this.btnDelFault.Appearance.Options.UseFont = true;
            this.btnDelFault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelFault.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnDelFault.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelFault.ImageOptions.Image")));
            this.btnDelFault.Location = new System.Drawing.Point(566, 9);
            this.btnDelFault.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelFault.Name = "btnDelFault";
            this.btnDelFault.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnDelFault.Size = new System.Drawing.Size(93, 30);
            this.btnDelFault.TabIndex = 24;
            this.btnDelFault.Text = "删除";
            this.btnDelFault.Click += new System.EventHandler(this.btnDelFault_Click);
            // 
            // btnExpFault
            // 
            this.btnExpFault.Appearance.Font = new System.Drawing.Font("宋体", 9F);
            this.btnExpFault.Appearance.Options.UseFont = true;
            this.btnExpFault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExpFault.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExpFault.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExpFault.ImageOptions.Image")));
            this.btnExpFault.Location = new System.Drawing.Point(665, 9);
            this.btnExpFault.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExpFault.Name = "btnExpFault";
            this.btnExpFault.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnExpFault.Size = new System.Drawing.Size(93, 30);
            this.btnExpFault.TabIndex = 23;
            this.btnExpFault.Text = "导出";
            this.btnExpFault.Click += new System.EventHandler(this.btnExpFault_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 15);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 18);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "故障描述：";
            // 
            // txtFaultCon
            // 
            this.txtFaultCon.Font = new System.Drawing.Font("宋体", 10.5F);
            this.txtFaultCon.Location = new System.Drawing.Point(108, 11);
            this.txtFaultCon.Name = "txtFaultCon";
            this.txtFaultCon.Size = new System.Drawing.Size(148, 27);
            this.txtFaultCon.TabIndex = 21;
            // 
            // btnAddFault
            // 
            this.btnAddFault.Appearance.Options.UseFont = true;
            this.btnAddFault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddFault.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAddFault.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFault.ImageOptions.Image")));
            this.btnAddFault.Location = new System.Drawing.Point(367, 10);
            this.btnAddFault.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFault.Name = "btnAddFault";
            this.btnAddFault.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnAddFault.Size = new System.Drawing.Size(94, 30);
            this.btnAddFault.TabIndex = 20;
            this.btnAddFault.Text = "添加";
            this.btnAddFault.Click += new System.EventHandler(this.btnAddFault_Click);
            // 
            // btnQueryFault
            // 
            this.btnQueryFault.Appearance.Options.UseFont = true;
            this.btnQueryFault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQueryFault.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnQueryFault.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQueryFault.ImageOptions.Image")));
            this.btnQueryFault.Location = new System.Drawing.Point(268, 10);
            this.btnQueryFault.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQueryFault.Name = "btnQueryFault";
            this.btnQueryFault.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnQueryFault.Size = new System.Drawing.Size(93, 30);
            this.btnQueryFault.TabIndex = 19;
            this.btnQueryFault.Text = "查询";
            this.btnQueryFault.Click += new System.EventHandler(this.btnQueryFault_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeEquip);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 785);
            this.panel2.TabIndex = 0;
            // 
            // treeEquip
            // 
            this.treeEquip.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn6,
            this.treeListColumn7,
            this.treeListColumn8,
            this.treeListColumn9,
            this.treeListColumn10,
            this.treeListColumn11,
            this.treeListColumn12,
            this.treeListColumn13});
            this.treeEquip.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeEquip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeEquip.KeyFieldName = "CODE";
            this.treeEquip.Location = new System.Drawing.Point(0, 75);
            this.treeEquip.Name = "treeEquip";
            this.treeEquip.OptionsBehavior.Editable = false;
            this.treeEquip.OptionsBehavior.PopulateServiceColumns = true;
            this.treeEquip.ParentFieldName = "PARENT_ID";
            this.treeEquip.Size = new System.Drawing.Size(799, 710);
            this.treeEquip.TabIndex = 12;
            this.treeEquip.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeEquip_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn1.Caption = "设备编码";
            this.treeListColumn1.FieldName = "CODE";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn2.Caption = "设备描述";
            this.treeListColumn2.FieldName = "CODE_DES";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn3.Caption = "父级编码";
            this.treeListColumn3.FieldName = "PARENT_ID";
            this.treeListColumn3.Name = "treeListColumn3";
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn4.Caption = "父级描述";
            this.treeListColumn4.FieldName = "PARENT_DES";
            this.treeListColumn4.Name = "treeListColumn4";
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn5.Caption = "设备总编码";
            this.treeListColumn5.FieldName = "EQUIP_ID";
            this.treeListColumn5.Name = "treeListColumn5";
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn6.Caption = "设备总信息描述";
            this.treeListColumn6.FieldName = "EQUIP_DES";
            this.treeListColumn6.Name = "treeListColumn6";
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn7.Caption = "是否重点设备";
            this.treeListColumn7.FieldName = "IMPORTANT_FALG";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 2;
            // 
            // treeListColumn8
            // 
            this.treeListColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn8.Caption = "PLC点名";
            this.treeListColumn8.FieldName = "TAG_NAME";
            this.treeListColumn8.Name = "treeListColumn8";
            this.treeListColumn8.Visible = true;
            this.treeListColumn8.VisibleIndex = 3;
            // 
            // treeListColumn9
            // 
            this.treeListColumn9.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn9.Caption = "设备排序";
            this.treeListColumn9.FieldName = "EQUIP_SEQ";
            this.treeListColumn9.Name = "treeListColumn9";
            // 
            // treeListColumn10
            // 
            this.treeListColumn10.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn10.Caption = "创建人";
            this.treeListColumn10.FieldName = "CREATE_BY";
            this.treeListColumn10.Name = "treeListColumn10";
            // 
            // treeListColumn11
            // 
            this.treeListColumn11.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn11.Caption = "创建时间";
            this.treeListColumn11.FieldName = "CREATE_TIME";
            this.treeListColumn11.Name = "treeListColumn11";
            // 
            // treeListColumn12
            // 
            this.treeListColumn12.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn12.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn12.Caption = "修改人";
            this.treeListColumn12.FieldName = "MODIFY_BY";
            this.treeListColumn12.Name = "treeListColumn12";
            // 
            // treeListColumn13
            // 
            this.treeListColumn13.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn13.Caption = "修改时间";
            this.treeListColumn13.FieldName = "MODIFY_TIME";
            this.treeListColumn13.Name = "treeListColumn13";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "text";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnExp);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.tboxCondition);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 48);
            this.panel1.TabIndex = 11;
            // 
            // btnModify
            // 
            this.btnModify.Appearance.Options.UseFont = true;
            this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModify.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnModify.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.ImageOptions.Image")));
            this.btnModify.Location = new System.Drawing.Point(467, 9);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnModify.Size = new System.Drawing.Size(93, 30);
            this.btnModify.TabIndex = 25;
            this.btnModify.Text = "修改";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDel
            // 
            this.btnDel.Appearance.Options.UseFont = true;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.Location = new System.Drawing.Point(566, 9);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnDel.Size = new System.Drawing.Size(93, 30);
            this.btnDel.TabIndex = 24;
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExp
            // 
            this.btnExp.Appearance.Font = new System.Drawing.Font("宋体", 9F);
            this.btnExp.Appearance.Options.UseFont = true;
            this.btnExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExp.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExp.ImageOptions.Image")));
            this.btnExp.Location = new System.Drawing.Point(665, 9);
            this.btnExp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExp.Name = "btnExp";
            this.btnExp.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnExp.Size = new System.Drawing.Size(93, 30);
            this.btnExp.TabIndex = 23;
            this.btnExp.Text = "导出";
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 18);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "设备名称：";
            // 
            // tboxCondition
            // 
            this.tboxCondition.Font = new System.Drawing.Font("宋体", 10.5F);
            this.tboxCondition.Location = new System.Drawing.Point(108, 11);
            this.tboxCondition.Name = "tboxCondition";
            this.tboxCondition.Size = new System.Drawing.Size(148, 27);
            this.tboxCondition.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(367, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnAdd.Size = new System.Drawing.Size(94, 30);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Appearance.Options.UseFont = true;
            this.btnQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQuery.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnQuery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.ImageOptions.Image")));
            this.btnQuery.Location = new System.Drawing.Point(268, 10);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnQuery.Size = new System.Drawing.Size(93, 30);
            this.btnQuery.TabIndex = 19;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // BF_FRM_EQUIPMENT_INFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BF_FRM_EQUIPMENT_INFO";
            this.Size = new System.Drawing.Size(1610, 791);
            this.Load += new System.EventHandler(this.BF_FRM_EQUIPMENT_INFO_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFault)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeEquip)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl gcFault;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFault;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnModifyFault;
        private DevExpress.XtraEditors.SimpleButton btnDelFault;
        private DevExpress.XtraEditors.SimpleButton btnExpFault;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtFaultCon;
        private DevExpress.XtraEditors.SimpleButton btnAddFault;
        private DevExpress.XtraEditors.SimpleButton btnQueryFault;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraTreeList.TreeList treeEquip;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn8;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn9;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn10;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn11;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnModify;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnExp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox tboxCondition;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}
