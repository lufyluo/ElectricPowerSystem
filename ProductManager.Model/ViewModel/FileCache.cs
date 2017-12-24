using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Model.ViewModel
{
    [Serializable]
    public class FileCache:User
    {
        public string Version { get; set; }
        public bool IsRememberedAccount { get; set; }
    }
}
