using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Model.ItemModel;

namespace ProductManager.Model.ViewModel
{
    public class DateTimeSelect:DateTimeItem
    {
        public string Show 
        {
            get
            {
                var item = this.Year + "年";
                item += this.Month == null ? "" : this.Month + "月";
                return item;
            }
        }
    }
}
