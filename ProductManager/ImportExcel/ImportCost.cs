using Microsoft.Office.Interop.Excel;
using ProductManager.Helper;
using ProductManager.Model.ItemModel;
using System;
using System.Text;

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

            if (!CommonHelper.ExistCompany(companyName)) {
                sb.Append("【B4】处输入编制单位不存在，请先添加相应的编制单位;");
            }

            var timeRange = worksheet.Cells.Range["J4", "J4"];
            var time = timeRange.Value2;
            var underDateTime = CommonHelper.GetUnderDateTime(time);

            if (underDateTime == null) {
                sb.Append("表所属时间【J4】不对;");
            }

            var salaryRange = worksheet.Cells.Range["L10", "L10"];
            var salary = salaryRange.Value2;
            if (!CommonHelper.IsNumberOrNull(salary)) {
                sb.Append("工资指标【L10】不是可读数;");
            }

            var workersWelfareRange = worksheet.Cells.Range["L26", "L26"];
            var workersWelfare = workersWelfareRange.Value2;
            if (!CommonHelper.IsNumberOrNull(workersWelfare)) {
                sb.Append("职工福利费指标【L26】不是可读数;");
            }

            var totalCostRange = worksheet.Cells.Range["L63", "L63"];
            var totalCost = totalCostRange.Value2;
            if (!CommonHelper.IsNumberOrNull(totalCost)) {
                sb.Append("合计指标【L10】不是可读数;");
            }

            var controllableCostRange = worksheet.Cells.Range["L64", "L64"];
            var controllableCost = controllableCostRange.Value2;
            if (!CommonHelper.IsNumberOrNull(controllableCost)) {
                sb.Append("可控成本指标【L64】不是可读数;");
            }

            ExcelHelper.CloseExcel(application);

            if (sb.Length > 0) {
                throw new Exception(sb.ToString());
            }
            var costItem = new CostItem {
                Year = underDateTime.Year,
                Month = underDateTime.Month,
                CompanyName = companyName,
                Salary = salary,
                WorkersWelfare = workersWelfare,
                TotalCost = totalCost,
                ControllableCost = controllableCost,
            };

            return costItem;
        }
    }
}