using Microsoft.Office.Interop.Excel;
using ProductManager.Helper;
using ProductManager.Logic;
using System;

namespace ProductManager.ImportExcel {

    public class ImportLogic {

        /// <summary>
        /// 导入excel调用入口
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public bool ImportExcel(string filePath) {
            var application = ExcelHelper.ReadFromExcelFile(filePath);
            if (application == null) {
                throw new Exception("没有找到");
            }

            var worksheet = application.ActiveSheet;

            var nameRange = worksheet.Cells.Range["B2", "B2"];
            var excelName = nameRange.Value2.ToString();

            if (excelName.Contains("其他指标")) {
                return ImportElectric(application);
            }
            if (excelName.Contains("成本费用")) {
                return ImportCost(application);
            }
            return !excelName.Contains("利润") || ImportProfit(application);
        }

        private bool ImportElectric(Application application) {
            var importElectric = new ImportElectric();
            var electricItem = importElectric.GetElectricItemFromExcel(application);
            var electricLogic = new ElectricLogic();
            return electricLogic.Add(electricItem);
        }

        private bool ImportCost(Application application) {
            var importCost = new ImportCost();
            var costItem = importCost.GetCostItemFromExcel(application);
            var costLogic = new CostLogic();
            return costLogic.Add(costItem);
        }

        private bool ImportProfit(Application application) {
            var importProfit = new ImportProfit();
            var profitItem = importProfit.GetProfitItemFromExcel(application);
            var profitLogic = new ProfitLogic();
            return profitLogic.Add(profitItem);
        }
    }
}