using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Entity
{
    public class User {
        public int Id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { set; get; }

        public DateTime ModifyTime { set; get; }
    }
}
