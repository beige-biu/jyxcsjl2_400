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
    public partial class BF_FRM_EQUIPMENT_FAULT_DIG : Form
    {
        public BF_FRM_EQUIPMENT_FAULT_DIG()
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

            strSql = " SELECT DISTINCT FAULT_TYPE,FAULT_TYPE_DES FROM ORALTL2_ST.T_BASE_EQUIP_FAULT_CODE ";
            DataTable dt = cls_public_main.GetData(strSql);
            cmbFaultType.DataSource = dt;
            cmbFaultType.DisplayMember = "FAULT_TYPE_DES";
            cmbFaultType.ValueMember = "FAULT_TYPE";
            txtCode.ReadOnly = true;
            txtCodeDes.ReadOnly = true;

            if (flag == OperateFlag.Add)
            {
                strSql = " SELECT * FROM ORALTL2_ST.T_BASE_EQUIP_INFO WHERE CODE = '" + strID + "' ";
                dt = cls_public_main.GetData(strSql);
                txtCode.Text = dt.Rows[0]["CODE"].ToString();
                txtCodeDes.Text = dt.Rows[0]["CODE_DES"].ToString();
                strSql = " SELECT COUNT(*) FROM ORALTL2_ST.T_BASE_EQUIP_FAULT_STD WHERE CODE = '" + strID + "' ";
                dt = cls_public_main.GetData(strSql);
                string strValue = dt.Rows[0][0].ToString();
                strValue = (int.Parse(strValue) + 1).ToString();
                txtFaultSeq.Text = strValue;
                txtFaultID.Text = strID + "_" + strValue.PadLeft(3, '0');
            }
            else
            {
                strSql = " SELECT * FROM ORALTL2_ST.T_BASE_EQUIP_FAULT_STD WHERE ID = '" + strID + "' ";
                dt = cls_public_main.GetData(strSql);
                txtCode.Text = dt.Rows[0]["CODE"].ToString();
                txtCodeDes.Text = dt.Rows[0]["CODE_DES"].ToString();
                txtFaultID.Text = dt.Rows[0]["FAULT_ID"].ToString();
                txtFaultDes.Text = dt.Rows[0]["FAULT_DES"].ToString();
                cmbFaultType.SelectedValue = dt.Rows[0]["FAULT_TYPE"].ToString();
                txtTagName.Text = dt.Rows[0]["TAG_NAME"].ToString();
                txtFaultSeq.Text = dt.Rows[0]["FAULT_SEQ"].ToString();
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
                    strSql = " INSERT INTO ORALTL2_ST.T_BASE_EQUIP_FAULT_STD( ";
                    strSql += " ID, CODE, CODE_DES, ";
                    strSql += " FAULT_ID, FAULT_DES, FAULT_TYPE, ";
                    strSql += " TAG_NAME, FAULT_SEQ, CREATE_BY, ";
                    strSql += " CREATE_TIME, MODIFY_BY, MODIFY_TIME) ";
                    strSql += " VALUES( T_BASE_EQUIP_FAULT_S_SEQ.nextval, ";
                    strSql += " '" + txtCode.Text + "', ";
                    strSql += " '" + txtCodeDes.Text + "', ";
                    strSql += " '" + txtFaultID.Text + "', ";
                    strSql += " '" + txtFaultDes.Text + "', ";
                    strSql += " '" + cmbFaultType.SelectedValue.ToString() + "', ";
                    strSql += " '" + txtTagName.Text.Trim() + "', ";
                    strSql += " '" + txtFaultSeq.Text + "', ";
                    strSql += " '" + cls_public_main.m_strUserName + "', ";
                    strSql += " TO_CHAR(SYSDATE,'YYYY-MM-DD HH24:MI:SS'), ";
                    strSql += " '', ";
                    strSql += " '' ) ";
                    if (cls_public_main.SaveData(strSql))
                        this.DialogResult = DialogResult.OK;
                }
                else if (flag == OperateFlag.Modify)
                {
                    strSql = " UPDATE ORALTL2_ST.T_BASE_EQUIP_FAULT_STD SET ";
                    strSql += " FAULT_ID = '" + txtFaultID.Text + "', ";
                    strSql += " FAULT_DES = '" + txtFaultDes.Text + "', ";
                    strSql += " FAULT_TYPE = '" + cmbFaultType.SelectedValue.ToString() + "', ";
                    strSql += " TAG_NAME = '" + txtTagName.Text.Trim() + "', ";
                    strSql += " FAULT_SEQ = '" + txtFaultSeq.Text + "', ";
                    strSql += " MODIFY_BY = '" + cls_public_main.m_strUserName + "', ";
                    strSql += " MODIFY_TIME = TO_CHAR(SYSDATE,'YYYY-MM-DD HH24:MI:SS') ";
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
