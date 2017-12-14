using ProductManager.Entity;
using ProductManager.Model.ItemModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductManager.Logic {

    public class CompanyLogic {
        private readonly ProductManagerContext _context;

        public CompanyLogic() {
            _context = new ProductManagerContext();
        }

        public int GetCompanyId(string companyName) {
            var company = _context.Companys.FirstOrDefault(item => item.Name == companyName);
            return company?.Id ?? 0;
        }

        public IList<Company> GetCompanys() {
            return _context.Companys.OrderBy(item => item.Name).ToList();
        }

        public int Add(IList<CompanyItem> companies) {
            foreach (var companyItem in companies) {
                if (_context.Companys.FirstOrDefault(item => item.Name == companyItem.Name) != null) {
                    continue;
                }
                var company = new Company {
                    Name = companyItem.Name,
                    CreateTime = DateTime.Now,
                    ModifyTime = DateTime.Now
                };
                _context.Companys.Add(company);
            }
            _context.SaveChanges();
            return 1;
        }
    }
}