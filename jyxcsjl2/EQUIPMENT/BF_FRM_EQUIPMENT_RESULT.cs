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
    public partial class BF_FRM_EQUIPMENT_RESULT : UserControl
    {
        private string strLogId;

        public BF_FRM_EQUIPMENT_RESULT()
        {
            InitializeComponent();
            cls_public_main.ButtonControl(this, null, new List<DevExpress.XtraEditors.SimpleButton> { btnModify }, null, null, null);
        }

        private void SelectLog()
        {
            string strSql = " SELECT * FROM ORALTL2_ST.T_BASE_EQUIP_LOG ";
            DataTable dt = cls_public_main.GetData(strSql);
            gcLog.DataSource = dt;
        }

        private void SelectDetail(string strLog, string strDate, string strShift)
        {
            string strSql = " SELECT * FROM ORALTL2_ST.T_BASE_EQUIP_LOG_DETAIL WHERE LOG_ID = '" + strLog + "' AND RECORD_DATE = '" + strDate + "' AND WORK_SHIFT = '" + strShift + "' ORDER BY TAG_NAME ASC ";
            DataTable dt = cls_public_main.GetData(strSql);
            gcDetail.DataSource = dt;
            gvDetail.BestFitColumns();
        }

        private void SelectResult(string strDate)
        {
            string strSql = " SELECT LOG_REMARK FROM ORALTL2_ST.T_BASE_EQUIP_LOG_RESULT WHERE TO_CHAR(RECORD_TIME + 1,'YYYY-MM-DD') = '" + strDate + "' ";
            DataTable dt = cls_public_main.GetData(strSql);
            if(dt.Rows.Count > 0)
            {
                txtResult.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                txtResult.Text = "";
            }
        }

        private void BF_FRM_EQUIPMENT_RESULT_Load(object sender, EventArgs e)
        {
            try
            {
                dtpDate.Value = cls_public_main.sys_timeDateTime().AddHours(4);
                cmbShift.SelectedIndex = 0;
                SelectLog();

                DevExpress.XtraGrid.StyleFormatCondition condition = new DevExpress.XtraGrid.StyleFormatCondition();
                condition.Appearance.BackColor = Color.LightPink;
                condition.Appearance.Options.UseBackColor = true;
                condition.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
                condition.Expression = "[TAG_STATUS] == '1'";
                condition.ApplyToRow = true;
                gvDetail.FormatConditions.Add(condition);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                SelectLog();
                SelectDetail(strLogId, dtpDate.Text, cmbShift.Text);
                SelectResult(dtpDate.Text);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = " UPDATE ORALTL2_ST.T_BASE_EQUIP_LOG_RESULT SET LOG_REMARK = '" + txtResult.Text + "' WHERE TO_CHAR(RECORD_TIME,'YYYY-MM-DD') = '" + dtpDate.Text + "' ";
                if (cls_public_main.SaveData(strSql))
                    MessageBox.Show("修改成功");
                else
                    MessageBox.Show("修改失败");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void gvLog_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                strLogId = gvLog.GetFocusedRowCellValue("LOG_ID").ToString();
                SelectDetail(strLogId, dtpDate.Text, cmbShift.Text);
                SelectResult(dtpDate.Text);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
