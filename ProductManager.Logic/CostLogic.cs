using System;
using ProductManager.Entity;
using ProductManager.Model.ItemModel;

namespace ProductManager.Logic {
    public class CostLogic {
        private readonly ProductManagerContext _context;
        public CostLogic() {
            _context = new ProductManagerContext();
        }

        public bool Add(CostItem item) {
            var entity = new Cost() {
                Year = item.Year,
                Month = item.Month,
                Salary = item.Salary,
                WorkersWelfare = item.WorkersWelfare,
                TotalCost = item.TotalCost,
                ControllableCost = item.ControllableCost,
                OtherControllableCost= item.ControllableCost - item.WorkersWelfare,
                OtherUnControllableCost = item.TotalCost - item.ControllableCost - item.Salary,
                CreateTime = DateTime.Now,
                ModifyTime = DateTime.Now
            };

            var companyLogic = new CompanyLogic();
            entity.CompanyId = companyLogic.GetCompanyId(item.CompanyName);
            _context.Costs.Add(entity);
            _context.SaveChanges();
            return true;
        }
    }
}