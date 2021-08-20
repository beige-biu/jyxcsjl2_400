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
    public partial class BF_FRM_EQUIPMENT_FAULT_CODE : UserControl
    {
        public BF_FRM_EQUIPMENT_FAULT_CODE()
        {
            InitializeComponent();
            cls_public_main.ButtonControl(this, new List<SimpleButton> { btnAdd }, new List<SimpleButton> { btnModify }, new List<SimpleButton> { btnDel }, null, null);
        }

        private void select()
        {
            string strSql = " SELECT * FROM ORALTL2_ST.T_BASE_EQUIP_FAULT_CODE WHERE FAULT_TYPE_DES LIKE '%" + tboxCondition.Text.Trim() + "%' ";
            DataTable dt = cls_public_main.GetData(strSql);
            gcFault.DataSource = dt;
        }

        private void BF_FRM_EQUIPMENT_FAULT_CODE_Load(object sender, EventArgs e)
        {
            try
            {
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
                EQUIPMENT.BF_FRM_EQUIPMENT_FAULT_CODE_DIG form = new EQUIPMENT.BF_FRM_EQUIPMENT_FAULT_CODE_DIG();
                if (form.ShowDialogEx(null, OperateFlag.Add) == DialogResult.OK)
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
                if (gvFault.SelectedRowsCount > 0)
                {
                    string id = gvFault.GetFocusedRowCellValue("ID").ToString();
                    EQUIPMENT.BF_FRM_EQUIPMENT_FAULT_CODE_DIG form = new EQUIPMENT.BF_FRM_EQUIPMENT_FAULT_CODE_DIG();
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
                if (gvFault.SelectedRowsCount > 0)
                {
                    string id = gvFault.GetFocusedRowCellValue("ID").ToString();
                    string text = gvFault.GetFocusedRowCellValue("FAULT_CODE_DES").ToString();
                    if (MessageBox.Show("确定删除: " + text, "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        
                        string strSql = " DELETE FROM ORALTL2_ST.T_BASE_EQUIP_FAULT_CODE WHERE ID = '" + id + "' ";
                        if (cls_public_main.SaveData(strSql))
                        {
                            MessageBox.Show("删除成功");
                            select();
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

        private void btnExp_Click(object sender, EventArgs e)
        {
            try
            {
                string path = cls_public_main.to_path();
                if (!string.IsNullOrEmpty(path))
                    gvFault.ExportToXls(path);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
