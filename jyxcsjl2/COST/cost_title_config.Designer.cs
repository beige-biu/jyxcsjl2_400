namespace jyxcsjl2
{
    partial class cost_title_config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cost_title_config));
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRECORD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAT_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOST_CENTER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOST_CENTER_DESCR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAT_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAT_CODE_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOST_TITLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOST_TITLE_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_H2O = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1347, 58);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(752, 10);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(128, 36);
            this.simpleButton4.TabIndex = 20;
            this.simpleButton4.Text = "导出";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(1173, 12);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton3.Size = new System.Drawing.Size(104, 36);
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
            this.simpleButton2.Location = new System.Drawing.Point(1034, 10);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton2.Size = new System.Drawing.Size(104, 36);
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
            this.simpleButton1.Location = new System.Drawing.Point(902, 10);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton1.Size = new System.Drawing.Size(104, 36);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "查询";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridControl1.Location = new System.Drawing.Point(0, 58);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1347, 388);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRECORD_ID,
            this.colMAT_TYPE,
            this.colCOST_CENTER,
            this.colCOST_CENTER_DESCR,
            this.colMAT_CODE,
            this.colMAT_CODE_DESC,
            this.colCOST_TITLE,
            this.colCOST_TITLE_DESC,
            this.colUNIT,
            this.colPRICE,
            this.colC_H2O});
            this.gridView1.DetailHeight = 349;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colRECORD_ID
            // 
            this.colRECORD_ID.Caption = "序列号";
            this.colRECORD_ID.FieldName = "RECORD_ID";
            this.colRECORD_ID.MinWidth = 30;
            this.colRECORD_ID.Name = "colRECORD_ID";
            this.colRECORD_ID.Visible = true;
            this.colRECORD_ID.VisibleIndex = 0;
            this.colRECORD_ID.Width = 213;
            // 
            // colMAT_TYPE
            // 
            this.colMAT_TYPE.Caption = "物料类型";
            this.colMAT_TYPE.FieldName = "MAT_TYPE";
            this.colMAT_TYPE.MinWidth = 30;
            this.colMAT_TYPE.Name = "colMAT_TYPE";
            this.colMAT_TYPE.Width = 85;
            // 
            // colCOST_CENTER
            // 
            this.colCOST_CENTER.Caption = "成本中心";
            this.colCOST_CENTER.FieldName = "COST_CENTER";
            this.colCOST_CENTER.MinWidth = 30;
            this.colCOST_CENTER.Name = "colCOST_CENTER";
            this.colCOST_CENTER.Visible = true;
            this.colCOST_CENTER.VisibleIndex = 5;
            this.colCOST_CENTER.Width = 211;
            // 
            // colCOST_CENTER_DESCR
            // 
            this.colCOST_CENTER_DESCR.Caption = "成本中心描述";
            this.colCOST_CENTER_DESCR.FieldName = "COST_CENTER_DESCR";
            this.colCOST_CENTER_DESCR.MinWidth = 30;
            this.colCOST_CENTER_DESCR.Name = "colCOST_CENTER_DESCR";
            this.colCOST_CENTER_DESCR.Visible = true;
            this.colCOST_CENTER_DESCR.VisibleIndex = 6;
            this.colCOST_CENTER_DESCR.Width = 234;
            // 
            // colMAT_CODE
            // 
            this.colMAT_CODE.Caption = "物料代码";
            this.colMAT_CODE.FieldName = "MAT_CODE";
            this.colMAT_CODE.MinWidth = 30;
            this.colMAT_CODE.Name = "colMAT_CODE";
            this.colMAT_CODE.Visible = true;
            this.colMAT_CODE.VisibleIndex = 7;
            this.colMAT_CODE.Width = 190;
            // 
            // colMAT_CODE_DESC
            // 
            this.colMAT_CODE_DESC.Caption = "物料代码描述";
            this.colMAT_CODE_DESC.FieldName = "MAT_CODE_DESC";
            this.colMAT_CODE_DESC.MinWidth = 30;
            this.colMAT_CODE_DESC.Name = "colMAT_CODE_DESC";
            this.colMAT_CODE_DESC.Visible = true;
            this.colMAT_CODE_DESC.VisibleIndex = 1;
            this.colMAT_CODE_DESC.Width = 202;
            // 
            // colCOST_TITLE
            // 
            this.colCOST_TITLE.Caption = "成本科目";
            this.colCOST_TITLE.FieldName = "COST_TITLE";
            this.colCOST_TITLE.MinWidth = 30;
            this.colCOST_TITLE.Name = "colCOST_TITLE";
            this.colCOST_TITLE.Visible = true;
            this.colCOST_TITLE.VisibleIndex = 8;
            this.colCOST_TITLE.Width = 129;
            // 
            // colCOST_TITLE_DESC
            // 
            this.colCOST_TITLE_DESC.Caption = "成本科目描述";
            this.colCOST_TITLE_DESC.FieldName = "COST_TITLE_DESC";
            this.colCOST_TITLE_DESC.MinWidth = 30;
            this.colCOST_TITLE_DESC.Name = "colCOST_TITLE_DESC";
            this.colCOST_TITLE_DESC.Visible = true;
            this.colCOST_TITLE_DESC.VisibleIndex = 9;
            this.colCOST_TITLE_DESC.Width = 214;
            // 
            // colUNIT
            // 
            this.colUNIT.Caption = "单位";
            this.colUNIT.FieldName = "UNIT";
            this.colUNIT.MinWidth = 30;
            this.colUNIT.Name = "colUNIT";
            this.colUNIT.Visible = true;
            this.colUNIT.VisibleIndex = 2;
            this.colUNIT.Width = 120;
            // 
            // colPRICE
            // 
            this.colPRICE.Caption = "单价";
            this.colPRICE.FieldName = "PRICE";
            this.colPRICE.MinWidth = 30;
            this.colPRICE.Name = "colPRICE";
            this.colPRICE.Visible = true;
            this.colPRICE.VisibleIndex = 3;
            this.colPRICE.Width = 99;
            // 
            // colC_H2O
            // 
            this.colC_H2O.Caption = "水分";
            this.colC_H2O.FieldName = "C_H2O";
            this.colC_H2O.MinWidth = 30;
            this.colC_H2O.Name = "colC_H2O";
            this.colC_H2O.Visible = true;
            this.colC_H2O.VisibleIndex = 4;
            this.colC_H2O.Width = 172;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemDateEdit1.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FAC_CODE", "物料代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FAC_NAME", "物料名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ERP_TYPE", "物料规格")});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            // 
            // cost_title_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "cost_title_config";
            this.Size = new System.Drawing.Size(1347, 446);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colRECORD_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMAT_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colCOST_CENTER;
        private DevExpress.XtraGrid.Columns.GridColumn colCOST_CENTER_DESCR;
        private DevExpress.XtraGrid.Columns.GridColumn colMAT_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colMAT_CODE_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colCOST_TITLE;
        private DevExpress.XtraGrid.Columns.GridColumn colCOST_TITLE_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIT;
        private DevExpress.XtraGrid.Columns.GridColumn colPRICE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_H2O;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}
