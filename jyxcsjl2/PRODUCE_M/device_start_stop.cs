using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace jyxcsjl2
{
    public partial class device_start_stop : UserControl
    {
        public device_start_stop()
        {
            InitializeComponent();
         
        }
        string update, begin_time, end_time;
        public List<MODEL.T_PRODUCE_SINTER_RUNSTOP> sj = new List<MODEL.T_PRODUCE_SINTER_RUNSTOP>();
        public BindingSource sjSource = new BindingSource();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sclect(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "最新");
        }

        private void device_start_stop_Load(object sender, EventArgs e)
        {
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            sclect(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "最新");
          
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount <= 0)
            {
                MessageBox.Show("没有选中删除行，请查询要删除的数据删除");
                return;
            }
            if (MessageBox.Show("你确定要删除选中的记录吗？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, 0, false) == DialogResult.Yes)
            {
                using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
                {
                    var row = gridView1.GetFocusedRow();
                    MODEL.T_PRODUCE_SINTER_RUNSTOP bbb = (MODEL.T_PRODUCE_SINTER_RUNSTOP)row;
                    yh.Entry<MODEL.T_PRODUCE_SINTER_RUNSTOP>(bbb).State = EntityState.Deleted;
                    yh.SaveChanges();
                    gridView1.DeleteSelectedRows();
                }
            }
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "SHIFT")
            {
                if (Convert.ToDecimal(e.Value) == 0) e.DisplayText = "夜班";
                if (Convert.ToDecimal(e.Value) == 1) e.DisplayText = "白班";
            }
            else
            {
                if (e.DisplayText == "0")
                {
                    if (Convert.ToDecimal(e.Value) == 0) e.DisplayText = "";
                }

            }
  
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DateTime end = Convert.ToDateTime(cls_public_main.sys_time());
            if (e.Column.FieldName == "STOP_REASON")
            {
                gridView1.SetFocusedRowCellValue("MODIFY_DATE", end);
                gridView1.SetFocusedRowCellValue("MODIFY_PERSON", cls_public_main.m_emp_name);
            }
            if (e.Column.FieldName == "JUDGE_REASON")
            {
                gridView1.SetFocusedRowCellValue("JUDGE_DATE", end);
                gridView1.SetFocusedRowCellValue("JUDGE_PERSON", cls_public_main.m_emp_name);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (path != "")
            {
                gridView1.ExportToXls(path);
            }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            {
                var row = e.Row;
                //DateTime end = Convert.ToDateTime(cls_public_main.sys_time());
                MODEL.T_PRODUCE_SINTER_RUNSTOP bbb = (MODEL.T_PRODUCE_SINTER_RUNSTOP)row;
                if (update == "insert") { yh.Entry<MODEL.T_PRODUCE_SINTER_RUNSTOP>(bbb).State = EntityState.Added; update = "update"; }
                else { yh.Entry<MODEL.T_PRODUCE_SINTER_RUNSTOP>(bbb).State = EntityState.Modified; }
                yh.Entry<MODEL.T_PRODUCE_SINTER_RUNSTOP>(bbb);
                try
                { yh.SaveChanges(); }
                catch (Exception ExFail)
                { MessageBox.Show(ExFail.Message); }
            }
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();
        }

        public void sclect(DateTime Begin_time, DateTime End_time, string i)
        {
            using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            {
                sj = yh.T_PRODUCE_SINTER_RUNSTOP.Where(t => (t.STOP_TIME >= 3) && (t.RECORD_DATE > Begin_time && t.RECORD_DATE <= End_time)).ToList();
                sjSource.DataSource = sj;
                gridControl1.DataSource = sjSource;
            }
        }
    }
}
