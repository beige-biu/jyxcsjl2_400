namespace jyxcsjl2
{
    partial class material_ratio_click
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPBD_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATERIAL_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colMATERIAL_PERCENTAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATERIAL_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBEGIN_STORE_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.colRECORD_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.colRECORD_PERSON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(913, 63);
            this.panel3.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jyxcsjl2.Properties.Resources.用户1;
            this.pictureBox1.Location = new System.Drawing.Point(91, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(179, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "发数据：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(352, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "请正确输入要输入的数据";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl2.Location = new System.Drawing.Point(0, 63);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemTimeEdit1,
            this.repositoryItemTimeEdit2});
            this.gridControl2.Size = new System.Drawing.Size(913, 321);
            this.gridControl2.TabIndex = 41;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Load += new System.EventHandler(this.gridControl2_Load);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPBD_NO,
            this.colMATERIAL_NAME,
            this.colMATERIAL_PERCENTAGE,
            this.colMATERIAL_CODE,
            this.colBEGIN_STORE_DATE,
            this.colRECORD_DATE,
            this.colRECORD_PERSON});
            this.gridView2.DetailHeight = 233;
            this.gridView2.FixedLineWidth = 1;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridView2.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView2.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView2.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.EditFormShowing += new DevExpress.XtraGrid.Views.Grid.EditFormShowingEventHandler(this.gridView2_EditFormShowing);
            this.gridView2.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView2_InitNewRow);
            this.gridView2.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2_RowUpdated);
            // 
            // colPBD_NO
            // 
            this.colPBD_NO.Caption = "配料单号";
            this.colPBD_NO.FieldName = "PBD_NO";
            this.colPBD_NO.Name = "colPBD_NO";
            this.colPBD_NO.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.Near;
            this.colPBD_NO.OptionsEditForm.ColumnSpan = 2;
            this.colPBD_NO.OptionsEditForm.UseEditorColRowSpan = false;
            this.colPBD_NO.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colPBD_NO.Visible = true;
            this.colPBD_NO.VisibleIndex = 0;
            this.colPBD_NO.Width = 135;
            // 
            // colMATERIAL_NAME
            // 
            this.colMATERIAL_NAME.Caption = "物料名称";
            this.colMATERIAL_NAME.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colMATERIAL_NAME.FieldName = "MATERIAL_NAME";
            this.colMATERIAL_NAME.Name = "colMATERIAL_NAME";
            this.colMATERIAL_NAME.OptionsColumn.AllowEdit = false;
            this.colMATERIAL_NAME.OptionsEditForm.StartNewRow = true;
            this.colMATERIAL_NAME.Visible = true;
            this.colMATERIAL_NAME.VisibleIndex = 1;
            this.colMATERIAL_NAME.Width = 199;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ERP_CODE", "物料代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ERP_NAME", "物料名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ERP_TYPE", "物料规格")});
            this.repositoryItemLookUpEdit1.DropDownRows = 14;
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.Modified += new System.EventHandler(this.repositoryItemLookUpEdit1_Modified);
            // 
            // colMATERIAL_PERCENTAGE
            // 
            this.colMATERIAL_PERCENTAGE.Caption = "物料配比";
            this.colMATERIAL_PERCENTAGE.FieldName = "MATERIAL_PERCENTAGE";
            this.colMATERIAL_PERCENTAGE.Name = "colMATERIAL_PERCENTAGE";
            this.colMATERIAL_PERCENTAGE.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.Near;
            this.colMATERIAL_PERCENTAGE.OptionsEditForm.UseEditorColRowSpan = false;
            this.colMATERIAL_PERCENTAGE.Visible = true;
            this.colMATERIAL_PERCENTAGE.VisibleIndex = 3;
            // 
            // colMATERIAL_CODE
            // 
            this.colMATERIAL_CODE.Caption = "物料代码";
            this.colMATERIAL_CODE.CustomizationCaption = "代码";
            this.colMATERIAL_CODE.FieldName = "MATERIAL_CODE";
            this.colMATERIAL_CODE.Name = "colMATERIAL_CODE";
            this.colMATERIAL_CODE.OptionsEditForm.StartNewRow = true;
            this.colMATERIAL_CODE.OptionsEditForm.UseEditorColRowSpan = false;
            this.colMATERIAL_CODE.Visible = true;
            this.colMATERIAL_CODE.VisibleIndex = 2;
            this.colMATERIAL_CODE.Width = 153;
            // 
            // colBEGIN_STORE_DATE
            // 
            this.colBEGIN_STORE_DATE.Caption = "开堆时间";
            this.colBEGIN_STORE_DATE.ColumnEdit = this.repositoryItemTimeEdit1;
            this.colBEGIN_STORE_DATE.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colBEGIN_STORE_DATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBEGIN_STORE_DATE.FieldName = "BEGIN_STORE_DATE";
            this.colBEGIN_STORE_DATE.Name = "colBEGIN_STORE_DATE";
            this.colBEGIN_STORE_DATE.Visible = true;
            this.colBEGIN_STORE_DATE.VisibleIndex = 4;
            this.colBEGIN_STORE_DATE.Width = 188;
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit1.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.repositoryItemTimeEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemTimeEdit1.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.repositoryItemTimeEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemTimeEdit1.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // colRECORD_DATE
            // 
            this.colRECORD_DATE.Caption = "记录时间";
            this.colRECORD_DATE.ColumnEdit = this.repositoryItemTimeEdit2;
            this.colRECORD_DATE.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colRECORD_DATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRECORD_DATE.FieldName = "RECORD_DATE";
            this.colRECORD_DATE.Name = "colRECORD_DATE";
            this.colRECORD_DATE.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colRECORD_DATE.Visible = true;
            this.colRECORD_DATE.VisibleIndex = 5;
            this.colRECORD_DATE.Width = 173;
            // 
            // repositoryItemTimeEdit2
            // 
            this.repositoryItemTimeEdit2.AutoHeight = false;
            this.repositoryItemTimeEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit2.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.repositoryItemTimeEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemTimeEdit2.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.repositoryItemTimeEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemTimeEdit2.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            this.repositoryItemTimeEdit2.Name = "repositoryItemTimeEdit2";
            // 
            // colRECORD_PERSON
            // 
            this.colRECORD_PERSON.Caption = "记录人";
            this.colRECORD_PERSON.FieldName = "RECORD_PERSON";
            this.colRECORD_PERSON.Name = "colRECORD_PERSON";
            this.colRECORD_PERSON.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colRECORD_PERSON.Visible = true;
            this.colRECORD_PERSON.VisibleIndex = 6;
            this.colRECORD_PERSON.Width = 91;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(312, 395);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 27);
            this.button1.TabIndex = 42;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(457, 395);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 27);
            this.button2.TabIndex = 43;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(149, 395);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 27);
            this.button3.TabIndex = 44;
            this.button3.Text = "开堆";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(603, 395);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 27);
            this.button4.TabIndex = 45;
            this.button4.Text = "关闭";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // material_ratio_click
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 435);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "material_ratio_click";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配料单修改";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.material_ratio_click_FormClosed);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colPBD_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colMATERIAL_NAME;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colMATERIAL_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colMATERIAL_PERCENTAGE;
        private DevExpress.XtraGrid.Columns.GridColumn colBEGIN_STORE_DATE;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colRECORD_DATE;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colRECORD_PERSON;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
    }
}