using System;
using ProductManager.Entity;
using ProductManager.Model.ItemModel;

namespace ProductManager.Logic {
    public class ProfitLogic {
        private readonly ProductManagerContext _context;
        public ProfitLogic() {
            _context = new ProductManagerContext();
        }

        public bool Add(ProfitItem item) {
            var entity = new Profit {
                Year = item.Year,
                Month = item.Month,
                CompanyId = 1,
                AssetsImpairmentLoss = item.AssetsImpairmentLoss,
                EngineeringAndLeasehold = item.EngineeringAndLeasehold,
                FinancialCost = item.FinancialCost,
                ProfitValue = item.ProfitValue,
                OtherCost = item.OtherCost,
                TaxAndAdditional = item.TaxAndAdditional,
                ThirdMaintenanceFee = item.ThirdMaintenanceFee,
                CreateTime = DateTime.Now,
                ModifyTime = DateTime.Now
            };

            var companyLogic = new CompanyLogic();
            entity.CompanyId = companyLogic.GetCompanyId(item.CompanyName);
            _context.Profits.Add(entity);
            _context.SaveChanges();
            return true;
        }
    }
}