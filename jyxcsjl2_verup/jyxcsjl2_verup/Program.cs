using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jyxcsjl2_verup
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {    
            autoupdate update = new autoupdate();
            update.GetInfo();
            //主程序名称      
            string filename = Application.StartupPath + "\\" + "jyxcsjl2.exe";     //参数名称      
            string arg = "1";     //运行主程序         
            System.Diagnostics.Process fun = System.Diagnostics.Process.Start(filename, arg);
        }
    }
}
