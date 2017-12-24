using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Logic;
using ProductManager.Model.ViewModel;

namespace ProductManager.Controls.Common
{
    public  class VersionHelper
    {
        public static void VersionHanlde(string version)
        {
            if (CacheHelper.GetCache()!=null&&CacheHelper.GetCache().Version != version)
            {
                ResetPassword();
                ResetRememberData(version);
            } 
        }

        private static void ResetPassword()
        {
            new UserLogic().Modify("admin", "111");
            //new UserLogic().Modify("test1", "111");
            //new UserLogic().Modify("test2", "111");
            //new UserLogic().Modify("test3", "111");
            //new UserLogic().Modify("test4", "111");
            //new UserLogic().Modify("test5", "111");
            //new UserLogic().Modify("test6", "111");
            //new UserLogic().Modify("test7", "111");
            //new UserLogic().Modify("test8", "111");
            //new UserLogic().Modify("test9", "111");
            //new UserLogic().Modify("test10", "111");
        }

        private static void ResetRememberData(string version)
        {
            CacheHelper.SetCache(new FileCache()
            {
                IsRememberedAccount = false,
                Version = version,
                Account = "",
                Password = ""
            });
        }
    }
}
