using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jyxcsjl2.EQUIPMENT
{
    public partial class BF_FRM_EQUIPMENT_STD_DIG : Form
    {
        public BF_FRM_EQUIPMENT_STD_DIG()
        {
            InitializeComponent();
        }

        private OperateFlag flag;
        private string strId = "";

        public DialogResult ShowDialogEx(string strID, OperateFlag flag)
        {
            this.strId = strID;
            this.flag = flag;
            string strSql = "";
            if (flag == OperateFlag.Add)
            {

                strSql = " SELECT COUNT(*) AS CVAL FROM ORALTL2_ST.T_BASE_EQUIP_LOG_DETAIL_STD WHERE LOG_ID = '" + strID + "' ";
                DataTable dt = cls_public_main.GetData(strSql);
                string strValue = dt.Rows[0][0].ToString();
                strValue = (int.Parse(strValue) + 1).ToString();
                txtTagSeq.Text = strValue;
                txtLogId.Text = strID;
                txtLogId.ReadOnly = true;
                txtTagName.Text = strID + "_" + strValue.PadLeft(3, '0');
            }
            else
            {
                strSql = " SELECT * FROM ORALTL2_ST.T_BASE_EQUIP_LOG_DETAIL_STD WHERE ID = '" + strID + "' ";
                DataTable dt = cls_public_main.GetData(strSql);
                txtLogId.Text = dt.Rows[0]["LOG_ID"].ToString();
                txtLogId.ReadOnly = true;
                txtTagGroup.Text = dt.Rows[0]["TAG_GROUP"].ToString();
                txtTagName.Text = dt.Rows[0]["TAG_NAME"].ToString();
                txtTagDes.Text = dt.Rows[0]["TAG_DES"].ToString();
                txtLowerValue.Text = dt.Rows[0]["LOWERVALUE"].ToString();
                txtUpperValue.Text = dt.Rows[0]["UPPERVALUE"].ToString();
                txtUnit.Text = dt.Rows[0]["UNIT"].ToString();
                txtTagPlc.Text = dt.Rows[0]["TAG_PLC"].ToString();
                txtTagSeq.Text = dt.Rows[0]["TAG_SEQ"].ToString();
            }
            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "";
                if (flag == OperateFlag.Add)
                {
                    strSql = " INSERT INTO ORALTL2_ST.T_BASE_EQUIP_LOG_DETAIL_STD ( ";
                    strSql += " ID, LOG_ID, TAG_NAME,              ";
                    strSql += " TAG_DES, TAG_GROUP, LOWERVALUE,    ";
                    strSql += " UPPERVALUE, UNIT, TAG_PLC,         ";
                    strSql += " TAG_SEQ)                           ";
                    strSql += " VALUES( T_BASE_EQUIP_LOG_DETAILSTD_SEQ.nextval, ";
                    strSql += " '" + txtLogId.Text + "', ";
                    strSql += " '" + txtTagName.Text + "', ";
                    strSql += " '" + txtTagDes.Text + "', ";
                    strSql += " '" + txtTagGroup.Text + "', ";
                    strSql += " " + double.Parse(txtLowerValue.Text.Trim().Equals("") ? "0" : txtLowerValue.Text.Trim()) + ", ";
                    strSql += " " + double.Parse(txtUpperValue.Text.Trim().Equals("") ? "0" : txtUpperValue.Text.Trim()) + ", ";
                    strSql += " '" + txtUnit.Text + "', ";
                    strSql += " '" + txtTagPlc.Text.Trim() + "', ";
                    strSql += " '" + txtTagSeq.Text + "' ) ";
                    if (cls_public_main.SaveData(strSql))
                        this.DialogResult = DialogResult.OK;
                }
                else if (flag == OperateFlag.Modify)
                {
                    strSql = " UPDATE ORALTL2_ST.T_BASE_EQUIP_LOG_DETAIL_STD SET ";
                    strSql += " LOG_ID = '" + txtLogId.Text + "', ";
                    strSql += " TAG_NAME = '" + txtTagName.Text + "', ";
                    strSql += " TAG_DES = '" + txtTagDes.Text + "', ";
                    strSql += " TAG_GROUP = '" + txtTagGroup.Text + "', ";
                    strSql += " LOWERVALUE = " + double.Parse(txtLowerValue.Text.Trim().Equals("") ? "0" : txtLowerValue.Text.Trim()) + ", ";
                    strSql += " UPPERVALUE = " + double.Parse(txtUpperValue.Text.Trim().Equals("") ? "0" : txtUpperValue.Text.Trim()) + ", ";
                    strSql += " UNIT = '" + txtUnit.Text + "', ";
                    strSql += " TAG_PLC = '" + txtTagPlc.Text.Trim() + "', ";
                    strSql += " TAG_SEQ = '" + txtTagSeq.Text + "' ";
                    strSql += " WHERE  ID = " + strId;
                    if (cls_public_main.SaveData(strSql))
                        this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
