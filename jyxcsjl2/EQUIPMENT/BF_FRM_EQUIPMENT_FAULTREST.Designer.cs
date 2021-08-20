namespace jyxcsjl2
{
    partial class BF_FRM_EQUIPMENT_FAULTREST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BF_FRM_EQUIPMENT_FAULTREST));
            this.btnExp = new DevExpress.XtraEditors.SimpleButton();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colFAULT_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colEND_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTART_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFAULT_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFAULT_DES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFAULT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_DES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_TEAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_SHIFT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRECORD_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvFAULTREST = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcFAULTREST = new DevExpress.XtraGrid.GridControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFAULTREST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFAULTREST)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExp
            // 
            this.btnExp.Appearance.Font = new System.Drawing.Font("宋体", 9F);
            this.btnExp.Appearance.Options.UseFont = true;
            this.btnExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExp.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExp.ImageOptions.Image")));
            this.btnExp.Location = new System.Drawing.Point(809, 10);
            this.btnExp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExp.Name = "btnExp";
            this.btnExp.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnExp.Size = new System.Drawing.Size(93, 30);
            this.btnExp.TabIndex = 21;
            this.btnExp.Text = "导出";
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEnd.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(451, 11);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(251, 27);
            this.dtpEnd.TabIndex = 16;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 18);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "开始时间：";
            // 
            // btnQuery
            // 
            this.btnQuery.Appearance.Options.UseFont = true;
            this.btnQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQuery.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnQuery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.ImageOptions.Image")));
            this.btnQuery.Location = new System.Drawing.Point(708, 10);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnQuery.Size = new System.Drawing.Size(93, 30);
            this.btnQuery.TabIndex = 14;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(360, 15);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 18);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "结束时间：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExp);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 48);
            this.panel1.TabIndex = 13;
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStart.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(105, 11);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(243, 27);
            this.dtpStart.TabIndex = 15;
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
            // colFAULT_TYPE
            // 
            this.colFAULT_TYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colFAULT_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFAULT_TYPE.Caption = "故障类型";
            this.colFAULT_TYPE.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colFAULT_TYPE.FieldName = "FAULT_TYPE";
            this.colFAULT_TYPE.MinWidth = 25;
            this.colFAULT_TYPE.Name = "colFAULT_TYPE";
            this.colFAULT_TYPE.Visible = true;
            this.colFAULT_TYPE.VisibleIndex = 8;
            this.colFAULT_TYPE.Width = 94;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // colEND_TIME
            // 
            this.colEND_TIME.AppearanceHeader.Options.UseTextOptions = true;
            this.colEND_TIME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEND_TIME.Caption = "故障结束时间";
            this.colEND_TIME.FieldName = "END_TIME";
            this.colEND_TIME.MinWidth = 25;
            this.colEND_TIME.Name = "colEND_TIME";
            this.colEND_TIME.Visible = true;
            this.colEND_TIME.VisibleIndex = 7;
            this.colEND_TIME.Width = 94;
            // 
            // colSTART_TIME
            // 
            this.colSTART_TIME.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTART_TIME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTART_TIME.Caption = "故障开始时间";
            this.colSTART_TIME.FieldName = "START_TIME";
            this.colSTART_TIME.MinWidth = 25;
            this.colSTART_TIME.Name = "colSTART_TIME";
            this.colSTART_TIME.Visible = true;
            this.colSTART_TIME.VisibleIndex = 6;
            this.colSTART_TIME.Width = 94;
            // 
            // colFAULT_CODE
            // 
            this.colFAULT_CODE.AppearanceHeader.Options.UseTextOptions = true;
            this.colFAULT_CODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFAULT_CODE.Caption = "故障值";
            this.colFAULT_CODE.FieldName = "FAULT_CODE";
            this.colFAULT_CODE.MinWidth = 25;
            this.colFAULT_CODE.Name = "colFAULT_CODE";
            this.colFAULT_CODE.Visible = true;
            this.colFAULT_CODE.VisibleIndex = 5;
            this.colFAULT_CODE.Width = 94;
            // 
            // colFAULT_DES
            // 
            this.colFAULT_DES.AppearanceHeader.Options.UseTextOptions = true;
            this.colFAULT_DES.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFAULT_DES.Caption = "故障描述";
            this.colFAULT_DES.FieldName = "FAULT_DES";
            this.colFAULT_DES.MinWidth = 25;
            this.colFAULT_DES.Name = "colFAULT_DES";
            this.colFAULT_DES.Visible = true;
            this.colFAULT_DES.VisibleIndex = 4;
            this.colFAULT_DES.Width = 94;
            // 
            // colFAULT_ID
            // 
            this.colFAULT_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colFAULT_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFAULT_ID.Caption = "故障编码";
            this.colFAULT_ID.FieldName = "FAULT_ID";
            this.colFAULT_ID.MinWidth = 25;
            this.colFAULT_ID.Name = "colFAULT_ID";
            this.colFAULT_ID.Width = 94;
            // 
            // colCODE_DES
            // 
            this.colCODE_DES.AppearanceHeader.Options.UseTextOptions = true;
            this.colCODE_DES.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCODE_DES.Caption = "设备描述";
            this.colCODE_DES.FieldName = "CODE_DES";
            this.colCODE_DES.MinWidth = 25;
            this.colCODE_DES.Name = "colCODE_DES";
            this.colCODE_DES.Visible = true;
            this.colCODE_DES.VisibleIndex = 3;
            this.colCODE_DES.Width = 94;
            // 
            // colCODE
            // 
            this.colCODE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCODE.FieldName = "CODE";
            this.colCODE.MinWidth = 25;
            this.colCODE.Name = "colCODE";
            this.colCODE.Width = 94;
            // 
            // colWORK_TEAM
            // 
            this.colWORK_TEAM.AppearanceHeader.Options.UseTextOptions = true;
            this.colWORK_TEAM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWORK_TEAM.Caption = "班别";
            this.colWORK_TEAM.FieldName = "WORK_TEAM";
            this.colWORK_TEAM.MinWidth = 25;
            this.colWORK_TEAM.Name = "colWORK_TEAM";
            this.colWORK_TEAM.Visible = true;
            this.colWORK_TEAM.VisibleIndex = 2;
            this.colWORK_TEAM.Width = 94;
            // 
            // colWORK_SHIFT
            // 
            this.colWORK_SHIFT.AppearanceHeader.Options.UseTextOptions = true;
            this.colWORK_SHIFT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWORK_SHIFT.Caption = "班次";
            this.colWORK_SHIFT.FieldName = "WORK_SHIFT";
            this.colWORK_SHIFT.MinWidth = 25;
            this.colWORK_SHIFT.Name = "colWORK_SHIFT";
            this.colWORK_SHIFT.Visible = true;
            this.colWORK_SHIFT.VisibleIndex = 1;
            this.colWORK_SHIFT.Width = 94;
            // 
            // colRECORD_TIME
            // 
            this.colRECORD_TIME.AppearanceHeader.Options.UseTextOptions = true;
            this.colRECORD_TIME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRECORD_TIME.Caption = "记录时间";
            this.colRECORD_TIME.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colRECORD_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRECORD_TIME.FieldName = "RECORD_TIME";
            this.colRECORD_TIME.MinWidth = 25;
            this.colRECORD_TIME.Name = "colRECORD_TIME";
            this.colRECORD_TIME.Visible = true;
            this.colRECORD_TIME.VisibleIndex = 0;
            this.colRECORD_TIME.Width = 94;
            // 
            // gvFAULTREST
            // 
            this.gvFAULTREST.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRECORD_TIME,
            this.colWORK_SHIFT,
            this.colWORK_TEAM,
            this.colCODE,
            this.colCODE_DES,
            this.colFAULT_ID,
            this.colFAULT_DES,
            this.colFAULT_CODE,
            this.colSTART_TIME,
            this.colEND_TIME,
            this.colFAULT_TYPE});
            this.gvFAULTREST.DetailHeight = 292;
            this.gvFAULTREST.GridControl = this.gcFAULTREST;
            this.gvFAULTREST.Name = "gvFAULTREST";
            this.gvFAULTREST.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gvFAULTREST.OptionsEditForm.EditFormColumnCount = 2;
            this.gvFAULTREST.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.gvFAULTREST.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Fast;
            this.gvFAULTREST.OptionsView.ColumnAutoWidth = false;
            this.gvFAULTREST.OptionsView.ShowGroupPanel = false;
            // 
            // gcFAULTREST
            // 
            this.gcFAULTREST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFAULTREST.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcFAULTREST.Location = new System.Drawing.Point(0, 48);
            this.gcFAULTREST.MainView = this.gvFAULTREST;
            this.gcFAULTREST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcFAULTREST.Name = "gcFAULTREST";
            this.gcFAULTREST.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemLookUpEdit1});
            this.gcFAULTREST.Size = new System.Drawing.Size(1228, 716);
            this.gcFAULTREST.TabIndex = 14;
            this.gcFAULTREST.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFAULTREST});
            // 
            // BF_FRM_EQUIPMENT_FAULTREST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcFAULTREST);
            this.Controls.Add(this.panel1);
            this.Name = "BF_FRM_EQUIPMENT_FAULTREST";
            this.Size = new System.Drawing.Size(1228, 764);
            this.Load += new System.EventHandler(this.BF_FRM_EQUIPMENT_FAULTREST_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFAULTREST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFAULTREST)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnExp;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colFAULT_TYPE;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colEND_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colSTART_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colFAULT_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colFAULT_DES;
        private DevExpress.XtraGrid.Columns.GridColumn colFAULT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_DES;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_TEAM;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_SHIFT;
        private DevExpress.XtraGrid.Columns.GridColumn colRECORD_TIME;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFAULTREST;
        private DevExpress.XtraGrid.GridControl gcFAULTREST;
    }
}
