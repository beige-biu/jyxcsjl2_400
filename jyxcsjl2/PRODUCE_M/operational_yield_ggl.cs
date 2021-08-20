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
    public partial class operational_yield_ggl : UserControl
    {
        public operational_yield_ggl()
        {
            InitializeComponent();
            cls_public_main.FuncControl(this, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton2 }, new List<DevExpress.XtraGrid.Views.Grid.GridView> { gridView1 }, null, null, null);
        }
        string update, begin_time, end_time, begin_r, begin_t, begin_r1, begin_r2, begin_up;
    

        public List<MODEL.T_MATERIAL_TEAM_YIELDGGL> datelist = new List<MODEL.T_MATERIAL_TEAM_YIELDGGL>();
        public BindingSource DateSource = new BindingSource();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            select(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "查询");
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

            begin_r2 = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("TEAM_BEGIN_TIME").ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                
        }

        private void operational_yield_ggl_Load(object sender, EventArgs e)
        {
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            select(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "最新");
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

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {
                var row = e.Row;
               
                MODEL.T_MATERIAL_TEAM_YIELDGGL bbb = (MODEL.T_MATERIAL_TEAM_YIELDGGL)row;
             
                if (update == "insert")
                { yh.Entry<MODEL.T_MATERIAL_TEAM_YIELDGGL>(bbb).State = EntityState.Added; }
                else
                { yh.Entry<MODEL.T_MATERIAL_TEAM_YIELDGGL>(bbb).State = EntityState.Modified; }
                   yh.Entry<MODEL.T_MATERIAL_TEAM_YIELDGGL>(bbb);



                if (update == "insert")

                {
                    string begin_r1 = bbb.TEAM_BEGIN_TIME.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    string Sql = " Call PROC_MATERIAL_TEAM_YIELDGGL('" + begin_r1 + "','" + begin_r1 + "',1)";
                    int dt = cls_public_main.ExcuteSQL(cls_public_main.RZW9DB_CONSTR, Sql);
                    update = "update";

                    try
                    { yh.SaveChanges(); }
                    catch (Exception ExFail)
                    { MessageBox.Show(ExFail.Message); }
                }
                else
                {
                    try
                    { yh.SaveChanges(); }
                    catch (Exception ExFail)
                    { MessageBox.Show(ExFail.Message); }

                    string begin_up = bbb.TEAM_BEGIN_TIME.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    string Sql = " Call PROC_MATERIAL_TEAM_YIELDGGL('" + begin_r2 + "','" + begin_up + "',2) ";
                    int dt = cls_public_main.ExcuteSQL(cls_public_main.RZW9DB_CONSTR, Sql);

                }


            }
        
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();
            select(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "查询");
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //string begin_r = Convert.ToDateTime(cls_public_main.sys_time()).ToString("yyyy-MM-dd HH:mm:ss");
            string begin_r = Convert.ToDateTime(cls_public_main.sys_time()).ToString("yyyy-MM-dd HH:mm:ss").Substring(0, 16) + ":00";
            gridView1.SetFocusedRowCellValue("RECORD_DATE", begin_r);
            gridView1.SetFocusedRowCellValue("TEAM", cls_public_main.m_team);
            gridView1.SetFocusedRowCellValue("TEAM_BEGIN_TIME", begin_r);
            gridView1.SetFocusedRowCellValue("RECORD_NAME", cls_public_main.m_emp_name);
            gridView1.ShowEditForm();           
            update = "insert";

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }
        public void select(DateTime Begin_time, DateTime End_time, String i)
        {
            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {


                if (i == "最新")
                {
                    datelist = yh.T_MATERIAL_TEAM_YIELDGGL.Where(t => t.RECORD_DATE == yh.T_MATERIAL_TEAM_YIELDGGL.Max(s => s.RECORD_DATE)).ToList();
                    DateSource.DataSource = datelist;
                    gridControl1.DataSource = DateSource;
                }
                else
                {
                    datelist.Clear();
                    DateSource.Clear();
                    datelist = yh.T_MATERIAL_TEAM_YIELDGGL.Where(t => (t.RECORD_DATE >= Begin_time && t.RECORD_DATE < End_time)).ToList();
                    DateSource.DataSource = datelist;
                    gridControl1.DataSource = DateSource;
                }
            }
        }
    }
}
