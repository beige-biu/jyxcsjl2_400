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
    public partial class BF_FRM_EQUIPMENT_LOG_DIG : Form
    {
        public BF_FRM_EQUIPMENT_LOG_DIG()
        {
            InitializeComponent();
        }

        private OperateFlag flag;
        private string strId = "",logId = "";

        public DialogResult ShowDialogEx(string strID, OperateFlag flag)
        {
            string strSql;
            strId = strID;
            this.flag = flag;
            if (flag == OperateFlag.Add)
            {
                txtUnitid.Text = "S6";
                strSql = " SELECT COUNT(*) AS CVAL FROM ORALTL2_ST.T_BASE_EQUIP_LOG_DETAIL_STD WHERE LOG_ID = '" + strID + "' ";
                DataTable dt = cls_public_main.GetData(strSql);
                string strValue = dt.Rows[0][0].ToString();
                strValue = (int.Parse(strValue) + 1).ToString();
                txtLogId.Text = "S6" + strValue.PadLeft(2, '0');
            }
            else
            {
                strSql = " SELECT * FROM ORALTL2_ST.T_BASE_EQUIP_LOG WHERE ID = '" + strId + "' ";
                DataTable dt = cls_public_main.GetData(strSql);
                txtUnitid.Text = dt.Rows[0]["UNITID"].ToString();
                txtLogId.Text = dt.Rows[0]["LOG_ID"].ToString();
                txtLogDes.Text = dt.Rows[0]["LOG_DES"].ToString();
                logId = txtLogId.Text;
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
                    strSql = " INSERT INTO ORALTL2_ST.T_BASE_EQUIP_LOG (ID, UNITID, LOG_ID, LOG_DES) ";
                    strSql += " VALUES(T_BASE_EQUIP_LOG_SEQ.nextval,'" + txtUnitid.Text + "','" + txtLogId.Text + "','" + txtLogDes.Text + "') ";
                    if (cls_public_main.SaveData(strSql))
                        this.DialogResult = DialogResult.OK;
                }
                else if (flag == OperateFlag.Modify)
                {
                    strSql = " UPDATE ORALTL2_ST.T_BASE_EQUIP_LOG SET ";
                    strSql += " UNITID = '" + txtUnitid.Text + "',   ";
                    strSql += " LOG_ID = '" + txtLogId.Text + "',   ";
                    strSql += " LOG_DES = '" + txtLogDes.Text + "'  ";
                    strSql += " WHERE  ID = " + strId;
                    if (cls_public_main.SaveData(strSql))
                        if (!txtLogId.Text.Trim().Equals(logId))
                        {
                            strSql = " UPDATE ORALTL2_ST.T_BASE_EQUIP_LOG_DETAIL_STD SET ";
                            strSql += " LOG_ID = '" + txtLogId.Text.Trim() + "' ";
                            strSql += " WHERE  LOG_ID = '" + logId + "' ";
                            if (cls_public_main.SaveData(strSql))
                                this.DialogResult = DialogResult.OK;
                            else MessageBox.Show("修改失败");
                        }
                        else this.DialogResult = DialogResult.OK;
                    else MessageBox.Show("修改失败");
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
