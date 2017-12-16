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
        private DataTable dataTable;
        private IList<Company> selects;
        private DataReportLogic dataReport;
        private const int SELECTITEMSMAXCOUNT = 10;
        public ViewReport()
        {
            InitializeComponent();
            
        }

        private void InitHeader()
        {
            FileFormat format = FileFormat.Excel2007;
            var path = Environment.CurrentDirectory;
            excel.Load(path + "\\Template\\StatisticsTemplate.xlsx", FileFormat.Excel2007);
        }

        private void LoadData()
        {
            try
            {
                reportDatas = dataReport.GetBudgetReportData(new BaseParam());
                dataTable = CommonHelper.ToDataTable(reportDatas);
                selects.Add(new Company()
                {
                    Id = 0,
                    Name = "无"
                });
                for (int i = 0; i < reportDatas.Count && i < SELECTITEMSMAXCOUNT; i++)
                {
                    selects.Add(new Company()
                    {
                        Id = i + 1,
                        Name = $"{reportDatas[i].CompanyName}{reportDatas[i].Year}年{reportDatas[i].Month}月预算表"
                    });
                }
                comboBox1.DataSource = selects;
                comboBox1.DisplayMember = "Name";
                pushInExcel(dataTable);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
           
        }
        private void pushInExcel(DataTable data)
        {
            sheet?.SetRangeData(new RangePosition(3, 0, data.Rows.Count, data.Columns.Count), data);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = sender as ComboBox;
            var index = item.SelectedIndex;
            var data = new List<BudgetReportData>();
            if (index == 0)
            {
                data = reportDatas.ToList();
            }
            else
            {
                data.Add(reportDatas[index-1]);             }
            pushInExcel(CommonHelper.ToDataTable(data));
        }

        private void ViewReport_Load(object sender, EventArgs e)
        {
            //sheet.InsertColumns(0,23);
            dataReport = new DataReportLogic();
            selects = new List<Company>();
            LoadData();
            InitHeader();
            sheet = excel.CurrentWorksheet;
            sheet.DeleteRows(0, 2);//删除模板1、2行
        }
    }
}
