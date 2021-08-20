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
    public partial class date_select : UserControl
    {
        public date_select()
        {
            InitializeComponent();
        }
        public string begin_time;
        public string end_time;
     
        public event EventHandler BtnEvent;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            begin_time = dateTimePicker1.Value.ToString();
              end_time = dateTimePicker2.Value.ToString();
            if (BtnEvent != null)
            {
                BtnEvent(sender, e);
            }
        }

        public string sys_time()
        {

            using (var db = new jyxcsjl2.MODEL.T_USER())
            {
                var systime = db.Database.SqlQuery<string>("select to_char(sysdate,'yyyy-mm-dd hh24:mi:ss') from dual").FirstAsync();
                return systime.Result.ToString();
            }

        }
        private void date_select_Load(object sender, EventArgs e)
        {
           
            //string bb = cls_public_main.sys_time();
            DateTime time = Convert.ToDateTime(sys_time());
            if ((time >= Convert.ToDateTime(time.ToShortDateString() + " 8:00:00")) &&
               (time <= Convert.ToDateTime(time.ToShortDateString() + " 20:00:00")))
            {
                begin_time = time.ToShortDateString() + " 8:00:00";
            }
            if ((time >= Convert.ToDateTime(time.ToShortDateString() + " 20:00:00")) &&
                (time <= Convert.ToDateTime(time.Date.AddDays(1).ToShortDateString() + " 08:00:00")))
            { 
                begin_time = time.ToShortDateString() + " 20:00:00";
            }
            end_time = time.ToString();
            this.dateTimePicker1.Value = Convert.ToDateTime( begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);


        }
    }
}
