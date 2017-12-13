using Microsoft.Office.Interop.Excel;
using ProductManager.Helper;
using ProductManager.Model.ItemModel;
using System;
using System.Text;

namespace ProductManager.ImportExcel {

    public class ImportProfit {

        public ProfitItem GetProfitItemFromExcel(Application application) {
            var worksheet = application.ActiveSheet;
            var sb = new StringBuilder();

            var companyRange = worksheet.Cells.Range["B4", "B4"];
            var company = companyRange.Value2;
            var companyName = CommonHelper.GetCompanyName(company);

            if (string.IsNullOrEmpty(companyName)) {
                sb.Append("请在【B4】处输入编制单位;");
            }

            var timeRange = worksheet.Cells.Range["E4", "E4"];
            var time = timeRange.Value2;
            var underDateTime = CommonHelper.GetUnderDateTime(time);

            if (underDateTime == null) {
                sb.Append("表所属时间【E4】不对;");
            }

            var thirdMaintenanceFeeRange = worksheet.Cells.Range["E33", "E33"];
            var thirdMaintenanceFee = thirdMaintenanceFeeRange.Value2;
            if (!CommonHelper.IsNumberOrNull(thirdMaintenanceFee)) {
                sb.Append("委托运行维护费【E33】不是可读数;");
            }

            var engineeringAndLeaseholdRange = worksheet.Cells.Range["E32", "E32"];
            var engineeringAndLeasehold = engineeringAndLeaseholdRange.Value2;
            if (!CommonHelper.IsNumberOrNull(engineeringAndLeasehold)) {
                sb.Append("用户工程及租赁收入【E32】不是可读数;");
            }

            var otherCostRange = worksheet.Cells.Range["E41", "E41"];
            var otherCost = otherCostRange.Value2;
            if (!CommonHelper.IsNumberOrNull(otherCost)) {
                sb.Append("其他业务成本【E41】不是可读数;");
            }

            var taxAndAdditionalRange = worksheet.Cells.Range["E49", "E49"];
            var taxAndAdditional = taxAndAdditionalRange.Value2;
            if (!CommonHelper.IsNumberOrNull(taxAndAdditional)) {
                sb.Append("营业税金及附加【E49】不是可读数;");
            }

            var financialCostRange = worksheet.Cells.Range["E54", "E54"];
            var financialCost = financialCostRange.Value2;
            if (!CommonHelper.IsNumberOrNull(financialCost)) {
                sb.Append("财务费用【E54】不是可读数;");
            }

            var assetsImpairmentLossRange = worksheet.Cells.Range["E60", "E60"];
            var assetsImpairmentLoss = assetsImpairmentLossRange.Value2;
            if (!CommonHelper.IsNumberOrNull(assetsImpairmentLoss)) {
                sb.Append("资产减值损失【E60】不是可读数;");
            }

            var profitValueRange = worksheet.Cells.Range["E75", "E75"];
            var profitValue = profitValueRange.Value2;
            if (!CommonHelper.IsNumberOrNull(profitValue)) {
                sb.Append("利润【E75】不是可读数;");
            }

            ExcelHelper.CloseExcel(application);

            if (sb.Length > 0) {
                throw new Exception(sb.ToString());
            }
            var profitItem = new ProfitItem {
                Year = underDateTime.Year,
                Month = underDateTime.Month,
                CompanyName = companyName,
                ThirdMaintenanceFee = thirdMaintenanceFee,
                EngineeringAndLeasehold = engineeringAndLeasehold,
                OtherCost = otherCost,
                TaxAndAdditional = taxAndAdditional,
                FinancialCost = financialCost,
                AssetsImpairmentLoss = assetsImpairmentLoss,
                ProfitValue = profitValue
            };

            return profitItem;
        }
    }
}