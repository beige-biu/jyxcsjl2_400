using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace jyxcsjl2
{
    public partial class material_ratio_click : Form
    {
        public string begin_time, end_time, sys_time, update,Pbd_no,mat_code,cz;
        public List<MODEL.T_SINTER_MATERIAL_RATIO> pb = new List<MODEL.T_SINTER_MATERIAL_RATIO>();
        public BindingSource pbSource = new BindingSource();
      // jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM();
        public string updateStatus;
        public material_ratio_click()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.cz = "添加";
            gridView2.AddNewRow();

        }
        public void add_pbd(string pbd_no)
        {
            
            
        }
        private void button2_Click(object sender, EventArgs e)
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
                    MODEL.T_SINTER_MATERIAL_RATIO bbb = (MODEL.T_SINTER_MATERIAL_RATIO)row;
                    yh.Entry<MODEL.T_SINTER_MATERIAL_RATIO>(bbb).State = EntityState.Deleted;
                    try
                    {
                        yh.SaveChanges();

                        //jyxcsjl2.MODEL.T_BKYL bk = new jyxcsjl2.MODEL.T_BKYL();
                        //bk.Entry<MODEL.T_SINTER_MATERIAL_RATIO>(bbb).State = EntityState.Deleted;
                        //bk.SaveChanges();

                        updateStatus = "修改";
                    }
                    catch (Exception ExFail)
                    { MessageBox.Show(ExFail.Message); }
                    gridView2.DeleteSelectedRows();
                }
            }
        }
        private void repositoryItemLookUpEdit1_Modified(object sender, EventArgs e)
        {
            //LookUpEdit lookUpEdit = sender as LookUpEdit;
            //string code = lookUpEdit.GetColumnValue("FAC_CODE").ToString();
            //string name = lookUpEdit.GetColumnValue("FAC_NAME").ToString();
            //gridView2.SetFocusedRowCellValue("MATERIAL_CODE", code);
            //gridView2.SetFocusedRowCellValue("MATERIAL_NAME", name);
            LookUpEdit lookUpEdit = sender as LookUpEdit;
            string code = lookUpEdit.GetColumnValue("ERP_CODE").ToString();
            string name = lookUpEdit.GetColumnValue("ERP_NAME").ToString();
            gridView2.SetFocusedRowCellValue("MATERIAL_CODE", code);
            gridView2.SetFocusedRowCellValue("MATERIAL_NAME", name);
        }

        private void gridControl2_Load(object sender, EventArgs e)
        {
            combox();
            using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            {
                if (cz == "添加")
                {
                    Pbd_no = string_create();
                    begin_time = cls_public_main.sys_time();
                    pb = yh.T_SINTER_MATERIAL_RATIO.Where(t => t.PBD_NO == Pbd_no).ToList();
                    pbSource.DataSource = pb;
                    gridControl2.DataSource = pbSource;
                    gridView2.AddNewRow();
                }
                else
                {
                    pb = yh.T_SINTER_MATERIAL_RATIO.Where(t => t.PBD_NO == Pbd_no).ToList();
                    pbSource.DataSource = pb;
                  gridControl2.DataSource = pbSource;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
               
        }

        private void material_ratio_click_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (updateStatus == "修改")
            {
                this.Close();
            }
            else
            {
                updateStatus = "取消";
                this.Close();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string begin = cls_public_main.sys_time();
            using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            {
                for (int i = 0; i < gridView2.DataRowCount; i++)
                {                 
                 gridView2.SetRowCellValue(i, "BEGIN_STORE_DATE", begin);
                 gridView2.SetRowCellValue(i, "RECORD_PERSON", cls_public_main.m_emp_name);
                    MODEL.T_SINTER_MATERIAL_RATIO Newrow = new MODEL.T_SINTER_MATERIAL_RATIO();
                    Newrow.MATERIAL_CODE = gridView2.GetRowCellValue(i, "MATERIAL_CODE").ToString();
                    Newrow.MATERIAL_NAME = gridView2.GetRowCellValue(i, "MATERIAL_NAME").ToString();
                    Newrow.MATERIAL_PERCENTAGE = Convert.ToDecimal( gridView2.GetRowCellValue(i, "MATERIAL_PERCENTAGE").ToString());
                    Newrow.BEGIN_STORE_DATE = Convert.ToDateTime( gridView2.GetRowCellValue(i, "BEGIN_STORE_DATE").ToString());
                    Newrow.RECORD_DATE = Convert.ToDateTime(gridView2.GetRowCellValue(i, "RECORD_DATE").ToString());
                    Newrow.RECORD_PERSON  = gridView2.GetRowCellValue(i, "RECORD_PERSON").ToString();
                    Newrow.PBD_NO = gridView2.GetRowCellValue(i, "PBD_NO").ToString();
                    try
                    {
                        Newrow.RECORD_PERSON = gridView2.GetRowCellValue(i, "RECORD_PERSON").ToString();
                        yh.Entry<MODEL.T_SINTER_MATERIAL_RATIO>(Newrow).State = EntityState.Modified;
                        yh.SaveChanges();

                        
                        //jyxcsjl2.MODEL.T_BKYL bk = new jyxcsjl2.MODEL.T_BKYL();
                        //int count = bk.T_SINTER_MATERIAL_RATIO.Where(t => t.PBD_NO == Newrow.PBD_NO && t.MATERIAL_CODE== Newrow.MATERIAL_CODE).ToList().Count();
                        //if(count > 0)
                        //{
                        //    bk.Entry<MODEL.T_SINTER_MATERIAL_RATIO>(Newrow).State = EntityState.Modified;
                        //    bk.SaveChanges();
                        //}
                        //else
                        //{
                        //    bk.Entry<MODEL.T_SINTER_MATERIAL_RATIO>(Newrow).State = EntityState.Added;
                        //    bk.SaveChanges();
                        //}
                       
                        // this.Close();
                    }
                    catch (Exception ExFail)
                    { MessageBox.Show(ExFail.Message); }

                }
              
             //   yh.SaveChanges();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void gridView2_EditFormShowing(object sender, EditFormShowingEventArgs e)
        {
            if ((cz != "添加") )
            {
                mat_code = gridView2.GetFocusedRowCellValue("MATERIAL_CODE").ToString();
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

        private void gridView2_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            string begin = cls_public_main.sys_time();
            update = "insert";
            gridView2.SetFocusedRowCellValue("PBD_NO", Pbd_no);
            gridView2.SetFocusedRowCellValue("BEGIN_STORE_DATE", begin_time);
            gridView2.SetFocusedRowCellValue("RECORD_PERSON", cls_public_main.m_emp_name);
            gridView2.ShowEditForm();
          
        }

        public void combox()
        {
            //210804
            //using (jyxcsjl2.MODEL.T_PROM com = new jyxcsjl2.MODEL.T_PROM())
            //{
            //    var dl = com.T_BASE_MATERIAL.Where(u => u.ISST == "Y" && u.ISUSE != "1");
            //    repositoryItemLookUpEdit1.DataSource = dl.ToList();
            //    repositoryItemLookUpEdit1.ValueMember = "FAC_NAME";
            //    repositoryItemLookUpEdit1.DisplayMember = "FAC_NAME";
            //    //repositoryItemLookUpEdit1. = 0;
            //}
            using (jyxcsjl2.MODEL.L2BF_COM com = new jyxcsjl2.MODEL.L2BF_COM())
            {
                var dl = com.T_BASE_MATERIAL_NEW.Where(u => u.ISST == "Y" && u.ISUSE != "1");
                repositoryItemLookUpEdit1.DataSource = dl.ToList();
                repositoryItemLookUpEdit1.ValueMember = "ERP_NAME";
                repositoryItemLookUpEdit1.DisplayMember = "ERP_NAME";
                //repositoryItemLookUpEdit1. = 0;
            }
        }
        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
                {
                    var newrow = e.Row;
                    var oldrow = e.Row;
                    DateTime end = Convert.ToDateTime(cls_public_main.sys_time());
                    MODEL.T_SINTER_MATERIAL_RATIO Newrow = (MODEL.T_SINTER_MATERIAL_RATIO)newrow;
                    MODEL.T_SINTER_MATERIAL_RATIO Oldrow = (MODEL.T_SINTER_MATERIAL_RATIO)oldrow;
                    
                    if (update == "insert")
                    {
                        Newrow.RECORD_DATE = end;
                        yh.Entry<MODEL.T_SINTER_MATERIAL_RATIO>(Newrow).State = EntityState.Added; update = "update";
                        yh.SaveChanges();

                        //jyxcsjl2.MODEL.T_BKYL bk = new jyxcsjl2.MODEL.T_BKYL();
                        //bk.Entry<MODEL.T_SINTER_MATERIAL_RATIO>(Newrow).State = EntityState.Added; update = "update";
                        //bk.SaveChanges();
                        updateStatus = "修改";
                        cz = "";
                    }
                    else
                    {
                        if (cz == "开堆")
                        {

                        }
                        else
                        {
                            Oldrow.MATERIAL_CODE = mat_code;
                            yh.Entry<MODEL.T_SINTER_MATERIAL_RATIO>(Oldrow).State = EntityState.Deleted;
                            yh.SaveChanges();
                            yh.Entry<MODEL.T_SINTER_MATERIAL_RATIO>(Newrow).State = EntityState.Added;
                            yh.SaveChanges();

                            //jyxcsjl2.MODEL.T_BKYL bk = new jyxcsjl2.MODEL.T_BKYL();
                            //bk.Entry<MODEL.T_SINTER_MATERIAL_RATIO>(Oldrow).State = EntityState.Deleted;
                            //bk.SaveChanges();
                            //bk.Entry<MODEL.T_SINTER_MATERIAL_RATIO>(Newrow).State = EntityState.Added;
                            //bk.SaveChanges();
                            updateStatus = "修改";
                        }
                    }
             }
             gridView2.CloseEditor();
             gridView2.UpdateCurrentRow();
            }
            catch (Exception ExFail)
            { MessageBox.Show(ExFail.Message); }
            
        }
       

    }
}
