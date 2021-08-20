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
    public partial class material_code_add : UserControl
    {
        public material_code_add()
        {
            InitializeComponent();
            cls_public_main.FuncControl(this, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton3 }, new List<DevExpress.XtraGrid.Views.Grid.GridView> { gridView1, gridView2 }, null, null, null);
        }
        string update;

        public string text1, text2;
        //210803
        //public List<MODEL.T_BASE_MATERIAL> datelist = new List<MODEL.T_BASE_MATERIAL>();
        public List<MODEL.T_BASE_MATERIAL_NEW> datelist = new List<MODEL.T_BASE_MATERIAL_NEW>();
        public BindingSource DateSource = new BindingSource();
        private void material_code_add_Load(object sender, EventArgs e)
        {
            select();
            select1("load");
            combox();


        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //210803
            //using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            //{
            //    var row = e.Row;
            //    DateTime end = Convert.ToDateTime(cls_public_main.sys_time());
            //    MODEL.T_BASE_MATERIAL bbb = (MODEL.T_BASE_MATERIAL)row;
            //    //bbb.RECORD_DATE = end;
            //    if (update == "insert") { yh.Entry<MODEL.T_BASE_MATERIAL>(bbb).State = EntityState.Added; update = "update"; }
            //    else { yh.Entry<MODEL.T_BASE_MATERIAL>(bbb).State = EntityState.Modified; }
            //    yh.Entry<MODEL.T_BASE_MATERIAL>(bbb);
            //    try
            //    { yh.SaveChanges(); }
            //    catch (Exception ExFail)
            //    { MessageBox.Show(ExFail.Message); }
            //}

            using (jyxcsjl2.MODEL.L2BF_COM yh = new jyxcsjl2.MODEL.L2BF_COM())
            {
                var row = e.Row;
                DateTime end = Convert.ToDateTime(cls_public_main.sys_time());
                MODEL.T_BASE_MATERIAL_NEW bbb = (MODEL.T_BASE_MATERIAL_NEW)row;
                //bbb.RECORD_DATE = end;
                if (update == "insert") { yh.Entry<MODEL.T_BASE_MATERIAL_NEW>(bbb).State = EntityState.Added; update = "update"; }
                else { yh.Entry<MODEL.T_BASE_MATERIAL_NEW>(bbb).State = EntityState.Modified; }
                yh.Entry<MODEL.T_BASE_MATERIAL_NEW>(bbb);
                try
                { yh.SaveChanges(); }
                catch (Exception ExFail)
                { MessageBox.Show(ExFail.Message); }
            }
            gridView2.CloseEditor();
            gridView2.UpdateCurrentRow();
        }

        private void combox()
        {
            //210803
            //string sql = "SELECT e.MAT_PROD_CODE 物料代码,e.MAT_PROD_CNAME 物料名称  FROM (   SELECT d.MAT_PROD_CODE ,d.MAT_PROD_CNAME,d.MAT_PROD_ENAME ,d.MAT_PROD_CODE_RELATE,d.MAT_PROD_CODE_RELATE_2,d.MAT_PROD_CODE_RELATE_3 FROM TYMIR21_IOOP @TO_XCT1OPEN d  WHERE d.MAT_PROD_CODE IN( SELECT a.MAT_PROD_CODE FROM TYMIR21_IOOP @TO_XCT1OPEN a WHERE a.MAT_PROD_CODE NOT IN (SELECT p.ERP_CODE FROM T_BASE_MATERIAL p))) e where  e.MAT_PROD_CODE like'D0604%' OR e.MAT_PROD_CODE like'D0601%' or e.MAT_PROD_CODE like'D0501007%'or e.MAT_PROD_CODE like'D0501008%'or e.MAT_PROD_CODE like'D050101%' ORDER BY  e.MAT_PROD_CODE ASC  ";
            string sql =  " SELECT ERP_CODE 物料代码,ERP_NAME 物料名称  FROM L2BF_COM.T_BASE_MATERIAL_NEW WHERE ISST = 'Y' AND ISUSE = '0' ";
            DataTable dataTable = cls_public_main.ExecuteQuery("", sql);
            DataRow dataRow = dataTable.NewRow();
            dataRow[0] = "显示全部";
            dataRow[1] = "显示全部";
            dataTable.Rows.InsertAt(dataRow, 0);
            lookUpEdit1.Properties.DataSource = dataTable;
            lookUpEdit1.Properties.ValueMember = "物料代码";
            lookUpEdit1.Properties.DisplayMember = "物料名称";
            //lookUpEdit1.EditValue = "C60101100100002A";
            //this.lookUpEdit1.Properties.ShowAutoFilterRow = true;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

            //text1 = textEdit1.Text.ToUpper;
            text2 = this.lookUpEdit1.EditValue.ToString() ;
            text1 = this.lookUpEdit1.Text.Trim();


           if ( text2 == "显示全部")
            {
                //210803
                //string sql = "SELECT e.MAT_PROD_CODE as 集团物料代码 ,e.MAT_PROD_CNAME as 集团物料名称,e.MAT_PROD_ENAME as 粒度区间,e.MAT_PROD_CODE_RELATE as 品名分类,e.MAT_PROD_CODE_RELATE_2  as 品名分类2 ,e.MAT_PROD_CODE_RELATE_3 as 品名分类3  FROM (   SELECT d.MAT_PROD_CODE ,d.MAT_PROD_CNAME,d.MAT_PROD_ENAME ,d.MAT_PROD_CODE_RELATE,d.MAT_PROD_CODE_RELATE_2,d.MAT_PROD_CODE_RELATE_3 FROM TYMIR21_IOOP @TO_XCT1OPEN d  WHERE d.MAT_PROD_CODE IN( SELECT a.MAT_PROD_CODE FROM TYMIR21_IOOP @TO_XCT1OPEN a WHERE a.MAT_PROD_CODE NOT IN (SELECT p.ERP_CODE FROM T_BASE_MATERIAL p))) e where  e.MAT_PROD_CODE like'D0604%' OR e.MAT_PROD_CODE like'D0601%' or e.MAT_PROD_CODE like'D0501007%'or e.MAT_PROD_CODE like'D0501008%'or e.MAT_PROD_CODE like'D050101%' ORDER BY  e.MAT_PROD_CODE ASC  ";
                string sql = " SELECT ERP_CODE 物料代码,ERP_NAME 物料名称  FROM L2BF_COM.T_BASE_MATERIAL_NEW WHERE ISST = 'Y' AND ISUSE = '0' ";
                DataTable dataTable = cls_public_main.ExecuteQuery("", sql);
                gridControl1.DataSource = dataTable;
            }
            else
            {
                //210803
                //string sql3 = "SELECT e.MAT_PROD_CODE as 集团物料代码,e.MAT_PROD_CNAME as 集团物料名称,e.MAT_PROD_ENAME as 粒度区间,e.MAT_PROD_CODE_RELATE as 品名分类,e.MAT_PROD_CODE_RELATE_2  as 品名分类2 ,e.MAT_PROD_CODE_RELATE_3 as 品名分类3  FROM TYMIR21_IOOP @TO_XCT1OPEN e WHERE MAT_PROD_CODE ='" + text2+"'";
                string sql3 = " SELECT ERP_CODE 物料代码,ERP_NAME 物料名称  FROM L2BF_COM.T_BASE_MATERIAL_NEW WHERE ISST = 'Y' AND ISUSE = '0'  AND  ERP_CODE ='" + text2+"'";
                DataTable dataTable1 = cls_public_main.ExecuteQuery("", sql3);
                gridControl1.DataSource = dataTable1;
            }


        }

        public void select()
        {
            //210803
            //using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            //{

            //    datelist = yh.T_BASE_MATERIAL.ToList();
            //    DateSource.DataSource = datelist;
            //    gridControl2.DataSource = DateSource;

            //}
            using (jyxcsjl2.MODEL.L2BF_COM yh = new jyxcsjl2.MODEL.L2BF_COM())
            {

                datelist = yh.T_BASE_MATERIAL_NEW.Where(u => u.ISST == "Y" && u.ISUSE != "1").ToList();
                DateSource.DataSource = datelist;
                gridControl2.DataSource = DateSource;

            }
        }
        public void select1(string i)
        {
            if (i == "load")
            {
                //210803
                //string sql = "SELECT e.MAT_PROD_CODE as 集团物料代码 ,e.MAT_PROD_CNAME as 集团物料名称,e.MAT_PROD_ENAME as 粒度区间,e.MAT_PROD_CODE_RELATE as 品名分类,e.MAT_PROD_CODE_RELATE_2  as 品名分类2 ,e.MAT_PROD_CODE_RELATE_3 as 品名分类3  FROM (   SELECT d.MAT_PROD_CODE ,d.MAT_PROD_CNAME,d.MAT_PROD_ENAME ,d.MAT_PROD_CODE_RELATE,d.MAT_PROD_CODE_RELATE_2,d.MAT_PROD_CODE_RELATE_3 FROM TYMIR21_IOOP @TO_XCT1OPEN d  WHERE d.MAT_PROD_CODE IN( SELECT a.MAT_PROD_CODE FROM TYMIR21_IOOP @TO_XCT1OPEN a WHERE a.MAT_PROD_CODE NOT IN (SELECT p.ERP_CODE FROM T_BASE_MATERIAL p))) e where  e.MAT_PROD_CODE like'D0604%' OR e.MAT_PROD_CODE like'D0601%' or e.MAT_PROD_CODE like'D0501007%'or e.MAT_PROD_CODE like'D0501008%'or e.MAT_PROD_CODE like'D050101%' ORDER BY  e.MAT_PROD_CODE ASC  ";
                string sql = " SELECT ERP_CODE 物料代码,ERP_NAME 物料名称  FROM L2BF_COM.T_BASE_MATERIAL_NEW WHERE ISST = 'Y' AND ISUSE = '0' ";
                DataTable dataTable = cls_public_main.ExecuteQuery("", sql);
            gridControl1.DataSource = dataTable;
            }
       
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            gridView2.AddNewRow();
        }



        private void gridView2_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //string begin = cls_public_main.sys_time();
            gridView2.SetFocusedRowCellValue("ERP_CODE", text2);
            gridView2.SetFocusedRowCellValue("FAC_CODE", text2);
            gridView2.SetFocusedRowCellValue("ERP_NAME", text1);
            gridView2.SetFocusedRowCellValue("FAC_NAME", text1);
            gridView2.ShowEditForm();
            update = "insert";

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (path != "")
            {
                gridView2.ExportToXls(path);
            }
        }

        //private void lookUpEdit1_Modified(object sender, EventArgs e)
        //{

        //}

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

        }

    }
}
