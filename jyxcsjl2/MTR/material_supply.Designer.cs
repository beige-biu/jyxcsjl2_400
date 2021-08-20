namespace jyxcsjl2
{
    partial class material_supply
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.sendButton = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.queryButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tMATERIALSUPPLYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWORK_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAT_BATCH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAT_PROD_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAT_PROD_CNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRUB_TAPE_START_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRUB_TAPE_END_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCARRY_WGT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSRC_PILE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDST_PILE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBACKLOG_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSCALE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTICE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWEIGH_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAT_TRANS_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONFIRM_MAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONFIRM_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBIN_COLLECTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMATERIALSUPPLYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.sendButton);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.queryButton1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 39);
            this.panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "全部",
            "已确认",
            "未确认"});
            this.comboBox1.Location = new System.Drawing.Point(605, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 23);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Location = new System.Drawing.Point(923, 7);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(94, 24);
            this.simpleButton4.TabIndex = 21;
            this.simpleButton4.Text = "导出";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // sendButton
            // 
            this.sendButton.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendButton.Appearance.Options.UseFont = true;
            this.sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sendButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.sendButton.Location = new System.Drawing.Point(819, 7);
            this.sendButton.Margin = new System.Windows.Forms.Padding(2);
            this.sendButton.Name = "sendButton";
            this.sendButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sendButton.Size = new System.Drawing.Size(94, 24);
            this.sendButton.TabIndex = 17;
            this.sendButton.Text = "确定";
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click_1);
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
            // queryButton1
            // 
            this.queryButton1.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryButton1.Appearance.Options.UseFont = true;
            this.queryButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.queryButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.queryButton1.Location = new System.Drawing.Point(715, 7);
            this.queryButton1.Margin = new System.Windows.Forms.Padding(2);
            this.queryButton1.Name = "queryButton1";
            this.queryButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.queryButton1.Size = new System.Drawing.Size(94, 24);
            this.queryButton1.TabIndex = 14;
            this.queryButton1.Text = "查询";
            this.queryButton1.Click += new System.EventHandler(this.queryButton1_Click);
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
            this.gridControl1.DataSource = this.tMATERIALSUPPLYBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridLevelNode2.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControl1.Location = new System.Drawing.Point(0, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1023, 361);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("宋体", 10.5F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("宋体", 10.5F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("宋体", 10.5F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWORK_TIME,
            this.colMAT_BATCH_NO,
            this.colMAT_PROD_CODE,
            this.colMAT_PROD_CNAME,
            this.colRUB_TAPE_START_TIME,
            this.colRUB_TAPE_END_TIME,
            this.colCARRY_WGT,
            this.colSRC_PILE_NO,
            this.colDST_PILE_NO,
            this.colBACKLOG_CODE,
            this.colSCALE_NO,
            this.colNOTICE_NO,
            this.colWEIGH_BY,
            this.colMAT_TRANS_TYPE,
            this.colCONFIRM_MAN,
            this.colCONFIRM_TIME,
            this.colREMARK,
            this.colBIN_COLLECTION});
            this.gridView1.DetailHeight = 233;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMAT_TRANS_TYPE, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMAT_BATCH_NO, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // colWORK_TIME
            // 
            this.colWORK_TIME.Caption = "时间";
            this.colWORK_TIME.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colWORK_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colWORK_TIME.FieldName = "WORK_TIME";
            this.colWORK_TIME.Name = "colWORK_TIME";
            this.colWORK_TIME.Visible = true;
            this.colWORK_TIME.VisibleIndex = 1;
            this.colWORK_TIME.Width = 145;
            // 
            // colMAT_BATCH_NO
            // 
            this.colMAT_BATCH_NO.Caption = "批号";
            this.colMAT_BATCH_NO.FieldName = "MAT_BATCH_NO";
            this.colMAT_BATCH_NO.Name = "colMAT_BATCH_NO";
            this.colMAT_BATCH_NO.Visible = true;
            this.colMAT_BATCH_NO.VisibleIndex = 0;
            this.colMAT_BATCH_NO.Width = 111;
            // 
            // colMAT_PROD_CODE
            // 
            this.colMAT_PROD_CODE.Caption = "物资代码";
            this.colMAT_PROD_CODE.FieldName = "MAT_PROD_CODE";
            this.colMAT_PROD_CODE.Name = "colMAT_PROD_CODE";
            this.colMAT_PROD_CODE.Width = 92;
            // 
            // colMAT_PROD_CNAME
            // 
            this.colMAT_PROD_CNAME.Caption = "物资名称";
            this.colMAT_PROD_CNAME.FieldName = "MAT_PROD_CNAME";
            this.colMAT_PROD_CNAME.Name = "colMAT_PROD_CNAME";
            this.colMAT_PROD_CNAME.Visible = true;
            this.colMAT_PROD_CNAME.VisibleIndex = 2;
            this.colMAT_PROD_CNAME.Width = 143;
            // 
            // colRUB_TAPE_START_TIME
            // 
            this.colRUB_TAPE_START_TIME.Caption = "供料开始时间";
            this.colRUB_TAPE_START_TIME.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss.";
            this.colRUB_TAPE_START_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRUB_TAPE_START_TIME.FieldName = "RUB_TAPE_START_TIME";
            this.colRUB_TAPE_START_TIME.Name = "colRUB_TAPE_START_TIME";
            this.colRUB_TAPE_START_TIME.Visible = true;
            this.colRUB_TAPE_START_TIME.VisibleIndex = 3;
            this.colRUB_TAPE_START_TIME.Width = 162;
            // 
            // colRUB_TAPE_END_TIME
            // 
            this.colRUB_TAPE_END_TIME.Caption = "供料结束时间";
            this.colRUB_TAPE_END_TIME.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colRUB_TAPE_END_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRUB_TAPE_END_TIME.FieldName = "RUB_TAPE_END_TIME";
            this.colRUB_TAPE_END_TIME.Name = "colRUB_TAPE_END_TIME";
            this.colRUB_TAPE_END_TIME.Visible = true;
            this.colRUB_TAPE_END_TIME.VisibleIndex = 4;
            this.colRUB_TAPE_END_TIME.Width = 145;
            // 
            // colCARRY_WGT
            // 
            this.colCARRY_WGT.Caption = "供料量(t)";
            this.colCARRY_WGT.FieldName = "CARRY_WGT";
            this.colCARRY_WGT.Name = "colCARRY_WGT";
            this.colCARRY_WGT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CARRY_WGT", "合计={0:0.##}")});
            this.colCARRY_WGT.Visible = true;
            this.colCARRY_WGT.VisibleIndex = 5;
            this.colCARRY_WGT.Width = 109;
            // 
            // colSRC_PILE_NO
            // 
            this.colSRC_PILE_NO.Caption = "料堆号";
            this.colSRC_PILE_NO.FieldName = "SRC_PILE_NO";
            this.colSRC_PILE_NO.Name = "colSRC_PILE_NO";
            this.colSRC_PILE_NO.Visible = true;
            this.colSRC_PILE_NO.VisibleIndex = 7;
            // 
            // colDST_PILE_NO
            // 
            this.colDST_PILE_NO.Caption = "目的堆号";
            this.colDST_PILE_NO.FieldName = "DST_PILE_NO";
            this.colDST_PILE_NO.Name = "colDST_PILE_NO";
            this.colDST_PILE_NO.Visible = true;
            this.colDST_PILE_NO.VisibleIndex = 8;
            this.colDST_PILE_NO.Width = 104;
            // 
            // colBACKLOG_CODE
            // 
            this.colBACKLOG_CODE.Caption = "去向";
            this.colBACKLOG_CODE.FieldName = "BACKLOG_CODE";
            this.colBACKLOG_CODE.Name = "colBACKLOG_CODE";
            this.colBACKLOG_CODE.Visible = true;
            this.colBACKLOG_CODE.VisibleIndex = 9;
            this.colBACKLOG_CODE.Width = 97;
            // 
            // colSCALE_NO
            // 
            this.colSCALE_NO.Caption = "称号";
            this.colSCALE_NO.FieldName = "SCALE_NO";
            this.colSCALE_NO.Name = "colSCALE_NO";
            this.colSCALE_NO.Visible = true;
            this.colSCALE_NO.VisibleIndex = 6;
            // 
            // colNOTICE_NO
            // 
            this.colNOTICE_NO.Caption = "配料通知单号";
            this.colNOTICE_NO.FieldName = "NOTICE_NO";
            this.colNOTICE_NO.Name = "colNOTICE_NO";
            this.colNOTICE_NO.Visible = true;
            this.colNOTICE_NO.VisibleIndex = 10;
            this.colNOTICE_NO.Width = 112;
            // 
            // colWEIGH_BY
            // 
            this.colWEIGH_BY.Caption = "计量员";
            this.colWEIGH_BY.FieldName = "WEIGH_BY";
            this.colWEIGH_BY.Name = "colWEIGH_BY";
            this.colWEIGH_BY.Visible = true;
            this.colWEIGH_BY.VisibleIndex = 11;
            this.colWEIGH_BY.Width = 89;
            // 
            // colMAT_TRANS_TYPE
            // 
            this.colMAT_TRANS_TYPE.Caption = "上料类型";
            this.colMAT_TRANS_TYPE.FieldName = "MAT_TRANS_TYPE";
            this.colMAT_TRANS_TYPE.Name = "colMAT_TRANS_TYPE";
            this.colMAT_TRANS_TYPE.Width = 120;
            // 
            // colCONFIRM_MAN
            // 
            this.colCONFIRM_MAN.Caption = "确认人";
            this.colCONFIRM_MAN.FieldName = "CONFIRM_MAN";
            this.colCONFIRM_MAN.Name = "colCONFIRM_MAN";
            this.colCONFIRM_MAN.Visible = true;
            this.colCONFIRM_MAN.VisibleIndex = 13;
            this.colCONFIRM_MAN.Width = 101;
            // 
            // colCONFIRM_TIME
            // 
            this.colCONFIRM_TIME.Caption = "确认时间";
            this.colCONFIRM_TIME.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colCONFIRM_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCONFIRM_TIME.FieldName = "CONFIRM_TIME";
            this.colCONFIRM_TIME.Name = "colCONFIRM_TIME";
            this.colCONFIRM_TIME.Visible = true;
            this.colCONFIRM_TIME.VisibleIndex = 14;
            this.colCONFIRM_TIME.Width = 171;
            // 
            // colREMARK
            // 
            this.colREMARK.Caption = "备注";
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 15;
            this.colREMARK.Width = 170;
            // 
            // colBIN_COLLECTION
            // 
            this.colBIN_COLLECTION.Caption = "料仓号";
            this.colBIN_COLLECTION.FieldName = "BIN_COLLECTION";
            this.colBIN_COLLECTION.Name = "colBIN_COLLECTION";
            this.colBIN_COLLECTION.Visible = true;
            this.colBIN_COLLECTION.VisibleIndex = 12;
            // 
            // material_supply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "material_supply";
            this.Size = new System.Drawing.Size(1023, 400);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMATERIALSUPPLYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton sendButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.SimpleButton queryButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tMATERIALSUPPLYBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colMAT_BATCH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colMAT_PROD_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colMAT_PROD_CNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colRUB_TAPE_START_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colRUB_TAPE_END_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colCARRY_WGT;
        private DevExpress.XtraGrid.Columns.GridColumn colSRC_PILE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colDST_PILE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colBACKLOG_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colSCALE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOTICE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colWEIGH_BY;
        private DevExpress.XtraGrid.Columns.GridColumn colMAT_TRANS_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colCONFIRM_MAN;
        private DevExpress.XtraGrid.Columns.GridColumn colCONFIRM_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraGrid.Columns.GridColumn colBIN_COLLECTION;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
