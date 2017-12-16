using System;
using System.Linq;
using ProductManager.Entity;
using ProductManager.Model.ItemModel;

namespace ProductManager.Logic {
    public class CostLogic {
        private readonly ProductManagerContext _context;
        public CostLogic() {
            _context = new ProductManagerContext();
        }

        public bool Add(CostItem costItem) {
            var companyLogic = new CompanyLogic();
            var companyId = companyLogic.GetCompanyId(costItem.CompanyName);
            var cost = _context.Costs.FirstOrDefault(item => item.CompanyId == companyId && item.Year==costItem.Year && item.Month==costItem.Month);
            if (cost != null) {
                cost.Salary = costItem.Salary;
                cost.WorkersWelfare = costItem.WorkersWelfare;
                cost.TotalCost = costItem.TotalCost;
                cost.ControllableCost = costItem.ControllableCost;
                cost.OtherControllableCost = costItem.ControllableCost - costItem.WorkersWelfare;
                cost.OtherUnControllableCost = costItem.TotalCost - costItem.ControllableCost - costItem.Salary;
                cost.ModifyTime = DateTime.Now;
            }
            else {
                var entity = new Cost() {
                    Year = costItem.Year,
                    Month = costItem.Month,
                    Salary = costItem.Salary,
                    WorkersWelfare = costItem.WorkersWelfare,
                    TotalCost = costItem.TotalCost,
                    ControllableCost = costItem.ControllableCost,
                    OtherControllableCost = costItem.ControllableCost - costItem.WorkersWelfare,
                    OtherUnControllableCost = costItem.TotalCost - costItem.ControllableCost - costItem.Salary,
                    CreateTime = DateTime.Now,
                    ModifyTime = DateTime.Now
                };
                entity.CompanyId = companyId;
                _context.Costs.Add(entity);
            }
            _context.SaveChanges();
            return true;
        }
    }
}