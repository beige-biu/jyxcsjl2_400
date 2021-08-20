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
    public partial class BF_FRM_EQUIPMENT_FAULTREST : UserControl
    {
        public BF_FRM_EQUIPMENT_FAULTREST()
        {
            InitializeComponent();
        }

        private void initcombox()
        {
            string strSql = " SELECT DISTINCT FAULT_TYPE,FAULT_TYPE_DES FROM ORALTL2_ST.T_BASE_EQUIP_FAULT_CODE ";
            DataTable dt = cls_public_main.GetData(strSql);
            repositoryItemLookUpEdit1.DataSource = dt;
            repositoryItemLookUpEdit1.ValueMember = "FAULT_TYPE";
            repositoryItemLookUpEdit1.DisplayMember = "FAULT_TYPE_DES";
            repositoryItemLookUpEdit1.NullText = "";            
        }

        private void select(string strStartTime, string strEndTime)
        {
            string strSql = " SELECT RECORD_TIME, WORK_SHIFT, WORK_TEAM, CODE, CODE_DES, ";
            strSql += " FAULT_ID, FAULT_DES, b.FAULT_CODE_DES as FAULT_CODE, START_TIME, END_TIME, a.FAULT_TYPE ";
            strSql += " FROM ORALTL2_ST.T_BASE_EQUIP_FAULT a ";
            strSql += " LEFT JOIN ORALTL2_ST.T_BASE_EQUIP_FAULT_CODE b ON a.FAULT_TYPE = b.FAULT_TYPE AND a.FAULT_CODE = b.FAULT_CODE ";
            strSql += " WHERE TO_CHAR(RECORD_TIME,'YYYY-MM-DD HH24:MI:SS') BETWEEN '" + strStartTime + "' AND '" + strEndTime + "' ";
            DataTable dt = cls_public_main.GetData(strSql);
            gcFAULTREST.DataSource = dt;
            gvFAULTREST.BestFitColumns();
        }

        private void BF_FRM_EQUIPMENT_FAULTREST_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime dtStart = DateTime.Now, dtEnd = DateTime.Now;
                cls_public_main.select_time(out dtStart, out dtEnd);
                dtpStart.Value = dtStart;
                dtpEnd.Value = dtEnd;
                initcombox();
                select(dtpStart.Text, dtpEnd.Text);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                select(dtpStart.Text, dtpEnd.Text);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (!"".Equals(path))
            {
                gcFAULTREST.ExportToXls(path);
            }
        }
    }
}
