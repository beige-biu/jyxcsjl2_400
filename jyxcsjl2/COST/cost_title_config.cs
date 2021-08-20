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
    public partial class cost_title_config : UserControl
    {  
        public cost_title_config()
        {
            InitializeComponent();
            cls_public_main.FuncControl(this, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton2 }, new List<DevExpress.XtraGrid.Views.Grid.GridView> { gridView1 }, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton3 }, null, null);
        }
        string update;
        public List<MODEL.T_COST_TITLE_CONFIG> qt = new List<MODEL.T_COST_TITLE_CONFIG>();
        public BindingSource qtSource = new BindingSource(); 

        public void select()
        {
            using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            {

                qt = yh.T_COST_TITLE_CONFIG.ToList();
                qtSource.DataSource = qt;
                gridControl1.DataSource = qtSource;
                //string s = " select * from T_COST_TITLE_CONFIG";
                //DataTable dt = cls_public_main.ExecuteQuery("", s);
                //gridControl1.DataSource = dt;

            }
        }

     

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetFocusedRowCellValue("COST_CENTER", "SML0108");
            gridView1.SetFocusedRowCellValue("COST_CENTER_DESCR", "400烧结");
            gridView1.ShowEditForm();
            update = "insert";
        }
        //添加
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            {
                var row = e.Row;
 
                MODEL.T_COST_TITLE_CONFIG bbb = (MODEL.T_COST_TITLE_CONFIG)row;
                if (update == "insert") { yh.Entry<MODEL.T_COST_TITLE_CONFIG>(bbb).State = EntityState.Added; update = "update"; }
                else { yh.Entry<MODEL.T_COST_TITLE_CONFIG>(bbb).State = EntityState.Modified; }
                yh.Entry<MODEL.T_COST_TITLE_CONFIG>(bbb);
                try
                { yh.SaveChanges(); }
                catch (Exception ExFail)
                { MessageBox.Show(ExFail.Message); }
            }
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();
        }
        //删除
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount <= 0)
            {
                MessageBox.Show("没有选中删除行，请查询要删除的数据删除");
                return;
            }
            if (MessageBox.Show("你确定要删除选中的记录吗？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, 0, false) == DialogResult.Yes)
            {
                using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
                {

                    var row = gridView1.GetFocusedRow();
                    MODEL.T_COST_TITLE_CONFIG bbb = (MODEL.T_COST_TITLE_CONFIG)row;
                    yh.Entry<MODEL.T_COST_TITLE_CONFIG>(bbb).State = EntityState.Deleted;
                    yh.SaveChanges();
                    gridView1.DeleteSelectedRows();

                }
            }
        }
        //查询
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            select();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            select();
            using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            {
                var dl = yh.T_COST_TITLE_CONFIG;
                repositoryItemLookUpEdit1.DataSource = dl.ToList();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //导出
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (path != "")
            {
                gridView1.ExportToXls(path);
            }

        }
    }
}
