using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.Logic;
using ProductManager.Model.ParamModel;
using ProductManager.Model.ViewModel;
using unvell.ReoGrid;
using unvell.ReoGrid.IO;

namespace ProductManager.Controls
{
    public partial class ViewReport : UserControl
    {
        public Worksheet sheet;
        private IList<BudgetReportData> reportDatas;
        private IList<Company> selects;
        private DataReportLogic dataReport;
        private const int SELECTITEMSMAXCOUNT = 10;
        public ViewReport()
        {
            InitializeComponent();
            sheet = excel.CurrentWorksheet;
            //sheet.InsertColumns(0,23);
            dataReport = new DataReportLogic();
            LoadData();
            InitHeader();
        }

        private void InitHeader()
        {
            FileFormat format = FileFormat.Excel2007;
            var path = Environment.CurrentDirectory;
            excel.Load(path + "\\Template\\StatisticsTemplate.xlsx", FileFormat.Excel2007);
        }

        private void LoadData()
        {
            reportDatas = dataReport.GetBudgetReportData(new BaseParam());
            selects.Add(new Company()
            {
                Id=0,Name = "无"
            });
            for (int i = 0; i < reportDatas.Count&&i<SELECTITEMSMAXCOUNT; i++)
            {
                selects.Add(new Company()
                {
                    Id=i+1,
                    Name = $"{reportDatas[i].CompanyName}{reportDatas[i]}年{reportDatas[i].Month}月预算表"//TODO:差年
                });
            }
            comboBox1.DataSource = selects;
            comboBox1.DisplayMember = "Name";
        }
        private void pushInExcel(IList<BudgetReportData> rangData)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = sender as ComboBox;
            var index = item.SelectedIndex;
        }
    }
}
