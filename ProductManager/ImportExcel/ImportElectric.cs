using Microsoft.Office.Interop.Excel;
using ProductManager.Helper;
using ProductManager.Model.ItemModel;
using System;
using System.Text;

namespace ProductManager.ImportExcel {

    public class ImportElectric {

        public ElectricItem GetElectricItemFromExcel(Application application) {
            var worksheet = application.ActiveSheet;
            var sb = new StringBuilder();

            var companyRange = worksheet.Cells.Range["B4", "B4"];
            var company = companyRange.Value2;
            var companyName = CommonHelper.GetCompanyName(company);

            if (string.IsNullOrEmpty(companyName)) {
                sb.Append("请在【B4】处输入编制单位;");
            }

            if (!CommonHelper.ExistCompany(companyName))
            {
                sb.Append("【B4】处输入编制单位不存在，请先添加相应的编制单位;");
            }

            var timeRange = worksheet.Cells.Range["D4", "D4"];
            var time = timeRange.Value2;
            var underDateTime = CommonHelper.GetUnderDateTime(time);

            if (underDateTime == null) {
                sb.Append("表所属时间【D4】不对;");
            }

            var electricityRange = worksheet.Cells.Range["E52", "E52"];
            var electricity = electricityRange.Value2;
            if (!CommonHelper.IsNumberOrNull(electricity)) {
                sb.Append("发电量指标【E52】不是可读数;");
            }

            var buyElectricityRange = worksheet.Cells.Range["E58", "E58"];
            var buyElectricity = buyElectricityRange.Value2;
            if (!CommonHelper.IsNumberOrNull(buyElectricity)) {
                sb.Append("购电量指标【E58】不是可读数;");
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
            var electricItem = new ElectricItem {
                Year = underDateTime.Year,
                Month = underDateTime.Month,
                CompanyName = companyName,
                Electricity = electricity,
                BuyAvgPrice = buyAvgPrice,
                BuyElectricity = buyElectricity,
                SellElectricity = sellElectricity,
                SellAvgPrice = sellAvgPrice
            };

            return electricItem;
        }
    }
}