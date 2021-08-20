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
    public partial class yandaoxunhuan : UserControl
    {
        public yandaoxunhuan()
        {
            InitializeComponent();
        }
        public string begin_time, end_time;
        private void yandaoxunhuan_Load(object sender, EventArgs e)
        {
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            sclect_p(dateTimePicker1.Value, dateTimePicker2.Value);
            sclect_t(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void sclect_p(DateTime Begin_time, DateTime End_time)
        {
            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {
                var bb = yh.T_PRODUCE_YANDAOXUNHUAN.Where(u => u.RECORD_DATE > Begin_time && u.RECORD_DATE <= End_time);
                gridControl1.DataSource = bb.ToList();
                var sql = bb.ToString();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (path != "")
            {
                bandedGridView1.ExportToXls(path);
            }


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (path != "")
            {
                bandedGridView2.ExportToXls(path);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sclect_p(dateTimePicker1.Value, dateTimePicker2.Value);
            sclect_t(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        public void sclect_t(DateTime Begin_time, DateTime End_time)
        {

            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {

                var bb = yh.T_PRODUCE_YANDAOXUNHUAN.Where(t => (t.RECORD_DATE > Begin_time && t.RECORD_DATE <= End_time));
                gridControl2.DataSource = bb.ToList();
                var sql = bb.ToString();
            }
        }


    }
}
