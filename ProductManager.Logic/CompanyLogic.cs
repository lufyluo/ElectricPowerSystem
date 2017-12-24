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
            var company = _context.Companies.FirstOrDefault(item => item.Name == companyName);
            return company?.Id ?? 0;
        }

        public IList<Company> GetCompanys() {
            return _context.Companies.OrderBy(item => item.Name).ToList();
        }

        public int Add(IList<CompanyItem> companies) {
            foreach (var companyItem in companies) {
                if (string.IsNullOrEmpty(companyItem.Name.Trim(' '))) {
                    continue;
                }
                if (_context.Companies.FirstOrDefault(item => item.Name == companyItem.Name) != null) {
                    continue;
                }
                var company = new Company {
                    Name = companyItem.Name,
                    CreateTime = DateTime.Now,
                    ModifyTime = DateTime.Now
                };
                _context.Companies.Add(company);
            }
            _context.SaveChanges();
            return 1;
        }

        public bool Delete(IEnumerable<string> companyNames) {
            foreach (var companyName in companyNames) {
                var company = _context.Companies.FirstOrDefault(item => item.Name == companyName);
                if (company == null) {
                    continue;
                }
                _context.Companies.Remove(company);

                var electric = _context.Electrics.Where(item => item.CompanyId == company.Id);
                _context.Electrics.RemoveRange(electric);

                var cost = _context.Costs.Where(item => item.CompanyId == company.Id);
                _context.Costs.RemoveRange(cost);

                var profit = _context.Profits.Where(item => item.CompanyId == company.Id);
                _context.Profits.RemoveRange(profit);
            }
            _context.SaveChanges();
            return true;
        }
    }
}