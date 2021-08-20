using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jyxcsjl2
{
    public partial class operational_center_edit : Form
    {
        public operational_center_edit()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string time = dateTimePicker1.Text;
            string Sql = " Call PROC_GET_SINTER_SCRB('" + time +"')"; 
            int dt = cls_public_main.ExcuteSQL(cls_public_main.RZW9DB_CONSTR, Sql);
            string Sql1 = " Call PROC_GET_SINTER_SCRB2('" + time + "')";
            int dt1 = cls_public_main.ExcuteSQL(cls_public_main.RZW9DB_CONSTR, Sql1);
            string Sql2 = " Call PROC_GET_SINTER_SCRB1('" + time + "')";
            int dt2 = cls_public_main.ExcuteSQL(cls_public_main.RZW9DB_CONSTR, Sql2);
            if (dt == 1 || dt1 == 1 || dt2 == 1)
            {
                MessageBox.Show("执行失败");
             } else
            {
                MessageBox.Show("执行成功");
            }
        }
    }
}
