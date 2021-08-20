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
    public partial class feeding_instructions : UserControl
    {
        public feeding_instructions()
        {
            InitializeComponent();
            cls_public_main.ButtonControl(this, null, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton1 }, null, new List<DevExpress.XtraEditors.SimpleButton> { sendButton }, null);
        }
        public string begin_time,end_time;
        private void feeding_instructions_Load(object sender, EventArgs e)
        {
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            select(dateTimePicker1.Value, dateTimePicker2.Value);          
        }
        private void select(DateTime Begin_time, DateTime End_time)
        {
            //string sql = " SELECT to_char(to_date(DT,'yyyy-mm-dd hh24:mi:ss'),'yyyy-mm-dd hh24:mi:ss') as 记录日期, DICT_NO as 指令号, case TYPE_ENABLE_FLAG when '1' then '停料' else '供料' end as 类别, MAT_PROD_CODE as 物料代码, " +
            //            "T_BASE_MATERIAL.ERP_NAME as 物料名称,SENDER_NAME as 发送人 ,to_char(to_date(START_TIME,'yyyy-mm-dd hh24:mi:ss'),'yyyy-mm-dd hh24:mi:ss') as 发出时间,RECEIVER_NAME as " +
            //            "接收人,RECE_TIME as 接收时间,case recive_status when '1' then '未接受' else '已接受' end as 接受状态,REMARK as 备注" +
            //            " FROM TMMIRSJ_IOOP @TO_XCT1OPEN TMMIRSJ_IOOP,T_BASE_MATERIAL " + "WHERE TMMIRSJ_IOOP.MAT_PROD_CODE = T_BASE_MATERIAL.ERP_CODE and " +
            //            " to_date(DT,'yyyy-MM-dd HH24:mi:ss' ) between " +
            //            " to_date('" + dateTimePicker1.Value.ToString() + "','yyyy-MM-dd HH24:mi:ss' )and to_date('" + dateTimePicker2.Value.ToString() + "','yyyy-MM-dd HH24:mi:ss') order by DT asc";
            string sql = " SELECT to_char(to_date(DT,'yyyy-mm-dd hh24:mi:ss'),'yyyy-mm-dd hh24:mi:ss') as 记录日期, DICT_NO as 指令号, case TYPE_ENABLE_FLAG when '1' then '停料' else '供料' end as 类别, MAT_PROD_CODE as 物料代码, " +
                        "L2BF_COM.T_BASE_MATERIAL_NEW.ERP_NAME as 物料名称,SENDER_NAME as 发送人 ,to_char(to_date(START_TIME,'yyyy-mm-dd hh24:mi:ss'),'yyyy-mm-dd hh24:mi:ss') as 发出时间,RECEIVER_NAME as " +
                        "接收人,RECE_TIME as 接收时间,case recive_status when '1' then '未接受' else '已接受' end as 接受状态,REMARK as 备注" +
                        " FROM TMMIRSJ_IOOP @TO_XCT1OPEN TMMIRSJ_IOOP,L2BF_COM.T_BASE_MATERIAL_NEW " + "WHERE TMMIRSJ_IOOP.MAT_PROD_CODE = L2BF_COM.T_BASE_MATERIAL_NEW.ERP_CODE and " +
                        " to_date(DT,'yyyy-MM-dd HH24:mi:ss' ) between " +
                        " to_date('" + dateTimePicker1.Value.ToString() + "','yyyy-MM-dd HH24:mi:ss' )and to_date('" + dateTimePicker2.Value.ToString() + "','yyyy-MM-dd HH24:mi:ss') order by DT asc";
            DataTable dt = cls_public_main.ExecuteQuery(cls_public_main.RZW9DB_CONSTR, sql);
            gridControl1.DataSource = dt;
            gridView1.BestFitColumns();
        }
        private void queryButton(object sender, EventArgs e)
        {
            select(dateTimePicker1.Value, dateTimePicker2.Value);
        }

 

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (path != "")
            {
                gridView1.ExportToXls(path);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount <= 0)
            {
                MessageBox.Show("没有选中修改行，请选中修改数据行！");
                return;
            }
            else
            {
               
                insert_feeding_instrutions win = new insert_feeding_instrutions();
                win.insert = "update";
                win.text1 = gridView1.GetFocusedRowCellValue("指令号").ToString();
                win.text2 = gridView1.GetFocusedRowCellValue("备注").ToString();
                win.tlgl  = gridView1.GetFocusedRowCellValue("类别").ToString();
                win.FAC_CODE = gridView1.GetFocusedRowCellValue("物料代码").ToString();
                win.ShowDialog();
                if (win.DialogResult == DialogResult.OK)
                { select(dateTimePicker1.Value, dateTimePicker2.Value); }
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            insert_feeding_instrutions win = new insert_feeding_instrutions();
            win.insert = "insert";
            win.ShowDialog();
            if (win.DialogResult == DialogResult.OK)
            { select(dateTimePicker1.Value, dateTimePicker2.Value);}
            
        }
    }
}
