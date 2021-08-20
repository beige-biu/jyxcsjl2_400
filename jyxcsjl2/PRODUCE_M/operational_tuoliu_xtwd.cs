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
using jyxcsjl2.MODEL;


namespace jyxcsjl2
{
    public partial class operational_tuoliu_xtwd : UserControl
    {
        public operational_tuoliu_xtwd()
        {
            InitializeComponent();
        }
        string begin_time, end_time;
        private void operational_tuoliu_xtwd_Load(object sender, EventArgs e)
        {
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            sclect_p(this.dateTimePicker1.Value, this.dateTimePicker2.Value);
            sclect_t(this.dateTimePicker1.Value, this.dateTimePicker2.Value);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sclect_p(this.dateTimePicker1.Value, this.dateTimePicker2.Value);
            sclect_t(this.dateTimePicker1.Value, this.dateTimePicker2.Value);
        }
        public void sclect_p(DateTime Begin_time, DateTime End_time)
        {
            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {
                var bb = yh.T_PRODUCE_TUOLIU_AZ.Where(u => u.RECORD_DATE > Begin_time && u.RECORD_DATE <= End_time);
                gridControl1.DataSource = bb.ToList();
                var sql = bb.ToString();
            }
        }
        public void sclect_t(DateTime Begin_time, DateTime End_time)
        {

            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {

                var bb = yh.T_PRODUCE_TUOLIU_ZYFJ.Where(t => (t.RECORD_DATE > Begin_time && t.RECORD_DATE <= End_time));
                gridControl4.DataSource = bb.ToList();
                var sql = bb.ToString();
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
                bandedGridView4.ExportToXls(path);
            }
        }
    }
}
