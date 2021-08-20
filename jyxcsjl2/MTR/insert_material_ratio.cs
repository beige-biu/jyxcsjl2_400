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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
namespace jyxcsjl2
{
    public partial class insert_material_ratio : UserControl
    {
        private MODEL.T_SYS_FUNCTION1 func = new MODEL.T_SYS_FUNCTION1();
        public insert_material_ratio()
        {
            InitializeComponent();
            func = cls_public_main.userFunc.Find(t => t.FUNCTION_FORM == this.GetType().Name);
            if(1 == func.FUNCTION_ADD)
            {
                simpleButton2.Enabled = true;
            }
            else
            {
                simpleButton2.Enabled = false;
            }

            if (1 == func.FUNCTION_UPDATE)
            {
                simpleButton3.Enabled = true;
            }
            else
            {
                simpleButton3.Enabled = true;
            }
        }
        public string begin_time, end_time, sys_time,update ;
        public List<MODEL.T_SINTER_MATERIAL_RATIO> sjk  = new List<MODEL.T_SINTER_MATERIAL_RATIO>();
        public BindingSource sjkSource = new BindingSource();

        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //sclect_hypb(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "");
            sclect_sjpb(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "");
        }

        private void insert_material_ratio_Load(object sender, EventArgs e)
        {
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            sclect_hypb(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "最新");
            sclect_sjpb(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "最新");
         
        }
        public void sclect_sjpb(DateTime Begin_time, DateTime End_time, string i)
        {
            using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            {
                if (i == "最新")
                {
                    string SQL = "select * from T_SINTER_MATERIAL_RATIO where RECORD_DATE = (select max(RECORD_DATE)from T_SINTER_MATERIAL_RATIO)";
                    DataTable dataTable = cls_public_main.ExecuteQuery("", SQL);
                    gridControl2.DataSource = dataTable;
                }
                else if (i == "")
                {
                    sjk.Clear();
                    sjkSource.Clear();
                    sjk = yh.T_SINTER_MATERIAL_RATIO.Where(t => (t.RECORD_DATE > Begin_time && t.RECORD_DATE <= End_time)).ToList();
                    sjkSource.DataSource = sjk;
                    gridControl2.DataSource = sjkSource;
                }
                else if (i != "修改")
                {
                    sjk.Clear();
                    sjkSource.Clear();
                    sjk = yh.T_SINTER_MATERIAL_RATIO.Where(t => (t.PBD_NO == i)).ToList();
                    sjkSource.DataSource = sjk;
                    gridControl2.DataSource = sjkSource;
                }
            }
        }
        public void sclect_hypb(DateTime Begin_time, DateTime End_time, string i)

        {


            //string Sql = " select * from(select it_plan_no as 配比单号, mat_batch_no as 物料代码, (select erp_name " +
            //             " from t_base_material where erp_code = mat_batch_no) as 物料名称, mat_rate as 配比,'S' || unit_no as 工序号," +
            //             " to_date(comm_recv_time, 'yyyy-mm-dd hh24:mi:ss') as 创建时间 from TPSIT14_S6 ) a ";


            //string Sql = " select * from(select it_plan_no as 配比单号, mat_batch_no as 物料代码, (select erp_name " +
            //             " from t_base_material where erp_code = mat_batch_no) as 物料名称, mat_rate as 配比," +
            //             " (select max(rec_revise_time) from XCT1.TPSIT14_S6@TO_XCTQ where IT_plan_no = (select max(it_plan_no) from XCT1.TPSIT14_S6@TO_XCTQ)) as 创建时间 from XCT1.TPSIT14_S6@TO_XCTQ )  a ";

            //210804
            //string Sql = " select * from(select it_plan_no as 配比单号, mat_batch_no as 物料代码, (select erp_name " +
            //             " from t_base_material where erp_code = mat_batch_no) as 物料名称, mat_rate as 配比" +
            //             "  from XCT1.TPSIT14_S6@TO_XCTQ ) a ";

            string Sql = " select * from(select it_plan_no as 配比单号, mat_batch_no as 物料代码, (select erp_name " +
                         " from L2BF_COM.T_BASE_MATERIAL_NEW where erp_code = mat_batch_no) as 物料名称, mat_rate as 配比" +
                         "  from XCT1.TPSIT14_S6@TO_XCTQ ) a ";
            if (i == "最新")
            { Sql = Sql + " where a.\"配比单号\" =(select max(it_plan_no) from XCT1.TPSIT14_S6@TO_XCTQ )"; }
            else
                { Sql = Sql + " where a.\"创建时间\" between to_date('" + Begin_time.ToString() + "','yyyy-mm-dd hh24:mi:ss') and to_date(' " + End_time.ToString() + "','yyyy-mm-dd hh24:mi:ss') "; }
                //{ Sql = Sql + " where a.\"创建时间\" >  "+ Begin_time.ToString().Replace("/","").Replace(" ","").Replace(":","")+ "  and  a.\"创建时间\" < "+  End_time.ToString().Replace("/", "").Replace(" ", "").Replace(":", "") + "" ; }

                DataTable query = cls_public_main.ExecuteQuery(cls_public_main.RZW9DB_CONSTR, Sql);
            gridControl1.DataSource = query;
            //gridView1.Columns[4].DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss" ;
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            if (1 == func.FUNCTION_UPDATE && gridView2.SelectedRowsCount > 0)
            {
                material_ratio_click material_Ratio_Click = new material_ratio_click();
                material_Ratio_Click.Pbd_no = gridView2.GetFocusedRowCellValue("PBD_NO").ToString();
                material_Ratio_Click.begin_time = gridView2.GetFocusedRowCellValue("BEGIN_STORE_DATE").ToString();
                material_Ratio_Click.button3.Enabled = false;
                material_Ratio_Click.ShowDialog();
                if (material_Ratio_Click.updateStatus == "修改")
                {
                    sclect_sjpb(this.dateTimePicker1.Value, this.dateTimePicker2.Value, material_Ratio_Click.Pbd_no);
                }
            }
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (gridView2.SelectedRowsCount > 0)
            {
                material_ratio_click material_Ratio_Click = new material_ratio_click();
                material_Ratio_Click.cz = "开堆";
                material_Ratio_Click.Pbd_no = gridView2.GetFocusedRowCellValue("PBD_NO").ToString();
               // material_Ratio_Click.begin_time = gridView2.GetFocusedRowCellValue("BEGIN_STORE_DATE").ToString();
                material_Ratio_Click.button1.Enabled = false;
                material_Ratio_Click.button2.Enabled = false;
                material_Ratio_Click.ShowDialog();
                if (material_Ratio_Click.cz == "开堆")
                {
                    sclect_sjpb(this.dateTimePicker1.Value, this.dateTimePicker2.Value, material_Ratio_Click.Pbd_no);
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            material_ratio_click material_Ratio_Click = new material_ratio_click();
            material_Ratio_Click.cz = "添加";
            material_Ratio_Click.button3.Enabled = false;
            material_Ratio_Click.ShowDialog();
            if (material_Ratio_Click.updateStatus == "修改")
            {
              sclect_sjpb(this.dateTimePicker1.Value, this.dateTimePicker2.Value, material_Ratio_Click.Pbd_no);
            }
            
        }
        private void gridView2_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
           
          if (e.Info.IsRowIndicator)
          {
            e.Info.DisplayText = e.RowHandle.ToString();
          }
        }
     
        public string string_create()
        {
            sys_time = cls_public_main.sys_time();
            using (var db = new jyxcsjl2.MODEL.T_USER())
            {
                var systime = db.Database.SqlQuery<string>("select F_SJPBDNO from dual").FirstAsync();
                return systime.Result.ToString();
            }
        }

    };

    
        
  
}
