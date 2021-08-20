using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jyxcsjl2
{
    public partial class w_main : DevExpress.XtraBars.TabForm
    {
        public w_main()
        {
            InitializeComponent();

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void w_main_Load(object sender, EventArgs e)
        {
            initForm();
            w_init();
        }
        private void w_init()
        {
            barStaticItem5.Caption = cls_public_main.m_strUserName;
            barStaticItem7.Caption = cls_public_main.m_emp_name;
            barStaticItem9.Caption = cls_public_main.m_team;
            barStaticItem11.Caption = cls_public_main.m_strSHIFTID;
            barStaticItem15.Caption = cls_public_main.login_time;

            home_main HOME = new home_main();
            HOME.Dock = DockStyle.Fill;
            tabFormPage1.ContentContainer.Controls.Add(HOME);
        }
        private void create_menu()
        { 
            using (jyxcsjl2.MODEL.T_USER yh = new jyxcsjl2.MODEL.T_USER())
            {
                decimal id = decimal.Parse(cls_public_main.m_strUserID.ToString());
                var ps = (from u in yh.T_SYS_USER
                      join r in yh.T_SYS_ROLE on u.ROLE_ID equals r.ROLE_ID
                      join y in yh.T_SYS_EMPLOYEE on u.EMPLOYEE_CODE equals y.EMPLOYEE_CODE
                      join f in yh.T_SYS_FUNCTION on r.ROLE_ID equals f.ROLE_ID
                      where u.USER_ID == id
                      select new
                      {
                          用户序号 = u.USER_ID,
                          用户名 = u.USER_NAME,
                          用户角色 = r.ROLE_NAME,
                          员工工号 = y.EMPLOYEE_CODE,
                          员工姓名 = y.EMPLOYEE_NAME,
                          班组 = y.EMPLOYEE_TEAM,
                          班次 = y.EMPLOYEE_SHIFTS,
                          工序 = y.EMPLOYEE_WORKSTATION,
                          用户口令 = u.USER_PASSWORD,
                          功能代码 = f.FUNCTION_CODE,
                          功能描述 = f.FUNCTION_DEC,
                          添加 = f.FUNCTION_ADD,
                          删除 = f.FUNCTION_DEL,
                          查询 = f.FUNCTION_QUERY,
                          保存 = f.FUNCTION_SAVE
                      }).ToList();
            }
        }

        private void barStaticItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "上料指令发送");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "上料指令发送";
                feeding_instructions browser = new feeding_instructions();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }
        private void barStaticItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //   TabFormControl.Container.Controls.Add(browser);
            //    browser.Dock = DockStyle.Fill;
            //   page.ContentContainer.Controls.Add(new BrowserNavigationControl());
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabFormControl1.Update();
            var b = tabFormControl1.Pages.Count(val => val.Text == "主抽风机运行实绩");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "主抽风机运行实绩";
                main_exhaust_fan browser = new main_exhaust_fan();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }
        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabFormControl1.Update();
            var b = tabFormControl1.Pages.Count(val => val.Text == "主抽风量单耗查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "主抽风量单耗查询";
                main_exhaust_fan_dh browser = new main_exhaust_fan_dh();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }
        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "风箱压力实绩查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "风箱压力实绩查询";
                bellows_operation_p browser = new bellows_operation_p();
                browser.win = "风箱压力";
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "风箱温度实绩查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "风箱温度实绩查询";
                bellows_operation_p browser = new bellows_operation_p();
                browser.win = "风箱温度";
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "配料仓位实际查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "配料仓位实际查询";
                hopper_position browser = new hopper_position();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }



        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "原料配比实际查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "原料配比实际查询";
                hopper_ratio browser = new hopper_ratio();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
            
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "烧结混合料物理检验");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "烧结混合料物理检验";
                mix_phy_inset browser = new mix_phy_inset();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "烧结运行实绩查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "烧结运行实绩查询";
                operational_olg browser = new operational_olg();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "烧结混匀配比查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "烧结混匀配比查询";
                insert_material_ratio browser = new insert_material_ratio();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "烧结受料信息");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "烧结受料信息";
                material_supply browser = new material_supply();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "原料小时累计查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "原料小时累计查询";
                hopper_sum browser = new hopper_sum();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "交接班信息");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "交接班信息";
                change_shift browser = new change_shift();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "烧结启停实际查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "烧结启停实际查询";
                device_start_stop browser = new device_start_stop();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "质量综合信息查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "质量综合信息查询";
                quaity_analyse browser = new quaity_analyse();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "混合运行实绩查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "混合运行实绩查询";
                mix_device browser = new mix_device();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "物料消耗单耗查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "物料消耗单耗查询";
                material_sum browser = new material_sum(); 
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "能源消耗实绩查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "能源消耗实绩查询";
                energy_team_consumption browser = new energy_team_consumption();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "料仓料种数据维护");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "料仓料种数据维护";
                material_metering_map browser = new material_metering_map();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barStaticItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            soft_upload upwin = new soft_upload();
            upwin.ShowDialog();
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var b = tabFormControl1.Pages.Count(val => val.Text == "产量指标综合查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "产量指标综合查询";
                team_yield browser = new team_yield();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "成本科目配置");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "成本科目配置";
                cost_title_config browser = new cost_title_config();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var b = tabFormControl1.Pages.Count(val => val.Text == "用户管理");
            //if (b == 0)
            //{
            //    tabFormControl1.AddNewPage();
            //    tabFormControl1.SelectedPage.Text = "用户管理";
            //    user_mag browser = new user_mag();
            //    browser.Dock = DockStyle.Fill;
            //    TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            //}
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var b = tabFormControl1.Pages.Count(val => val.Text == "成本核算报表");
            //if (b == 0)
            //{
            //    tabFormControl1.AddNewPage();
            //    tabFormControl1.SelectedPage.Text = "成本核算报表";
            //    cost_month browser = new cost_month();
            //    browser.Dock = DockStyle.Fill;
            //    TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            //}
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "高炉料仓料位查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "高炉料仓料位查询";
                hopper_position_gl browser = new hopper_position_gl();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "脱硫CEMS实绩查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "脱硫CEMS实绩查询";
                operationl_tuoliu_cems browser = new operationl_tuoliu_cems();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "脱硫氨站实绩查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "脱硫氨站实绩查询";
                operational_tuoliu_xtwd browser = new operational_tuoliu_xtwd();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "能源小时累计查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "能源小时累计查询";
                hopper_energer_sum browser = new hopper_energer_sum();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "中心值查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "中心值查询";
                operational_center browser = new operational_center();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "烧结生产日报查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "烧结生产日报查询";
                operational_scrb browser = new operational_scrb();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }

            
        }

        private void barButtonItem39_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "烧结矿供高炉总量查询");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "烧结矿供高炉总量查询";
                operational_yield_ggl browser = new operational_yield_ggl();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var b = tabFormControl1.Pages.Count(val => val.Text == "烧结物资代码新增");
            if (b == 0)
            {
                tabFormControl1.AddNewPage();
                tabFormControl1.SelectedPage.Text = "烧结物资代码新增";
                material_code_add browser = new material_code_add();
                browser.Dock = DockStyle.Fill;
                TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
            }
        }

        private void openControl(string caption, UserControl control)
        {
            try
            {
                tabFormControl1.Update();
                var b = tabFormControl1.Pages.Count(val => val.Text == caption);
                if (b == 0)
                {
                    tabFormControl1.AddNewPage();
                    tabFormControl1.SelectedPage.Text = caption;
                    control.Dock = DockStyle.Fill;
                    TabFormControl.SelectedPage.ContentContainer.Controls.Add(control);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "错误", MessageBoxButtons.OK);
            }
        }

        private void openBellowsControl(string caption)
        {
            try { 
                tabFormControl1.Update();
                var b = tabFormControl1.Pages.Count(val => val.Text == caption);
                if (b == 0)
                {
                    tabFormControl1.AddNewPage();
                    tabFormControl1.SelectedPage.Text = caption;
                    bellows_operation_p browser = new bellows_operation_p();
                    //风箱温度 风箱压力
                    browser.win = caption.Substring(0,4);
                    browser.Dock = DockStyle.Fill;
                    TabFormControl.SelectedPage.ContentContainer.Controls.Add(browser);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "错误", MessageBoxButtons.OK);
            }
        }

        private void openUploadForm()
        {
            soft_upload upwin = new soft_upload();
            upwin.ShowDialog();
        }

        private void barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //MessageBox.Show(e.Item.Caption, "text", MessageBoxButtons.OK);

                string strForm = rootData.Find(ob => (ob.FUNCTION_NAME == e.Item.Caption)).FUNCTION_FORM.Trim();
                Type type = Type.GetType("jyxcsjl2." + strForm);
                object control = Activator.CreateInstance(type);
                if (control is bellows_operation_p)
                    openBellowsControl(e.Item.Caption);
                else if (control is soft_upload)
                    openUploadForm();
                else
                    openControl(e.Item.Caption, control as UserControl);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "错误", MessageBoxButtons.OK);
            }
        }

        private List<MODEL.T_SYS_FUNCTION1> rootData; //所有的目录
        private DevExpress.XtraBars.BarButtonItem barButtonItem;
        private DevExpress.XtraBars.BarSubItem barSubItem;
        private int index = 9; //id计数
        private void initForm()
        {
            try
            {
                //((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();

                //获得所有目录，获得用户目录
                List<MODEL.T_SYS_FUNCTION1> userData;
                using (jyxcsjl2.MODEL.T_USER yh = new jyxcsjl2.MODEL.T_USER())
                {
                    rootData = yh.T_SYS_FUNCTION1.Where(t => (t.ROLE_NAME == "ROOT"))
                        .OrderBy(t => (t.FUNCTION_CODE)).ToList();
                    userData = yh.T_SYS_FUNCTION1.Where(t => (t.ROLE_NAME == cls_public_main.m_strRoleName && t.FUNCTION_QUERY == 1))
                        .OrderBy(t => (t.FUNCTION_CODE)).ToList();
                }
                //保存用户权限
                foreach (MODEL.T_SYS_FUNCTION1 ob in userData)
                {
                    string strForm = rootData.Find(t => t.FUNCTION_CODE == ob.FUNCTION_CODE).FUNCTION_FORM;
                    if (!string.IsNullOrEmpty(strForm))
                        ob.FUNCTION_FORM = strForm;
                }
                cls_public_main.userFunc = userData;
                //1#遍历一级（以编码为主）
                string curId = "00";
                string curName;
                foreach (var obj in userData)
                {
                    //2#判断当前一级是否存在，是跳过
                    if (obj.FUNCTION_CODE.Substring(0, 2) == curId)
                        continue;
                    //3#创建一级（通过用户目录获取一级）
                    curId = obj.FUNCTION_CODE.Substring(0, 2);
                    curName = rootData.Find(ob => (ob.FUNCTION_CODE == curId)).FUNCTION_NAME.Trim();
                    this.barSubItem = new DevExpress.XtraBars.BarSubItem();
                    this.barSubItem.Caption = curName;
                    this.barSubItem.Id = index;
                    this.barSubItem.Name = "barSubItem" + index;
                    this.tabFormControl1.Items.Add(this.barSubItem);
                    this.tabFormControl1.TitleItemLinks.Add(this.barSubItem);
                    index++;
                    //4#递归下级
                    openTitle(barSubItem, userData, curId, 1);
                }

                this.barButtonItem = new DevExpress.XtraBars.BarButtonItem();
                this.barButtonItem.Caption = "切换用户";
                this.barButtonItem.Id = index;
                this.barButtonItem.Name = "barButtonItem" + index;
                this.barButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemUser_ItemClick);
                this.tabFormControl1.Items.Add(this.barButtonItem);
                this.tabFormControl1.TitleItemLinks.Add(this.barButtonItem);
                ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "错误", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// 递归创建下级目录，确定下级是末级时终止
        /// </summary>
        /// <param name="curSubItem">当前item</param>
        /// <param name="table">用户所有目录</param>
        /// <param name="curName">当前id</param>
        /// <param name="curLev">当前级</param>
        private void openTitle(DevExpress.XtraBars.BarSubItem curSubItem, List<MODEL.T_SYS_FUNCTION1> userData, string curId, int curLev)
        {
            try
            {
                string curName;
                string subId = "99";
                //1#遍历用户权限
                foreach (var obj in userData)
                {
                    //2#去除已经创建的上级目录
                    if (obj.FUNCTION_CODE.Length <= curLev * 2)
                        continue;
                    //3#跳过非当前目录的下级
                    if (obj.FUNCTION_CODE.Substring(0, 2 * curLev) != curId)
                        continue;
                    //4#跳过已经创建下级
                    if (obj.FUNCTION_CODE.Substring(0, 2 * (curLev + 1)) == subId)
                        continue;
                    //5#创建下级
                    subId = obj.FUNCTION_CODE.Substring(0, 2 * (curLev + 1));
                    curName = rootData.Find(ob => (ob.FUNCTION_CODE == subId)).FUNCTION_NAME.Trim();
                    //6#判断末级
                    if (rootData.Exists(ob => (ob.FUNCTION_CODE == subId && ob.FUNCTION_CLASS_DEC == "0")))
                    {
                        this.barButtonItem = new DevExpress.XtraBars.BarButtonItem();
                        this.barButtonItem.Caption = curName;
                        this.barButtonItem.Id = index;
                        this.barButtonItem.Name = "barButtonItem" + index;
                        this.barButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ItemClick);
                        this.tabFormControl1.Items.Add(this.barButtonItem);
                        curSubItem.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem));
                        index++;
                        //递归结束
                    }
                    else
                    {
                        this.barSubItem = new DevExpress.XtraBars.BarSubItem();
                        this.barSubItem.Caption = curName;
                        this.barSubItem.Id = index;
                        this.barSubItem.Name = "barSubItem" + index;
                        this.tabFormControl1.Items.Add(this.barSubItem);
                        curSubItem.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem));
                        index++;
                        //7#递归下级
                        openTitle(barSubItem, userData, subId, curLev + 1);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "错误", MessageBoxButtons.OK);
            }
        }

        private void w_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (jyxcsjl2.MODEL.T_USER yh = new jyxcsjl2.MODEL.T_USER())
            {
                string strSql = "update T_SYS_USER1 set USER_QUIT_DATE = sysdate where USER_NAME = '" + cls_public_main.m_strUserName + "'";
                var result = yh.Database.SqlQuery<string>(strSql).FirstAsync();
                yh.SaveChanges();
            }
        }

        private void barButtonItemUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cls_public_main.bReStart = true;
            this.Close();
        }
    }
}
