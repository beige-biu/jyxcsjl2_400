using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace jyxcsjl2
{
    public partial class w_login : Form
    {
        public w_login()
        {
            InitializeComponent();
            //jyxcsjl2.MODEL.T_USER yh = new jyxcsjl2.MODEL.T_USER();
            //var dl = (from u in yh.T_SYS_USER
            //          join r in yh.T_SYS_ROLE on u.ROLE_ID equals r.ROLE_ID
            //          join y in yh.T_SYS_EMPLOYEE on u.EMPLOYEE_CODE equals y.EMPLOYEE_CODE
            //          select new
            //          {
            //              用户序号 = u.USER_ID,
            //              用户名 = u.USER_NAME,
            //              用户角色 = r.ROLE_NAME,
            //              员工工号 = y.EMPLOYEE_CODE,
            //              员工姓名 = y.EMPLOYEE_NAME,
            //              班组 = y.EMPLOYEE_TEAM,
            //              班次 = y.EMPLOYEE_SHIFTS,
            //              工序 = y.EMPLOYEE_WORKSTATION,
            //              //用户口令 = u.USER_PASSWORD,
            //          }).ToList();
            //lookUpEdit1.Properties.DataSource = dl;
            //lookUpEdit1.Properties.ValueMember = "用户序号";
            //lookUpEdit1.Properties.DisplayMember = "用户名";
            //lookUpEdit1.EditValue = 1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string userId = user.Text;
                using (jyxcsjl2.MODEL.T_USER yh = new jyxcsjl2.MODEL.T_USER())
                {
                    var dl = (from u in yh.T_SYS_USER1
                              join r in yh.T_SYS_ROLE1 on u.USER_ROLE equals r.ROLE_NAME
                              //join y in yh.T_SYS_EMPLOYEE on u.EMPLOYEE_CODE equals y.EMPLOYEE_CODE
                              where u.USER_ID == userId
                              select new
                              {
                                  用户名 = u.USER_NAME,
                                  用户角色 = r.ROLE_NAME,
                                  员工工号 = u.USER_ID,
                                  //员工工号 = y.EMPLOYEE_CODE,
                                  //员工姓名 = y.EMPLOYEE_NAME,
                                  //班组 = y.EMPLOYEE_TEAM,
                                  //工序 = y.EMPLOYEE_WORKSTATION,
                                  用户口令 = u.USER_PASSWORD
                              }).ToList();

                    if (dl.Count > 0)
                    {
                        string strPassword = dl[0].用户口令.ToString();
                        if (strPassword.Trim() == pass.Text.Trim())
                        {
                            cls_public_main.m_strUserName = dl[0].用户名.ToString();
                            cls_public_main.m_strUserID = dl[0].员工工号.ToString();
                            cls_public_main.m_strRoleName = dl[0].用户角色.ToString();
                            cls_public_main.login_time = cls_public_main.sys_timeDateTime().ToShortTimeString();
                            cls_public_main.m_emp = dl[0].员工工号.ToString();
                            cls_public_main.m_emp_name = dl[0].用户名.ToString();
                            cls_public_main.m_team = cls_public_main.get_team();
                            cls_public_main.m_strSHIFTID = cls_public_main.get_shift();
                            this.DialogResult = DialogResult.OK;
                            string strSql = "update T_SYS_USER1 set USER_LOGIN_DATE = sysdate where USER_NAME = '" + cls_public_main.m_strUserName + "'";
                            var result = yh.Database.SqlQuery<string>(strSql).FirstAsync();
                            yh.SaveChanges();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("用户或密码错误,请重新输入!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            pass.Text = "";
                            pass.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户或密码错误,请重新输入!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pass.Text = "";
                        pass.Focus();
                    }
                }
            }
            catch (Exception ExFail)
            {
                MessageBox.Show("登陆失败:" + ExFail.Message);
            }
        }

        private void w_login_Load(object sender, EventArgs e)
        {

            
            

        }

        
    }

       
    }
