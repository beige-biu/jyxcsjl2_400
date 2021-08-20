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
    public partial class BF_FRM_EQUIPMENT_LOG : UserControl
    {
        private string strLogId;

        public BF_FRM_EQUIPMENT_LOG()
        {
            InitializeComponent();
            cls_public_main.ButtonControl(this, new List<SimpleButton> { btnAddLog, btnAddStd }, new List<SimpleButton> { btnModifyLog, btnModifyStd }, new List<SimpleButton> { btnDelLog, btnDelStd }, null, null);
        }

        private void SelectLog()
        {
            string strSql = " SELECT * FROM ORALTL2_ST.T_BASE_EQUIP_LOG ";
            DataTable dt = cls_public_main.GetData(strSql);
            gcLog.DataSource = dt;
        }

        private void SelectStd(string strLogID, string strCon)
        {
            string strSql = " SELECT * FROM ORALTL2_ST.T_BASE_EQUIP_LOG_DETAIL_STD WHERE LOG_ID = '" + strLogId + "' AND TAG_DES LIKE '%" + strCon + "%' ORDER BY TAG_SEQ ASC ";
            DataTable dt = cls_public_main.GetData(strSql);
            gcStd.DataSource = dt;
            gvStd.BestFitColumns();
        }

        private void BF_FRM_EQUIPMENT_LOG_Load(object sender, EventArgs e)
        {
            try
            {
                SelectLog();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnAddLog_Click(object sender, EventArgs e)
        {
            try
            {
                EQUIPMENT.BF_FRM_EQUIPMENT_LOG_DIG form = new EQUIPMENT.BF_FRM_EQUIPMENT_LOG_DIG();
                if (form.ShowDialogEx(null, OperateFlag.Add) == DialogResult.OK)
                {
                    MessageBox.Show("新增成功");
                    SelectLog();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnModifyLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvLog.SelectedRowsCount > 0)
                {
                    string id = gvLog.GetFocusedRowCellValue("ID").ToString();
                    EQUIPMENT.BF_FRM_EQUIPMENT_LOG_DIG form = new EQUIPMENT.BF_FRM_EQUIPMENT_LOG_DIG();
                    if (form.ShowDialogEx(id, OperateFlag.Modify) == DialogResult.OK)
                    {
                        MessageBox.Show("修改成功");
                        SelectLog();
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

        private void btnDelLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvLog.SelectedRowsCount > 0)
                {
                    string id = gvLog.GetFocusedRowCellValue("ID").ToString();
                    string logid = gvLog.GetFocusedRowCellValue("LOG_ID").ToString();
                    string text = gvLog.GetFocusedRowCellValue("LOG_DES").ToString();
                    if (MessageBox.Show("确定删除: " + text, "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        string strSql = " DELETE FROM ORALTL2_ST.T_BASE_EQUIP_LOG WHERE ID = '" + id + "' ";
                        if (cls_public_main.SaveData(strSql))
                        {
                            strSql = string.Format(" DELETE FROM ORALTL2_ST.T_BASE_EQUIP_LOG_DETAIL_STD WHERE LOG_ID = '{0}' ", logid);
                            if (cls_public_main.SaveData(strSql))
                            {
                                MessageBox.Show("删除成功");
                                SelectLog();
                            }
                            else MessageBox.Show("删除失败");
                        }
                        else MessageBox.Show("删除失败");
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

        private void btnQueryStd_Click(object sender, EventArgs e)
        {
            try
            {
                string strCon = tboxCondition.Text.Trim();
                SelectStd(strLogId, strCon);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnAddStd_Click(object sender, EventArgs e)
        {
            try
            {
                string id = gvLog.GetFocusedRowCellValue("LOG_ID").ToString();
                EQUIPMENT.BF_FRM_EQUIPMENT_STD_DIG form = new EQUIPMENT.BF_FRM_EQUIPMENT_STD_DIG();
                if (form.ShowDialogEx(id, OperateFlag.Add) == DialogResult.OK)
                {
                    MessageBox.Show("新增成功");
                    string strCon = tboxCondition.Text.Trim();
                    SelectStd(strLogId, strCon);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnModifyStd_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvStd.SelectedRowsCount > 0)
                {
                    string id = gvStd.GetFocusedRowCellValue("ID").ToString();
                    EQUIPMENT.BF_FRM_EQUIPMENT_STD_DIG form = new EQUIPMENT.BF_FRM_EQUIPMENT_STD_DIG();
                    if (form.ShowDialogEx(id, OperateFlag.Modify) == DialogResult.OK)
                    {
                        MessageBox.Show("修改成功");
                        string strCon = tboxCondition.Text.Trim();
                        SelectStd(strLogId, strCon);
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

        private void btnDelStd_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvStd.SelectedRowsCount > 0)
                {
                    string id = gvStd.GetFocusedRowCellValue("ID").ToString();
                    string text = gvStd.GetFocusedRowCellValue("TAG_DES").ToString();
                    if (MessageBox.Show("确定删除: " + text, "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        string strSql = " DELETE FROM ORALTL2_ST.T_BASE_EQUIP_LOG_DETAIL_STD WHERE ID = '" + id + "' ";
                        if (cls_public_main.SaveData(strSql))
                        {
                            MessageBox.Show("删除成功");
                            string strCon = tboxCondition.Text.Trim();
                            SelectStd(strLogId, strCon);
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

        private void gvLog_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gvLog.SelectedRowsCount > 0)
                {
                    strLogId = gvLog.GetFocusedRowCellValue("LOG_ID").ToString();
                    string strCon = tboxCondition.Text.Trim();
                    SelectStd(strLogId, strCon);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }

    /// <summary>
    /// 窗体打开状态
    /// </summary>
    public enum OperateFlag
    {
        Add, Modify
    }
}
