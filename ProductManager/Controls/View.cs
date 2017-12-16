using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.Helper;
using ProductManager.Logic;
using ProductManager.Model.Dictionary;
using ProductManager.Model.ParamModel;
using ProductManager.Model.ViewModel;
using unvell.ReoGrid;
using unvell.ReoGrid.IO;

namespace ProductManager.Controls
{
    public partial class View : UserControl
    {
        public Worksheet sheet;
        private List<Company> companies = new List<Company>();
        private List<YearSelect> years = new List<YearSelect>();
        private List<MonthSelect> months = new List<MonthSelect>();
        private BaseParam reportParam = new BaseParam();
        private BaseParam lineParam = new BaseParam();
        private DataReportLogic reportLogic;
        public View()
        {
            InitializeComponent();
           
        }

        private void InitSelectData()
        {
            companies.Add(new Company()
            {
                Id = 0,
                Name = "全部公司"
            });
            

            var date = DateTime.Now;

            var year = date.Year;
            years.Add(new YearSelect() { Id = -1, Name = "每年" });
            for (int i = 0; i < 5; i++)
            {
                years.Add(new YearSelect() { Id = year - i, Name = year - i + "年" });
            }
            yearSelect.DataSource = years;
            yearSelect.ValueMember = "Id";
            yearSelect.SelectedIndex = 0;
            yearSelect.DisplayMember = "Name";
            line_Year.DataSource = years;
            line_Year.ValueMember = "Id";
            line_Year.DisplayMember = "Name";
            line_Year.SelectedIndex = 0;


            months.Add(new MonthSelect() { Id = -1, Name = "无" });
            months.Add(new MonthSelect() { Id = 1, IsQuarter = true, Name = "第一季度" });
            months.Add(new MonthSelect() { Id = 2, IsQuarter = true, Name = "第二季度" });
            months.Add(new MonthSelect() { Id = 3, IsQuarter = true, Name = "第三季度" });
            months.Add(new MonthSelect() { Id = 4, IsQuarter = true, Name = "第四季度" });

            months.Add(new MonthSelect() { Id = 1, Name = "1月" });
            months.Add(new MonthSelect() { Id = 2, Name = "2月" });
            months.Add(new MonthSelect() { Id = 3, Name = "3月" });
            months.Add(new MonthSelect() { Id = 4, Name = "4月" });
            months.Add(new MonthSelect() { Id = 5, Name = "5月" });
            months.Add(new MonthSelect() { Id = 6, Name = "6月" });
            months.Add(new MonthSelect() { Id = 7, Name = "7月" });
            months.Add(new MonthSelect() { Id = 8, Name = "8月" });
            months.Add(new MonthSelect() { Id = 9, Name = "9月" });
            months.Add(new MonthSelect() { Id = 10, Name = "10月" });
            months.Add(new MonthSelect() { Id = 11, Name = "11月" });
            months.Add(new MonthSelect() { Id = 12, Name = "12月" });
            monthSelect.DataSource = months;
            monthSelect.ValueMember = "Id";
            monthSelect.DisplayMember = "Name";
            monthSelect.SelectedIndex = 0;
            line_Month.DisplayMember = "Name";
            line_Month.DataSource = months;
            line_Month.ValueMember = "Id";
            line_Month.SelectedIndex = 0;

            line_Property.DataSource = NormDictionary.GetReportDictionary().ToList();
            line_Property.ValueMember = "value";
            line_Property.DisplayMember = "key";
            line_Property.SelectedIndex = 0;
        }

        private void InitHeader()
        {
            FileFormat format = FileFormat.Excel2007;
            var path = Environment.CurrentDirectory;
            report.Load(path + "\\Template\\StatisticsTemplate.xlsx", FileFormat.Excel2007);

        }

        #region 报表
        private void companySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var company = sender as Company;
            reportParam.CompanyId = company?.Id == 0 ? null : company?.Id;
        }

        private void yearSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var year = sender as YearSelect;
            reportParam.Year = year?.Id == 0 ? null : year?.Id;
        }

        private void monthSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var month = sender as MonthSelect;
            reportParam.Year = month?.Id == 0 ? null : month?.Id;
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                var budgetReportDatas = reportLogic.GetBudgetReportData(reportParam);
                var dataTable = CommonHelper.ToDataTable(budgetReportDatas);
                sheet?.SetRangeData(new RangePosition(4, 0, dataTable.Rows.Count, dataTable.Columns.Count), dataTable);
            }
            catch (Exception exception)
            {
                MessageBox.Show("查询失败！", "Error", MessageBoxButtons.OK);
            }
            
        }
        #endregion

        #region 折线图
        private void line_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selector = sender as ComboBox;
                var value = selector.SelectedItem as YearSelect;
                if (value.Id == -1)
                {
                    line_Month.SelectedIndex = line_Month.Items.IndexOf("无") + 1; ;
                    line_Month.Enabled = true;
                    lineParam.Year = null;
                }
                else
                {
                    line_Month.Enabled = false;
                lineParam.Year = value.Id;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

        }
        //趋势参数
        private void line_Property_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selector = sender as ComboBox;
            var value = selector.SelectedValue.ToString();
            lineParam.TargetKey = value;
        }

        private void line_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selector = sender as ComboBox;
                var value = selector.SelectedItem as MonthSelect;
                if (value.Id == -1)
                {
                    line_Year.SelectedIndex = line_Year.Items.IndexOf("每年") + 1; ;
                    line_Year.Enabled = true;
                    lineParam.Month = null;
                }
                else
                {
                    line_Year.Enabled = false;
                    lineParam.Month = value.Id;
                }
                
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

        }

        private void line_Company_SelectedIndexChanged(object sender, EventArgs e)
        {
            var company = sender as Company;
            lineParam.CompanyId = company?.Id == 0 ? null : company?.Id;
        }

        private void line_search_Click(object sender, EventArgs e)
        {
            try
            {
                var chartReportDatas = reportLogic.GetBudgetReportData(reportParam);
                chartReportDatas[0] = new BudgetReportData();
                var dataTable = CommonHelper.ToDataTable(chartReportDatas);
                lineChart1?.LoadData(dataTable, GetSerials());
            }
            catch (Exception exception)
            {
                MessageBox.Show("查询失败！", "Error", MessageBoxButtons.OK);
            }
        }
        #endregion

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadCompanys()
        {
            var companyData = new CompanyLogic().GetCompanys().Select(n=>new Company(){Id=n.Id,Name = n.Name});
            companies.AddRange(companyData);
            companySelect.DataSource = companies;
            companySelect.ValueMember = "Id";
            companySelect.DisplayMember = "Name";

            line_Company.DataSource = companies;
            line_Company.ValueMember = "Id";
            line_Company.DisplayMember = "Name";
            
        }
        private void View_Load(object sender, EventArgs e)
        {
            InitHeader();
            InitSelectData();
            sheet = report.CurrentWorksheet;
            sheet.DeleteRows(0, 2);//删除模板1、2行
            LoadCompanys();
            reportLogic = new DataReportLogic();
        }

        private string[] GetSerials()
        {
            if (lineParam.Year != null)
            {
                var yearsSerial = this.years.Where(n => n.Id > 0).Select(n=>n.Name).ToArray();
                return yearsSerial;
            }
            if (lineParam.Quarter != null)
            {
                var quarterSerial = this.months.Where(n => n.IsQuarter).Select(n => n.Name).ToArray();
                return quarterSerial;
            }
            return months.Where(n => !n.IsQuarter).Select(n => n.Name).ToArray();
        }
    }
}
