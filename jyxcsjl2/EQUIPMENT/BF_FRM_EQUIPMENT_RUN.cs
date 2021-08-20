using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jyxcsjl2
{
    public partial class BF_FRM_EQUIPMENT_RUN : UserControl
    {
        public BF_FRM_EQUIPMENT_RUN()
        {
            InitializeComponent();
        }

        private void initcombox()
        {
            using (jyxcsjl2.MODEL.T_USER yh = new jyxcsjl2.MODEL.T_USER())
            {
                var empl = yh.T_BASE_CODE.Where(t => t.CODE_GROUP == "Equip_Status").Select(c => new
                {
                    状态 = c.CODE_DES,
                    Value = c.CODE
                }).ToList();
                repositoryItemLookUpEdit1.DataSource = empl;
                repositoryItemLookUpEdit1.ValueMember = "Value";
                repositoryItemLookUpEdit1.DisplayMember = "状态";
                repositoryItemLookUpEdit1.NullText = "";
                repositoryItemLookUpEdit2.DataSource = empl;
                repositoryItemLookUpEdit2.ValueMember = "Value";
                repositoryItemLookUpEdit2.DisplayMember = "状态";
                repositoryItemLookUpEdit2.NullText = "";
            }
        }

        private void select1(string strStartTime, string strEndTime)
        {
            string strSql = " SELECT MAX(CODE_DES) AS TAGNAME,SUM(RUN_TIMR) AS TAGVALUE FROM ORALTL2_ST.T_BASE_EQUIP_RUN_STATISTICS WHERE ";
            strSql += " TO_CHAR(CREATE_TIME,'YYYY-MM-DD') BETWEEN '" + strStartTime + "' AND '" + strEndTime + "' GROUP BY CODE ORDER BY CODE ASC ";
            DataTable dt = cls_public_main.GetData(strSql);
            chartControl1.Series[0].ArgumentDataMember = "TAGNAME";
            chartControl1.Series[0].ValueDataMembers[0] = "TAGVALUE";
            chartControl1.Series[0].DataSource = dt;
        }

        private void select2()
        {
            string strSql = " SELECT CODE, CODE_DES, RUN_TIME01, RUN_TIME02, RUN_TIME03, RUN_TIME04, RUN_TIME05, RUN_TIME06, RUN_TIME07, ";
            strSql += " RUN_TIME08, RUN_TIME09, RUN_TIME10, RUN_TIME11, RUN_TIME12, RYN_YEAR FROM ORALTL2_ST.T_BASE_EQUIP_RUN_MONTH WHERE TO_CHAR(SYSDATE, 'YYYY') = RYN_YEAR ORDER BY CODE ASC ";
            DataTable dt = cls_public_main.GetData(strSql);
            gridControl1.DataSource = dt;
        }

        private void select3()
        {
            string strSql = " SELECT CODE,CODE_DES, STATUS, START_TIME, '0' AS CONTINUE_TIME FROM ORALTL2_ST.T_BASE_EQUIP_RUN WHERE END_TIME IS NULL ORDER BY CODE ASC ";
            DataTable dt = cls_public_main.GetData(strSql);
            DateTime time = cls_public_main.sys_timeDateTime();
            foreach (DataRow dr in dt.Rows)
            {
                DateTime startTime = DateTime.Now;
                try
                {
                    startTime = DateTime.Parse(dr["START_TIME"].ToString());
                }
                catch { }
                dr["CONTINUE_TIME"] = time.Subtract(startTime).TotalHours.ToString("N2");
            }
            gcEquipSMain.DataSource = dt;
            gvEquipSMain.BestFitColumns();
        }

        private void SelectRun(string strCode, string strStartTime, string strEndTime)
        {
            string strSql = " SELECT * FROM ORALTL2_ST.T_BASE_EQUIP_RUN WHERE CODE = '" + strCode + "' AND TO_CHAR(CREATE_TIME,'YYYY-MM-DD') BETWEEN  '" + strStartTime + "' AND '" + strEndTime + "' AND END_TIME IS NOT NULL ORDER BY CREATE_TIME DESC ";
            DataTable dt = cls_public_main.GetData(strSql);
            gcEquipRun.DataSource = dt;
        }

        private void SelectStatus(string strCode, string strStartTime, string strEndTime)
        {
            string strSql = " SELECT * FROM ORALTL2_ST.T_BASE_EQUIP_RUN_STATISTICS WHERE CODE = '" + strCode + "' AND TO_CHAR(CREATE_TIME,'YYYY-MM-DD') BETWEEN  '" + strStartTime + "' AND '" + strEndTime + "' ORDER BY CREATE_TIME DESC ";
            DataTable dt = cls_public_main.GetData(strSql);
            gcEquipStatus.DataSource = dt;
        }

        private void BF_FRM_EQUIPMENT_RUN_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime time = cls_public_main.sys_timeDateTime();
                int day = time.Day;
                if (day > 26)//每月第一天没值，第二天切换为当前月
                {
                    dtpStart.Value = time.AddDays(26 - time.Day);
                    dtpEnd.Value = time.AddMonths(1).AddDays(25 - time.Day);
                }
                else
                {
                    dtpStart.Value = time.AddMonths(-1).AddDays(26 - time.Day);
                    dtpEnd.Value = time.AddDays(25 - time.Day);
                }
                initcombox();
                btnQuery_Click(null, null);


                DevExpress.XtraGrid.StyleFormatCondition condition1 = new DevExpress.XtraGrid.StyleFormatCondition();
                condition1.Appearance.BackColor = Color.LavenderBlush;
                condition1.Appearance.Options.UseBackColor = true;
                condition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
                condition1.Expression = "[STATUS] == '0'";
                condition1.ApplyToRow = true;
                gvEquipSMain.FormatConditions.Add(condition1);

                DevExpress.XtraGrid.StyleFormatCondition condition2 = new DevExpress.XtraGrid.StyleFormatCondition();
                condition2.Appearance.BackColor = Color.Aquamarine;
                condition2.Appearance.Options.UseBackColor = true;
                condition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
                condition2.Expression = "[STATUS] == '1'";
                condition2.ApplyToRow = true;
                gvEquipSMain.FormatConditions.Add(condition2);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcEquip.SelectedIndex == 0)
                {
                    select1(dtpStart.Text, dtpEnd.Text);
                }
                else if (tcEquip.SelectedIndex == 1)
                {
                    select2();
                }
                else if (tcEquip.SelectedIndex == 2)
                {
                    select3();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void tcEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tcEquip.SelectedIndex == 0)
                {
                    select1(dtpStart.Text, dtpEnd.Text);
                }
                else if (tcEquip.SelectedIndex == 1)
                {
                    select2();
                }
                else if (tcEquip.SelectedIndex == 2)
                {
                    select3();
                }
            }
            catch { }
        }

        private void gvEquipSMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                string strCode = gvEquipSMain.GetFocusedRowCellValue("CODE").ToString();
                SelectRun(strCode, dtpStart.Text, dtpEnd.Text);
                SelectStatus(strCode, dtpStart.Text, dtpEnd.Text);
            }
            catch { }
        }
    }
}
