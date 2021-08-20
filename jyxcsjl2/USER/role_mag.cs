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
    public partial class role_mag : UserControl
    {
        private string update, role;
        private bool bSkip = false;
        private List<MODEL.T_SYS_ROLE1> role_table = new List<MODEL.T_SYS_ROLE1>();
        private BindingSource role_source = new BindingSource();
        private List<MODEL.T_SYS_FUNCTION1> fun_table = new List<MODEL.T_SYS_FUNCTION1>();
        private BindingSource fun_source = new BindingSource();

        public role_mag()
        {
            InitializeComponent();
            cls_public_main.ButtonControl(this, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton2 }, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton4, simpleButton5 }, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton3 }, null, null);
        }

        public void select_role()
        {
            using (jyxcsjl2.MODEL.T_USER yh = new jyxcsjl2.MODEL.T_USER())
            {
                role_table.Clear();
                role_source.Clear();
                role_table = yh.T_SYS_ROLE1.OrderBy(t => t.ROLE_NAME).ToList();
                role_source.DataSource = role_table;
                gridControl1.DataSource = role_source;
            }
        }
        public void select_fun(string role_name)
        {
            using (jyxcsjl2.MODEL.T_USER yh = new jyxcsjl2.MODEL.T_USER())
            {
                fun_table.Clear();
                fun_source.Clear();

                var fun1 = yh.T_SYS_FUNCTION1.Where(t => (t.ROLE_NAME == "ROOT" && t.FUNCTION_CLASS_DEC == "0")).OrderBy(c => (c.FUNCTION_CODE)).ToList();
                fun1.ForEach(t => {
                    t.MODIFIED_DATE = null;
                    t.MODIFIED_PERSON = null;
                });
                var fun2 = yh.T_SYS_FUNCTION1.Where(p => (p.ROLE_NAME == role_name && p.FUNCTION_CLASS_DEC == "0")).OrderBy(c => (c.FUNCTION_CODE)).ToList();
                if (fun2.Count == 0)
                {
                    fun1.ForEach(t => {
                        t.FUNCTION_ADD = 1;
                        t.FUNCTION_DEL = 1;
                        t.FUNCTION_UPDATE = 1;
                        t.FUNCTION_QUERY = 1;
                        t.FUNCTION_SEND = 1;
                        t.FUNCTION_RECEIVE = 1;
                    });
                }
                fun_table = fun2.Union(fun1, new FunComparer()).ToList();
                fun_source.DataSource = fun_table;
                gridControl2.DataSource = fun_source;
            }
        }

        private void role_mag_Load(object sender, EventArgs e)
        {
            try
            {
                select_role();
                gridView2.OptionsBehavior.Editable = false;
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //查询
            try
            {
                select_role();
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
                string begin = cls_public_main.sys_time();
                gridView1.SetFocusedRowCellValue("MODIFIED_DATE", begin);
                gridView1.SetFocusedRowCellValue("MODIFIED_PERSON", cls_public_main.m_emp_name);
                select_fun("");
                gridView2.OptionsBehavior.Editable = true;
                gridView1.ShowEditForm();
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

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            //修改详情
            try
            {
                gridView2.OptionsBehavior.Editable = true;
                time = cls_public_main.sys_timeDateTime();
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

                        var row = gridView1.GetFocusedRow();
                        MODEL.T_SYS_ROLE1 bbb = (MODEL.T_SYS_ROLE1)row;
                        bbb.ROLE_NAME = role;
                        yh.Entry<MODEL.T_SYS_ROLE1>(bbb).State = EntityState.Deleted;
                        int iRet = yh.SaveChanges();
                        if (iRet > 0)
                        {
                            //yh.T_SYS_FUNCTION1.RemoveRange(yh.T_SYS_FUNCTION1.Where(t => t.ROLE_NAME == role));
                            //iRet = yh.SaveChanges();
                            //if(iRet > 0)
                            //    gridView1.DeleteSelectedRows();

                            string strSql = " DELETE FROM T_SYS_FUNCTION1 WHERE ROLE_NAME = '" + role + "' ";
                            if (cls_public_main.SaveData(strSql))
                                gridView1.DeleteSelectedRows();
                        }
                    }
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (!bSkip && gridView1.SelectedRowsCount > 0)
                {
                    role = gridView1.GetFocusedRowCellValue("ROLE_NAME").ToString();
                    select_fun(role);
                    gridView2.OptionsBehavior.Editable = false;
                }
                else bSkip = false;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                DateTime modif = cls_public_main.sys_timeDateTime();
                MODEL.T_SYS_ROLE1 Newrow = (MODEL.T_SYS_ROLE1)e.Row;
                if (update == "insert")
                {
                    using (jyxcsjl2.MODEL.T_USER yh = new jyxcsjl2.MODEL.T_USER())
                    {
                        Newrow.MODIFIED_DATE = modif;
                        Newrow.MODIFIED_PERSON = cls_public_main.m_emp_name;
                        yh.Entry<MODEL.T_SYS_ROLE1>(Newrow).State = EntityState.Added;
                        update = "update";
                        yh.SaveChanges();

                        DateTime time = cls_public_main.sys_timeDateTime();
                        fun_table.ForEach(x => x.ROLE_NAME = Newrow.ROLE_NAME);
                        fun_table.ForEach(x => x.MODIFIED_DATE = time);
                        fun_table.ForEach(x => x.MODIFIED_PERSON = cls_public_main.m_emp_name);
                        fun_table.ForEach(x => x.FUNCTION_FORM = "");
                        yh.T_SYS_FUNCTION1.AddRange(fun_table);
                        yh.SaveChanges();
                    }
                }
                else
                {
                    string strSql = " UPDATE T_SYS_ROLE1 SET ROLE_NAME = '" + Newrow.ROLE_NAME + "' WHERE ROLE_NAME = '" + role + "' ";
                    cls_public_main.SaveData(strSql);

                    strSql = " UPDATE T_SYS_FUNCTION1 SET ROLE_NAME = '" + Newrow.ROLE_NAME + "' WHERE ROLE_NAME = '" + role + "' ";
                    cls_public_main.SaveData(strSql);

                    strSql = " UPDATE T_SYS_USER1 SET USER_ROLE = '" + Newrow.ROLE_NAME + "' WHERE USER_ROLE = '" + role + "' ";
                    cls_public_main.SaveData(strSql);
                }
                gridView1.CloseEditor();
                gridView1.UpdateCurrentRow();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private DateTime time;

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "FUNCTION_ADD" ||
                    e.Column.FieldName == "FUNCTION_DEL" ||
                    e.Column.FieldName == "FUNCTION_UPDATE" ||
                    e.Column.FieldName == "FUNCTION_QUERY" ||
                    e.Column.FieldName == "FUNCTION_SEND" ||
                    e.Column.FieldName == "FUNCTION_RECEIVE")
                {
                    using (jyxcsjl2.MODEL.T_USER yh = new jyxcsjl2.MODEL.T_USER())
                    {
                        var row = gridView2.GetFocusedRow();
                        MODEL.T_SYS_FUNCTION1 obNew = (MODEL.T_SYS_FUNCTION1)row;
                        if (obNew.MODIFIED_DATE == null)
                        {
                            obNew.ROLE_NAME = role;
                            obNew.MODIFIED_DATE = time;
                            obNew.MODIFIED_PERSON = cls_public_main.m_emp_name;
                            obNew.FUNCTION_FORM = "";
                            yh.Entry<MODEL.T_SYS_FUNCTION1>(obNew).State = EntityState.Added;
                            int iRet = yh.SaveChanges();
                        }
                        else
                        {
                            obNew.MODIFIED_DATE = time;
                            obNew.MODIFIED_PERSON = cls_public_main.m_emp_name;
                            yh.Entry<MODEL.T_SYS_FUNCTION1>(obNew).State = EntityState.Modified;
                            int iRet = yh.SaveChanges();
                        }
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        class FunComparer : IEqualityComparer<MODEL.T_SYS_FUNCTION1>
        {
            bool IEqualityComparer<MODEL.T_SYS_FUNCTION1>.Equals(MODEL.T_SYS_FUNCTION1 x, MODEL.T_SYS_FUNCTION1 y)
            {
                return x.FUNCTION_CODE == y.FUNCTION_CODE;
            }

            int IEqualityComparer<MODEL.T_SYS_FUNCTION1>.GetHashCode(MODEL.T_SYS_FUNCTION1 obj)
            {
                return 0;
            }
        }
    }
}
