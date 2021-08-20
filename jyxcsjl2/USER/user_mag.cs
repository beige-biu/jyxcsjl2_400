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
    public partial class user_mag : UserControl
    {
        private string update, user_name;
        private List<MODEL.T_SYS_USER1> us = new List<MODEL.T_SYS_USER1>();
        private BindingSource usSource = new BindingSource();
        public user_mag()
        {
            InitializeComponent();
            combox_load();
            cls_public_main.ButtonControl(this, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton2 }, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton4 }, new List<DevExpress.XtraEditors.SimpleButton> { simpleButton3 }, null, null);
        }

        public void select()
        {
            using (jyxcsjl2.MODEL.T_USER yh = new jyxcsjl2.MODEL.T_USER())
            {
                us.Clear();
                usSource.Clear();
                us = yh.T_SYS_USER1.ToList();
                usSource.DataSource = us;
                gridControl1.DataSource = usSource;
            }
        }
        public void combox_load()
        {
            using (jyxcsjl2.MODEL.T_USER yh = new jyxcsjl2.MODEL.T_USER())
            {
                var empl = yh.T_BASE_CODE.Where(t => t.CODE_GROUP == "User_Status").Select(c => new
                {
                    职称 = c.CODE_DES,
                    编码 = c.CODE
                }).ToList();
                repositoryItemLookUpEdit1.DataSource = empl;
                repositoryItemLookUpEdit1.ValueMember = "编码";
                repositoryItemLookUpEdit1.DisplayMember = "职称";
                repositoryItemLookUpEdit1.NullText = "";

                var role = yh.T_SYS_ROLE1.Select(c => new
                {
                    角色名称 = c.ROLE_NAME,
                    角色描述 = c.ROLE_DEC
                }).ToList();
                repositoryItemLookUpEdit2.DataSource = role;
                repositoryItemLookUpEdit2.ValueMember = "角色名称";
                repositoryItemLookUpEdit2.DisplayMember = "角色名称";
                repositoryItemLookUpEdit2.NullText = "";
            }
        }

        private void user_mag_Load(object sender, EventArgs e)
        {
            try
            {
                select();
            }
            catch(Exception ex)
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
                gridView1.SetFocusedRowCellValue("MARK", "1");
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

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                using (jyxcsjl2.MODEL.T_USER yh = new jyxcsjl2.MODEL.T_USER())
                {

                    DateTime modif = cls_public_main.sys_timeDateTime();
                    MODEL.T_SYS_USER1 Newrow = new MODEL.T_SYS_USER1();
                    MODEL.T_SYS_USER1 Oldrow = new MODEL.T_SYS_USER1();
                    Newrow = (MODEL.T_SYS_USER1)e.Row;
                    Oldrow.USER_NAME = user_name;
                    if (update == "insert")
                    {
                        Newrow.MODIFIED_DATE = modif;
                        Newrow.MODIFIED_PERSON = cls_public_main.m_emp_name;
                        yh.Entry<MODEL.T_SYS_USER1>(Newrow).State = EntityState.Added;
                        update = "update";
                        yh.SaveChanges();
                    }
                    else
                    {
                        Oldrow.USER_NAME = user_name;
                        yh.Entry(Oldrow).State = EntityState.Deleted;
                        yh.SaveChanges();
                        Newrow.MODIFIED_DATE = modif;
                        Newrow.MODIFIED_PERSON = cls_public_main.m_emp_name;
                        yh.Entry(Newrow).State = EntityState.Added;
                        yh.SaveChanges();
                    }
                }
                gridView1.CloseEditor();
                gridView1.UpdateCurrentRow();
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
                        MODEL.T_SYS_USER1 bbb = (MODEL.T_SYS_USER1)row;
                        yh.Entry<MODEL.T_SYS_USER1>(bbb).State = EntityState.Deleted;
                        yh.SaveChanges();
                        gridView1.DeleteSelectedRows();
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void gridView1_EditFormShowing(object sender, DevExpress.XtraGrid.Views.Grid.EditFormShowingEventArgs e)
        {
            try
            {
                if (update != "insert")
                {
                    user_name = gridView1.GetFocusedRowCellValue("USER_NAME").ToString();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
