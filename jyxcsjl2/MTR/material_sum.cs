using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace jyxcsjl2
{
    public partial class material_sum : UserControl
    {
        public material_sum()
        {
            InitializeComponent();
        }
        string begin_time, end_time;

        private void material_sum_Load(object sender, EventArgs e)
        {
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            sclect(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        public void sclect(DateTime Begin_time, DateTime End_time)
        {

            //string sql = "select RECORD_DATE_DAY as \"记录日期\",BEGIN_TEAM as \"班组\"，BEGIN_SHIFT as \"班次\",BEGIN_TIME as \"交班时间\",END_TIME as \"接班时间\",MAP_MAT_NAME as \"物料名称\" " +
            //             " , BEGIN_WEIGHT as \"接班重量\",END_WEIGHT as \"交班重量\", COUNT_WEIGHT as \"物料消耗\",BEGIN_YIELD as \"接班产量\" " +
            //             ", END_YILD as \"交班产量\",YIELD as \"实际产量\",ROUND (SPECIFIC,3) as \"单耗\" from V_TEAM_MATERIAL_SUM";
            //sql = sql + "  where END_TIME >= '" + Begin_time.ToString("yyyy-MM-dd HH:mm:ss") + "' and RECORD_DATE_DAY <= '" + End_time.ToString("yyyy-MM-dd HH:mm:ss") + "'";
            //sql = sql + "order by RECORD_DATE_DAY,MAP_MAT_NAME,BEGIN_TIME";
            //DataTable dataTable = new DataTable();
            //dataTable = cls_public_main.ExecuteQuery("", sql);
            //gridControl1.DataSource = dataTable;
            //gridView1.Columns[12].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            //gridView1.Columns[12].DisplayFormat.FormatString = "#0.00";
            //gridView1.OptionsView.ColumnAutoWidth = true;
            //gridView1.BestFitColumns();
            using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            {
                var bb = yh.T_MATERIAL_TEAM_CONSUMPTION.Where(u => u.RECORD_DATE > Begin_time && u.RECORD_DATE <= End_time);
                gridControl1.DataSource = bb.ToList();
                var sql = bb.ToString();
            }
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

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "SHIFTS")
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


    }
}
