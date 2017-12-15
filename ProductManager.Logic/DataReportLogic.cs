using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net.Configuration;
using ProductManager.Entity;
using ProductManager.Model.ParamModel;
using ProductManager.Model.ViewModel;

namespace ProductManager.Logic {
    public class DataReportLogic {
        private readonly ProductManagerContext _context;

        public List<string> ElectricTargets = new List<string> {"发电量","购电量","购电均价","售电量","售电均价","线损"};

        public List<string> CostTargets = new List<string> { "职工福利费", "其它可控成本", "可控成本小计", "人工成本(不含福利费", "其它不可控成本", "其它不可控成本小计" };

        public List<string> ProfitTargets = new List<string> { "职工福利费", "其它可控成本", "可控成本小计", "人工成本(不含福利费", "其它不可控成本", "其它不可控成本小计" };


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

                            Salary = cost.Salary,
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
                            ProfitValue = pt.ProfitValue
                        };

            return query.ToList();
        }

        public IList<BudgetReportData> GetChartDatas(BaseParam baseParam) {
            if (baseParam.Year.HasValue && !baseParam.Month.HasValue && !baseParam.Quarter.HasValue) {
                if (ElectricTargets.Contains(baseParam.TargetKey)) {
                    return GetElectricChartDataByMonthDemssion(baseParam);
                }
                if (CostTargets.Contains(baseParam.TargetKey)) {
                    return GetCostChartDataByMonthDemssion(baseParam);
                }
            }
            return null;
        }


        public IList<BudgetReportData> GetElectricChartDataByMonthDemssion(BaseParam baseParam) {
            var electricQueryable = _context.Electrics.Where(item => item.Year == baseParam.Year.Value && item.Month != null);
            if (baseParam.CompanyId.HasValue) {
                electricQueryable = electricQueryable.Where(item => item.CompanyId == baseParam.CompanyId.Value);
            }
            var lst = electricQueryable.ToList();
            var budgetReportDatas = GetCharDataInfoOfMonth();
            foreach (var budgetReportData in budgetReportDatas) {
                var electric = lst.FirstOrDefault(item => item.Month == budgetReportData.Month);
                if (electric == null) {
                    continue;
                }
                budgetReportData.Electricity = electric.Electricity;
                budgetReportData.BuyElectricity = electric.BuyElectricity;
                budgetReportData.BuyAvgPrice = electric.BuyAvgPrice;
                budgetReportData.SellElectricity = electric.SellElectricity;
                budgetReportData.SellAvgPrice = electric.SellAvgPrice;
            }
            return budgetReportDatas;
        }

        public IList<BudgetReportData> GetCostChartDataByMonthDemssion(BaseParam baseParam) {
            var costsQueryable = _context.Costs.Where(item => item.Year == baseParam.Year.Value && item.Month != null);
            if (baseParam.CompanyId.HasValue) {
                costsQueryable = costsQueryable.Where(item => item.CompanyId == baseParam.CompanyId.Value);
            }
            var lst = costsQueryable.ToList();
            var budgetReportDatas = GetCharDataInfoOfMonth();
            foreach (var budgetReportData in budgetReportDatas) {
                var cost = lst.FirstOrDefault(item => item.Month == budgetReportData.Month);
                if (cost == null) {
                    continue;
                }
                budgetReportData.Salary = cost.Salary;
                budgetReportData.WorkersWelfare = cost.WorkersWelfare;
                budgetReportData.ControllableCost = cost.ControllableCost;
                budgetReportData.OtherControllableCost = cost.OtherControllableCost;
                budgetReportData.OtherUnControllableCost = cost.OtherUnControllableCost;
            }
            return budgetReportDatas;
        }

        private IList<BudgetReportData> GetCharDataInfoOfMonth() {
            var budgetReportDatas = new List<BudgetReportData>();
            for (var i = 1; i <= 12; i++) {
                var budgetReportData = new BudgetReportData { Month = i };
                budgetReportDatas.Add(budgetReportData);
            }
            return budgetReportDatas;
        }

        private double GetModelValue(string fieldName, object obj) {
            try {
                var type = obj.GetType();
                var propertyInfo = type.GetProperty(fieldName);
                if (propertyInfo == null) {
                    return 0;
                }
                var o = propertyInfo.GetValue(obj, null)?.ToString();
                double value;
                return double.TryParse(o, out value) ? value : 0;
            }
            catch {
                return 0;
            }
        }

    }
}