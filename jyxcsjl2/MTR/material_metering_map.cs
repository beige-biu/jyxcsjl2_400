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
using DevExpress.XtraEditors;
namespace jyxcsjl2
{
    public partial class material_metering_map : UserControl
    {
        string update, begin_time, end_time;
        string end = "",begin = "";
        string mat_code, mat_name;
        public List<MODEL.T_MATERIAL_METERING_MAP> map = new List<MODEL.T_MATERIAL_METERING_MAP>();
        public BindingSource mapSource = new BindingSource();
        public material_metering_map()
        {
            InitializeComponent();
            cls_public_main.FuncControl(this, null, new List<DevExpress.XtraGrid.Views.Grid.GridView> { gridView1, gridView2 }, new List<SimpleButton> { simpleButton3 }, null, null);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            sclect1(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "最新");
        }

        private void material_metering_map_Load(object sender, EventArgs e)
        {
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            sclect1(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "最新");
            sclect2(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "最新");
            combox();
        }

        public void sclect1(DateTime Begin_time, DateTime End_time, string i)
        {
            using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            {
                var qq = yh.T_MATERIAL_METERING_MAP.Where(t => (t.MAP_STAT == "使用" )).ToList();
                gridControl1.DataSource = qq;
            }
        }
        public void sclect2(DateTime Begin_time, DateTime End_time, string i)
        {
            using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            {
                map.Clear();
                mapSource.Clear();
                map = yh.T_MATERIAL_METERING_MAP.Where(t => (t.MAP_END_TIME > Begin_time && t.MAP_END_TIME <= End_time)).ToList();
                mapSource.DataSource = map;
                gridControl2.DataSource = mapSource;
            }
        }

        private void repositoryItemLookUpEdit1_Modified(object sender, EventArgs e)
        {
            //LookUpEdit lookUpEdit = sender as LookUpEdit;
            //string code = lookUpEdit.GetColumnValue("FAC_CODE").ToString();
            //string name = lookUpEdit.GetColumnValue("FAC_NAME").ToString();
            //gridView2.SetFocusedRowCellValue("MAP_MAT_CODE", code);
            //gridView2.SetFocusedRowCellValue("MAP_MAT_NAME", name);
            LookUpEdit lookUpEdit = sender as LookUpEdit;
            string code = lookUpEdit.GetColumnValue("ERP_CODE").ToString();
            string name = lookUpEdit.GetColumnValue("ERP_NAME").ToString();
            gridView2.SetFocusedRowCellValue("MAP_MAT_CODE", code);
            gridView2.SetFocusedRowCellValue("MAP_MAT_NAME", name);
        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
           // if (update == "insert") { return; }
            using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            {
                var row = e.Row;
                end = cls_public_main.sys_time();
                MODEL.T_MATERIAL_METERING_MAP bbb = (MODEL.T_MATERIAL_METERING_MAP)row;
                bbb.CREATER = cls_public_main.m_emp_name;
                bbb.CREATE_DATE = Convert.ToDateTime(end);
                if (update == "insert")
                {
                    yh.Entry<MODEL.T_MATERIAL_METERING_MAP>(bbb).State = EntityState.Added;
                    update = "update"; 
                }

                else
                {
                    yh.Entry<MODEL.T_MATERIAL_METERING_MAP>(bbb).State = EntityState.Modified;
                }

                try
                { yh.SaveChanges(); }
                catch (Exception ExFail)
                { MessageBox.Show(ExFail.Message); }
                gridView2.CloseEditor();
                gridView2.UpdateCurrentRow();
               
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (gridView2.SelectedRowsCount <= 0)
            {
                MessageBox.Show("没有选中删除行，请查询要删除的数据删除");
                return;
            }
            if (MessageBox.Show("你确定要删除选中的记录吗？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, 0, false) == DialogResult.Yes)
            {
                using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
                {
                    var row = gridView2.GetFocusedRow();
                    MODEL.T_MATERIAL_METERING_MAP bbb = (MODEL.T_MATERIAL_METERING_MAP)row;
                    yh.Entry<MODEL.T_MATERIAL_METERING_MAP>(bbb).State = EntityState.Deleted;
                    try
                    { yh.SaveChanges(); }
                    catch (Exception ExFail)
                    { MessageBox.Show(ExFail.Message); }
                    gridView2.DeleteSelectedRows();

                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sclect2(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "最新");
        }

        private void gridView1_EditFormShowing(object sender, DevExpress.XtraGrid.Views.Grid.EditFormShowingEventArgs e)
        {
            mat_code = gridView1.GetFocusedRowCellValue("MAP_MAT_CODE").ToString();
            mat_name = gridView1.GetFocusedRowCellValue("MAP_MAT_NAME").ToString();
        }

        private void repositoryItemLookUpEdit2_Modified(object sender, EventArgs e)
        {
            //LookUpEdit lookUpEdit = sender as LookUpEdit;
            //string code = lookUpEdit.GetColumnValue("FAC_CODE").ToString();
            //string name = lookUpEdit.GetColumnValue("FAC_NAME").ToString();
            //gridView1.SetFocusedRowCellValue("MAP_MAT_CODE", code);
            //gridView1.SetFocusedRowCellValue("MAP_MAT_NAME", name);
            LookUpEdit lookUpEdit = sender as LookUpEdit;
            string code = lookUpEdit.GetColumnValue("ERP_CODE").ToString();
            string name = lookUpEdit.GetColumnValue("ERP_NAME").ToString();
            gridView1.SetFocusedRowCellValue("MAP_MAT_CODE", code);
            gridView1.SetFocusedRowCellValue("MAP_MAT_NAME", name);

        }

        public void combox()
        {
            using (jyxcsjl2.MODEL.L2BF_COM yh = new jyxcsjl2.MODEL.L2BF_COM())
            {
                //var dl = yh.T_BASE_MATERIAL.Where(u => u.ISST == "Y" && u.ISUSE != "1");
                //repositoryItemLookUpEdit2.DataSource = dl.ToList();
                //repositoryItemLookUpEdit2.ValueMember = "FAC_NAME";
                //repositoryItemLookUpEdit2.DisplayMember = "FAC_NAME";
                var dl = yh.T_BASE_MATERIAL_NEW.Where(u => u.ISST == "Y" && u.ISUSE != "1");
                repositoryItemLookUpEdit2.DataSource = dl.ToList();
                repositoryItemLookUpEdit2.ValueMember = "ERP_CODE";
                repositoryItemLookUpEdit2.DisplayMember = "ERP_CODE";

            }
            using (jyxcsjl2.MODEL.L2BF_COM yh = new jyxcsjl2.MODEL.L2BF_COM())
            {
                //var dl = yh.T_BASE_MATERIAL.Where(u => u.ISST == "Y" && u.ISUSE != "1");
                //repositoryItemLookUpEdit1.DataSource = dl.ToList();
                //repositoryItemLookUpEdit1.ValueMember = "FAC_NAME";
                //repositoryItemLookUpEdit1.DisplayMember = "FAC_NAME";
                var dl = yh.T_BASE_MATERIAL_NEW.Where(u => u.ISST == "Y" && u.ISUSE != "1");
                repositoryItemLookUpEdit2.DataSource = dl.ToList();
                repositoryItemLookUpEdit2.ValueMember = "ERP_NAME";
                repositoryItemLookUpEdit2.DisplayMember = "ERP_NAME";
            }
        }

        private void gridView2_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            
            gridView2.SetFocusedRowCellValue("DEVICE_NO", gridView1.GetFocusedRowCellValue("DEVICE_NO"));
            gridView2.SetFocusedRowCellValue("DEVICE_NAME", gridView1.GetFocusedRowCellValue("DEVICE_NAME"));
            gridView2.SetFocusedRowCellValue("DEVICE_DESCR", gridView1.GetFocusedRowCellValue("DEVICE_DESCR"));
            gridView2.SetFocusedRowCellValue("MAP_MAT_CODE", mat_code);
            gridView2.SetFocusedRowCellValue("MAP_MAT_NAME", mat_name);
            gridView2.SetFocusedRowCellValue("MAP_BEGIN_TIME", begin);
            gridView2.SetFocusedRowCellValue("MAP_END_TIME",end);
            gridView2.SetFocusedRowCellValue("CREATE_DATE", end);
            gridView2.SetFocusedRowCellValue("CREATER", cls_public_main.m_emp_name);
            gridView2.SetFocusedRowCellValue("MAP_STAT", "历史");
            //using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            //{
            //    MODEL.T_MATERIAL_METERING_MAP bbb = (MODEL.T_MATERIAL_METERING_MAP)gridView2.GetFocusedRow();
            //    bbb.DEVICE_NO = gridView1.GetFocusedRowCellValue("DEVICE_NO").ToString();
            //    bbb.DEVICE_NAME = gridView1.GetFocusedRowCellValue("DEVICE_NAME").ToString();
            //    bbb.DEVICE_DESCR = gridView1.GetFocusedRowCellValue("DEVICE_DESCR").ToString();
            //    bbb.MAP_MAT_CODE = gridView1.GetFocusedRowCellValue("MAP_MAT_CODE").ToString();
            //    bbb.MAP_MAT_NAME = gridView1.GetFocusedRowCellValue("MAP_MAT_NAME").ToString();
            //    bbb.MAP_BEGIN_TIME = Convert.ToDateTime(begin);
            //    bbb.MAP_END_TIME = Convert.ToDateTime(end);
            //    bbb.CREATE_DATE = Convert.ToDateTime(end);
            //    bbb.CREATER = cls_public_main.m_emp_name;
            //    bbb.MAP_STAT = "历史";
            //    yh.Entry<MODEL.T_MATERIAL_METERING_MAP>(bbb).State = EntityState.Added;
            //    yh.SaveChanges();
            //}
            end = ""; begin="";
            update = "insert";
        }

    
    }
}
