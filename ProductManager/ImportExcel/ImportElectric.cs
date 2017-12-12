using ProductManager.Helper;
using ProductManager.Model.ItemModel;
using System;
using System.Globalization;
using System.Text;

namespace ProductManager.ImportExcel {

    public class ImportElectric {

        public ElectricItem GetElectricItemFromExcel(string filePath) {
            var application = ExcelHelper.ReadFromExcelFile(filePath);
            if (application == null) {
                throw new Exception("没有找到");
            }
           
            var worksheet = application.ActiveSheet;
            var sb = new StringBuilder();
            //todo:数据类型需要处理！！！
            float outValue;
            var electricityRange = worksheet.Cells.Range["E52", "E52"];
            var electricity = electricityRange.Value2;
            if (electricity != null && !float.TryParse(electricity, out outValue)) {
                sb.Append("发电量指标【E52】不是可读数;");
            }

            var buyElectricityRange = worksheet.Cells.Range["E58", "E58"];
            var buyElectricity = buyElectricityRange.Value2?.ToString();
            if (buyElectricity!=null && !float.TryParse(buyElectricity, out outValue)) {
                sb.Append("购电量指标【E58】不是可读数;");
            }

            var buyAvgPriceRange = worksheet.Cells.Range["E162", "E162"];
            var buyAvgPrice = buyAvgPriceRange.Value2?.ToString();
            if (buyAvgPrice != null && !float.TryParse(buyAvgPrice, out outValue)) {
                sb.Append("购电均价指标【E162】不是可读数;");
            }

            var sellElectricityRange = worksheet.Cells.Range["E85", "E85"];
            var sellElectricity = sellElectricityRange.Value2?.ToString();
            if (sellElectricity != null && !float.TryParse(sellElectricity, out outValue)) {
                sb.Append("售电量指标【E85】不是可读数;");
            }

            var sellAvgPriceRange = worksheet.Cells.Range["E164", "E164"];
            var sellAvgPrice = sellAvgPriceRange.Value2?.ToString();
            if (sellAvgPrice != null && !float.TryParse(sellAvgPrice, out outValue)) {
                sb.Append("售电均价指标【E164】不是可读数;");
            }

            if (sb.Length > 0) {
                throw new Exception(sb.ToString());
            }

            ExcelHelper.CloseExcel(application);

            var electricItem = new ElectricItem {
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