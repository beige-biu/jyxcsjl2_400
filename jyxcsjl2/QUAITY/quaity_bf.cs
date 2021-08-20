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
   
    public partial class quaity_bf : UserControl
    {
        public quaity_bf()
        {
            InitializeComponent();
        }
        string begin_time, end_time,lu_no;

        

        private void combox()
        {
            

            string sql = " SELECT MAT_CODE 分析类别代码, MAT_NAME 分析类别中文 FROM oraltl2_bf.T_QUALITY_CODECFG where mat_name='铁水' ";
            //string sql = "SELECT MAT_CODE 分析类别代码, MAT_NAME 分析类别中文 FROM oraltl2_bf.T_QUALITY_CODECFG ORDER BY MAT_NO ASC";
            DataTable dataTable = cls_public_main.ExecuteQuery("", sql);
            lookUpEdit1.Properties.DataSource = dataTable;
            lookUpEdit1.Properties.ValueMember = "分析类别中文";
            lookUpEdit1.Properties.DisplayMember = "分析类别中文";
            lookUpEdit1.EditValue = "铁水";
        }

       

        private void gridControl1_Load(object sender, EventArgs e)
        {
            //labelControl4.Visible = false;
            //textEdit1.Visible = false;
            comboBox1.SelectedIndex = 2;
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            combox();
            select(dateTimePicker1.Value, dateTimePicker2.Value, "load");
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            select(dateTimePicker1.Value, dateTimePicker2.Value, "");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (path != "")
            {
                gridView1.ExportToXls(path);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1) {
                lu_no = "T6";
            }
           
            else if (comboBox1.SelectedIndex==2) {
                lu_no = "T%";
            }
            else
            {
                lu_no = "T7";
            }
            
        }

        public void select(DateTime Begin_time, DateTime End_time, string i)
        {
            OracleParameter[] temp = new OracleParameter[6];
            temp[0] = new OracleParameter("l_RetVal", OracleDbType.RefCursor);
            temp[0].Direction = ParameterDirection.ReturnValue;

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

            temp[4] = new OracleParameter(":SAMPLE_NO", OracleDbType.Varchar2);
            temp[4].Value = textEdit1.Text.ToUpper();
            temp[4].Direction = ParameterDirection.Input;
            string d = textEdit1.Text.ToUpper();

            temp[5] = new OracleParameter(":LU_NO", OracleDbType.Varchar2);
            temp[5].Value = lu_no.ToString();
            temp[5].Direction = ParameterDirection.Input;

            OracleConnection con = new OracleConnection(cls_public_main.RZW9DB_CONSTR);
            con.Open();
            OracleCommand or = con.CreateCommand();
            //执行存储过程
            or.CommandType = CommandType.StoredProcedure;
            or.CommandText = "F_QUALITY_QUARY_1";
            or.Parameters.Add(temp[0]);
            or.Parameters.Add(temp[1]);
            or.Parameters.Add(temp[2]);
            or.Parameters.Add(temp[3]);
            or.Parameters.Add(temp[4]);
            or.Parameters.Add(temp[5]);
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


            DataTable dt_result = new DataTable();

            foreach (DataColumn col in dataTable.Columns)
            {
                dt_result = dataTable.Clone();
                foreach (DataColumn col1 in dt_result.Columns)
                {
                    for (int index = 0; index <= 29; index++)
                    {
                        if (col1.ColumnName == dataTable.Columns[index].ColumnName && index >= 7 && index < 20)
                        {
                            col1.DataType = typeof(double);
                        }

                    }

                }


                foreach (DataRow row in dataTable.Rows)
                {
                    DataRow rowNew = dt_result.NewRow();
                    for (int index0 = 0; index0 <= 29; index0++)
                    {
                        rowNew[dataTable.Columns[index0].ColumnName] = row[dataTable.Columns[index0].ColumnName];
                    }
                    dt_result.Rows.Add(rowNew);

                }



            }

            gridControl1.DataSource = dt_result;

            



            if (dataTable.Rows.Count > 0)
            {
                //gridView1.Columns[1].Visible = false;
                //gridView1.Columns[3].Visible = false;
                gridView1.Columns[2].Visible = false;
                gridView1.Columns[0].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridView1.Columns[0].DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
                gridView1.BestFitColumns();
                gridView1.RowHeight = 30;
                int index = 0;
                foreach (GridColumn col in gridView1.Columns)
                {
                    gridView1.Columns[index].Width = gridView1.Columns[index].Width + 20;

                    if (index >= 7 && index < 20)
                    {
                        string exp;
                        string exp1;
                        string temp1;
                        string temp2;
                        if (lookUpEdit1.Text.ToString() == "铁水")
                        {
                            exp = "avg([" + dt_result.Columns[index].ColumnName + "])";
                            exp1 = "[" + dt_result.Columns[index].ColumnName + "]>0";
                            temp1 = dt_result.Compute(exp, exp1).ToString();

                        }
                        else
                        {
                            exp = "avg([" + dataTable.Columns[index].ColumnName + "])";
                            exp1 = "[" + dataTable.Columns[index].ColumnName + "]>0";
                            temp1 = dataTable.Compute(exp, exp1).ToString();

                        }

                        if (temp1 == "")
                        {
                            temp2 = "0";
                        }
                        else
                        {
                            temp2 = Math.Round(Convert.ToDecimal(temp1), 3).ToString();
                        }

                        this.gridView1.Columns[index].Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                        new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom,gridView1.Columns[index].FieldName, "{0:#0.00}")});
                        gridView1.Columns[index].SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Custom, temp2);
                    }
                    index++;
                }




            }

            
                gridView1.Columns["班次"].Visible = true;
                gridView1.Columns["班别"].Visible = true;
           
        }

    }
}
