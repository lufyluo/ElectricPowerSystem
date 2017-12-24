using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.Controls;
using ProductManager.Controls.Common;
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
            VersionHelper.VersionHanlde(ConfigurationSettings.AppSettings["Version"]);
            Application.Run(new Login());
            //Application.Run(new TestForm());
        }
    }
}
