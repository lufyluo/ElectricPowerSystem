using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.Controls;
using ProductManager.Helper;

namespace ProductManager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CommonHelper.CopyDbFileToPublic();
            CommonHelper.SetFileAccess();
            Application.Run(new Login());
            //Application.Run(new TestForm());
        }
    }
}
