using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using DevExpress.XtraGrid.Columns;

namespace jyxcsjl2
{
    public partial class quaity_analyse : UserControl
    {
        public quaity_analyse()
        {
            InitializeComponent();
        }
        string  begin_time, end_time;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sclect(dateTimePicker1.Value, dateTimePicker2.Value, "");
        }
        private void combox()
        {
            //210803
            //string sql = "select distinct MAT_PROD_CODE 物料代码, FAC_NAME 物料名称 from V_QUAITY_ANALYSE ";
            string sql = "select distinct MAT_CODE 物料代码, MAT_NAME 物料名称 from T_QUALITY_CODECFG ";
            //sql += " where MAT_PROD_CODE not in ('D05010100190000G', 'D0601001010CAN0G', 'D0601101010UKR0G', 'D0601002010MRT0G', 'D06040030100000X','D06011010100000G','C60700100100002') ";
                DataTable dataTable = cls_public_main.ExecuteQuery("", sql);
                lookUpEdit1.Properties.DataSource = dataTable;
                lookUpEdit1.Properties.ValueMember = "物料名称";
                lookUpEdit1.Properties.DisplayMember = "物料名称";
                //lookUpEdit1.EditValue = "C60101100100002A";
                lookUpEdit1.EditValue = "烧结矿";
            //this.lookUpEdit1.Properties.ShowAutoFilterRow = true;
        }

        private void quaity_analyse_Load(object sender, EventArgs e)
        {
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            combox();
            sclect(dateTimePicker1.Value, dateTimePicker2.Value,"load");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (path != "")
            {
                gridView1.ExportToXls(path);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string
            DataTable bb = new DataTable();
            DataTable bb_new = new DataTable();
            DataRow dataRow = bb_new.NewRow();
            string sql = "select * from T_BASE_ANALYSE_MASK";
            bb = cls_public_main.ExecuteQuery("", sql);
            //for (int i = 0; bb.Rows.Count; i++)
            //{
            //    DataRow dataRow = bb_new.NewRow();
            //    dataRow[0] = bb.Rows[i][0].ToString();
            //    dataRow[1] = bb.Rows[i][1].ToString();
            //    dataRow[0] = bb.Rows[i][2].ToString();

            //    int 



            //}

        }

        public void sclect(DateTime Begin_time, DateTime End_time, string i)
        {
                OracleParameter[] temp = new OracleParameter[5];
                temp[0] = new OracleParameter("l_RetVal", OracleDbType.RefCursor);
                temp[0].Direction = ParameterDirection.ReturnValue;

            temp[1] = new OracleParameter(":MATERIAL_NAME", OracleDbType.Varchar2);
            //if (i == "load") { temp[1].Value = "C60101100100002A"; }
            //if (i == "load") { temp[1].Value = "YK"; }
            //else { temp[1].Value = lookUpEdit1.EditValue.ToString(); }
            temp[1].Direction = ParameterDirection.Input;
            temp[1] = new OracleParameter(":MATERIAL_NAME", OracleDbType.Varchar2);
            temp[1].Value = lookUpEdit1.EditValue.ToString();
            temp[1].Direction = ParameterDirection.Input;
            string a = lookUpEdit1.EditValue.ToString();

            temp[2] = new OracleParameter(":BEGIN_TIME", OracleDbType.Varchar2);
                temp[2].Value = Begin_time.ToString("yyyy-MM-dd HH:mm:ss");
                temp[2].Direction = ParameterDirection.Input;
            string b = Begin_time.ToString("yyyy-MM-dd HH:mm:ss");
            temp[3] = new OracleParameter(":END_TIME", OracleDbType.Varchar2);
                temp[3].Value = End_time.ToString("yyyy-MM-dd HH:mm:ss");
                temp[3].Direction = ParameterDirection.Input;
            string c = End_time.ToString("yyyy-MM-dd HH:mm:ss");
            temp[4] = new OracleParameter(":sample_no", OracleDbType.Varchar2);
                temp[4].Value = textEdit1.Text.ToUpper();
                temp[4].Direction = ParameterDirection.Input;
            string d = textEdit1.Text.ToUpper();
            
            OracleConnection con = new OracleConnection(cls_public_main.RZW9DB_CONSTR);
                con.Open();
                OracleCommand or = con.CreateCommand();
                or.CommandType = CommandType.StoredProcedure;
                or.CommandText = "F_QUALITY_QUARY_ST";
                or.Parameters.Add(temp[0]);
                or.Parameters.Add(temp[1]);
                or.Parameters.Add(temp[2]);
                or.Parameters.Add(temp[3]);
                or.Parameters.Add(temp[4]);
                gridControl1.DataSource = null;
                gridView1.Columns.Clear();
                DataTable dataTable = new DataTable();
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(or);
                oracleDataAdapter.SelectCommand = or;
                oracleDataAdapter.Fill(dataTable);


            GridColumn gridColumn;
            //gridView1.OptionsBehavior.AutoPopulateColumns = false;
            int visibleIndex = 0;
            foreach (DataColumn col in dataTable.Columns)
            {
                gridColumn = new GridColumn();
                gridColumn.Name = gridColumn.Caption = gridColumn.FieldName = col.ColumnName;
                gridColumn.VisibleIndex = visibleIndex;
                gridView1.Columns.Add(gridColumn);
                visibleIndex++;
            } 
            gridControl1.DataSource = dataTable;

            if (dataTable.Rows.Count > 0)
            {
                gridView1.Columns[2].Visible = false;
                gridView1.Columns[1].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridView1.Columns[1].DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
                gridView1.BestFitColumns();
                gridView1.RowHeight = 30;


                int index = 0;
                foreach (GridColumn col in gridView1.Columns)
                {
                    gridView1.Columns[index].Width = gridView1.Columns[index].Width + 20;

                    if (index >= 6)
                    {
                        string exp = "avg([" + dataTable.Columns[index].ColumnName + "])";
                        string exp1 = "[" + dataTable.Columns[index].ColumnName + "]>0";
                        string temp1 = dataTable.Compute(exp, exp1).ToString();
                        string temp2;
                        if (temp1 == "")
                        {
                             temp2 = "0";
                        }
                        else
                        {
                             temp2 = Math.Round(Convert.ToDecimal(temp1),3).ToString();
                        }

                        this.gridView1.Columns[index].Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                        new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom,gridView1.Columns[index].FieldName, "{0:#0.00}")});
                        gridView1.Columns[index].SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Custom, temp2);
                    }
                    index++;

                }



            }


        }

    }
}
