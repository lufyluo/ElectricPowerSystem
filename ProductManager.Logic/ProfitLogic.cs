using System;
using System.Linq;
using ProductManager.Entity;
using ProductManager.Model.ItemModel;

namespace ProductManager.Logic {
    public class ProfitLogic {
        private readonly ProductManagerContext _context;
        public ProfitLogic() {
            _context = new ProductManagerContext();
        }

        public bool Add(ProfitItem profitItem) {
            var companyLogic = new CompanyLogic();
            var companyId = companyLogic.GetCompanyId(profitItem.CompanyName);
            var profit = _context.Profits.FirstOrDefault(item => item.CompanyId == companyId && item.Year == profitItem.Year && item.Month == profitItem.Month);
            if (profit != null) {
                profit.AssetsImpairmentLoss = profitItem.AssetsImpairmentLoss;
                profit.EngineeringAndLeasehold = profitItem.EngineeringAndLeasehold;
                profit.FinancialCost = profitItem.FinancialCost;
                profit.ProfitValue = profitItem.ProfitValue;
                profit.OtherCost = profitItem.OtherCost ;
                profit.TaxAndAdditional = profitItem.TaxAndAdditional ;
                profit.ThirdMaintenanceFee = profitItem.ThirdMaintenanceFee;
                profit.ModifyTime = DateTime.Now;
            }
            else {
                var entity = new Profit {
                    CompanyId = companyId,
                    Year = profitItem.Year,
                    Month = profitItem.Month,
                    AssetsImpairmentLoss = profitItem.AssetsImpairmentLoss,
                    EngineeringAndLeasehold = profitItem.EngineeringAndLeasehold,
                    FinancialCost = profitItem.FinancialCost,
                    ProfitValue = profitItem.ProfitValue,
                    OtherCost = profitItem.OtherCost,
                    TaxAndAdditional = profitItem.TaxAndAdditional,
                    ThirdMaintenanceFee = profitItem.ThirdMaintenanceFee,
                    CreateTime = DateTime.Now,
                    ModifyTime = DateTime.Now
                };
                _context.Profits.Add(entity);
            }
            _context.SaveChanges();
            return true;
        }
    }
}