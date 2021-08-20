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
using Oracle.ManagedDataAccess.Client;

namespace jyxcsjl2
{
    public partial class home_main : UserControl
    {
        public home_main()
        {
            InitializeComponent();
         
        }
        public void sclect()
        {
            using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            {
                //var list = yh.T_INSERT_QUAL_SJK.OrderByDescending(t => t.MAT_SAMPLE_NO);
                //gridControl1.DataSource = list.ToList().Take(5);
                //string ss = list.ToString();
                //string s = " select * from (select distinct * from T_INSERT_QUAL_SJK where feo is not null order by mat_sample_no desc) "
                //           +" where rownum <= 5  ";

                string s = " select MAT_SAMPLE_NO,TFE ,FEO,SIO2,CAO,MGO,AL2O3,R2,S," +
                    "P,K2O,NA2O,TIO2,MNO from(select distinct * from V_QUAITY_SJK order by mat_sample_no desc) where rownum <= 5  ";
                DataTable dt = cls_public_main.ExecuteQuery("",s);
                gridControl1.DataSource = dt;

            }
        }
        public void sclect_supply()
        {

            string s = " SELECT * FROM (select * from t_material_supply  order by work_time desc) where rownum <= 5 ";
            //to_char(to_date(DT,'yyyy-mm-dd hh24:mi:ss'),'yyyy-mm-dd hh24:mi:ss') as 记录日期
            //WORK_TIME,MAT_BATCH_NO,MAT_PROD_CNAME,RUB_TAPE_START_TIME,RUB_TAPE_END_TIME,CARRY_WGT,SRC_PILE_NO,BACKLOG_CODE,WEIGH_BY,WEIGH_BY
            DataTable dt = cls_public_main.ExecuteQuery("", s);
            gridControl3.DataSource = dt;

        }

        private void home_main_Load(object sender, EventArgs e)
        {
            sclect_sjpb();
            sclect_supply();
            sclect();
        }
        public void sclect_sjpb()
        {
            using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            {
                //var sjpb = from p in yh.T_SINTER_MATERIAL_RATIO
                //           group p by new
                //           {   p.MATERIAL_CODE,
                //               p.MATERIAL_NAME,
                //               p.MATERIAL_PERCENTAGE,
                //               p.RECORD_DATE,
                //               p.RECORD_PERSON
                //           } into g
                //           select new
                //           {
                //               PBD_NO = g.Max(p => p.PBD_NO),
                //               g.Key.MATERIAL_CODE,
                //               g.Key.MATERIAL_NAME,
                //               g.Key.MATERIAL_PERCENTAGE,
                //               g.Key.RECORD_DATE,
                //               g.Key.RECORD_PERSON
                //            };
                //var ls = yh.T_SINTER_MATERIAL_RATIO.GroupBy(a => new { a.PBD_NO,a.MATERIAL_CODE,a.MATERIAL_NAME,a.MATERIAL_PERCENTAGE,a.RECORD_PERSON} ).
                //                                            Select(g => (new {  g.Key.PBD_NO,g.Key.MATERIAL_CODE,g.Key.MATERIAL_NAME,g.Key.MATERIAL_PERCENTAGE,g.Key.RECORD_PERSON,
                //                                                                RECORD_DATE = g.Max( x=> x.RECORD_DATE) })).ToList();
                // sjpb.ToList();
                //var sjpb = yh.T_SINTER_MATERIAL_RATIO.Select(t => maxt).;
                string SQL = "select * from T_SINTER_MATERIAL_RATIO where pbd_no = (select max(pbd_no)from T_SINTER_MATERIAL_RATIO)";
                DataTable dataTable = cls_public_main.ExecuteQuery("", SQL);
                gridControl2.DataSource = dataTable;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

              

        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            sclect();
        }

        private void groupControl3_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            sclect_supply();
        }

     

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            sclect_sjpb();
        }

        private void gridView3_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "BACKLOG_CODE")
            {
                if (e.Value.ToString() == "S6") e.DisplayText = "400烧结";
                else
                {
                    e.DisplayText = "400烧结";
                }


            }
        }
    }
}
