using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace jyxcsjl2
{
    public partial class BF_FRM_EQUIPMENT_INFO : UserControl
    {
        public BF_FRM_EQUIPMENT_INFO()
        {
            InitializeComponent();
            cls_public_main.ButtonControl(this, new List<SimpleButton> { btnAdd, btnAddFault }, new List<SimpleButton> { btnModify, btnModifyFault }, new List<SimpleButton> { btnDel, btnDelFault }, null, null);
        }

        private string strCode;

        private void initcombox()
        {
            string strSql = " SELECT DISTINCT FAULT_TYPE,FAULT_TYPE_DES FROM ORALTL2_ST.T_BASE_EQUIP_FAULT_CODE ";
            DataTable dt = cls_public_main.GetData(strSql);
            repositoryItemLookUpEdit1.DataSource = dt;
            repositoryItemLookUpEdit1.ValueMember = "FAULT_TYPE";
            repositoryItemLookUpEdit1.DisplayMember = "FAULT_TYPE_DES";
            repositoryItemLookUpEdit1.NullText = "";
        }

        private void select()
        {
            string strCondition = tboxCondition.Text.Trim();
            string strSql = " SELECT * FROM ORALTL2_ST.T_BASE_EQUIP_INFO ORDER BY CODE ASC ";
            if (!string.IsNullOrEmpty(strCondition))
                strSql = string.Format(" SELECT * FROM ORALTL2_ST.T_BASE_EQUIP_INFO WHERE CODE_DES LIKE '%{0}%' ORDER BY CODE ASC ", strCondition);
            DataTable dt = cls_public_main.GetData(strSql);
            dt.PrimaryKey = new DataColumn[] { dt.Columns["CODE"] };
            treeEquip.DataSource = dt;
            treeEquip.ExpandAll();
            treeEquip.BestFitColumns();
        }

        private void SelectFault()
        {
            string strCon = txtFaultCon.Text.Trim();
            string strSql = " SELECT * FROM ORALTL2_ST.T_BASE_EQUIP_FAULT_STD WHERE CODE = '" + strCode + "' AND FAULT_DES LIKE '%" + strCon + "%' ORDER BY FAULT_SEQ ";
            DataTable dt = cls_public_main.GetData(strSql);
            gcFault.DataSource = dt;
            gvFault.BestFitColumns();
        }

        private void BF_FRM_EQUIPMENT_INFO_Load(object sender, EventArgs e)
        {
            try
            {
                initcombox();
                select();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                select();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                EQUIPMENT.BF_FRM_EQUIPMENT_INFO_DIG form = new EQUIPMENT.BF_FRM_EQUIPMENT_INFO_DIG();
                if (form.ShowDialogEx(strCode, OperateFlag.Add) == DialogResult.OK)
                {
                    MessageBox.Show("新增成功");
                    select();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                int iRows = treeEquip.AllNodesCount;
                if (iRows > 0)
                {
                    DataRow dr = treeEquip.GetFocusedDataRow();
                    string id = dr["CODE"].ToString();
                    EQUIPMENT.BF_FRM_EQUIPMENT_INFO_DIG form = new EQUIPMENT.BF_FRM_EQUIPMENT_INFO_DIG();
                    if (form.ShowDialogEx(id, OperateFlag.Modify) == DialogResult.OK)
                    {
                        MessageBox.Show("修改成功");
                        select();
                    }
                }
                else
                {
                    MessageBox.Show("没有要修改的记录");
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                int iRows = treeEquip.AllNodesCount;
                if (iRows > 0)
                {
                    DataRow dr = treeEquip.GetFocusedDataRow();
                    string id = dr["CODE"].ToString();
                    //判断是否存在下级
                    string strTemp = dr["EQUIP_ID"].ToString();
                    string strSql = string.Format(" SELECT COUNT(*) FROM ORALTL2_ST.T_BASE_EQUIP_INFO WHERE EQUIP_ID LIKE '{0}%' ", strTemp);
                    DataTable dt = cls_public_main.GetData(strSql);
                    int iRet = int.Parse(dt.Rows[0][0].ToString());
                    if (iRet == 1)
                    {
                        string text = dr["CODE_DES"].ToString();
                        if (MessageBox.Show("确定删除: " + text, "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            strSql = string.Format(" DELETE FROM ORALTL2_ST.T_BASE_EQUIP_INFO WHERE CODE = '{0}' ", id);
                            if (cls_public_main.SaveData(strSql))
                            {
                                strSql = string.Format(" DELETE FROM ORALTL2_ST.T_BASE_EQUIP_FAULT_STD WHERE CODE = '{0}' ", id);
                                if (cls_public_main.SaveData(strSql))
                                {
                                    MessageBox.Show("删除成功");
                                    select();
                                }
                                else MessageBox.Show("删除失败");
                            }
                            else MessageBox.Show("删除失败");
                        }
                    }
                    else
                    {
                        MessageBox.Show("该记录存在下级，请先删除下级");
                    }
                }
                else
                {
                    MessageBox.Show("没有要删除的记录");
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            try
            {
                string path = cls_public_main.to_path();
                if (!string.IsNullOrEmpty(path))
                {
                    treeEquip.ExportToXls(path);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void treeEquip_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                DataRow dr = treeEquip.GetFocusedDataRow();
                strCode = dr["CODE"].ToString();
                label1.Text = dr["EQUIP_DES"].ToString();
                SelectFault();
            }
            catch { }
        }

        private void btnQueryFault_Click(object sender, EventArgs e)
        {
            try
            {
                SelectFault();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnAddFault_Click(object sender, EventArgs e)
        {
            try
            {
                EQUIPMENT.BF_FRM_EQUIPMENT_FAULT_DIG form = new EQUIPMENT.BF_FRM_EQUIPMENT_FAULT_DIG();
                if (form.ShowDialogEx(strCode, OperateFlag.Add) == DialogResult.OK)
                {
                    MessageBox.Show("新增成功");
                    SelectFault();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnModifyFault_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvFault.SelectedRowsCount > 0)
                {
                    string id = gvFault.GetFocusedRowCellValue("ID").ToString();
                    EQUIPMENT.BF_FRM_EQUIPMENT_FAULT_DIG form = new EQUIPMENT.BF_FRM_EQUIPMENT_FAULT_DIG();
                    if (form.ShowDialogEx(id, OperateFlag.Modify) == DialogResult.OK)
                    {
                        MessageBox.Show("修改成功");
                        SelectFault();
                    }
                }
                else
                {
                    MessageBox.Show("没有要修改的记录");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnDelFault_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvFault.SelectedRowsCount > 0)
                {
                    string id = gvFault.GetFocusedRowCellValue("ID").ToString();
                    string text = gvFault.GetFocusedRowCellValue("FAULT_DES").ToString();
                    if (MessageBox.Show("确定删除: " + text, "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        string strSql = " DELETE FROM ORALTL2_ST.T_BASE_EQUIP_FAULT_STD WHERE ID = '" + id + "' ";
                        if (cls_public_main.SaveData(strSql))
                        {
                            MessageBox.Show("删除成功");
                            SelectFault();
                        }
                        else
                            MessageBox.Show("删除失败");
                    }

                }
                else
                {
                    MessageBox.Show("没有要删除的记录");
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnExpFault_Click(object sender, EventArgs e)
        {
            try
            {
                string path = cls_public_main.to_path();
                if (!string.IsNullOrEmpty(path))
                {
                    gvFault.ExportToXls(path);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
