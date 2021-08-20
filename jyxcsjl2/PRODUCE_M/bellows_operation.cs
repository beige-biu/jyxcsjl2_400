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
using jyxcsjl2.MODEL;





namespace jyxcsjl2
{
    public partial class bellows_operation_p : UserControl
    {
        string begin_time, end_time;
        public string win ;
        public bellows_operation_p()
        {
            InitializeComponent();
       
        }


        void userControl11_btnClick(object sender, EventArgs e)
        {
            
        }
        private void date_select1_Load(object sender, EventArgs e)
        {
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            if (win == "风箱压力")
            {
                sclect_p(this.dateTimePicker1.Value, this.dateTimePicker2.Value);
            }
            else
            {
                sclect_t(this.dateTimePicker1.Value, this.dateTimePicker2.Value);
            }
            
        }
        public void sclect_p(DateTime Begin_time, DateTime End_time )
        {
            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {
                var bb = yh.T_PRODUCE_BELLOWS_PRESSURE.Where(u => u.DATE_ID > Begin_time && u.DATE_ID <= End_time);
                gridControl1.DataSource = bb.ToList();
                var sql = bb.ToString();
            }
        }
        public void sclect_t(DateTime Begin_time, DateTime End_time)
        {

            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {
                var bb = yh.T_PRODUCE_BELLOWS_TEMPERATURE.Where(t => (t.DATE_ID > Begin_time && t.DATE_ID <= End_time));
                gridControl1.MainView = gridView2 ;
                gridControl1.DataSource = bb.ToList();
                var sql = bb.ToString();
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (win == "风箱压力")
            {
                sclect_p(this.dateTimePicker1.Value, this.dateTimePicker2.Value);
            }
            else
            {
                sclect_t(this.dateTimePicker1.Value, this.dateTimePicker2.Value);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (win == "风箱压力")
            {
                
                if (path != "")
                {
                    bandedGridView1.ExportToXls(path);
                }
            }
            else
            {
                if (path != "")
                {
                    gridView2.ExportToXls(path);
                }
            }
        }

      

    }
}
