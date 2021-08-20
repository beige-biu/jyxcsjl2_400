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
    public partial class BF_FRM_EQUIPMENT_FAULT_CODE_DIG : Form
    {
        public BF_FRM_EQUIPMENT_FAULT_CODE_DIG()
        {
            InitializeComponent();
        }

        private OperateFlag flag;
        private string strId = "";

        public DialogResult ShowDialogEx(string strID, OperateFlag flag)
        {
            strId = strID;
            this.flag = flag;
            if (flag == OperateFlag.Add)
            {
                //txtFaultType.Text = "T7";
            }
            else
            {
                string strSql = " SELECT * FROM ORALTL2_ST.T_BASE_EQUIP_FAULT_CODE WHERE ID = '" + strId + "' ";
                DataTable dt = cls_public_main.GetData(strSql);
                txtFaultType.Text = dt.Rows[0]["FAULT_TYPE"].ToString();
                txtFaultTypeDes.Text = dt.Rows[0]["FAULT_TYPE_DES"].ToString();
                txtFaultCode.Text = dt.Rows[0]["FAULT_CODE"].ToString();
                txtFaultCodeDes.Text = dt.Rows[0]["FAULT_CODE_DES"].ToString();
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
                    strSql = " INSERT INTO ORALTL2_ST.T_BASE_EQUIP_FAULT_CODE ( ";
                    strSql += " ID, FAULT_TYPE, FAULT_TYPE_DES,       ";
                    strSql += " FAULT_CODE, FAULT_CODE_DES, CREATE_BY,     ";
                    strSql += " CREATE_TIME, MODIFY_BY, MODIFY_TIME)  ";
                    strSql += " VALUES( T_BASE_EQUIP_FAULT_C_SEQ.nextval, ";
                    strSql += " '" + txtFaultType.Text + "', ";
                    strSql += " '" + txtFaultTypeDes.Text + "', ";
                    strSql += " '" + txtFaultCode.Text + "', ";
                    strSql += " '" + txtFaultCodeDes.Text + "', ";
                    strSql += " '" + cls_public_main.m_strUserName + "', ";
                    strSql += " TO_CHAR(SYSDATE,'YYYY-MM-DD HH24:MI:SS'), ";
                    strSql += " '', ";
                    strSql += " '' ) ";
                    if (cls_public_main.SaveData(strSql))
                        this.DialogResult = DialogResult.OK;
                }
                else if (flag == OperateFlag.Modify)
                {
                    strSql = " UPDATE ORALTL2_ST.T_BASE_EQUIP_FAULT_CODE SET ";
                    strSql += " FAULT_TYPE = '" + txtFaultType.Text + "', ";
                    strSql += " FAULT_TYPE_DES = '" + txtFaultTypeDes.Text + "', ";
                    strSql += " FAULT_CODE = '" + txtFaultCode.Text + "', ";
                    strSql += " FAULT_CODE_DES = '" + txtFaultCodeDes.Text + "', ";
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
