using System;
using System.Text;
using Microsoft.Office.Interop.Excel;
using ProductManager.Helper;
using ProductManager.Logic;

namespace ProductManager.ImportExcel {
    public class ImportLogic {
        public bool ImportExcel(string filePath) {
            var application = ExcelHelper.ReadFromExcelFile(filePath);
            if (application == null) {
                throw new Exception("没有找到");
            }

            var worksheet = application.ActiveSheet;

            var nameRange = worksheet.Cells.Range["B2", "B2"];
            var excelName = nameRange.Value2.ToString();

            if (excelName.Contains("其他指标")) {
                ImportElectric(application);
            }
            else if (excelName.Contains("成本费用")) {

            }
            else if (excelName.Contains("利润")) {

            }
            return true;
        }

        public bool ImportElectric(Application application) {
            var importElectric = new ImportElectric();
            var xx = importElectric.GetElectricItemFromExcel(application);
            var electricLogic = new ElectricLogic();
            return electricLogic.Add(xx);
        }
    }
}