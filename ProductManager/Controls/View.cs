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

            var date = DateTime.Now;

            var year = date.Year;
            years.Add(new YearSelect() { Id = -1, Name = "每年" });
            for (int i = 0; i < 5; i++)
            {
                years.Add(new YearSelect() { Id = year-i, Name = year - i + "年" });
            }
            yearSelect.DataSource = years;
            yearSelect.ValueMember = "Id";
            line_Year.DisplayMember = "Name";
            line_Year.DataSource = years;
            line_Year.ValueMember = "Id";
            line_Year.DisplayMember = "Name";


            months.Add(new MonthSelect() { Id = -1, Name = "无" });
            months.Add(new MonthSelect(){Id=1,IsQuarter = true,Name = "第一季度"});
            months.Add(new MonthSelect() { Id = 2, IsQuarter = true, Name = "第二季度" });
            months.Add(new MonthSelect() { Id = 3, IsQuarter = true, Name = "第三季度" });
            months.Add(new MonthSelect() { Id = 4, IsQuarter = true, Name = "第四季度" });

            months.Add(new MonthSelect() { Id = 1, Name = "1" });
            months.Add(new MonthSelect() { Id = 2, Name = "2" });
            months.Add(new MonthSelect() { Id = 3, Name = "3" });
            months.Add(new MonthSelect() { Id = 4, Name = "4" });
            months.Add(new MonthSelect() { Id = 5, Name = "5" });
            months.Add(new MonthSelect() { Id = 6, Name = "6" });
            months.Add(new MonthSelect() { Id = 7, Name = "7" });
            months.Add(new MonthSelect() { Id = 8, Name = "8" });
            months.Add(new MonthSelect() { Id = 9, Name = "9" });
            months.Add(new MonthSelect() { Id = 10, Name = "10" });
            months.Add(new MonthSelect() { Id = 11, Name = "11" });
            months.Add(new MonthSelect() { Id = 12, Name = "12" });
            monthSelect.DataSource = months;
            monthSelect.ValueMember = "Id";
            line_Month.DisplayMember = "Name";
            line_Month.DataSource = months;
            line_Month.ValueMember = "Id";
            line_Month.DisplayMember = "Name";
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

        private void line_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selector = sender as ComboBox;
            var value = selector.SelectedItem as YearSelect;
            if (value.Id == -1)
            {
                line_Month.SelectedIndex = 0;
                line_Month.Enabled = true;
            }
            else
            {
                line_Month.Enabled = false;
            }
          Console.WriteLine(value.Id);
        }
        //趋势参数
        private void line_Property_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void line_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selector = sender as ComboBox;
            var value = selector.SelectedItem as MonthSelect;
            if (value.Id == -1)
            {
                line_Year.SelectedIndex = 0;
                line_Year.Enabled = true;
            }
            else
            {
                line_Year.Enabled = false;
            }
            Console.WriteLine(value.Id);
        }

        private void line_Company_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void line_search_Click(object sender, EventArgs e)
        {

        }


        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
