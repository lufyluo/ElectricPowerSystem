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
using ProductManager.Model.ItemModel;
using ProductManager.Model.ParamModel;
using ProductManager.Model.ViewModel;
using unvell.ReoGrid;
using unvell.ReoGrid.IO;
using unvell.ReoGrid.IO.OpenXML.Schema;
using Worksheet = unvell.ReoGrid.Worksheet;

namespace ProductManager.Controls
{
    public partial class ViewReport : UserControl
    {
        public Worksheet sheet;
        public ReoGridControl workBook=>this.excel;
        private IList<BudgetReportData> selectItems;
        private DataTable dataTable;
        private IList<Company> selects;
        private DataReportLogic dataReport;
        private const int SELECTITEMSMAXCOUNT = 10;//最大下拉数量
        private IList<DateTimeItem> dateTimeItems;
        private IList<DateTimeSelect> dateTimeSelects;
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
                selectItems = dataReport.GetBudgetReportData(new BaseParam());
                dataTable = CommonHelper.ToDataTable(selectItems);
                var date = DateTime.Now;
                //selects.Add(new Company()
                //{
                //    Id = 0,
                //    Name = "无"
                //});
                for (int i = 0; i < selectItems.Count; i++)
                {
                    var year = selectItems[i].Year == 0 ? date.Year : selectItems[i].Year;
                    var month = selectItems[i].Month == 0 ? date.Month : selectItems[i].Month;
                    selects.Add(new Company()
                    {
                        Id = i + 1,
                        Name = $"{selectItems[i].CompanyName}{year}年{month}月预算表"
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
            var com = comboBox1.SelectedItem as DateTimeSelect;
            if (com != null)
            {
                var data = com.Month==null? dataReport.GetBudgetReportDataByYear(new BaseParam()
                {
                    Year = com.Year
                   }): dataReport.GetBudgetReportDataByMonth(new BaseParam()
                {
                    Year = com.Year,
                    Month = com.Month
                });
                pushInExcel(CommonHelper.ToDataTable(data));
            }
        }

        private void ViewReport_Load(object sender, EventArgs e)
        {
            //sheet.InsertColumns(0,23);
            dataReport = new DataReportLogic();
            selects = new List<Company>();
            InitHeader();
            sheet = excel.CurrentWorksheet;
            sheet.DeleteRows(0, 2);//删除模板1、2行
            //LoadData();
            LoadSelectItems();
            sheet.SetCols(22);
            sheet.Resize(200, 22);
            sheet.BeforeCellEdit += (s, ev) => ev.IsCancelled = true;
            if(comboBox1.Items.Count>0) comboBox1.SelectedIndex = 0;
            ExcelHelper.SetDecimalFormat(sheet,2);
            sheet.AutoFitColumnWidth(0, false);
        }

        private void LoadSelectItems()
        {
            dateTimeSelects = dataReport.GetDateTimeItems().Select(n => new DateTimeSelect()
            {
                Year = n.Year,
                Month = n.Month
            }).ToList();
            comboBox1.DataSource = dateTimeSelects;
            comboBox1.DisplayMember = "Show";
        }

        private void exportBtn_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExporAsExcel(excel);
        }
    }
}
