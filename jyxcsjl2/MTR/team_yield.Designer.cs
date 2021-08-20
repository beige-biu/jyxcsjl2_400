namespace jyxcsjl2
{
    partial class team_yield
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(team_yield));
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
            this.colTEAM_BEGIN_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEAM_END_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYIELD_BEGIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYIELD_END = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYIELD_SUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRUN_TIME_MIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPERATION_RATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIME_YIELD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPERATING_FACTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(905, 39);
            this.panel1.TabIndex = 3;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(713, 7);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 8);
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
            this.gridControl1.Size = new System.Drawing.Size(905, 330);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.colTEAM_BEGIN_TIME,
            this.colTEAM_END_TIME,
            this.colTEAM,
            this.colSHIFT,
            this.colYIELD_BEGIN,
            this.colYIELD_END,
            this.colYIELD_SUM,
            this.colRUN_TIME_MIN,
            this.colOPERATION_RATE,
            this.colTIME_YIELD,
            this.colOPERATING_FACTOR});
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
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colOPERATION_RATE, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colTEAM_BEGIN_TIME
            // 
            this.colTEAM_BEGIN_TIME.Caption = "班开始时间";
            this.colTEAM_BEGIN_TIME.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colTEAM_BEGIN_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTEAM_BEGIN_TIME.FieldName = "TEAM_BEGIN_TIME";
            this.colTEAM_BEGIN_TIME.Name = "colTEAM_BEGIN_TIME";
            this.colTEAM_BEGIN_TIME.Visible = true;
            this.colTEAM_BEGIN_TIME.VisibleIndex = 0;
            this.colTEAM_BEGIN_TIME.Width = 163;
            // 
            // colTEAM_END_TIME
            // 
            this.colTEAM_END_TIME.Caption = "班结束时间";
            this.colTEAM_END_TIME.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colTEAM_END_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTEAM_END_TIME.FieldName = "TEAM_END_TIME";
            this.colTEAM_END_TIME.Name = "colTEAM_END_TIME";
            this.colTEAM_END_TIME.Visible = true;
            this.colTEAM_END_TIME.VisibleIndex = 1;
            this.colTEAM_END_TIME.Width = 165;
            // 
            // colTEAM
            // 
            this.colTEAM.Caption = "班组";
            this.colTEAM.FieldName = "TEAM";
            this.colTEAM.Name = "colTEAM";
            this.colTEAM.Visible = true;
            this.colTEAM.VisibleIndex = 2;
            // 
            // colSHIFT
            // 
            this.colSHIFT.Caption = "班别";
            this.colSHIFT.FieldName = "SHIFT";
            this.colSHIFT.Name = "colSHIFT";
            this.colSHIFT.Visible = true;
            this.colSHIFT.VisibleIndex = 3;
            // 
            // colYIELD_BEGIN
            // 
            this.colYIELD_BEGIN.Caption = "接班读数";
            this.colYIELD_BEGIN.DisplayFormat.FormatString = "#0.00";
            this.colYIELD_BEGIN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colYIELD_BEGIN.FieldName = "YIELD_BEGIN";
            this.colYIELD_BEGIN.Name = "colYIELD_BEGIN";
            this.colYIELD_BEGIN.Visible = true;
            this.colYIELD_BEGIN.VisibleIndex = 4;
            // 
            // colYIELD_END
            // 
            this.colYIELD_END.Caption = "交班读数";
            this.colYIELD_END.DisplayFormat.FormatString = "#0.00";
            this.colYIELD_END.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colYIELD_END.FieldName = "YIELD_END";
            this.colYIELD_END.Name = "colYIELD_END";
            this.colYIELD_END.Visible = true;
            this.colYIELD_END.VisibleIndex = 5;
            // 
            // colYIELD_SUM
            // 
            this.colYIELD_SUM.Caption = "实际产量(t)";
            this.colYIELD_SUM.DisplayFormat.FormatString = "#0.00";
            this.colYIELD_SUM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colYIELD_SUM.FieldName = "YIELD_SUM";
            this.colYIELD_SUM.Name = "colYIELD_SUM";
            this.colYIELD_SUM.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "YIELD_SUM", "合计:{0:#0.00}")});
            this.colYIELD_SUM.Visible = true;
            this.colYIELD_SUM.VisibleIndex = 6;
            this.colYIELD_SUM.Width = 97;
            // 
            // colRUN_TIME_MIN
            // 
            this.colRUN_TIME_MIN.Caption = "运转时间(min)";
            this.colRUN_TIME_MIN.FieldName = "RUN_TIME_MIN";
            this.colRUN_TIME_MIN.Name = "colRUN_TIME_MIN";
            this.colRUN_TIME_MIN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RUN_TIME_MIN", "{0:0.##}")});
            this.colRUN_TIME_MIN.Visible = true;
            this.colRUN_TIME_MIN.VisibleIndex = 7;
            this.colRUN_TIME_MIN.Width = 110;
            // 
            // colOPERATION_RATE
            // 
            this.colOPERATION_RATE.Caption = "作业率(%)";
            this.colOPERATION_RATE.DisplayFormat.FormatString = "#0.00";
            this.colOPERATION_RATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colOPERATION_RATE.FieldName = "OPERATION_RATE";
            this.colOPERATION_RATE.Name = "colOPERATION_RATE";
            this.colOPERATION_RATE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "OPERATION_RATE", "{0:#0.00}")});
            this.colOPERATION_RATE.Visible = true;
            this.colOPERATION_RATE.VisibleIndex = 8;
            this.colOPERATION_RATE.Width = 96;
            // 
            // colTIME_YIELD
            // 
            this.colTIME_YIELD.Caption = "台时产量(t/h)";
            this.colTIME_YIELD.DisplayFormat.FormatString = "#0.00";
            this.colTIME_YIELD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTIME_YIELD.FieldName = "TIME_YIELD";
            this.colTIME_YIELD.Name = "colTIME_YIELD";
            this.colTIME_YIELD.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "TIME_YIELD", "{0:#0.00}")});
            this.colTIME_YIELD.Visible = true;
            this.colTIME_YIELD.VisibleIndex = 9;
            this.colTIME_YIELD.Width = 110;
            // 
            // colOPERATING_FACTOR
            // 
            this.colOPERATING_FACTOR.Caption = "利用系数(t/m2*h)";
            this.colOPERATING_FACTOR.DisplayFormat.FormatString = "#0.00";
            this.colOPERATING_FACTOR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colOPERATING_FACTOR.FieldName = "OPERATING_FACTOR";
            this.colOPERATING_FACTOR.Name = "colOPERATING_FACTOR";
            this.colOPERATING_FACTOR.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "OPERATING_FACTOR", "{0:#0.00}")});
            this.colOPERATING_FACTOR.Visible = true;
            this.colOPERATING_FACTOR.VisibleIndex = 10;
            this.colOPERATING_FACTOR.Width = 134;
            // 
            // team_yield
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "team_yield";
            this.Size = new System.Drawing.Size(905, 369);
            this.Load += new System.EventHandler(this.team_yield_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colTEAM_BEGIN_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colTEAM_END_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colTEAM;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT;
        private DevExpress.XtraGrid.Columns.GridColumn colYIELD_BEGIN;
        private DevExpress.XtraGrid.Columns.GridColumn colYIELD_END;
        private DevExpress.XtraGrid.Columns.GridColumn colYIELD_SUM;
        private DevExpress.XtraGrid.Columns.GridColumn colRUN_TIME_MIN;
        private DevExpress.XtraGrid.Columns.GridColumn colOPERATION_RATE;
        private DevExpress.XtraGrid.Columns.GridColumn colTIME_YIELD;
        private DevExpress.XtraGrid.Columns.GridColumn colOPERATING_FACTOR;
    }
}
