using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Entity;

namespace ProductManager.Logic {
    public class CompanyLogic
    {
        private readonly ProductManagerContext _context;
        public CompanyLogic()
        {
            _context=new ProductManagerContext();
        }

        public int GetCompanyId(string companyName) {
            var company = _context.Companys.FirstOrDefault(item => item.Name == companyName);
            return company?.Id ?? 0;
        }
    }
}
