using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace jyxcsjl2
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        { 
            if (args.Length == 0)//有参数输入，你还可以根据实际情况传入更多参数    
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-Hans");
                Application.EnableVisualStyles();
                // Application.SetCompatibleTextRenderingDefault(false);
                
                do
                {
                    cls_public_main.bReStart = false;
                    w_login login = new w_login();
                    if (DialogResult.OK == login.ShowDialog())
                    {
                        UserLookAndFeel.Default.SetSkinStyle("McSkin");
                        Application.Run(new w_main());
                    }
                }
                while (cls_public_main.bReStart);
            }
            else { MessageBox.Show("该二级系统不能从这里启动"); }
            
        }
    }
}
