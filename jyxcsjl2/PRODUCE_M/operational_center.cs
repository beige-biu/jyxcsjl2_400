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
    public partial class operational_center : UserControl
    {
        public operational_center()
        {
            InitializeComponent();
            cls_public_main.FuncControl(this, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton2, simpleButton3 }, new List<DevExpress.XtraGrid.Views.Grid.GridView> { gridView1 }, new List<DevExpress.XtraEditors.SimpleButton> { Delete_Button4 }, null, null);
        }
        string update, begin_time, end_time;
        public List<MODEL.T_PRODUCE_SINTER_SCRB_CENTER> datelist = new List<MODEL.T_PRODUCE_SINTER_SCRB_CENTER>();
        public BindingSource DateSource = new BindingSource();
        private void operational_center_Load(object sender, EventArgs e)
        {
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            select(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "最新");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            operational_center_edit edit = new operational_center_edit();
            edit.ShowDialog();
           // if (win.DialogResult == DialogResult.OK)
          //  { select(dateTimePicker1.Value, dateTimePicker2.Value); }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            select(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "查询");
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {
                var row = e.Row;
                DateTime end = Convert.ToDateTime(cls_public_main.sys_time());
                MODEL.T_PRODUCE_SINTER_SCRB_CENTER bbb = (MODEL.T_PRODUCE_SINTER_SCRB_CENTER)row;
                //bbb.RECORD_DATE = end;
                if (update == "insert") { yh.Entry<MODEL.T_PRODUCE_SINTER_SCRB_CENTER>(bbb).State = EntityState.Added; update = "update"; }
                else { yh.Entry<MODEL.T_PRODUCE_SINTER_SCRB_CENTER>(bbb).State = EntityState.Modified; }
                yh.Entry<MODEL.T_PRODUCE_SINTER_SCRB_CENTER>(bbb);
                try
                { yh.SaveChanges(); }
                catch (Exception ExFail)
                { MessageBox.Show(ExFail.Message); }
            }
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();


        }

        private void Delete_Button4_Click(object sender, EventArgs e)
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
                    MODEL.T_PRODUCE_SINTER_SCRB_CENTER bbb = (MODEL.T_PRODUCE_SINTER_SCRB_CENTER)row;
                    yh.Entry<MODEL.T_PRODUCE_SINTER_SCRB_CENTER>(bbb).State = EntityState.Deleted;
                    yh.SaveChanges();
                    gridView1.DeleteSelectedRows();

                }
            }
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            string begin = cls_public_main.sys_time();
            gridView1.SetFocusedRowCellValue("RECORD_DATE", begin);
            gridView1.ShowEditForm();
            update = "insert";
        }

        public void select(DateTime Begin_time, DateTime End_time,String i)
        {
            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {


            if (i == "最新")
            {
                datelist = yh.T_PRODUCE_SINTER_SCRB_CENTER.Where(t => t.RECORD_DATE == yh.T_PRODUCE_SINTER_SCRB_CENTER.Max(s => s.RECORD_DATE)).ToList();
                DateSource.DataSource = datelist;
                gridControl1.DataSource = DateSource;
            }
            else
            {
                    datelist.Clear();
                    DateSource.Clear();
                    datelist = yh.T_PRODUCE_SINTER_SCRB_CENTER.Where(t => (t.RECORD_DATE > Begin_time && t.RECORD_DATE <= End_time)).ToList();
                    DateSource.DataSource = datelist;
                gridControl1.DataSource = DateSource;
            }
            }
        }


    }
}
