using ProductManager.Helper;
using ProductManager.Model.ItemModel;
using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;

namespace ProductManager.ImportExcel {

    public class ImportCost {

        public CostItem GetCostItemFromExcel(Application application) {
            var worksheet = application.ActiveSheet;
            var sb = new StringBuilder();

            var companyRange = worksheet.Cells.Range["B4", "B4"];
            var company = companyRange.Value2;
            var companyName = CommonHelper.GetCompanyName(company);

            if (string.IsNullOrEmpty(companyName)) {
                sb.Append("请在【B4】处输入编制单位;");
            }

            var timeRange = worksheet.Cells.Range["J4", "J4"];
            var time = timeRange.Value2;
            var underDateTime = CommonHelper.GetUnderDateTime(time); 

            if (underDateTime==null) {
                sb.Append("表所属时间【J4】不对;");
            }

            var welfareFundsRange = worksheet.Cells.Range["L26", "L26"];
            var welfareFunds = welfareFundsRange.Value2;
            if (!CommonHelper.IsNumberOrNull(welfareFunds)) {
                sb.Append("福利费指标【L26】不是可读数;");
            }

            var controllableCostRange = worksheet.Cells.Range["L64", "L64"];
            var controllableCost = controllableCostRange.Value2;
            if (!CommonHelper.IsNumberOrNull(controllableCost)) {
                sb.Append("可控成本【L64】不是可读数;");
            }

            var buyAvgPriceRange = worksheet.Cells.Range["E162", "E162"];
            var buyAvgPrice = buyAvgPriceRange.Value2;
            if (!CommonHelper.IsNumberOrNull(buyAvgPrice)) {
                sb.Append("购电均价指标【E162】不是可读数;");
            }

            var sellElectricityRange = worksheet.Cells.Range["E85", "E85"];
            var sellElectricity = sellElectricityRange.Value2;
            if (!CommonHelper.IsNumberOrNull(sellElectricity)) {
                sb.Append("售电量指标【E85】不是可读数;");
            }

            var sellAvgPriceRange = worksheet.Cells.Range["E164", "E164"];
            var sellAvgPrice = sellAvgPriceRange.Value2;
            if (!CommonHelper.IsNumberOrNull(sellAvgPrice)) {
                sb.Append("售电均价指标【E164】不是可读数;");
            }

            ExcelHelper.CloseExcel(application);

            if (sb.Length > 0) {
                throw new Exception(sb.ToString());
            }
            var costItem = new CostItem {
                Year=underDateTime.Year,
                Month = underDateTime.Month,
                CompanyName = companyName,
                //Electricity = welfareFunds,
                //BuyAvgPrice = buyAvgPrice,
                //BuyElectricity = controllableCost,
                //SellElectricity = sellElectricity,
                //SellAvgPrice = sellAvgPrice
            };

            return costItem;
        }
       
    }
}