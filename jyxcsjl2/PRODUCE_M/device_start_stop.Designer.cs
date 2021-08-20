namespace jyxcsjl2
{
    partial class device_start_stop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(device_start_stop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRECORD_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBEGIN_STOP_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEND_STOP_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOP_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOP_REASON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colMODIFY_PERSON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJUDGE_REASON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colJUDGE_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colJUDGE_PERSON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 39);
            this.panel1.TabIndex = 3;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(706, 7);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(94, 24);
            this.simpleButton2.TabIndex = 20;
            this.simpleButton2.Text = "导出";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(813, 8);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton3.Size = new System.Drawing.Size(94, 24);
            this.simpleButton3.TabIndex = 18;
            this.simpleButton3.Text = "删除";
            this.simpleButton3.Visible = false;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
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
            this.labelControl1.Location = new System.Drawing.Point(51, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 14);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "开始时间：";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(jyxcsjl2.MODEL.T_PRODUCE_SINTER_RUNSTOP);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridControl1.Location = new System.Drawing.Point(0, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemDateEdit2});
            this.gridControl1.Size = new System.Drawing.Size(915, 305);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("宋体", 10.5F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("宋体", 10.5F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRECORD_DATE,
            this.colSHIFT,
            this.colTEAM,
            this.colBEGIN_STOP_TIME,
            this.colEND_STOP_TIME,
            this.colSTOP_TIME,
            this.colSTOP_REASON,
            this.colMODIFY_DATE,
            this.colMODIFY_PERSON,
            this.colJUDGE_REASON,
            this.colJUDGE_DATE,
            this.colJUDGE_PERSON});
            this.gridView1.DetailHeight = 233;
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
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRECORD_DATE, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // colRECORD_DATE
            // 
            this.colRECORD_DATE.Caption = "记录时间";
            this.colRECORD_DATE.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colRECORD_DATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRECORD_DATE.FieldName = "RECORD_DATE";
            this.colRECORD_DATE.Name = "colRECORD_DATE";
            this.colRECORD_DATE.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colRECORD_DATE.Visible = true;
            this.colRECORD_DATE.VisibleIndex = 0;
            this.colRECORD_DATE.Width = 170;
            // 
            // colSHIFT
            // 
            this.colSHIFT.Caption = "班组";
            this.colSHIFT.FieldName = "SHIFT";
            this.colSHIFT.Name = "colSHIFT";
            this.colSHIFT.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colSHIFT.Visible = true;
            this.colSHIFT.VisibleIndex = 1;
            this.colSHIFT.Width = 42;
            // 
            // colTEAM
            // 
            this.colTEAM.Caption = "班别";
            this.colTEAM.FieldName = "TEAM";
            this.colTEAM.Name = "colTEAM";
            this.colTEAM.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colTEAM.Visible = true;
            this.colTEAM.VisibleIndex = 2;
            this.colTEAM.Width = 50;
            // 
            // colBEGIN_STOP_TIME
            // 
            this.colBEGIN_STOP_TIME.Caption = "停机开始时间";
            this.colBEGIN_STOP_TIME.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colBEGIN_STOP_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBEGIN_STOP_TIME.FieldName = "BEGIN_STOP_TIME";
            this.colBEGIN_STOP_TIME.Name = "colBEGIN_STOP_TIME";
            this.colBEGIN_STOP_TIME.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colBEGIN_STOP_TIME.Visible = true;
            this.colBEGIN_STOP_TIME.VisibleIndex = 3;
            this.colBEGIN_STOP_TIME.Width = 154;
            // 
            // colEND_STOP_TIME
            // 
            this.colEND_STOP_TIME.Caption = "停机结束时间";
            this.colEND_STOP_TIME.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colEND_STOP_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colEND_STOP_TIME.FieldName = "END_STOP_TIME";
            this.colEND_STOP_TIME.Name = "colEND_STOP_TIME";
            this.colEND_STOP_TIME.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colEND_STOP_TIME.Visible = true;
            this.colEND_STOP_TIME.VisibleIndex = 4;
            this.colEND_STOP_TIME.Width = 154;
            // 
            // colSTOP_TIME
            // 
            this.colSTOP_TIME.Caption = "停机时间(min)";
            this.colSTOP_TIME.FieldName = "STOP_TIME";
            this.colSTOP_TIME.Name = "colSTOP_TIME";
            this.colSTOP_TIME.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colSTOP_TIME.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "STOP_TIME", "合计:{0:0.##}")});
            this.colSTOP_TIME.Visible = true;
            this.colSTOP_TIME.VisibleIndex = 5;
            this.colSTOP_TIME.Width = 111;
            // 
            // colSTOP_REASON
            // 
            this.colSTOP_REASON.Caption = "停机原因";
            this.colSTOP_REASON.FieldName = "STOP_REASON";
            this.colSTOP_REASON.Name = "colSTOP_REASON";
            this.colSTOP_REASON.OptionsEditForm.ColumnSpan = 2;
            this.colSTOP_REASON.OptionsEditForm.RowSpan = 4;
            this.colSTOP_REASON.OptionsEditForm.StartNewRow = true;
            this.colSTOP_REASON.OptionsEditForm.UseEditorColRowSpan = false;
            this.colSTOP_REASON.Visible = true;
            this.colSTOP_REASON.VisibleIndex = 6;
            this.colSTOP_REASON.Width = 171;
            // 
            // colMODIFY_DATE
            // 
            this.colMODIFY_DATE.Caption = "修改时间";
            this.colMODIFY_DATE.ColumnEdit = this.repositoryItemDateEdit1;
            this.colMODIFY_DATE.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colMODIFY_DATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colMODIFY_DATE.FieldName = "MODIFY_DATE";
            this.colMODIFY_DATE.Name = "colMODIFY_DATE";
            this.colMODIFY_DATE.Visible = true;
            this.colMODIFY_DATE.VisibleIndex = 7;
            this.colMODIFY_DATE.Width = 150;
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
            // colMODIFY_PERSON
            // 
            this.colMODIFY_PERSON.Caption = "录入人";
            this.colMODIFY_PERSON.FieldName = "MODIFY_PERSON";
            this.colMODIFY_PERSON.Name = "colMODIFY_PERSON";
            this.colMODIFY_PERSON.Visible = true;
            this.colMODIFY_PERSON.VisibleIndex = 8;
            // 
            // colJUDGE_REASON
            // 
            this.colJUDGE_REASON.Caption = "判定原因";
            this.colJUDGE_REASON.ColumnEdit = this.repositoryItemComboBox1;
            this.colJUDGE_REASON.FieldName = "JUDGE_REASON";
            this.colJUDGE_REASON.Name = "colJUDGE_REASON";
            this.colJUDGE_REASON.OptionsEditForm.ColumnSpan = 2;
            this.colJUDGE_REASON.OptionsEditForm.StartNewRow = true;
            this.colJUDGE_REASON.OptionsEditForm.UseEditorColRowSpan = false;
            this.colJUDGE_REASON.Visible = true;
            this.colJUDGE_REASON.VisibleIndex = 9;
            this.colJUDGE_REASON.Width = 205;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "检修",
            "机械",
            "电气",
            "操作",
            "储运",
            "高炉",
            "动力",
            "其它外因"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colJUDGE_DATE
            // 
            this.colJUDGE_DATE.Caption = "判定时间";
            this.colJUDGE_DATE.ColumnEdit = this.repositoryItemDateEdit2;
            this.colJUDGE_DATE.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colJUDGE_DATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colJUDGE_DATE.FieldName = "JUDGE_DATE";
            this.colJUDGE_DATE.Name = "colJUDGE_DATE";
            this.colJUDGE_DATE.OptionsEditForm.StartNewRow = true;
            this.colJUDGE_DATE.Visible = true;
            this.colJUDGE_DATE.VisibleIndex = 10;
            this.colJUDGE_DATE.Width = 161;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.repositoryItemDateEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemDateEdit2.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.repositoryItemDateEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // colJUDGE_PERSON
            // 
            this.colJUDGE_PERSON.Caption = "判定人";
            this.colJUDGE_PERSON.FieldName = "JUDGE_PERSON";
            this.colJUDGE_PERSON.Name = "colJUDGE_PERSON";
            this.colJUDGE_PERSON.Visible = true;
            this.colJUDGE_PERSON.VisibleIndex = 11;
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Items.AddRange(new object[] {
            "白班",
            "夜班"});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // device_start_stop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "device_start_stop";
            this.Size = new System.Drawing.Size(915, 344);
            this.Load += new System.EventHandler(this.device_start_stop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraGrid.Columns.GridColumn colBEGIN_STOP_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colEND_STOP_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOP_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOP_REASON;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_PERSON;
        private DevExpress.XtraGrid.Columns.GridColumn colJUDGE_REASON;
        private DevExpress.XtraGrid.Columns.GridColumn colJUDGE_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colJUDGE_PERSON;
        private DevExpress.XtraGrid.Columns.GridColumn colRECORD_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT;
        private DevExpress.XtraGrid.Columns.GridColumn colTEAM;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
