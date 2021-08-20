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
    public partial class team_yield : UserControl
    {
        public team_yield()
        {
            InitializeComponent();
        }
        string begin_time, end_time;

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

        private void team_yield_Load(object sender, EventArgs e)
        {
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            sclect(dateTimePicker1.Value, dateTimePicker2.Value);
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

        public void sclect(DateTime Begin_time, DateTime End_time)
        {
            using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            {
                var bb = yh.T_MATERIAL_TEAM_YIELD.Where(u => u.TEAM_END_TIME > Begin_time && u.TEAM_END_TIME <= End_time);
                gridControl1.DataSource = bb.ToList();
                var sql = bb.ToString();
            }
        }
    }
}
