namespace jyxcsjl2
{
    partial class material_sum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(material_sum));
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRECORD_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colTAEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_BEGIN_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_END_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATERIAL_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATERIAL_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONSUMPTION_SUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPECIFIC_CONSUMPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 39);
            this.panel1.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(717, 7);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(94, 24);
            this.simpleButton2.TabIndex = 19;
            this.simpleButton2.Text = "导出";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(394, 9);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(189, 23);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 9);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 23);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(601, 7);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton1.Size = new System.Drawing.Size(94, 24);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "查询";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(320, 12);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 14);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "结束时间：";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(51, 14);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 14);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "开始时间：";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(0, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(852, 378);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("宋体", 10.5F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("宋体", 10.5F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colRECORD_DATE,
            this.colSHIFTS,
            this.colTAEM,
            this.colWORK_BEGIN_TIME,
            this.colWORK_END_TIME,
            this.colMATERIAL_CODE,
            this.colMATERIAL_NAME,
            this.colCONSUMPTION_SUM,
            this.colSPECIFIC_CONSUMPTION});
            this.gridView1.DetailHeight = 233;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsClipboard.AllowHtmlFormat = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRECORD_DATE, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ID", "={0:0.##}")});
            // 
            // colRECORD_DATE
            // 
            this.colRECORD_DATE.Caption = "记录时间";
            this.colRECORD_DATE.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colRECORD_DATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRECORD_DATE.FieldName = "RECORD_DATE";
            this.colRECORD_DATE.Name = "colRECORD_DATE";
            this.colRECORD_DATE.Visible = true;
            this.colRECORD_DATE.VisibleIndex = 0;
            this.colRECORD_DATE.Width = 155;
            // 
            // colSHIFTS
            // 
            this.colSHIFTS.Caption = "班次";
            this.colSHIFTS.ColumnEdit = this.repositoryItemComboBox1;
            this.colSHIFTS.FieldName = "SHIFTS";
            this.colSHIFTS.Name = "colSHIFTS";
            this.colSHIFTS.Visible = true;
            this.colSHIFTS.VisibleIndex = 1;
            this.colSHIFTS.Width = 77;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "白班",
            "夜班"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colTAEM
            // 
            this.colTAEM.Caption = "班组";
            this.colTAEM.FieldName = "TAEM";
            this.colTAEM.Name = "colTAEM";
            this.colTAEM.Visible = true;
            this.colTAEM.VisibleIndex = 2;
            // 
            // colWORK_BEGIN_TIME
            // 
            this.colWORK_BEGIN_TIME.Caption = "开始时间";
            this.colWORK_BEGIN_TIME.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colWORK_BEGIN_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colWORK_BEGIN_TIME.FieldName = "WORK_BEGIN_TIME";
            this.colWORK_BEGIN_TIME.Name = "colWORK_BEGIN_TIME";
            this.colWORK_BEGIN_TIME.Visible = true;
            this.colWORK_BEGIN_TIME.VisibleIndex = 3;
            this.colWORK_BEGIN_TIME.Width = 198;
            // 
            // colWORK_END_TIME
            // 
            this.colWORK_END_TIME.Caption = "结束时间";
            this.colWORK_END_TIME.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colWORK_END_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colWORK_END_TIME.FieldName = "WORK_END_TIME";
            this.colWORK_END_TIME.Name = "colWORK_END_TIME";
            this.colWORK_END_TIME.Visible = true;
            this.colWORK_END_TIME.VisibleIndex = 4;
            this.colWORK_END_TIME.Width = 171;
            // 
            // colMATERIAL_CODE
            // 
            this.colMATERIAL_CODE.Caption = "物料代码";
            this.colMATERIAL_CODE.FieldName = "MATERIAL_CODE";
            this.colMATERIAL_CODE.Name = "colMATERIAL_CODE";
            this.colMATERIAL_CODE.Width = 202;
            // 
            // colMATERIAL_NAME
            // 
            this.colMATERIAL_NAME.Caption = "物料名称";
            this.colMATERIAL_NAME.FieldName = "MATERIAL_NAME";
            this.colMATERIAL_NAME.Name = "colMATERIAL_NAME";
            this.colMATERIAL_NAME.Visible = true;
            this.colMATERIAL_NAME.VisibleIndex = 5;
            this.colMATERIAL_NAME.Width = 154;
            // 
            // colCONSUMPTION_SUM
            // 
            this.colCONSUMPTION_SUM.Caption = "消耗量(t)";
            this.colCONSUMPTION_SUM.DisplayFormat.FormatString = "#0.00";
            this.colCONSUMPTION_SUM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCONSUMPTION_SUM.FieldName = "CONSUMPTION_SUM";
            this.colCONSUMPTION_SUM.Name = "colCONSUMPTION_SUM";
            this.colCONSUMPTION_SUM.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CONSUMPTION_SUM", "合计:{0:#0.00}")});
            this.colCONSUMPTION_SUM.Visible = true;
            this.colCONSUMPTION_SUM.VisibleIndex = 6;
            this.colCONSUMPTION_SUM.Width = 138;
            // 
            // colSPECIFIC_CONSUMPTION
            // 
            this.colSPECIFIC_CONSUMPTION.Caption = "单耗(kg/t)";
            this.colSPECIFIC_CONSUMPTION.DisplayFormat.FormatString = "#0.00";
            this.colSPECIFIC_CONSUMPTION.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSPECIFIC_CONSUMPTION.FieldName = "SPECIFIC_CONSUMPTION";
            this.colSPECIFIC_CONSUMPTION.Name = "colSPECIFIC_CONSUMPTION";
            this.colSPECIFIC_CONSUMPTION.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "SPECIFIC_CONSUMPTION", "平均:{0:#0.00}")});
            this.colSPECIFIC_CONSUMPTION.Visible = true;
            this.colSPECIFIC_CONSUMPTION.VisibleIndex = 7;
            this.colSPECIFIC_CONSUMPTION.Width = 121;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // material_sum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "material_sum";
            this.Size = new System.Drawing.Size(852, 417);
            this.Load += new System.EventHandler(this.material_sum_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colRECORD_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFTS;
        private DevExpress.XtraGrid.Columns.GridColumn colTAEM;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_BEGIN_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_END_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colMATERIAL_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colMATERIAL_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colCONSUMPTION_SUM;
        private DevExpress.XtraGrid.Columns.GridColumn colSPECIFIC_CONSUMPTION;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}
