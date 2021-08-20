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
    public partial class qualty_query : UserControl
    {
        public qualty_query()
        {
            InitializeComponent();
        }
        public string begin_time, end_time;
        private void qualty_query_Load(object sender, EventArgs e)
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

        private void sclect(DateTime begin_time, DateTime end_time)
        {
            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {
                var cc = yh.T_PRODUCE_SINTER_SCRB2.Where(u => u.RECORD_DATE >= begin_time &&u.RECORD_DATE<=end_time && u.PISHU > 0 && u.TEAM != "累计").OrderBy(x => x.RECORD_ID);
                gridControl2.DataSource = cc.ToList();
                var sql = cc.ToString();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (path != "")
            {
                bandedGridView2.ExportToXls(path);
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

       
    }
}
