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
    public partial class mix_phy_inset : UserControl
    {  
        public mix_phy_inset()
        {
            InitializeComponent();
            cls_public_main.FuncControl(this, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton2 }, new List<DevExpress.XtraGrid.Views.Grid.GridView> { gridView1 }, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton3 }, null, null);
        }
        string update, begin_time, end_time;
        public List<MODEL.T_QUALITY_MIX_PHY_INSET> qt = new List<MODEL.T_QUALITY_MIX_PHY_INSET>();
        public BindingSource qtSource = new BindingSource(); 

        public void sclect(DateTime Begin_time, DateTime End_time,string i)
        {
            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {
                if (i == "最新")
                {
                    qt = yh.T_QUALITY_MIX_PHY_INSET.Where(t => t.RECORD_DATE == yh.T_QUALITY_MIX_PHY_INSET.Max(s => s.RECORD_DATE)).ToList();
                    qtSource.DataSource = qt ;
                    gridControl1.DataSource = qtSource;
                    // yh.T_BASE_MATERIAL.Distinct
                }
                else
                {
                    qt.Clear();
                    qtSource.Clear();
                    qt = yh.T_QUALITY_MIX_PHY_INSET.Where(t => (t.RECORD_DATE > Begin_time && t.RECORD_DATE <= End_time)).ToList();
                    qtSource.DataSource = qt;
                    gridControl1.DataSource = qtSource;
                }
            }
        }

     

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
  
            string begin = cls_public_main.sys_time();
            gridView1.SetFocusedRowCellValue("RECORD_DATE",Convert.ToDateTime(begin));
            gridView1.SetFocusedRowCellValue("WP_NO", "S6");
            gridView1.SetFocusedRowCellValue("SHIFT", cls_public_main.m_team);
            gridView1.SetFocusedRowCellValue("RECORD_PERSON", cls_public_main.m_emp_name);
            gridView1.ShowEditForm();
            update = "insert";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {
            //    using (jyxcsjl2.MODEL.T_BKYL bk = new jyxcsjl2.MODEL.T_BKYL())
            //    {
                    var row = e.Row;
                    //DateTime end = Convert.ToDateTime(cls_public_main.sys_time());
                    MODEL.T_QUALITY_MIX_PHY_INSET bbb = (MODEL.T_QUALITY_MIX_PHY_INSET)row;
                    if (update == "insert")
                    {
                        yh.Entry<MODEL.T_QUALITY_MIX_PHY_INSET>(bbb).State = EntityState.Added;
                   //     bk.Entry<MODEL.T_QUALITY_MIX_PHY_INSET>(bbb).State = EntityState.Added;
                        update = "update";
                    }
                    else
                    {
                         yh.Entry<MODEL.T_QUALITY_MIX_PHY_INSET>(bbb).State = EntityState.Modified;
                     //    bk.Entry<MODEL.T_QUALITY_MIX_PHY_INSET>(bbb).State = EntityState.Modified;
                    }
                      yh.Entry<MODEL.T_QUALITY_MIX_PHY_INSET>(bbb);
                   //   bk.Entry<MODEL.T_QUALITY_MIX_PHY_INSET>(bbb);
                    try
                    {
                      yh.SaveChanges();
                  //    bk.SaveChanges();
                    }
                    catch (Exception ExFail)
                    { MessageBox.Show(ExFail.Message); }
            //    }
            }
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount <= 0)
            {
                MessageBox.Show("没有选中删除行，请查询要删除的数据删除");
                return;
            }
            if (MessageBox.Show("你确定要删除选中的记录吗？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, 0, false) == DialogResult.Yes)
            {
                using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
                {
                //    using (jyxcsjl2.MODEL.T_BKYL bk = new jyxcsjl2.MODEL.T_BKYL())
                //    {
                        var row = gridView1.GetFocusedRow();
                        MODEL.T_QUALITY_MIX_PHY_INSET bbb = (MODEL.T_QUALITY_MIX_PHY_INSET)row;
                        yh.Entry<MODEL.T_QUALITY_MIX_PHY_INSET>(bbb).State = EntityState.Deleted;
                    //    bk.Entry<MODEL.T_QUALITY_MIX_PHY_INSET>(bbb).State = EntityState.Deleted;
                     //   bk.T_QUALITY_MIX_PHY_INSET = yh.T_QUALITY_MIX_PHY_INSET;
                        try
                        {
                            yh.SaveChanges();
                     //       bk.SaveChanges();
                        }
                        catch (Exception ExFail)
                        {
                            MessageBox.Show(ExFail.Message); 
                        }
                        gridView1.DeleteSelectedRows();
                 //   }
                }
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           if  (e.Column.FieldName == "GRAIN_COMP_3")
           {
                Double BB = Convert.ToDouble( gridView1.GetFocusedRowCellValue("GRAIN_COMP_3").ToString());
                gridView1.SetFocusedRowCellValue("GRAIN_3", (100 - BB));
           }
            if (e.Column.FieldName == "GRAIN_COMP_31")
            {
                Double BB = Convert.ToDouble(gridView1.GetFocusedRowCellValue("GRAIN_COMP_3").ToString());
                Double CC = Convert.ToDouble(gridView1.GetFocusedRowCellValue("GRAIN_COMP_31").ToString());
                gridView1.SetFocusedRowCellValue("GRAIN_COMP_1", (100 - BB -CC));
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sclect(this.dateTimePicker1.Value, this.dateTimePicker2.Value,"");
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            sclect(this.dateTimePicker1.Value, this.dateTimePicker2.Value,"最新");
            //210804
            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {
                var dl = yh.T_BASE_MATERIAL.Where(u => u.ISST == "Y" && u.ISUSE != "1");
                repositoryItemLookUpEdit1.DataSource = dl.ToList();
                repositoryItemLookUpEdit1.ValueMember = "FAC_NAME";
                repositoryItemLookUpEdit1.DisplayMember = "FAC_NAME";
                //repositoryItemLookUpEdit1. = 0;
            }
            //using (jyxcsjl2.MODEL.L2BF_COM yh = new jyxcsjl2.MODEL.L2BF_COM())
            //{
            //    var dl = yh.T_BASE_MATERIAL_NEW.Where(u => u.ISST == "Y" && u.ISUSE != "1");
            //    repositoryItemLookUpEdit1.DataSource = dl.ToList();
            //    repositoryItemLookUpEdit1.ValueMember = "ERP_NAME";
            //    repositoryItemLookUpEdit1.DisplayMember = "ERP_NAME";
            //    //repositoryItemLookUpEdit1. = 0;
            //}
        }
    }
}
