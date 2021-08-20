using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jyxcsjl2
{
    public partial class material_supply : UserControl
    {
        public material_supply()
        {
            InitializeComponent();
            cls_public_main.ButtonControl(this, null, new List<DevExpress.XtraEditors.SimpleButton> { sendButton }, null, null, null);
        }
        public string begin_time, end_time;
        public DataTable dt;
        public OracleDataAdapter da;
        string confirm;

        private void queryButton1_Click(object sender, EventArgs e)
        {
            sclect(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            sclect(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            sclect(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void sendButton_Click_1(object sender, EventArgs e)
        {
           

            if (gridView1.SelectedRowsCount <= 0)
            {
                MessageBox.Show("没有选中修改行，请选中修改数据行！");
                return;
            }
            else
            {
                DialogResult result =  MessageBox.Show("是否确认？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes) {
                    string work_time = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["WORK_TIME"]).ToString();//2020-09-21 15:15:25
                    work_time = work_time.Replace("-", "");
                    work_time = work_time.Replace(":", "");
                    work_time = work_time.Replace(" ", "");
                    string MAT_BATCH_NO = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MAT_BATCH_NO"]).ToString();
                    string name = cls_public_main.m_emp_name;
                    DateTime fix_time = Convert.ToDateTime(cls_public_main.sys_time());
                    string sql1 = "select * from t_material_supply where WORK_TIME ='" + work_time + "'  and MAT_BATCH_NO = '" + MAT_BATCH_NO + "' and CONFIRM_MAN IS NOT NULL and CONFIRM_TIME IS NOT NULL";

                    DataTable dt1 = cls_public_main.ExecuteQuery("", sql1);
                    if (dt1.Rows.Count == 0)
                    {
                        string sql = "update t_material_supply  set  CONFIRM_MAN = '" + cls_public_main.m_emp_name + "'," +
                   " CONFIRM_TIME = to_date('" + cls_public_main.sys_time() + "','yyyy-mm-dd hh24:mi:ss') where WORK_TIME ='" + work_time + "'  and MAT_BATCH_NO = '" + MAT_BATCH_NO + "'";
                        int no = 0;
                        no = cls_public_main.ExcuteSQL("", sql);
                        if (no > 0)
                        {
                            MessageBox.Show("确认成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else {
                        MessageBox.Show("已经确认过", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    sclect(dateTimePicker1.Value, dateTimePicker2.Value);


                }
                
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (path != "")
            {
                gridControl1.ExportToXls(path);
            }
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //BACKLOG_CODE
            if (e.Column.FieldName == "BACKLOG_CODE")
            {
                if (e.Value.ToString() == "S6") e.DisplayText = "400烧结";
                else
                {
                    e.DisplayText = "400烧结";
                }


            }

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var row = e.Row;
            object remark = gridView1.GetFocusedRowCellValue(fieldName: "REMARK");
            //string remark = row["REMARK"];
            string begin = gridView1.GetFocusedRowCellValue(fieldName: "WORK_TIME").ToString();
            //2021-03-11 21:26:37
            begin = begin.ToString().Replace("-", "").Replace(":", "").Replace(" ", "");

            string sql = "update T_MATERIAL_SUPPLY set remark="
                          + " '" + remark + "'" + " where WORK_TIME=" + begin;

            cls_public_main.ExecuteQuery("", sql);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 1)
            {
                confirm = " and confirm_man is not null ";
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                confirm = "  and confirm_man is null";
            }
            else
            {
                confirm = " ";
            }
        }

        public void sclect(DateTime Begin_time, DateTime End_time)
        {
                using (jyxcsjl2.MODEL.T_MATM db = new jyxcsjl2.MODEL.T_MATM())
                {
                string s = "select to_char(to_date(WORK_TIME,'yyyy-mm-dd hh24:mi:ss'),'yyyy-mm-dd hh24:mi:ss') as WORK_TIME ," +
                            " MAT_BATCH_NO,MAT_PROD_CODE,MAT_PROD_CNAME,to_char(to_date(RUB_TAPE_START_TIME, 'yyyy-mm-dd hh24:mi:ss'), 'yyyy-mm-dd hh24:mi:ss') as RUB_TAPE_START_TIME, " +
                            " to_char(to_date(RUB_TAPE_END_TIME, 'yyyy-mm-dd hh24:mi:ss'), 'yyyy-mm-dd hh24:mi:ss') as RUB_TAPE_END_TIME ,CARRY_WGT,SRC_PILE_NO,DST_PILE_NO,BACKLOG_CODE,SCALE_NO,NOTICE_NO,WEIGH_BY,MAT_TRANS_TYPE," +
                            " CONFIRM_MAN,CONFIRM_TIME,REMARK,BIN_COLLECTION from t_material_supply " +
                            " where to_date(work_time,'yyyy-mm-dd hh24:mi:ss')> to_date('" + Begin_time.ToString() + "', 'yyyy-mm-dd hh24:mi:ss') "
                                 + " and to_date(work_time,'yyyy-mm-dd hh24:mi:ss')<= to_date('" + End_time.ToString() + "', 'yyyy-mm-dd hh24:mi:ss')"+confirm;
                    da = new OracleDataAdapter(s,cls_public_main.RZW9DB_CONSTR);
                    dt = cls_public_main.ExecuteQuery("", s);
                    gridControl1.DataSource = dt;
                //var b = db.Database.SqlQuery<string>(s).ToList();
                //string c = b.ToString();
            }
        }
    }
}
