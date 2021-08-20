using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jyxcsjl2
{
    public partial class operational_scrb : UserControl
    {
        public operational_scrb()
        {
            InitializeComponent();
        }
        string begin_time, end_time;
        DateTime begin_date;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
       
            sclect_p(this.dateTimePicker1.Value);
            sclect_p1(this.dateTimePicker1.Value);
            sclect_p2(this.dateTimePicker1.Value);
        }

        private void operational_scrb_Load(object sender, EventArgs e)
        {
            cls_public_main.select_time(out begin_time, out end_time);
            begin_date = Convert.ToDateTime(begin_time);

            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            sclect_p( begin_date);
            sclect_p1(begin_date);
            sclect_p2(begin_date);
        }
        public void sclect_p(DateTime begin_date)
        {
            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {
                var bb = yh.T_PRODUCE_SINTER_SCRB.Where(u => u.RECORD_DATE == begin_date ).OrderBy(x=>x.RECORD_ID);
                gridControl1.DataSource = bb.ToList();
                var sql = bb.ToString();
            }
        }
        public void sclect_p1(DateTime begin_date)
        {
            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {
                var cc = yh.T_PRODUCE_SINTER_SCRB2.Where(u => u.RECORD_DATE ==begin_date).OrderBy(x => x.RECORD_ID);
                gridControl2.DataSource = cc.ToList();
                var sql = cc.ToString();
            }
        }
        public void sclect_p2(DateTime begin_date)
        {
            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {
                var dd = yh.T_PRODUCE_SINTER_SCRB1.Where(u => u.RECORD_DATE == begin_date).OrderBy(x => x.RECORD_ID);
                gridControl3.DataSource = dd.ToList();
                var sql = dd.ToString();
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (path != "")
            {
                bandedGridView1.ExportToXls(path);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (path != "")
            {
                bandedGridView2.ExportToXls(path);
            }
        }

        private void bandedGridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "SHIFT")
            {
                if (e.Value == null)
                {
                    e.DisplayText = " ";
                }
                else if (e.Value.ToString() == "1") { e.DisplayText = "夜班"; }
                else if (e.Value.ToString() == "0") { e.DisplayText = "白班"; }
            }
           
        }

        private void bandedGridView2_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "SHIFT")
            {
                if (e.Value == null)
                {
                    e.DisplayText = " ";
                }
                else if (e.Value.ToString() == "1") { e.DisplayText = "夜班"; }
                else if (e.Value.ToString() == "0") { e.DisplayText = "白班"; }
            }
           
        }

        private void bandedGridView3_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "SHIFT")
            {
                if (e.Value == null)
                {
                    e.DisplayText = " ";
                }
                else if (e.Value.ToString() == "1") { e.DisplayText = "夜班"; }
                else if (e.Value.ToString() == "0") { e.DisplayText = "白班"; }
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (path != "")
            {
                bandedGridView3.ExportToXls(path);
            }
        }
    }
}
