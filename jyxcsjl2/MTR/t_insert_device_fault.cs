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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;

namespace jyxcsjl2
{
    public partial class t_insert_device_fault : UserControl
    {
        private string update = "";
        private int iFlag = 0;
        public List<MODEL.T_INSERT_DEVICE_FAULT> shift = new List<MODEL.T_INSERT_DEVICE_FAULT>();
        public BindingSource shiftSource = new BindingSource();
        public t_insert_device_fault()
        {

            InitializeComponent();
            cls_public_main.FuncControl(this, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton2 }, new List<DevExpress.XtraGrid.Views.Grid.GridView> { gridView1 }, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton1 }, null, null);
        }

        private void t_insert_device_fault_Load(object sender, EventArgs e)
        {
            try
            {
                string begin_time, end_time;
                cls_public_main.select_time(out begin_time, out end_time);
                this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
                this.dateTimePicker2.Value = Convert.ToDateTime(end_time);           
               comboxinit();
               GetData(dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString(), "");
                gridView1.Columns.ColumnByFieldName("FLAG").OptionsColumn.ReadOnly = true;
             //   sclect(this.dateTimePicker1.Value, this.dateTimePicker2.Value, "");
            }
            catch (Exception ExFail)
            { MessageBox.Show(ExFail.Message); }
        }
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                gridView1.AddNewRow();
            }
            catch (Exception ExFail)
            { MessageBox.Show(ExFail.Message); }

        }
        public void comboxinit()
        {
            using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            {
                var empl = yh.T_BASE_CODE.Where(t => t.CODE_GROUP == "Fault_Status").Select(c => new
                {
                    状态 = c.CODE_DES,
                    Value = c.CODE
                }).ToList();
                repositoryItemLookUpEdit1.DataSource = empl;
                repositoryItemLookUpEdit1.ValueMember = "Value";
                repositoryItemLookUpEdit1.DisplayMember = "状态";
                repositoryItemLookUpEdit1.NullText = "";
            }
        }
            public void sclect(DateTime Begin_time, DateTime End_time, string i)
        {
            using (jyxcsjl2.MODEL.T_MATM yh = new jyxcsjl2.MODEL.T_MATM())
            {
                //if (i == "最新")
                //{
                //    shift = yh.T_INSERT_DEVICE_FAULT.Where(t => t.RECORD_DATE == yh.T_INSERT_DEVICE_FAULT.Max(s => s.RECORD_DATE)).ToList();
                //    shiftSource.DataSource = shift;
                //    gridControl1.DataSource = shiftSource;
                //}
                //else
                //{
                 //   shift.Clear();
                 //   shiftSource.Clear();
                    shift = yh.T_INSERT_DEVICE_FAULT.Where(t => (t.RECORD_DATE > Begin_time && t.RECORD_DATE <= End_time)).OrderBy(t => t.RECORD_DATE).ToList();
                    shiftSource.DataSource = shift;
                    gridControl1.DataSource = shiftSource;
               // }
            }
        }

        private void GetData(string strStartDate, string strEndDate, string strWhere)
        {
            try
            {
                string strSQL = "";
                strSQL = " select * from T_INSERT_DEVICE_FAULT WHERE RECORD_DATE BETWEEN TO_DATE('" + strStartDate + "','yyyy-mm-dd hh24:mi:ss') AND TO_DATE('" + strEndDate + "','yyyy-mm-dd hh24:mi:ss')";
                if (strWhere != "")
                    strSQL += strWhere;
                strSQL += " ORDER BY RECORD_DATE ASC";
                DataTable dt = new DataTable();
                cls_public_main.ExecuteSelectSql_dt(strSQL, ref dt);
                gridControl1.DataSource = dt;
                gridView1.BestFitColumns();
            }
            catch { }
        }
        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            try
            {
                iFlag = 1;
                string begin = cls_public_main.sys_time();

                gridView1.SetFocusedRowCellValue("RECORD_DATE", begin);
                gridView1.SetFocusedRowCellValue("FAULT_STARTTIME", begin);
                gridView1.SetFocusedRowCellValue("FAULT_MADEMAN", cls_public_main.m_emp_name);
                gridView1.SetFocusedRowCellValue("FLAG", "0");
                gridView1.ShowEditForm();
            }
            catch (Exception ExFail)
            { MessageBox.Show(ExFail.Message); }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string strSQL = "select * from T_INSERT_DEVICE_FAULT where null=null";
                cls_public_main.ExecuteSelectSql_dt(strSQL, ref dt);
                DataRowView drv = (DataRowView)e.Row;
                DataRowState state = DataRowState.Unchanged;
                foreach (DataRow dr in drv.Row.Table.Rows)
                {
                    state = dr.RowState;
                    if (state == DataRowState.Added || state == DataRowState.Modified)
                    {
                        dt.ImportRow(dr);
                        break;
                    }
                }

                string strKey = dt.Rows[0]["RECORD_DATE"].ToString();
                if (state == DataRowState.Added)
                {
                    if (string.IsNullOrEmpty(dt.Rows[0]["FAULT_NAME"].ToString()))
                    {
                        MessageBox.Show("故障名称为空");
                    }
                    else if (string.IsNullOrEmpty(dt.Rows[0]["FAULT_MADEMAN"].ToString()))
                    {
                        MessageBox.Show("提出人为空");
                    }
                    else
                    {
                        dt.AcceptChanges();
                        int iRet = cls_public_main.InsertData(strSQL, dt);
                    }
                }
                else if (state == DataRowState.Modified)
                {
                    if (update.Equals("accept") && !gridView1.Columns["ACCEPTANCE_MAN"].OptionsColumn.ReadOnly && string.IsNullOrEmpty(dt.Rows[0]["ACCEPTANCE_MAN"].ToString()))
                    {
                        MessageBox.Show("受理人为空");
                    }
                    else if (update.Equals("confirm") && !gridView1.Columns["RECORDER"].OptionsColumn.ReadOnly && string.IsNullOrEmpty(dt.Rows[0]["RECORDER"].ToString()))
                    {
                        MessageBox.Show("确认人为空");
                    }
                    else
                    {
                        if (update.Equals("accept"))
                        {
                            strSQL = "update T_INSERT_DEVICE_FAULT set FLAG = '1',ACCEPTANCE_MAN = '" + dt.Rows[0]["ACCEPTANCE_MAN"].ToString() + "', ACCEPTANCE_TIME = to_date('" + dt.Rows[0]["ACCEPTANCE_TIME"].ToString() + "', 'yyyy/mm/dd hh24:mi:ss'),REMARK = '" + dt.Rows[0]["REMARK"].ToString() + "' where RECORD_DATE = to_date('" + strKey + "', 'yyyy/mm/dd hh24:mi:ss')";
                        }
                        else if (update.Equals("confirm"))
                        {
                            DateTime endTime = Convert.ToDateTime(dt.Rows[0]["FAULT_ENDTIME"].ToString());
                            DateTime startTime = Convert.ToDateTime(dt.Rows[0]["FAULT_STARTTIME"].ToString());
                            TimeSpan contime = endTime.Subtract(startTime);
                            strSQL = "update T_INSERT_DEVICE_FAULT set FLAG = '2',RECORDER = '" + dt.Rows[0]["RECORDER"].ToString() + "', FAULT_ENDTIME = to_date('" + dt.Rows[0]["FAULT_ENDTIME"].ToString() + "', 'yyyy/mm/dd hh24:mi:ss'), FAULT_ALLTIME = '" + Math.Round(contime.TotalMinutes).ToString() + "' ,REMARK = '" + dt.Rows[0]["REMARK"].ToString() + "' where RECORD_DATE = to_date('" + strKey + "', 'yyyy/mm/dd hh24:mi:ss')";
                        }
                        dt.AcceptChanges();
                        bool bRet = cls_public_main.SaveData(strSQL);
                    }

                    //int iRet = ConnectionORA.UpdateData(strSQL, dt);
                }
                gridView1.CloseEditor();

               
            }
            catch (Exception ExFail)
            {
                MessageBox.Show(ExFail.Message);
            }
            finally
            {
                GetData(this.dateTimePicker1.Value.ToString(), this.dateTimePicker2.Value.ToString(), "");
            }
        }

        private void gridView1_EditFormPrepared(object sender, EditFormPreparedEventArgs e)
        {
            try
            {
                if (iFlag == 1)
                {
                    (e.BindableControls["RECORD_DATE"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["FAULT_NAME"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = false;
                    (e.BindableControls["FAULT_STARTTIME"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = false;
                    (e.BindableControls["FAULT_MADEMAN"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = false;
                    (e.BindableControls["ACCEPTANCE_TIME"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["ACCEPTANCE_MAN"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["RECORDER"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["FAULT_ENDTIME"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["FAULT_ALLTIME"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["REMARK"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = false;
                }
                else if (iFlag == 2)
                {
                    (e.BindableControls["RECORD_DATE"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["FAULT_NAME"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["FAULT_STARTTIME"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["FAULT_MADEMAN"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["ACCEPTANCE_TIME"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = false;
                    (e.BindableControls["ACCEPTANCE_MAN"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = false;
                    (e.BindableControls["RECORDER"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["FAULT_ENDTIME"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["FAULT_ALLTIME"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["REMARK"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = false;
                }
                else if (iFlag == 3)
                {
                    (e.BindableControls["RECORD_DATE"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["FAULT_NAME"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["FAULT_STARTTIME"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["FAULT_MADEMAN"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["ACCEPTANCE_TIME"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["ACCEPTANCE_MAN"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["RECORDER"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = false;
                    (e.BindableControls["FAULT_ENDTIME"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = false;
                    (e.BindableControls["FAULT_ALLTIME"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = true;
                    (e.BindableControls["REMARK"] as DevExpress.XtraEditors.BaseEdit).ReadOnly = false;
                }
            }
            catch { }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.GetFocusedRowCellValue("ACCEPTANCE_MAN") != null && gridView1.GetFocusedRowCellValue("ACCEPTANCE_TIME").ToString() != "")
                {
                    MessageBox.Show("该故障已经受理！");
                    return;
                }
                iFlag = 2;
                string begin = cls_public_main.sys_time();
                gridView1.SetFocusedRowCellValue("ACCEPTANCE_TIME", begin);
                gridView1.ShowEditForm();
                update = "accept";
            }
            catch (Exception ExFail)
            { MessageBox.Show(ExFail.Message); }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.GetFocusedRowCellValue("ACCEPTANCE_MAN") == null || this.gridView1.GetFocusedRowCellValue("ACCEPTANCE_MAN").ToString() == "")
                {
                    MessageBox.Show("该故障还没有受理！");
                    return;
                }
                if (gridView1.GetFocusedRowCellValue("FAULT_ALLTIME") != null && gridView1.GetFocusedRowCellValue("FAULT_ALLTIME").ToString() != "")
                {
                    MessageBox.Show("该故障已经确认！");
                    return;
                }
                iFlag = 3;
                string begin = cls_public_main.sys_time();

                gridView1.SetFocusedRowCellValue("FAULT_ENDTIME", begin);
                DateTime start = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("FAULT_STARTTIME").ToString());
                DateTime end = Convert.ToDateTime(begin);
                TimeSpan contime = end.Subtract(start);
                gridView1.SetFocusedRowCellValue("FAULT_ALLTIME", Math.Round(contime.TotalMinutes).ToString());
                gridView1.SetFocusedRowCellValue("RECORDER", cls_public_main.m_emp_name);
                gridView1.ShowEditForm();
                update = "confirm";
            }
            catch (Exception ExFail)
            { MessageBox.Show(ExFail.Message); }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string path = cls_public_main.to_path();
                if (!"".Equals(path))
                {
                    gridView1.ExportToXls(path);
                }
            }
            catch (Exception ExFail)
            { MessageBox.Show(ExFail.Message); }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string strStartDate = dateTimePicker1.Value.ToString();
            string strEndDate = dateTimePicker2.Value.ToString();
            string strWhere = "";
            GetData(strStartDate, strEndDate, strWhere);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string strStartDate = dateTimePicker1.Value.ToString();
            string strEndDate = dateTimePicker2.Value.ToString();
            string strWhere = " and FAULT_ENDTIME is null";
            GetData(strStartDate, strEndDate, strWhere);
        }
    }
}
