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
    public partial class BF_FRM_EQUIPMENT_INFO_DIG : Form
    {
        public BF_FRM_EQUIPMENT_INFO_DIG()
        {
            InitializeComponent();
        }

        private OperateFlag strFlag;
        private string strCodeID = "";

        public DialogResult ShowDialogEx(string strID, OperateFlag flag)
        {
            strCodeID = strID;
            strFlag = flag;
            
            if (flag == OperateFlag.Add)
            {
                string strSQL = "select * from ORALTL2_ST.T_BASE_EQUIP_INFO where CODE='" + strID + "'";
                DataTable dt = cls_public_main.GetData(strSQL);
                if (dt.Rows.Count > 0)
                {
                    txtParentID.Text = dt.Rows[0]["CODE"].ToString();
                    txtParentDes.Text = dt.Rows[0]["CODE_DES"].ToString();
                    txtCode.Text = dt.Rows[0]["CODE"].ToString() + "~";
                    txtParentID.Enabled = false;
                    txtParentDes.Enabled = false;
                }

                rbtImportFlag2.Checked = true;
            }
            else
            {
                txtParentID.Enabled = false;
                txtParentDes.Enabled = false;
                //txtCode.Enabled = false;
                //txtCodeDes.Enabled = false;
                //修改获取焦点行数据
                string strSQL = "select * from ORALTL2_ST.T_BASE_EQUIP_INFO where CODE='" + strID + "'";
                DataTable dt = cls_public_main.GetData(strSQL);
                txtCode.Text = dt.Rows[0]["CODE"].ToString();
                txtCodeDes.Text = dt.Rows[0]["CODE_DES"].ToString();
                txtParentID.Text = dt.Rows[0]["PARENT_ID"].ToString();
                txtParentDes.Text = dt.Rows[0]["PARENT_DES"].ToString();
                if (dt.Rows[0]["IMPORTANT_FALG"].ToString().Equals("是"))
                    rbtImportFlag1.Checked = true;
                else
                    rbtImportFlag2.Checked = true;
                txtTagNam.Text = dt.Rows[0]["TAG_NAME"].ToString();
            }
            return ShowDialog();
        }

        private void SetEnable()
        {
            //重点设备选‘是’
            if (rbtImportFlag1.Checked)
            {
                txtTagNam.Enabled = true;
            }
            else
            {
                txtTagNam.Enabled = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "";
                if (txtCode.Text.Trim().Contains("~"))
                {
                    MessageBox.Show("请检查CODE");
                    return;
                }
                if (strFlag == OperateFlag.Add)
                {
                    strSQL = "select * from ORALTL2_ST.T_BASE_EQUIP_INFO where CODE='" + txtParentID.Text.Trim() + "'";
                    DataTable dtTemp = cls_public_main.GetData(strSQL);
                    string strEquipID = "", strEquipDes = "";
                    if (dtTemp.Rows.Count == 1)
                    {
                        strEquipID = dtTemp.Rows[0]["EQUIP_ID"].ToString();
                        strEquipDes = dtTemp.Rows[0]["EQUIP_DES"].ToString();
                    }
                    DataTable dt = dtTemp.Clone();
                    DataRow dr = dt.NewRow();
                    dr["CODE"] = txtCode.Text.Trim();
                    dr["CODE_DES"] = txtCodeDes.Text.Trim();
                    dr["PARENT_ID"] = txtParentID.Text.Trim();
                    dr["PARENT_DES"] = txtParentDes.Text.Trim();
                    dr["EQUIP_ID"] = strEquipID.Equals("") ? txtCode.Text.Trim() : strEquipID + "/" + txtCode.Text.Trim();
                    dr["EQUIP_DES"] = strEquipDes.Equals("") ? txtCodeDes.Text.Trim() : strEquipDes + "/" + txtCodeDes.Text.Trim();
                    dr["IMPORTANT_FALG"] = rbtImportFlag1.Checked ? "是" : "否";
                    dr["TAG_NAME"] = rbtImportFlag1.Checked ? txtTagNam.Text.Trim() : "";
                    dr["EQUIP_SEQ"] = 0;
                    dr["CREATE_BY"] = cls_public_main.m_strUserName;
                    dr["CREATE_TIME"] = cls_public_main.sys_time();
                    dr["MODIFY_BY"] = "";
                    dr["MODIFY_TIME"] = "";
                    dt.Rows.Add(dr);
                    dt.AcceptChanges();
                    int iRet = cls_public_main.InsertData(strSQL, dt);
                    if (iRet > 0)
                        this.DialogResult = DialogResult.OK;
                    else
                        MessageBox.Show("添加失败");
                }
                else if (strFlag == OperateFlag.Modify)
                {
                    strSQL = "select * from ORALTL2_ST.T_BASE_EQUIP_INFO where CODE='" + txtParentID.Text.Trim() + "'";
                    DataTable dtTemp = cls_public_main.GetData(strSQL);
                    string strEquipID = "", strEquipDes = "";
                    if (dtTemp.Rows.Count == 1)
                    {
                        strEquipID = dtTemp.Rows[0]["EQUIP_ID"].ToString();
                        strEquipDes = dtTemp.Rows[0]["EQUIP_DES"].ToString();
                    }

                    strSQL = "select * from ORALTL2_ST.T_BASE_EQUIP_INFO where CODE='" + strCodeID + "'";
                    DataTable dt = cls_public_main.GetData(strSQL);
                    foreach (DataRow dr in dt.Rows)
                    {
                        dr["CODE"] = txtCode.Text.Trim();
                        dr["CODE_DES"] = txtCodeDes.Text.Trim();
                        dr["PARENT_ID"] = txtParentID.Text.Trim();
                        dr["PARENT_DES"] = txtParentDes.Text.Trim();
                        dr["EQUIP_ID"] = strEquipID.Equals("") ? txtCode.Text.Trim() : strEquipID + "/" + txtCode.Text.Trim();
                        dr["EQUIP_DES"] = strEquipDes.Equals("") ? txtCodeDes.Text.Trim() : strEquipDes + "/" + txtCodeDes.Text.Trim();
                        dr["IMPORTANT_FALG"] = rbtImportFlag1.Checked ? "是" : "否";
                        dr["TAG_NAME"] = rbtImportFlag1.Checked ? txtTagNam.Text.Trim() : "";
                        //dr["CREATE_BY"] = cls_public_main.m_strUserName;
                        //dr["CREATE_TIME"] = cls_public_main.sys_timeDateTime();
                        dr["MODIFY_BY"] = cls_public_main.m_strUserName;
                        dr["MODIFY_TIME"] = cls_public_main.sys_time();
                    }
                    //dt.AcceptChanges();
                    int iRet = cls_public_main.UpdateData(strSQL, dt);
                    if (iRet > 0)
                        if (!txtCode.Text.Trim().Equals(strCodeID))
                        {
                            strSQL = " UPDATE ORALTL2_ST.T_BASE_EQUIP_FAULT_STD SET ";
                            strSQL += " CODE = '" + txtCode.Text.Trim() + "', ";
                            strSQL += " CODE_DES = '" + txtCodeDes.Text.Trim() + "', ";
                            strSQL += " MODIFY_BY = '" + cls_public_main.m_strUserName + "', ";
                            strSQL += " MODIFY_TIME = TO_CHAR(SYSDATE,'YYYY-MM-DD HH24:MI:SS') ";
                            strSQL += " WHERE  CODE = " + strCodeID;
                            if (cls_public_main.SaveData(strSQL))
                                this.DialogResult = DialogResult.OK;
                            else MessageBox.Show("修改失败");
                        }
                        else this.DialogResult = DialogResult.OK;
                    else MessageBox.Show("修改失败");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Rbt_CheckedChanged(object sender, EventArgs e)
        {
            //根据条件设置Enable
            SetEnable();
        }
    }
}
