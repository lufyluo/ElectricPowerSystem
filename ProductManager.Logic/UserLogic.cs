using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Entity;

namespace ProductManager.Logic {
    public class UserLogic
    {
        private readonly ProductManagerContext _context;
        public UserLogic()
        {
            _context=new ProductManagerContext();
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string account, string password) {
            var user = _context.Users.FirstOrDefault(item => item.Account.Equals(account) && item.Password.Equals(password));
            return user != null;

        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Modify(string account, string password) {
            var user = _context.Users.FirstOrDefault(item => item.Account.Equals(account));
            if (user == null)
            {
                return false;
            }
            user.Password = password;
            user.ModifyTime=DateTime.Now;
            _context.SaveChanges();
            return true;
        }
    }
}
