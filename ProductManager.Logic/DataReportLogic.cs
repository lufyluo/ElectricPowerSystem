using ProductManager.Entity;
using ProductManager.Model.ParamModel;
using ProductManager.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductManager.Logic {

    public class DataReportLogic {
        private readonly ProductManagerContext _context;

        public List<string> ElectricTargets = new List<string> { "Electricity", "BuyElectricity", "BuyAvgPrice", "SellElectricity", "SellAvgPrice", "LineLoss", "Income", "ElectricityCost" };

        public List<string> CostTargets = new List<string> { "WorkersWelfare", "ControllableCost", "ControllableCostTotal", "Salary", "OtherUnControllableCost", "OtherUnControllableCostTotal" };

        public List<string> ProfitTargets = new List<string> { "ThirdMaintenanceFee", "EngineeringAndLeasehold", "OtherCost", "TaxAndAdditional", "FinancialCost", "AssetsImpairmentLoss", "ProfitValue" };

        public DataReportLogic() {
            _context = new ProductManagerContext();
        }

        public IList<BudgetReportData> GetBudgetReportData(BaseParam baseParam) {
            if (baseParam.Month.HasValue || baseParam.Quarter.HasValue) {
                return GetBudgetReportDataByMonth(baseParam);
            }
            return GetBudgetReportDataByYear(baseParam);
        }

        public IList<BudgetReportData> GetBudgetReportDataByMonth(BaseParam baseParam) {
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
                        join c in costQueryable on new { CompanyId = cy.Id, tc.Year, tc.Month } equals new { c.CompanyId, c.Year, c.Month } into tcost
                        from cost in tcost.DefaultIfEmpty()
                        join p in profitQueryable on new { CompanyId = cy.Id, tc.Year, tc.Month } equals new { p.CompanyId, p.Year, p.Month } into tp
                        from pt in tp.DefaultIfEmpty()
                        select new BudgetReportData {
                            CompanyName = cy.Name,
                            Year = tc.Year,
                            Month = tc.Month,

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

            var budgetReportDatas = GetBudgetReportDatas(query);
            return budgetReportDatas;
        }

        public IList<BudgetReportData> GetBudgetReportDataByYear(BaseParam baseParam) {
            var companyQueryable = _context.Companies.Where(item => true);
            var costQueryable = _context.Costs.Where(item => item.Month == null);
            var electricQueryable = _context.Electrics.Where(item => item.Month == null);
            var profitQueryable = _context.Profits.Where(item => item.Month == null);

            if (baseParam.CompanyId.HasValue) {
                companyQueryable = companyQueryable.Where(item => item.Id == baseParam.CompanyId.Value);
                costQueryable = costQueryable.Where(item => item.CompanyId == baseParam.CompanyId.Value);
                electricQueryable = electricQueryable.Where(item => item.CompanyId == baseParam.CompanyId.Value);
                profitQueryable = profitQueryable.Where(item => item.CompanyId == baseParam.CompanyId.Value);
            }
            if (baseParam.Year.HasValue) {
                costQueryable = costQueryable.Where(item => item.Year == baseParam.Year.Value );
                electricQueryable = electricQueryable.Where(item => item.Year == baseParam.Year.Value );
                profitQueryable = profitQueryable.Where(item => item.Year == baseParam.Year.Value);
            }
            var query = from cy in companyQueryable
                        join ele in electricQueryable on cy.Id equals ele.CompanyId into tele
                        from tc in tele.DefaultIfEmpty()
                        join c in costQueryable on new { CompanyId = cy.Id, tc.Year } equals new { c.CompanyId, c.Year } into tcost
                        from cost in tcost.DefaultIfEmpty()
                        join p in profitQueryable on new { CompanyId = cy.Id, tc.Year } equals new { p.CompanyId, p.Year } into tp
                        from pt in tp.DefaultIfEmpty()
                        select new BudgetReportData {
                            CompanyName = cy.Name,
                            Year = tc.Year,

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

            var budgetReportDatas = GetBudgetReportDatas(query);
            return budgetReportDatas;
        }

        private static List<BudgetReportData> GetBudgetReportDatas(IQueryable<BudgetReportData> query) {
            var budgetReportDatas = query.ToList()
                .GroupBy(item => item.CompanyName)
                .Select(g => new BudgetReportData {
                    CompanyName = g.Key,

                    Electricity = g.Sum(x => x.Electricity),
                    BuyElectricity = g.Sum(x => x.BuyElectricity),
                    BuyAvgPrice = g.Sum(x => x.BuyAvgPrice),
                    SellElectricity = g.Sum(x => x.SellElectricity),
                    SellAvgPrice = g.Sum(x => x.SellAvgPrice),

                    Salary = g.Sum(x => x.Salary),
                    WorkersWelfare = g.Sum(x => x.WorkersWelfare),
                    ControllableCost = g.Sum(x => x.ControllableCost),
                    OtherControllableCost = g.Sum(x => x.OtherControllableCost),
                    OtherUnControllableCost = g.Sum(x => x.OtherUnControllableCost),

                    ThirdMaintenanceFee = g.Sum(x => x.ThirdMaintenanceFee),
                    EngineeringAndLeasehold = g.Sum(x => x.EngineeringAndLeasehold),
                    OtherCost = g.Sum(x => x.OtherCost),
                    TaxAndAdditional = g.Sum(x => x.TaxAndAdditional),
                    FinancialCost = g.Sum(x => x.FinancialCost),
                    AssetsImpairmentLoss = g.Sum(x => x.AssetsImpairmentLoss),
                    ProfitValue = g.Sum(x => x.ProfitValue),
                })
                .OrderBy(item => item.CompanyName)
                .ToList();

            SetTotalRow(budgetReportDatas);

            return budgetReportDatas;
        }

        private static void SetTotalRow(List<BudgetReportData> budgetReportDatas) {
            if (budgetReportDatas.Count <= 1) {
                return;
            }
            var totalBudgetReportData = budgetReportDatas.GroupBy(item => true)
                .Select(g => new BudgetReportData {
                    CompanyName = "全州公司合计",

                    Electricity = g.Sum(x => x.Electricity),
                    BuyElectricity = g.Sum(x => x.BuyElectricity),
                    BuyAvgPrice = g.Sum(x => x.BuyAvgPrice),
                    SellElectricity = g.Sum(x => x.SellElectricity),
                    SellAvgPrice = g.Sum(x => x.SellAvgPrice),

                    Salary = g.Sum(x => x.Salary),
                    WorkersWelfare = g.Sum(x => x.WorkersWelfare),
                    ControllableCost = g.Sum(x => x.ControllableCost),
                    OtherControllableCost = g.Sum(x => x.OtherControllableCost),
                    OtherUnControllableCost = g.Sum(x => x.OtherUnControllableCost),

                    ThirdMaintenanceFee = g.Sum(x => x.ThirdMaintenanceFee),
                    EngineeringAndLeasehold = g.Sum(x => x.EngineeringAndLeasehold),
                    OtherCost = g.Sum(x => x.OtherCost),
                    TaxAndAdditional = g.Sum(x => x.TaxAndAdditional),
                    FinancialCost = g.Sum(x => x.FinancialCost),
                    AssetsImpairmentLoss = g.Sum(x => x.AssetsImpairmentLoss),
                    ProfitValue = g.Sum(x => x.ProfitValue),
                })
                .FirstOrDefault();
            budgetReportDatas.Add(totalBudgetReportData);
        }

        public IList<BudgetReportData> GetChartDatas(BaseParam baseParam) {
            //看某个12个月的数据
            if (baseParam.Year.HasValue && !baseParam.Month.HasValue && !baseParam.Quarter.HasValue) {
                if (ElectricTargets.Contains(baseParam.TargetKey)) {
                    return GetElectricChartDataByMonthDemssion(baseParam);
                }
                if (CostTargets.Contains(baseParam.TargetKey)) {
                    return GetCostChartDataByMonthDemssion(baseParam);
                }

                if (ProfitTargets.Contains(baseParam.TargetKey)) {
                    return GetProfitChartDataByMonthDemssion(baseParam);
                }
            }
            //看每年的某个月的数据
            if (!baseParam.Year.HasValue && baseParam.Month.HasValue) {
                if (ElectricTargets.Contains(baseParam.TargetKey)) {
                    return GetElectricChartDataByYearAndMonthDemssion(baseParam);
                }
                if (CostTargets.Contains(baseParam.TargetKey)) {
                    return GetCostChartDataByYearAndMonthDemssion(baseParam);
                }

                if (ProfitTargets.Contains(baseParam.TargetKey)) {
                    return GetProfitChartDataByYearAndMonthDemssion(baseParam);
                }
            }

            //看每年某个季度的数据
            if (!baseParam.Year.HasValue && baseParam.Quarter.HasValue) {
                if (ElectricTargets.Contains(baseParam.TargetKey)) {
                    return GetElectricChartDataByYearAndQuarterDemssion(baseParam);
                }
                if (CostTargets.Contains(baseParam.TargetKey)) {
                    return GetCostChartDataByYearAndQuarterDemssion(baseParam);
                }

                if (ProfitTargets.Contains(baseParam.TargetKey)) {
                    return GetProfitChartDataByYearAndQuarterDemssion(baseParam);
                }
            }
            return null;
        }

        #region 看某个12个月的数据

        private IList<BudgetReportData> GetElectricChartDataByMonthDemssion(BaseParam baseParam) {
            var electricQueryable = _context.Electrics.Where(item => item.Year == baseParam.Year.Value && item.Month != null);
            if (baseParam.CompanyId.HasValue) {
                electricQueryable = electricQueryable.Where(item => item.CompanyId == baseParam.CompanyId.Value);
            }
            var lst = electricQueryable.GroupBy(item => item.Month).Select(item => new {
                Month = item.Key,
                Electricity = item.Sum(x => x.Electricity),
                BuyElectricity = item.Sum(x => x.BuyElectricity),
                BuyAvgPrice = item.Sum(x => x.BuyAvgPrice),
                SellElectricity = item.Sum(x => x.SellElectricity),
                SellAvgPrice = item.Sum(x => x.SellAvgPrice)
            }).ToList();
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

        private IList<BudgetReportData> GetCostChartDataByMonthDemssion(BaseParam baseParam) {
            var costsQueryable = _context.Costs.Where(item => item.Year == baseParam.Year.Value && item.Month != null);
            if (baseParam.CompanyId.HasValue) {
                costsQueryable = costsQueryable.Where(item => item.CompanyId == baseParam.CompanyId.Value);
            }
            var lst = costsQueryable.GroupBy(item => item.Month).Select(item => new {
                Month = item.Key,
                Salary = item.Sum(x => x.Salary),
                WorkersWelfare = item.Sum(x => x.WorkersWelfare),
                ControllableCost = item.Sum(x => x.ControllableCost),
                OtherControllableCost = item.Sum(x => x.OtherControllableCost),
                OtherUnControllableCost = item.Sum(x => x.OtherUnControllableCost)
            }).ToList();
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

        private IList<BudgetReportData> GetProfitChartDataByMonthDemssion(BaseParam baseParam) {
            var profitsQueryable = _context.Profits.Where(item => item.Year == baseParam.Year.Value && item.Month != null);
            if (baseParam.CompanyId.HasValue) {
                profitsQueryable = profitsQueryable.Where(item => item.CompanyId == baseParam.CompanyId.Value);
            }
            var lst = profitsQueryable.GroupBy(item => item.Month).Select(item => new {
                Month = item.Key,
                ThirdMaintenanceFee = item.Sum(x => x.ThirdMaintenanceFee),
                EngineeringAndLeasehold = item.Sum(x => x.EngineeringAndLeasehold),
                OtherCost = item.Sum(x => x.OtherCost),
                TaxAndAdditional = item.Sum(x => x.TaxAndAdditional),
                FinancialCost = item.Sum(x => x.FinancialCost),
                AssetsImpairmentLoss = item.Sum(x => x.AssetsImpairmentLoss),
                ProfitValue = item.Sum(x => x.ProfitValue)
            }).ToList();
            var budgetReportDatas = GetCharDataInfoOfMonth();
            foreach (var budgetReportData in budgetReportDatas) {
                var cost = lst.FirstOrDefault(item => item.Month == budgetReportData.Month);
                if (cost == null) {
                    continue;
                }
                budgetReportData.ThirdMaintenanceFee = cost.ThirdMaintenanceFee;
                budgetReportData.EngineeringAndLeasehold = cost.EngineeringAndLeasehold;
                budgetReportData.OtherCost = cost.OtherCost;
                budgetReportData.TaxAndAdditional = cost.TaxAndAdditional;
                budgetReportData.FinancialCost = cost.FinancialCost;
                budgetReportData.AssetsImpairmentLoss = cost.AssetsImpairmentLoss;
                budgetReportData.ProfitValue = cost.ProfitValue;
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

        #endregion 看某个12个月的数据

        #region 看每年的某个月的数据

        private IList<BudgetReportData> GetElectricChartDataByYearAndMonthDemssion(BaseParam baseParam) {
            var electricQueryable = _context.Electrics.Where(item => item.Month == baseParam.Month);
            if (baseParam.CompanyId.HasValue) {
                electricQueryable = electricQueryable.Where(item => item.CompanyId == baseParam.CompanyId.Value);
            }
            var lst = electricQueryable.GroupBy(item => new { item.Year, item.Month }).Select(item => new {
                Year = item.Key.Year,
                Month = item.Key.Month,
                Electricity = item.Sum(x => x.Electricity),
                BuyElectricity = item.Sum(x => x.BuyElectricity),
                BuyAvgPrice = item.Sum(x => x.BuyAvgPrice),
                SellElectricity = item.Sum(x => x.SellElectricity),
                SellAvgPrice = item.Sum(x => x.SellAvgPrice)
            }).ToList();
            var budgetReportDatas = GetCharDataInfoOfYearAndMonth(baseParam.Month.GetValueOrDefault());
            foreach (var budgetReportData in budgetReportDatas) {
                var electric = lst.FirstOrDefault(item => item.Year == budgetReportData.Year && item.Month == budgetReportData.Month);
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

        private IList<BudgetReportData> GetCostChartDataByYearAndMonthDemssion(BaseParam baseParam) {
            var costQueryable = _context.Costs.Where(item => item.Month == baseParam.Month);
            if (baseParam.CompanyId.HasValue) {
                costQueryable = costQueryable.Where(item => item.CompanyId == baseParam.CompanyId.Value);
            }
            var lst = costQueryable.GroupBy(item => new { item.Year, item.Month }).Select(item => new {
                item.Key.Year,
                item.Key.Month,
                Salary = item.Sum(x => x.Salary),
                WorkersWelfare = item.Sum(x => x.WorkersWelfare),
                ControllableCost = item.Sum(x => x.ControllableCost),
                OtherControllableCost = item.Sum(x => x.OtherControllableCost),
                OtherUnControllableCost = item.Sum(x => x.OtherUnControllableCost)
            }).ToList();
            var budgetReportDatas = GetCharDataInfoOfYearAndMonth(baseParam.Month.GetValueOrDefault());
            foreach (var budgetReportData in budgetReportDatas) {
                var cost = lst.FirstOrDefault(item => item.Year == budgetReportData.Year && item.Month == budgetReportData.Month);
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

        private IList<BudgetReportData> GetProfitChartDataByYearAndMonthDemssion(BaseParam baseParam) {
            var profitQueryable = _context.Profits.Where(item => item.Month == baseParam.Month);
            if (baseParam.CompanyId.HasValue) {
                profitQueryable = profitQueryable.Where(item => item.CompanyId == baseParam.CompanyId.Value);
            }
            var lst = profitQueryable.GroupBy(item => new { item.Year, item.Month }).Select(item => new {
                item.Key.Year,
                item.Key.Month,
                ThirdMaintenanceFee = item.Sum(x => x.ThirdMaintenanceFee),
                EngineeringAndLeasehold = item.Sum(x => x.EngineeringAndLeasehold),
                OtherCost = item.Sum(x => x.OtherCost),
                TaxAndAdditional = item.Sum(x => x.TaxAndAdditional),
                FinancialCost = item.Sum(x => x.FinancialCost),
                AssetsImpairmentLoss = item.Sum(x => x.AssetsImpairmentLoss),
                ProfitValue = item.Sum(x => x.ProfitValue)
            }).ToList();
            var budgetReportDatas = GetCharDataInfoOfYearAndMonth(baseParam.Month.GetValueOrDefault());
            foreach (var budgetReportData in budgetReportDatas) {
                var profit = lst.FirstOrDefault(item => item.Year == budgetReportData.Year && item.Month == budgetReportData.Month);
                if (profit == null) {
                    continue;
                }
                budgetReportData.ThirdMaintenanceFee = profit.ThirdMaintenanceFee;
                budgetReportData.EngineeringAndLeasehold = profit.EngineeringAndLeasehold;
                budgetReportData.OtherCost = profit.OtherCost;
                budgetReportData.TaxAndAdditional = profit.TaxAndAdditional;
                budgetReportData.FinancialCost = profit.FinancialCost;
                budgetReportData.AssetsImpairmentLoss = profit.AssetsImpairmentLoss;
                budgetReportData.ProfitValue = profit.ProfitValue;
            }
            return budgetReportDatas;
        }

        private IList<BudgetReportData> GetCharDataInfoOfYearAndMonth(int month) {
            var budgetReportDatas = new List<BudgetReportData>();
            for (var i = 0; i < 5; i++) {
                var year = DateTime.Now.Year - i;
                var budgetReportData = new BudgetReportData { Year = year, Month = month };
                budgetReportDatas.Add(budgetReportData);
            }

            return budgetReportDatas;
        }

        #endregion 看每年的某个月的数据

        #region 看每年某个季度的数据

        private IList<BudgetReportData> GetElectricChartDataByYearAndQuarterDemssion(BaseParam baseParam) {
            var electricQueryable = _context.Electrics.Where(item => item.Month >= 1 + 3 * (baseParam.Quarter.Value - 1) && item.Month <= baseParam.Quarter.Value * 3);
            if (baseParam.CompanyId.HasValue) {
                electricQueryable = electricQueryable.Where(item => item.CompanyId == baseParam.CompanyId.Value);
            }
            var lst = electricQueryable.GroupBy(item => new { item.Year }).Select(g => new {
                g.Key.Year,
                Electricity = g.Sum(x => x.Electricity),
                BuyElectricity = g.Sum(x => x.BuyElectricity),
                BuyAvgPrice = g.Sum(x => x.BuyAvgPrice),
                SellElectricity = g.Sum(x => x.SellElectricity),
                SellAvgPrice = g.Sum(x => x.SellAvgPrice),
            }).ToList();
            var budgetReportDatas = GetCharDataInfoOfYearAndQuarter(baseParam.Quarter.GetValueOrDefault());
            foreach (var budgetReportData in budgetReportDatas) {
                var electric = lst.FirstOrDefault(item => item.Year == budgetReportData.Year);
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

        private IList<BudgetReportData> GetCostChartDataByYearAndQuarterDemssion(BaseParam baseParam) {
            var costQueryable = _context.Costs.Where(item => item.Month >= 1 + 3 * (baseParam.Quarter.Value - 1) && item.Month <= baseParam.Quarter.Value * 3);
            if (baseParam.CompanyId.HasValue) {
                costQueryable = costQueryable.Where(item => item.CompanyId == baseParam.CompanyId.Value);
            }
            var lst = costQueryable.GroupBy(item => new { item.Year }).Select(g => new {
                g.Key.Year,
                Salary = g.Sum(x => x.Salary),
                WorkersWelfare = g.Sum(x => x.WorkersWelfare),
                ControllableCost = g.Sum(x => x.ControllableCost),
                OtherControllableCost = g.Sum(x => x.OtherControllableCost),
                OtherUnControllableCost = g.Sum(x => x.OtherUnControllableCost),
            }).ToList();
            var budgetReportDatas = GetCharDataInfoOfYearAndQuarter(baseParam.Quarter.GetValueOrDefault());
            foreach (var budgetReportData in budgetReportDatas) {
                var cost = lst.FirstOrDefault(item => item.Year == budgetReportData.Year);
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

        private IList<BudgetReportData> GetProfitChartDataByYearAndQuarterDemssion(BaseParam baseParam) {
            var profitQueryable = _context.Profits.Where(item => item.Month >= 1 + 3 * (baseParam.Quarter.Value - 1) && item.Month <= baseParam.Quarter.Value * 3);
            if (baseParam.CompanyId.HasValue) {
                profitQueryable = profitQueryable.Where(item => item.CompanyId == baseParam.CompanyId.Value);
            }
            var lst = profitQueryable.GroupBy(item => new { item.Year }).Select(g => new {
                g.Key.Year,
                ThirdMaintenanceFee = g.Sum(x => x.ThirdMaintenanceFee),
                EngineeringAndLeasehold = g.Sum(x => x.EngineeringAndLeasehold),
                OtherCost = g.Sum(x => x.OtherCost),
                TaxAndAdditional = g.Sum(x => x.TaxAndAdditional),
                FinancialCost = g.Sum(x => x.FinancialCost),
                AssetsImpairmentLoss = g.Sum(x => x.AssetsImpairmentLoss),
                ProfitValue = g.Sum(x => x.ProfitValue),
            }).ToList();
            var budgetReportDatas = GetCharDataInfoOfYearAndQuarter(baseParam.Quarter.GetValueOrDefault());
            foreach (var budgetReportData in budgetReportDatas) {
                var profit = lst.FirstOrDefault(item => item.Year == budgetReportData.Year);
                if (profit == null) {
                    continue;
                }
                budgetReportData.ThirdMaintenanceFee = profit.ThirdMaintenanceFee;
                budgetReportData.EngineeringAndLeasehold = profit.EngineeringAndLeasehold;
                budgetReportData.OtherCost = profit.OtherCost;
                budgetReportData.TaxAndAdditional = profit.TaxAndAdditional;
                budgetReportData.FinancialCost = profit.FinancialCost;
                budgetReportData.AssetsImpairmentLoss = profit.AssetsImpairmentLoss;
                budgetReportData.ProfitValue = profit.ProfitValue;
            }
            return budgetReportDatas;
        }

        private IList<BudgetReportData> GetCharDataInfoOfYearAndQuarter(int quarter) {
            var budgetReportDatas = new List<BudgetReportData>();
            for (var i = 0; i < 5; i++) {
                var year = DateTime.Now.Year - i;
                var budgetReportData = new BudgetReportData { Year = year, Quarter = quarter };
                budgetReportDatas.Add(budgetReportData);
            }

            return budgetReportDatas;
        }

        #endregion 看每年某个季度的数据
    }
}