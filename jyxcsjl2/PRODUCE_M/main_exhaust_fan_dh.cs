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
    public partial class main_exhaust_fan_dh : UserControl
    {
        public main_exhaust_fan_dh()
        {
            InitializeComponent();
        }
        string update, begin_time, end_time;
        private void main_exhaust_fan_dh_Load(object sender, EventArgs e)
        {
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            sclect(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "最新");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sclect(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "最新");
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "SHIFT")
            {
                if (Convert.ToDecimal(e.Value) == 1) e.DisplayText = "夜班";
                if (Convert.ToDecimal(e.Value) == 0) e.DisplayText = "白班";
            }
            else
            {
                if (e.DisplayText == "0")
                {
                    if (Convert.ToDecimal(e.Value) == 0) e.DisplayText = "";
                }

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (path != "")
            {
                gridView1.ExportToXls(path);
            }

        }

        public void sclect(DateTime Begin_time, DateTime End_time, string i)
        {
            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {
                var bb = yh.T_PRODUCE_MAIN_EXHAUST_DH.Where(u => u.RECORD_DATE > Begin_time && u.RECORD_DATE <= End_time);
                gridControl1.DataSource = bb.ToList();
                var sql = bb.ToString();
            }
        }

 
    }
}
