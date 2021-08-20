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
    public partial class change_shift : UserControl
    {
        public change_shift()
        {
            InitializeComponent();
            cls_public_main.FuncControl(this, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton2 }, new List<DevExpress.XtraGrid.Views.Grid.GridView> { gridView1 }, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton3 }, null, null);
        }
        string update, begin_time, end_time;
        public List<MODEL.T_INSERT_CHANGE_SHIFT> shift = new List<MODEL.T_INSERT_CHANGE_SHIFT>();
        public BindingSource shiftSource = new BindingSource();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sclect(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "");
        }

        private void change_shift_Load(object sender, EventArgs e)
        {
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            sclect(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "最新");
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            string begin = cls_public_main.sys_time();
            gridView1.SetFocusedRowCellValue("OPERATION_AREA", "S6");
            gridView1.SetFocusedRowCellValue("RECORD_DATE", begin);
            gridView1.SetFocusedRowCellValue("SHIFT", cls_public_main.m_team);
            gridView1.SetFocusedRowCellValue("RECORD_PERSON", cls_public_main.m_emp_name);
            gridView1.ShowEditForm();
            update = "insert";
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {
                var row = e.Row;
                DateTime end = Convert.ToDateTime(cls_public_main.sys_time());
                MODEL.T_INSERT_CHANGE_SHIFT bbb = (MODEL.T_INSERT_CHANGE_SHIFT)row;
                //bbb.RECORD_DATE = end;
                if (update == "insert") { yh.Entry<MODEL.T_INSERT_CHANGE_SHIFT>(bbb).State = EntityState.Added; update = "update"; }
                else { yh.Entry<MODEL.T_INSERT_CHANGE_SHIFT>(bbb).State = EntityState.Modified; }
                yh.Entry<MODEL.T_INSERT_CHANGE_SHIFT>(bbb);
                try
                { yh.SaveChanges(); }
                catch (Exception ExFail)
                { MessageBox.Show(ExFail.Message); }
            }
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (path != "")
            {
                gridView1.ExportToXls(path);
            }
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
                using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
                {

                    var row = gridView1.GetFocusedRow();
                    MODEL.T_INSERT_CHANGE_SHIFT bbb = (MODEL.T_INSERT_CHANGE_SHIFT)row;
                    yh.Entry<MODEL.T_INSERT_CHANGE_SHIFT>(bbb).State = EntityState.Deleted;
                    yh.SaveChanges();
                    gridView1.DeleteSelectedRows();

                }
            }
        }
        public void sclect(DateTime Begin_time, DateTime End_time, string i)
        {
            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {
                if (i == "最新")
                {
                    shift = yh.T_INSERT_CHANGE_SHIFT.Where(t => t.RECORD_DATE == yh.T_INSERT_CHANGE_SHIFT.Max(s => s.RECORD_DATE)).ToList();
                    shiftSource.DataSource = shift;
                    gridControl1.DataSource = shiftSource;
                }
                else
                {
                    shift.Clear();
                    shiftSource.Clear();
                    shift = yh.T_INSERT_CHANGE_SHIFT.Where(t => (t.RECORD_DATE > Begin_time && t.RECORD_DATE <= End_time)).ToList();
                    shiftSource.DataSource = shift;
                    gridControl1.DataSource = shiftSource;
                }
            }
        }
    }
}
