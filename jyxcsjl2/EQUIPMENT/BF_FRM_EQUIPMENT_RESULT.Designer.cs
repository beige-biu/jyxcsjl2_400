namespace jyxcsjl2
{
    partial class BF_FRM_EQUIPMENT_RESULT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BF_FRM_EQUIPMENT_RESULT));
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.gcDetail = new DevExpress.XtraGrid.GridControl();
            this.gvDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRECORD_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_SHIFT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_TEAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOG_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAG_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAG_DES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAG_GROUP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAG_VALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAG_LOWERVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAG_UPPERVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAG_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOWERVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPPERVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAG_PLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAG_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDATE_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gcLog = new DevExpress.XtraGrid.GridControl();
            this.gvLog = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLog)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.Appearance.Options.UseFont = true;
            this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModify.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnModify.Location = new System.Drawing.Point(804, 2);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnModify.Size = new System.Drawing.Size(83, 30);
            this.btnModify.TabIndex = 20;
            this.btnModify.Text = "修改";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(0, 3);
            this.txtResult.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(798, 133);
            this.txtResult.TabIndex = 0;
            // 
            // gcDetail
            // 
            this.gcDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDetail.Location = new System.Drawing.Point(0, 0);
            this.gcDetail.MainView = this.gvDetail;
            this.gcDetail.Margin = new System.Windows.Forms.Padding(0);
            this.gcDetail.Name = "gcDetail";
            this.gcDetail.Size = new System.Drawing.Size(890, 541);
            this.gcDetail.TabIndex = 1;
            this.gcDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetail});
            // 
            // gvDetail
            // 
            this.gvDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colRECORD_TIME,
            this.colWORK_SHIFT,
            this.colWORK_TEAM,
            this.colLOG_ID,
            this.colTAG_NAME,
            this.colTAG_DES,
            this.colTAG_GROUP,
            this.colTAG_VALUE,
            this.colTAG_LOWERVALUE,
            this.colTAG_UPPERVALUE,
            this.colTAG_STATUS,
            this.colLOWERVALUE,
            this.colUPPERVALUE,
            this.colUNIT,
            this.colTAG_PLC,
            this.colTAG_SEQ,
            this.colUPDATE_TIME});
            this.gvDetail.GridControl = this.gcDetail;
            this.gvDetail.Name = "gvDetail";
            this.gvDetail.OptionsBehavior.Editable = false;
            this.gvDetail.OptionsView.ColumnAutoWidth = false;
            this.gvDetail.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Width = 94;
            // 
            // colRECORD_TIME
            // 
            this.colRECORD_TIME.Caption = "记录时间";
            this.colRECORD_TIME.DisplayFormat.FormatString = "yyyy-MM-dd HH-mm-ss";
            this.colRECORD_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRECORD_TIME.FieldName = "RECORD_TIME";
            this.colRECORD_TIME.MinWidth = 25;
            this.colRECORD_TIME.Name = "colRECORD_TIME";
            this.colRECORD_TIME.Visible = true;
            this.colRECORD_TIME.VisibleIndex = 0;
            this.colRECORD_TIME.Width = 94;
            // 
            // colWORK_SHIFT
            // 
            this.colWORK_SHIFT.Caption = "班次";
            this.colWORK_SHIFT.FieldName = "WORK_SHIFT";
            this.colWORK_SHIFT.MinWidth = 25;
            this.colWORK_SHIFT.Name = "colWORK_SHIFT";
            this.colWORK_SHIFT.Visible = true;
            this.colWORK_SHIFT.VisibleIndex = 1;
            this.colWORK_SHIFT.Width = 94;
            // 
            // colWORK_TEAM
            // 
            this.colWORK_TEAM.Caption = "班别";
            this.colWORK_TEAM.FieldName = "WORK_TEAM";
            this.colWORK_TEAM.MinWidth = 25;
            this.colWORK_TEAM.Name = "colWORK_TEAM";
            this.colWORK_TEAM.Visible = true;
            this.colWORK_TEAM.VisibleIndex = 2;
            this.colWORK_TEAM.Width = 94;
            // 
            // colLOG_ID
            // 
            this.colLOG_ID.Caption = "机组ID";
            this.colLOG_ID.FieldName = "LOG_ID";
            this.colLOG_ID.MinWidth = 25;
            this.colLOG_ID.Name = "colLOG_ID";
            this.colLOG_ID.Width = 94;
            // 
            // colTAG_NAME
            // 
            this.colTAG_NAME.Caption = "点名";
            this.colTAG_NAME.FieldName = "TAG_NAME";
            this.colTAG_NAME.MinWidth = 25;
            this.colTAG_NAME.Name = "colTAG_NAME";
            this.colTAG_NAME.Visible = true;
            this.colTAG_NAME.VisibleIndex = 3;
            this.colTAG_NAME.Width = 94;
            // 
            // colTAG_DES
            // 
            this.colTAG_DES.Caption = "点名描述";
            this.colTAG_DES.FieldName = "TAG_DES";
            this.colTAG_DES.MinWidth = 25;
            this.colTAG_DES.Name = "colTAG_DES";
            this.colTAG_DES.Visible = true;
            this.colTAG_DES.VisibleIndex = 4;
            this.colTAG_DES.Width = 94;
            // 
            // colTAG_GROUP
            // 
            this.colTAG_GROUP.Caption = "点名分组";
            this.colTAG_GROUP.FieldName = "TAG_GROUP";
            this.colTAG_GROUP.MinWidth = 25;
            this.colTAG_GROUP.Name = "colTAG_GROUP";
            this.colTAG_GROUP.Visible = true;
            this.colTAG_GROUP.VisibleIndex = 5;
            this.colTAG_GROUP.Width = 94;
            // 
            // colTAG_VALUE
            // 
            this.colTAG_VALUE.Caption = "最新值";
            this.colTAG_VALUE.FieldName = "TAG_VALUE";
            this.colTAG_VALUE.MinWidth = 25;
            this.colTAG_VALUE.Name = "colTAG_VALUE";
            this.colTAG_VALUE.Visible = true;
            this.colTAG_VALUE.VisibleIndex = 6;
            this.colTAG_VALUE.Width = 94;
            // 
            // colTAG_LOWERVALUE
            // 
            this.colTAG_LOWERVALUE.Caption = "最小值";
            this.colTAG_LOWERVALUE.FieldName = "TAG_LOWERVALUE";
            this.colTAG_LOWERVALUE.MinWidth = 25;
            this.colTAG_LOWERVALUE.Name = "colTAG_LOWERVALUE";
            this.colTAG_LOWERVALUE.Visible = true;
            this.colTAG_LOWERVALUE.VisibleIndex = 7;
            this.colTAG_LOWERVALUE.Width = 94;
            // 
            // colTAG_UPPERVALUE
            // 
            this.colTAG_UPPERVALUE.Caption = "最大值";
            this.colTAG_UPPERVALUE.FieldName = "TAG_UPPERVALUE";
            this.colTAG_UPPERVALUE.MinWidth = 25;
            this.colTAG_UPPERVALUE.Name = "colTAG_UPPERVALUE";
            this.colTAG_UPPERVALUE.Visible = true;
            this.colTAG_UPPERVALUE.VisibleIndex = 8;
            this.colTAG_UPPERVALUE.Width = 94;
            // 
            // colTAG_STATUS
            // 
            this.colTAG_STATUS.Caption = "点状态";
            this.colTAG_STATUS.FieldName = "TAG_STATUS";
            this.colTAG_STATUS.MinWidth = 25;
            this.colTAG_STATUS.Name = "colTAG_STATUS";
            this.colTAG_STATUS.Width = 94;
            // 
            // colLOWERVALUE
            // 
            this.colLOWERVALUE.Caption = "下限";
            this.colLOWERVALUE.FieldName = "LOWERVALUE";
            this.colLOWERVALUE.MinWidth = 25;
            this.colLOWERVALUE.Name = "colLOWERVALUE";
            this.colLOWERVALUE.Visible = true;
            this.colLOWERVALUE.VisibleIndex = 9;
            this.colLOWERVALUE.Width = 94;
            // 
            // colUPPERVALUE
            // 
            this.colUPPERVALUE.Caption = "上限";
            this.colUPPERVALUE.FieldName = "UPPERVALUE";
            this.colUPPERVALUE.MinWidth = 25;
            this.colUPPERVALUE.Name = "colUPPERVALUE";
            this.colUPPERVALUE.Visible = true;
            this.colUPPERVALUE.VisibleIndex = 10;
            this.colUPPERVALUE.Width = 94;
            // 
            // colUNIT
            // 
            this.colUNIT.Caption = "单位";
            this.colUNIT.FieldName = "UNIT";
            this.colUNIT.MinWidth = 25;
            this.colUNIT.Name = "colUNIT";
            this.colUNIT.Visible = true;
            this.colUNIT.VisibleIndex = 11;
            this.colUNIT.Width = 94;
            // 
            // colTAG_PLC
            // 
            this.colTAG_PLC.Caption = "PLC点名";
            this.colTAG_PLC.FieldName = "TAG_PLC";
            this.colTAG_PLC.MinWidth = 25;
            this.colTAG_PLC.Name = "colTAG_PLC";
            this.colTAG_PLC.Width = 94;
            // 
            // colTAG_SEQ
            // 
            this.colTAG_SEQ.FieldName = "TAG_SEQ";
            this.colTAG_SEQ.MinWidth = 25;
            this.colTAG_SEQ.Name = "colTAG_SEQ";
            this.colTAG_SEQ.Width = 94;
            // 
            // colUPDATE_TIME
            // 
            this.colUPDATE_TIME.FieldName = "UPDATE_TIME";
            this.colUPDATE_TIME.MinWidth = 25;
            this.colUPDATE_TIME.Name = "colUPDATE_TIME";
            this.colUPDATE_TIME.Width = 94;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbShift);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 48);
            this.panel1.TabIndex = 9;
            // 
            // cmbShift
            // 
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.Font = new System.Drawing.Font("宋体", 11F);
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Items.AddRange(new object[] {
            "夜班",
            "白班"});
            this.cmbShift.Location = new System.Drawing.Point(274, 11);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(100, 26);
            this.cmbShift.TabIndex = 21;
            // 
            // btnQuery
            // 
            this.btnQuery.Appearance.Options.UseFont = true;
            this.btnQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQuery.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnQuery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.ImageOptions.Image")));
            this.btnQuery.Location = new System.Drawing.Point(388, 10);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnQuery.Size = new System.Drawing.Size(93, 30);
            this.btnQuery.TabIndex = 19;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(96, 11);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(150, 27);
            this.dtpDate.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(41, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 18);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "日期：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.gcLog, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1279, 683);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // gcLog
            // 
            this.gcLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLog.Location = new System.Drawing.Point(3, 3);
            this.gcLog.MainView = this.gvLog;
            this.gcLog.Name = "gcLog";
            this.gcLog.Size = new System.Drawing.Size(377, 677);
            this.gcLog.TabIndex = 17;
            this.gcLog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLog});
            // 
            // gvLog
            // 
            this.gvLog.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvLog.GridControl = this.gcLog;
            this.gvLog.Name = "gvLog";
            this.gvLog.OptionsBehavior.Editable = false;
            this.gvLog.OptionsView.ShowGroupPanel = false;
            this.gvLog.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvLog_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "工序ID";
            this.gridColumn2.FieldName = "UNITID";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "机组ID";
            this.gridColumn3.FieldName = "LOG_ID";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "机组描述";
            this.gridColumn4.FieldName = "LOG_DES";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 94;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.gcDetail, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(386, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(890, 677);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.btnModify, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtResult, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 541);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(890, 136);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // BF_FRM_EQUIPMENT_RESULT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "BF_FRM_EQUIPMENT_RESULT";
            this.Size = new System.Drawing.Size(1279, 731);
            this.Load += new System.EventHandler(this.BF_FRM_EQUIPMENT_RESULT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLog)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colWORK_TEAM;
        private DevExpress.XtraGrid.Columns.GridColumn colTAG_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colTAG_DES;
        private DevExpress.XtraGrid.Columns.GridColumn colTAG_GROUP;
        private DevExpress.XtraGrid.Columns.GridColumn colTAG_VALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colTAG_LOWERVALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colTAG_UPPERVALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colLOG_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colTAG_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colUPPERVALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIT;
        private DevExpress.XtraGrid.Columns.GridColumn colTAG_PLC;
        private DevExpress.XtraGrid.Columns.GridColumn colTAG_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDATE_TIME;
        private DevExpress.XtraEditors.SimpleButton btnModify;
        private System.Windows.Forms.TextBox txtResult;
        private DevExpress.XtraGrid.Columns.GridColumn colLOWERVALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_SHIFT;
        private DevExpress.XtraGrid.GridControl gcDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colRECORD_TIME;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbShift;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gcLog;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLog;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
