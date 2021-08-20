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
    public partial class insert_feeding_instrutions : Form
    {
        public insert_feeding_instrutions()
        {
            InitializeComponent();
        }
        string sys_time;
        public string insert;
        public string text1, text2;
        public string FAC_CODE, FAC_NAME,tlgl;
        

     //   string f_getzlno;
        private void insert_feeding_instrutions_Load(object sender, EventArgs e)
        {
            string_create();
            init_combox();
        }

        public void string_create()
        {
            if (insert == "insert")
            {
                sys_time = cls_public_main.sys_time(); //获取当前时间
                using (var db = new jyxcsjl2.MODEL.T_USER())
                {
                    var systime = db.Database.SqlQuery<string>("select f_getzlno from dual").FirstAsync();
                    textBox1.Text = systime.Result.ToString();
                }
            }

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void init_combox()
        {
            
            using (jyxcsjl2.MODEL.T_PROM yh = new jyxcsjl2.MODEL.T_PROM())
            {
                //查询出所有正在使用的烧结物资
                //var dl = yh.T_BASE_MATERIAL.Where(u => u.ISST == "Y" && u.ISUSE != "1");
                string sql = "select ERP_CODE 物料代码,ERP_NAME 物料名称 from L2BF_COM.T_BASE_MATERIAL_NEW where ISST='Y'and ISUSE ='0'";
                DataTable dataTable = cls_public_main.ExecuteQuery("", sql);
                lookUpEdit1.Properties.DataSource = dataTable;
                lookUpEdit1.Properties.ValueMember = "物料代码";
                lookUpEdit1.Properties.DisplayMember = "物料名称";



                //lookUpEdit1.Properties.DataSource = dl.ToList();
                //lookUpEdit1.Properties.ValueMember = "FAC_CODE";
                //lookUpEdit1.Properties.DisplayMember = "FAC_NAME";
                lookUpEdit1.ItemIndex = 0;
            }
            if (insert == "insert")
            {
                comboBox1.SelectedIndex = 0;
            }
            if (insert == "update")
            {
                comboBox1.Text = tlgl;
                lookUpEdit1.EditValue = FAC_CODE;
                textBox1.Text = text1;
                textBox2.Text = text2;
                comboBox1.Enabled = false;
                textBox1.Enabled = false;
                lookUpEdit1.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (insert == "insert")
            {
                string sql, st;
                string lrsj = Convert.ToDateTime(sys_time).ToString("yyyyMMddHHmmss");
                if (comboBox1.Text == "供料") { st = "2"; } else { st = "1"; }
                if (textBox2.Text == "") { textBox2.Text = " "; }
                sql = "INSERT INTO TMMIRSJ_IOOP@TO_XCT1OPEN " +
                      " (DT , DICT_NO, SENDER_NAME,UNIT_NO, WORK_NO, MAT_PROD_CODE, TYPE_ENABLE_FLAG, COMM_SND_FLAG,START_TIME,REMARK,recive_status) " +
                      " VALUES ('" + lrsj + "', '" + textBox1.Text + "', '"
                                 + cls_public_main.m_emp_name + "', '6', 'S', '" + lookUpEdit1.EditValue + "', '" + st + "', 'I','"
                                 + Convert.ToDateTime(sys_time).ToString("yyyyMMddHHmmss") + "','" + textBox2.Text + "','1')";
                if (cls_public_main.ExcuteSQL(cls_public_main.RZW9DB_CONSTR, sql) == 2)
                {
                    MessageBox.Show("数据发送成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("数据发送失败！");
                }
            }
            if (insert == "update")
            {

                string sql, st;
                string lrsj = Convert.ToDateTime(sys_time).ToString("yyyyMMddHHmmss");
                if (comboBox1.Text == "供料") { st = "2"; } else { st = "1"; }
                if (textBox2.Text == "") { textBox2.Text = " "; }
                sql = "update TMMIRSJ_IOOP@TO_XCT1OPEN set REMARK = '" + textBox2.Text + "' where  DICT_NO ='" + textBox1.Text + "' " ;
                if (cls_public_main.ExcuteSQL(cls_public_main.RZW9DB_CONSTR, sql) == 2)
                {
                    MessageBox.Show("数据发送成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("数据发送失败！");
                }
            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
