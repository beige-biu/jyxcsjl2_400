using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
namespace jyxcsjl2
{
    public partial class cost_month : UserControl
    {
        DataView dataView;
        Range previousRange;
        public cost_month()
        {
            InitializeComponent();
            //spreadsheetControl1.LoadDocument(cls_public_main.Readrep("烧结成本月报.xlsx"));
        }

        private void spreadsheetControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //spreadsheetControl1.LoadDocument(cls_public_main.Readrep("烧结成本月报.xlsx"));
            IWorkbook workbook = spreadsheetControl1.Document;
            Worksheet sheet = workbook.Worksheets[0];
            workbook.BeginUpdate();
            DataTable bb = new DataTable();
            string sql = " select T_COST_TITLE_CONFIG.MAT_TYPE," +
                         " T_COST_TITLE_CONFIG.COST_TITLE," +
                        " T_COST_TITLE_CONFIG.COST_TITLE_DESC," +
                        " T_COST_TITLE_CONFIG.UNIT," +
                        " T_COST_TITLE_CONFIG.PRICE," +
                        " T_COST_TITLE_CONFIG.C_H2O," +
                       //" T_COST_TITLE_CONFIG.MAT_CODE," +
                       // " T_COST_TITLE_CONFIG.MAT_CODE_DESC," +
                        " T_REPORTM_MONTH_COST.DAY_QNT_WET," +
                        " T_REPORTM_MONTH_COST.DAY_QNT_DRY," +
                        " T_REPORTM_MONTH_COST.DAY_AMOUT_DRY," +
                        " T_REPORTM_MONTH_COST.DAY_UNIT_AMOUNT," +
                        " T_REPORTM_MONTH_COST.DAY_UNIT_PRICE," +
                        " T_REPORTM_MONTH_COST.MONTH_QNT_WET," +
                        " T_REPORTM_MONTH_COST.MONT_QNT_DRY," +
                        " T_REPORTM_MONTH_COST.MONTH_AMOUT_DRY," +
                        " T_REPORTM_MONTH_COST.MONTH_UNIT_AMOUNT," +
                        " T_REPORTM_MONTH_COST.MONTH_UNIT_PRICE," +
                        " T_REPORTM_MONTH_COST.COMPARE_DAY_QNT," +
                        " T_REPORTM_MONTH_COST.COMPARE_DAY_AMOUNT," +
                        " T_REPORTM_MONTH_COST.COMPARE_MONTH_QNT," +
                        " T_REPORTM_MONTH_COST.COMPARE_MONTH_AMOUNT " +
                       // " T_REPORTM_MONTH_COST.CUR_MONTH," +
                       // " T_REPORTM_MONTH_COST.MATERIAL_CODE," +
                      //  " T_REPORTM_MONTH_COST.C_H2O h2o" +
                     " FROM T_COST_TITLE_CONFIG LEFT OUTER JOIN T_REPORTM_MONTH_COST " +
                     "       ON(T_COST_TITLE_CONFIG.COST_TITLE = T_REPORTM_MONTH_COST.COST_TITLE)" +
                " ORDER BY T_COST_TITLE_CONFIG.COST_TITLE asc";
            bb = cls_public_main.ExecuteQuery("", sql);
            dataView = new DataView(bb);
            Table table = sheet.Tables.Add(dataView, 6, 1);
            workbook.EndUpdate();
        }

       
    }
}
