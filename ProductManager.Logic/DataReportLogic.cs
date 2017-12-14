using System.Collections.Generic;
using System.Data;
using System.Linq;
using ProductManager.Entity;
using ProductManager.Model.ParamModel;
using ProductManager.Model.ViewModel;

namespace ProductManager.Logic {
    public class DataReportLogic {
        private readonly ProductManagerContext _context;

        public DataReportLogic() {
            _context = new ProductManagerContext();
        }
        public IList<BudgetReportData> GetBudgetReportData(BaseParam baseParam) {
            var companyQueryable = _context.Companies.Where(item => true);
            var costQueryable = _context.Costs.Where(item => true);
            var electricQueryable = _context.Electrics.Where(item => true);
            var profitQueryable = _context.Profits.Where(item => true);

            if (baseParam.CompanyId.HasValue) {
                companyQueryable = companyQueryable.Where(item => item.Id == baseParam.CompanyId.Value);
                costQueryable = costQueryable.Where(item => item.CompanyId == baseParam.CompanyId.Value);
                electricQueryable = electricQueryable.Where(item => item.CompanyId == baseParam.CompanyId.Value);
                profitQueryable = profitQueryable.Where(item => item.CompanyId == baseParam.CompanyId.Value);
            }
            if (baseParam.Year.HasValue) {
                costQueryable = costQueryable.Where(item => item.Year == baseParam.Year.Value);
                electricQueryable = electricQueryable.Where(item => item.Year == baseParam.Year.Value);
                profitQueryable = profitQueryable.Where(item => item.Year == baseParam.Year.Value);
            }

            if (baseParam.Month.HasValue) {
                costQueryable = costQueryable.Where(item => item.Month == baseParam.Month.Value);
                electricQueryable = electricQueryable.Where(item => item.Month == baseParam.Month.Value);
                profitQueryable = profitQueryable.Where(item => item.Month == baseParam.Month.Value);
            }

            if (baseParam.Quarter.HasValue) {
                costQueryable = costQueryable.Where(item => item.Month >= (1 + 3 * (baseParam.Quarter.Value - 1)) && item.Month <= baseParam.Quarter.Value * 3);
                electricQueryable = electricQueryable.Where(item => item.Month >= (1 + 3 * (baseParam.Quarter.Value - 1)) && item.Month <= baseParam.Quarter.Value * 3);
                profitQueryable = profitQueryable.Where(item => item.Month >= (1 + 3 * (baseParam.Quarter.Value - 1)) && item.Month <= baseParam.Quarter.Value * 3);
            }

            var query = from cy in companyQueryable
                        join ele in electricQueryable on cy.Id equals ele.CompanyId into tele
                        from tc in tele.DefaultIfEmpty()
                        join c in costQueryable on cy.Id equals c.CompanyId into tcost
                        from cost in tcost.DefaultIfEmpty()
                        join p in profitQueryable on cy.Id equals p.CompanyId into tp
                        from pt in tp.DefaultIfEmpty()
                        select new BudgetReportData() {
                            CompanyName = cy.Name,

                            Electricity = tc.Electricity,
                            BuyElectricity = tc.BuyElectricity,
                            BuyAvgPrice = tc.BuyAvgPrice,
                            SellElectricity = tc.SellElectricity,
                            SellAvgPrice = tc.SellAvgPrice,

                            Salary =cost.Salary,
                            WorkersWelfare = cost.WorkersWelfare,
                            ControllableCost = cost.ControllableCost,
                            OtherControllableCost = cost.OtherControllableCost,
                            OtherUnControllableCost = cost.OtherUnControllableCost,

                            ThirdMaintenanceFee = pt.ThirdMaintenanceFee,
                            EngineeringAndLeasehold = pt.EngineeringAndLeasehold,
                            OtherCost = pt.OtherCost,
                            TaxAndAdditional = pt.TaxAndAdditional,
                            FinancialCost = pt.FinancialCost,
                            AssetsImpairmentLoss = pt.AssetsImpairmentLoss,
                            ProfitValue = pt.ProfitValue,
                            CreateTime = pt.CreateTime,
                        };
        
            return query.ToList();
        }
    }
}