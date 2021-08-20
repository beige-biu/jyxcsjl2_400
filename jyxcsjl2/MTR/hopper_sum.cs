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
    public partial class hopper_sum : UserControl
    {
        public hopper_sum()
        {
            InitializeComponent();   
        }
        public string begin_time, end_time;
        private void gridControl1_Load(object sender, EventArgs e)
        {
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            sclect(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sclect(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (path != "")
            {
                gridView1.ExportToXls(path);
            }
            
        }

        public void sclect(DateTime Begin_time, DateTime End_time)
        {

            using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            {
                //DateTime beg = Convert.ToDateTime(begin_time);//.CreateDateTime(, beg.Month, beg.Day, beg.Hour, beg.Minute, beg.Second);
                //DateTime end = Convert.ToDateTime(End_time);
                var bb = yh.T_MATERIAL_HOPPER_SUM.Where(t => (t.RECORD_DATE > Begin_time && t.RECORD_DATE <= End_time));
                gridControl1.DataSource = bb.ToList();
                var sql = bb.ToString();
            }
        }
    }
}
