namespace jyxcsjl2
{
    partial class role_mag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(role_mag));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colROLE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROLE_DEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFIED_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFIED_PERSON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFUNCTION_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFUNCTION_DEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFUNCTION_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROLE_NAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFUNCTION_ADD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colFUNCTION_DEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colFUNCTION_UPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colFUNCTION_QUERY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colMODIFIED_DATE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFIED_PERSON1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFUNCTION_CLASS_DEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFUNCTION_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFUNCTION_SEND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colFUNCTION_RECEIVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colFUNCTION_FORM = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit6)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("宋体", 10.5F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("宋体", 10.5F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colROLE_NAME,
            this.colROLE_DEC,
            this.colMODIFIED_DATE,
            this.colMODIFIED_PERSON});
            this.gridView1.DetailHeight = 292;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colROLE_NAME
            // 
            this.colROLE_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colROLE_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colROLE_NAME.Caption = "用户组";
            this.colROLE_NAME.FieldName = "ROLE_NAME";
            this.colROLE_NAME.MinWidth = 25;
            this.colROLE_NAME.Name = "colROLE_NAME";
            this.colROLE_NAME.Visible = true;
            this.colROLE_NAME.VisibleIndex = 0;
            this.colROLE_NAME.Width = 94;
            // 
            // colROLE_DEC
            // 
            this.colROLE_DEC.AppearanceHeader.Options.UseTextOptions = true;
            this.colROLE_DEC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colROLE_DEC.FieldName = "ROLE_DEC";
            this.colROLE_DEC.MinWidth = 25;
            this.colROLE_DEC.Name = "colROLE_DEC";
            this.colROLE_DEC.Width = 94;
            // 
            // colMODIFIED_DATE
            // 
            this.colMODIFIED_DATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colMODIFIED_DATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMODIFIED_DATE.Caption = "修改时间";
            this.colMODIFIED_DATE.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colMODIFIED_DATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colMODIFIED_DATE.FieldName = "MODIFIED_DATE";
            this.colMODIFIED_DATE.MinWidth = 25;
            this.colMODIFIED_DATE.Name = "colMODIFIED_DATE";
            this.colMODIFIED_DATE.OptionsColumn.ReadOnly = true;
            this.colMODIFIED_DATE.Visible = true;
            this.colMODIFIED_DATE.VisibleIndex = 2;
            this.colMODIFIED_DATE.Width = 94;
            // 
            // colMODIFIED_PERSON
            // 
            this.colMODIFIED_PERSON.AppearanceHeader.Options.UseTextOptions = true;
            this.colMODIFIED_PERSON.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMODIFIED_PERSON.Caption = "修改人";
            this.colMODIFIED_PERSON.FieldName = "MODIFIED_PERSON";
            this.colMODIFIED_PERSON.MinWidth = 25;
            this.colMODIFIED_PERSON.Name = "colMODIFIED_PERSON";
            this.colMODIFIED_PERSON.OptionsColumn.ReadOnly = true;
            this.colMODIFIED_PERSON.Visible = true;
            this.colMODIFIED_PERSON.VisibleIndex = 1;
            this.colMODIFIED_PERSON.Width = 94;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridControl1.Location = new System.Drawing.Point(0, 49);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1250, 394);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(291, 9);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton4.Size = new System.Drawing.Size(110, 30);
            this.simpleButton4.TabIndex = 19;
            this.simpleButton4.Text = "修改";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(563, 9);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton3.Size = new System.Drawing.Size(110, 30);
            this.simpleButton3.TabIndex = 18;
            this.simpleButton3.Text = "删除";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(170, 9);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton2.Size = new System.Drawing.Size(110, 30);
            this.simpleButton2.TabIndex = 17;
            this.simpleButton2.Text = "添加";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(49, 9);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton1.Size = new System.Drawing.Size(110, 30);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "查询";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton5);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 49);
            this.panel1.TabIndex = 10;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(412, 9);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton5.Size = new System.Drawing.Size(140, 30);
            this.simpleButton5.TabIndex = 20;
            this.simpleButton5.Text = "修改详情";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridControl2.Location = new System.Drawing.Point(0, 443);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3,
            this.repositoryItemCheckEdit4,
            this.repositoryItemCheckEdit5,
            this.repositoryItemCheckEdit6});
            this.gridControl2.Size = new System.Drawing.Size(1250, 274);
            this.gridControl2.TabIndex = 12;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("宋体", 10.5F);
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("宋体", 10.5F);
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFUNCTION_CODE,
            this.colFUNCTION_DEC,
            this.colFUNCTION_NAME,
            this.colROLE_NAME1,
            this.colFUNCTION_ADD,
            this.colFUNCTION_DEL,
            this.colFUNCTION_UPDATE,
            this.colFUNCTION_QUERY,
            this.colMODIFIED_DATE1,
            this.colMODIFIED_PERSON1,
            this.colFUNCTION_CLASS_DEC,
            this.colFUNCTION_SEQ,
            this.colFUNCTION_SEND,
            this.colFUNCTION_RECEIVE,
            this.colFUNCTION_FORM});
            this.gridView2.DetailHeight = 292;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView2.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanged);
            // 
            // colFUNCTION_CODE
            // 
            this.colFUNCTION_CODE.AppearanceHeader.Options.UseTextOptions = true;
            this.colFUNCTION_CODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFUNCTION_CODE.Caption = "功能编码";
            this.colFUNCTION_CODE.FieldName = "FUNCTION_CODE";
            this.colFUNCTION_CODE.MinWidth = 25;
            this.colFUNCTION_CODE.Name = "colFUNCTION_CODE";
            this.colFUNCTION_CODE.OptionsColumn.AllowEdit = false;
            this.colFUNCTION_CODE.OptionsColumn.ReadOnly = true;
            this.colFUNCTION_CODE.Visible = true;
            this.colFUNCTION_CODE.VisibleIndex = 0;
            this.colFUNCTION_CODE.Width = 94;
            // 
            // colFUNCTION_DEC
            // 
            this.colFUNCTION_DEC.AppearanceHeader.Options.UseTextOptions = true;
            this.colFUNCTION_DEC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFUNCTION_DEC.FieldName = "FUNCTION_DEC";
            this.colFUNCTION_DEC.MinWidth = 25;
            this.colFUNCTION_DEC.Name = "colFUNCTION_DEC";
            this.colFUNCTION_DEC.Width = 94;
            // 
            // colFUNCTION_NAME
            // 
            this.colFUNCTION_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colFUNCTION_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFUNCTION_NAME.Caption = "功能名称";
            this.colFUNCTION_NAME.FieldName = "FUNCTION_NAME";
            this.colFUNCTION_NAME.MinWidth = 25;
            this.colFUNCTION_NAME.Name = "colFUNCTION_NAME";
            this.colFUNCTION_NAME.OptionsColumn.AllowEdit = false;
            this.colFUNCTION_NAME.OptionsColumn.ReadOnly = true;
            this.colFUNCTION_NAME.Visible = true;
            this.colFUNCTION_NAME.VisibleIndex = 1;
            this.colFUNCTION_NAME.Width = 94;
            // 
            // colROLE_NAME1
            // 
            this.colROLE_NAME1.AppearanceHeader.Options.UseTextOptions = true;
            this.colROLE_NAME1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colROLE_NAME1.FieldName = "ROLE_NAME";
            this.colROLE_NAME1.MinWidth = 25;
            this.colROLE_NAME1.Name = "colROLE_NAME1";
            this.colROLE_NAME1.Width = 94;
            // 
            // colFUNCTION_ADD
            // 
            this.colFUNCTION_ADD.AppearanceHeader.Options.UseTextOptions = true;
            this.colFUNCTION_ADD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFUNCTION_ADD.Caption = "添加权限";
            this.colFUNCTION_ADD.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colFUNCTION_ADD.FieldName = "FUNCTION_ADD";
            this.colFUNCTION_ADD.MinWidth = 25;
            this.colFUNCTION_ADD.Name = "colFUNCTION_ADD";
            this.colFUNCTION_ADD.Visible = true;
            this.colFUNCTION_ADD.VisibleIndex = 3;
            this.colFUNCTION_ADD.Width = 94;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.DisplayValueChecked = "1";
            this.repositoryItemCheckEdit1.DisplayValueUnchecked = "0";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.ValueChecked = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemCheckEdit1.ValueUnchecked = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // colFUNCTION_DEL
            // 
            this.colFUNCTION_DEL.AppearanceHeader.Options.UseTextOptions = true;
            this.colFUNCTION_DEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFUNCTION_DEL.Caption = "删除权限";
            this.colFUNCTION_DEL.ColumnEdit = this.repositoryItemCheckEdit2;
            this.colFUNCTION_DEL.FieldName = "FUNCTION_DEL";
            this.colFUNCTION_DEL.MinWidth = 25;
            this.colFUNCTION_DEL.Name = "colFUNCTION_DEL";
            this.colFUNCTION_DEL.Visible = true;
            this.colFUNCTION_DEL.VisibleIndex = 5;
            this.colFUNCTION_DEL.Width = 94;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.DisplayValueChecked = "1";
            this.repositoryItemCheckEdit2.DisplayValueUnchecked = "0";
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit2.ValueChecked = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemCheckEdit2.ValueUnchecked = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // colFUNCTION_UPDATE
            // 
            this.colFUNCTION_UPDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colFUNCTION_UPDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFUNCTION_UPDATE.Caption = "修改权限";
            this.colFUNCTION_UPDATE.ColumnEdit = this.repositoryItemCheckEdit3;
            this.colFUNCTION_UPDATE.FieldName = "FUNCTION_UPDATE";
            this.colFUNCTION_UPDATE.MinWidth = 25;
            this.colFUNCTION_UPDATE.Name = "colFUNCTION_UPDATE";
            this.colFUNCTION_UPDATE.Visible = true;
            this.colFUNCTION_UPDATE.VisibleIndex = 4;
            this.colFUNCTION_UPDATE.Width = 94;
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.DisplayValueChecked = "1";
            this.repositoryItemCheckEdit3.DisplayValueUnchecked = "0";
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            this.repositoryItemCheckEdit3.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit3.ValueChecked = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemCheckEdit3.ValueUnchecked = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // colFUNCTION_QUERY
            // 
            this.colFUNCTION_QUERY.AppearanceHeader.Options.UseTextOptions = true;
            this.colFUNCTION_QUERY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFUNCTION_QUERY.Caption = "查询权限";
            this.colFUNCTION_QUERY.ColumnEdit = this.repositoryItemCheckEdit4;
            this.colFUNCTION_QUERY.FieldName = "FUNCTION_QUERY";
            this.colFUNCTION_QUERY.MinWidth = 25;
            this.colFUNCTION_QUERY.Name = "colFUNCTION_QUERY";
            this.colFUNCTION_QUERY.Visible = true;
            this.colFUNCTION_QUERY.VisibleIndex = 2;
            this.colFUNCTION_QUERY.Width = 94;
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.DisplayValueChecked = "1";
            this.repositoryItemCheckEdit4.DisplayValueUnchecked = "0";
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            this.repositoryItemCheckEdit4.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit4.ValueChecked = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemCheckEdit4.ValueUnchecked = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // colMODIFIED_DATE1
            // 
            this.colMODIFIED_DATE1.AppearanceHeader.Options.UseTextOptions = true;
            this.colMODIFIED_DATE1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMODIFIED_DATE1.Caption = "修改时间";
            this.colMODIFIED_DATE1.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colMODIFIED_DATE1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colMODIFIED_DATE1.FieldName = "MODIFIED_DATE";
            this.colMODIFIED_DATE1.MinWidth = 25;
            this.colMODIFIED_DATE1.Name = "colMODIFIED_DATE1";
            this.colMODIFIED_DATE1.OptionsColumn.AllowEdit = false;
            this.colMODIFIED_DATE1.OptionsColumn.ReadOnly = true;
            this.colMODIFIED_DATE1.Visible = true;
            this.colMODIFIED_DATE1.VisibleIndex = 8;
            this.colMODIFIED_DATE1.Width = 94;
            // 
            // colMODIFIED_PERSON1
            // 
            this.colMODIFIED_PERSON1.AppearanceHeader.Options.UseTextOptions = true;
            this.colMODIFIED_PERSON1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMODIFIED_PERSON1.Caption = "修改人";
            this.colMODIFIED_PERSON1.FieldName = "MODIFIED_PERSON";
            this.colMODIFIED_PERSON1.MinWidth = 25;
            this.colMODIFIED_PERSON1.Name = "colMODIFIED_PERSON1";
            this.colMODIFIED_PERSON1.OptionsColumn.AllowEdit = false;
            this.colMODIFIED_PERSON1.OptionsColumn.ReadOnly = true;
            this.colMODIFIED_PERSON1.Visible = true;
            this.colMODIFIED_PERSON1.VisibleIndex = 9;
            this.colMODIFIED_PERSON1.Width = 94;
            // 
            // colFUNCTION_CLASS_DEC
            // 
            this.colFUNCTION_CLASS_DEC.AppearanceHeader.Options.UseTextOptions = true;
            this.colFUNCTION_CLASS_DEC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFUNCTION_CLASS_DEC.FieldName = "FUNCTION_CLASS_DEC";
            this.colFUNCTION_CLASS_DEC.MinWidth = 25;
            this.colFUNCTION_CLASS_DEC.Name = "colFUNCTION_CLASS_DEC";
            this.colFUNCTION_CLASS_DEC.Width = 94;
            // 
            // colFUNCTION_SEQ
            // 
            this.colFUNCTION_SEQ.AppearanceHeader.Options.UseTextOptions = true;
            this.colFUNCTION_SEQ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFUNCTION_SEQ.FieldName = "FUNCTION_SEQ";
            this.colFUNCTION_SEQ.MinWidth = 25;
            this.colFUNCTION_SEQ.Name = "colFUNCTION_SEQ";
            this.colFUNCTION_SEQ.Width = 94;
            // 
            // colFUNCTION_SEND
            // 
            this.colFUNCTION_SEND.AppearanceHeader.Options.UseTextOptions = true;
            this.colFUNCTION_SEND.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFUNCTION_SEND.Caption = "发送权限";
            this.colFUNCTION_SEND.ColumnEdit = this.repositoryItemCheckEdit5;
            this.colFUNCTION_SEND.FieldName = "FUNCTION_SEND";
            this.colFUNCTION_SEND.MinWidth = 25;
            this.colFUNCTION_SEND.Name = "colFUNCTION_SEND";
            this.colFUNCTION_SEND.Visible = true;
            this.colFUNCTION_SEND.VisibleIndex = 6;
            this.colFUNCTION_SEND.Width = 94;
            // 
            // repositoryItemCheckEdit5
            // 
            this.repositoryItemCheckEdit5.AutoHeight = false;
            this.repositoryItemCheckEdit5.DisplayValueChecked = "1";
            this.repositoryItemCheckEdit5.DisplayValueUnchecked = "0";
            this.repositoryItemCheckEdit5.Name = "repositoryItemCheckEdit5";
            this.repositoryItemCheckEdit5.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit5.ValueChecked = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemCheckEdit5.ValueUnchecked = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // colFUNCTION_RECEIVE
            // 
            this.colFUNCTION_RECEIVE.AppearanceHeader.Options.UseTextOptions = true;
            this.colFUNCTION_RECEIVE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFUNCTION_RECEIVE.Caption = "接收权限";
            this.colFUNCTION_RECEIVE.ColumnEdit = this.repositoryItemCheckEdit6;
            this.colFUNCTION_RECEIVE.FieldName = "FUNCTION_RECEIVE";
            this.colFUNCTION_RECEIVE.MinWidth = 25;
            this.colFUNCTION_RECEIVE.Name = "colFUNCTION_RECEIVE";
            this.colFUNCTION_RECEIVE.Visible = true;
            this.colFUNCTION_RECEIVE.VisibleIndex = 7;
            this.colFUNCTION_RECEIVE.Width = 94;
            // 
            // repositoryItemCheckEdit6
            // 
            this.repositoryItemCheckEdit6.AutoHeight = false;
            this.repositoryItemCheckEdit6.DisplayValueChecked = "1";
            this.repositoryItemCheckEdit6.DisplayValueUnchecked = "0";
            this.repositoryItemCheckEdit6.Name = "repositoryItemCheckEdit6";
            this.repositoryItemCheckEdit6.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit6.ValueChecked = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemCheckEdit6.ValueUnchecked = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // colFUNCTION_FORM
            // 
            this.colFUNCTION_FORM.AppearanceHeader.Options.UseTextOptions = true;
            this.colFUNCTION_FORM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFUNCTION_FORM.FieldName = "FUNCTION_FORM";
            this.colFUNCTION_FORM.MinWidth = 25;
            this.colFUNCTION_FORM.Name = "colFUNCTION_FORM";
            this.colFUNCTION_FORM.Width = 94;
            // 
            // role_mag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "role_mag";
            this.Size = new System.Drawing.Size(1250, 717);
            this.Load += new System.EventHandler(this.role_mag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraGrid.Columns.GridColumn colROLE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colROLE_DEC;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFIED_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFIED_PERSON;
        private DevExpress.XtraGrid.Columns.GridColumn colFUNCTION_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colFUNCTION_DEC;
        private DevExpress.XtraGrid.Columns.GridColumn colFUNCTION_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colROLE_NAME1;
        private DevExpress.XtraGrid.Columns.GridColumn colFUNCTION_ADD;
        private DevExpress.XtraGrid.Columns.GridColumn colFUNCTION_DEL;
        private DevExpress.XtraGrid.Columns.GridColumn colFUNCTION_UPDATE;
        private DevExpress.XtraGrid.Columns.GridColumn colFUNCTION_QUERY;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFIED_DATE1;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFIED_PERSON1;
        private DevExpress.XtraGrid.Columns.GridColumn colFUNCTION_CLASS_DEC;
        private DevExpress.XtraGrid.Columns.GridColumn colFUNCTION_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colFUNCTION_SEND;
        private DevExpress.XtraGrid.Columns.GridColumn colFUNCTION_RECEIVE;
        private DevExpress.XtraGrid.Columns.GridColumn colFUNCTION_FORM;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit5;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit6;
    }
}
