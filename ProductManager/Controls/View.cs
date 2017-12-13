using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.Model.ViewModel;
using unvell.ReoGrid.IO;

namespace ProductManager.Controls
{
    public partial class View : UserControl
    {
        private IList<Company> companies = new List<Company>();
        private IList<YearSelect> years= new List<YearSelect>();
        private IList<MonthSelect> months = new List<MonthSelect>();
        public View()
        {
            InitializeComponent();
            InitHeader();
            InitSelectData();
        }

        private void InitSelectData()
        {
            companies.Add(new Company()
            {
                Id = 0,
                Name = "全部公司"
            });
            companySelect.DataSource = companies;
            companySelect.ValueMember = "Id";
            companySelect.DisplayMember = "Name";

            years.Add(new YearSelect(){Id=0,Name = "2012年"});
            years.Add(new YearSelect() { Id = 1, Name = "2013年" });
            years.Add(new YearSelect() { Id = 2, Name = "2014年" });
            years.Add(new YearSelect() { Id = 3, Name = "2015年" });
            years.Add(new YearSelect() { Id = 4, Name = "2016年" });
            years.Add(new YearSelect() { Id = 5, Name = "2017年" });
            yearSelect.DataSource = years;
            yearSelect.ValueMember = "Id";
            yearSelect.DisplayMember = "Name";

            months.Add(new MonthSelect(){Id=0,Name = "第一季度"});
            months.Add(new MonthSelect() { Id = 1, Name = "第二季度" });
            months.Add(new MonthSelect() { Id = 2, Name = "第三季度" });
            months.Add(new MonthSelect() { Id = 3, Name = "第四季度" });
            months.Add(new MonthSelect() { Id = 4, Name = "1" });
            months.Add(new MonthSelect() { Id = 5, Name = "2" });
            months.Add(new MonthSelect() { Id = 6, Name = "3" });
            months.Add(new MonthSelect() { Id = 7, Name = "4" });
            months.Add(new MonthSelect() { Id = 8, Name = "5" });
            months.Add(new MonthSelect() { Id = 9, Name = "6" });
            months.Add(new MonthSelect() { Id = 10, Name = "7" });
            months.Add(new MonthSelect() { Id = 11, Name = "8" });
            months.Add(new MonthSelect() { Id = 12, Name = "9" });
            months.Add(new MonthSelect() { Id = 13, Name = "10" });
            months.Add(new MonthSelect() { Id = 14, Name = "11" });
            months.Add(new MonthSelect() { Id = 15, Name = "12" });
            monthSelect.DataSource = months;
            monthSelect.ValueMember = "Id";
            monthSelect.DisplayMember = "Name";

        }

        private void InitHeader()
        {
            FileFormat format = FileFormat.Excel2007;
            var path = Environment.CurrentDirectory;
            report.Load(path + "\\Template\\StatisticsTemplate.xlsx", FileFormat.Excel2007);
        }

        private void companySelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yearSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

        }

    }
}
