using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jyxcsjl2
{
    public partial class func_mag : UserControl
    {
        private string update, funCode;
        private bool bSkip = false;
        private List<MODEL.T_SYS_FUNCTION1> us = new List<MODEL.T_SYS_FUNCTION1>();
        private BindingSource usSource = new BindingSource();

        public func_mag()
        {
            InitializeComponent();
            cls_public_main.ButtonControl(this, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton2 }, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton4 }, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton3 }, null, null);
        }

        private void select()
        {
            string strCondition = txtCon.Text.Trim();
            string strClass = txtGrd.Text.Trim();
            using (jyxcsjl2.MODEL.T_USER yh = new jyxcsjl2.MODEL.T_USER())
            {
                us.Clear();
                usSource.Clear();
                us = yh.T_SYS_FUNCTION1.Where(t => (t.ROLE_NAME == "ROOT"
                && t.FUNCTION_CLASS_DEC.Contains(strClass)
                && t.FUNCTION_NAME.Contains(strCondition)))
                    .OrderBy(t => (t.FUNCTION_CODE)).ToList();
                usSource.DataSource = us;
                gridControl1.DataSource = usSource;
            }
        }

        private void func_mag_Load(object sender, EventArgs e)
        {
            try
            {
                select();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //查询
            try
            {
                select();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //添加
            try
            {
                update = "insert";
                bSkip = true;
                gridView1.AddNewRow();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                using (jyxcsjl2.MODEL.T_USER yh = new jyxcsjl2.MODEL.T_USER())
                {
                    var tt = yh.T_SYS_FUNCTION1.Where(t => t.FUNCTION_CODE == funCode).FirstOrDefault();
                    if (tt != null)
                    {
                        gridView1.SetFocusedRowCellValue("FUNCTION_CODE", tt.FUNCTION_CODE);
                        gridView1.SetFocusedRowCellValue("FUNCTION_NAME", tt.FUNCTION_NAME);
                        gridView1.SetFocusedRowCellValue("FUNCTION_DEC", tt.FUNCTION_DEC);
                        gridView1.SetFocusedRowCellValue("FUNCTION_CLASS_DEC", tt.FUNCTION_CLASS_DEC);
                        gridView1.SetFocusedRowCellValue("FUNCTION_FORM", tt.FUNCTION_FORM);
                    }
                    gridView1.SetFocusedRowCellValue("MODIFIED_DATE", cls_public_main.sys_time());
                    gridView1.SetFocusedRowCellValue("MODIFIED_PERSON", cls_public_main.m_emp_name);
                    gridView1.ShowEditForm();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //修改
            try
            {
                update = "update";
                gridView1.ShowEditForm();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //删除
            try
            {
                if (gridView1.SelectedRowsCount <= 0)
                {
                    MessageBox.Show("没有选中删除行，请查询要删除的数据删除");
                    return;
                }
                if (MessageBox.Show("你确定要删除选中的记录吗？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, 0, false) == DialogResult.Yes)
                {
                    using (jyxcsjl2.MODEL.T_USER yh = new jyxcsjl2.MODEL.T_USER())
                    {
                        //yh.T_SYS_FUNCTION1.RemoveRange(yh.T_SYS_FUNCTION1.Where(t => t.FUNCTION_CODE == funCode));
                        //int iRet = yh.SaveChanges();
                        //if (iRet > 0)
                        //    gridView1.DeleteSelectedRows();

                        string strSql = " DELETE FROM T_SYS_FUNCTION1 WHERE FUNCTION_CODE = '" + funCode + "' ";
                        if (cls_public_main.SaveData(strSql))
                            gridView1.DeleteSelectedRows();
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        
        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                MODEL.T_SYS_FUNCTION1 Newrow = new MODEL.T_SYS_FUNCTION1();
                Newrow = (MODEL.T_SYS_FUNCTION1)e.Row;
                Newrow.FUNCTION_CODE = Newrow.FUNCTION_CODE == null ? "" : Newrow.FUNCTION_CODE.Trim();
                Newrow.FUNCTION_NAME = Newrow.FUNCTION_NAME == null ? "" : Newrow.FUNCTION_NAME.Trim();
                Newrow.FUNCTION_DEC = Newrow.FUNCTION_DEC == null ? "" : Newrow.FUNCTION_DEC.Trim();
                Newrow.FUNCTION_CLASS_DEC = Newrow.FUNCTION_CLASS_DEC == null ? "" : Newrow.FUNCTION_CLASS_DEC;
                Newrow.FUNCTION_FORM = Newrow.FUNCTION_FORM == null ? "" : Newrow.FUNCTION_FORM.Trim();
                int iRet = -1;
                if (update == "insert")
                {
                    using (jyxcsjl2.MODEL.T_USER yh = new jyxcsjl2.MODEL.T_USER())
                    {
                        Newrow.ROLE_NAME = "ROOT";
                        yh.Entry<MODEL.T_SYS_FUNCTION1>(Newrow).State = EntityState.Added;
                        update = "update";
                        iRet = yh.SaveChanges();
                    }
                }
                else
                {
                    string strSql = "update T_SYS_FUNCTION1 set FUNCTION_FORM = '" + Newrow.FUNCTION_FORM + "', " +
                        "MODIFIED_DATE = SYSDATE, MODIFIED_PERSON = '" + cls_public_main.m_emp_name + "' " +
                        "where ROLE_NAME = 'ROOT' AND FUNCTION_CODE = '" + funCode + "'";
                    if (cls_public_main.SaveData(strSql))
                    {
                        strSql = "update T_SYS_FUNCTION1 " +
                            "set FUNCTION_CODE = '" + Newrow.FUNCTION_CODE + "'," +
                            "FUNCTION_NAME = '" + Newrow.FUNCTION_NAME + "'," +
                            "FUNCTION_DEC = '" + Newrow.FUNCTION_DEC + "'," +
                            "FUNCTION_CLASS_DEC = '" + Newrow.FUNCTION_CLASS_DEC + "' " +
                            "where FUNCTION_CODE = '" + funCode + "'";
                        if (cls_public_main.SaveData(strSql))
                            iRet = 1;
                    }
                }
                gridView1.CloseEditor();
                if (iRet > 0)
                    gridView1.UpdateCurrentRow();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (!bSkip && gridView1.SelectedRowsCount > 0)
                {
                    funCode = gridView1.GetFocusedRowCellValue("FUNCTION_CODE").ToString();
                }
                else bSkip = false;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
