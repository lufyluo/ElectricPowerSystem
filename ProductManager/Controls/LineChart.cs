using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unvell.ReoGrid;
using unvell.ReoGrid.Chart;
using unvell.ReoGrid.Graphics;

namespace ProductManager.Controls
{
    public partial class LineChart : UserControl
    {
        public Worksheet worksheet;
        private Chart chart;
        public LineChart()
        {
            InitializeComponent();

        }

        void initData()
        {
            worksheet = this.reoGridControl1.CurrentWorksheet;
            worksheet.SetRows(49);

        }
        //废除但保留
        public void LoadData(DataTable dataTable, string[] serialName)
        {
            //worksheet.Reset();
            ClearRange(worksheet);
            worksheet["A2"] = serialName;
            worksheet.SetRangeData(new RangePosition(2, 0, dataTable.Rows.Count, dataTable.Columns.Count), dataTable);
            ChartRender(dataTable, serialName);
        }
        public void LoadData(string[] dataTable, string[] serialName)
        {
            //worksheet.Reset();
            ClearRange(worksheet);
            worksheet["A2"] = serialName;
            worksheet["A3"] = dataTable;
            //worksheet.SetRangeData(new RangePosition(2, 0, 1, dataTable.Length), dataTable);
            ChartRender(dataTable, serialName);
        }

        private void ChartRender(string[] dataTable, string[] serialName)
        {
            var dataRange = worksheet.Ranges[$"A3:{NunberToChar(serialName.Length)}3"];
            var serialNamesRange = worksheet.Ranges[$"P3:P3"];
            var categoryNamesRange = worksheet.Ranges[$"A2:{NunberToChar(serialName.Length)}2"];
            chart = new unvell.ReoGrid.Chart.LineChart()
            {
                Location = new unvell.ReoGrid.Graphics.Point(0, 0),//new Graphics.Point(220, 160),
                Size = new unvell.ReoGrid.Graphics.Size(1200, 553),//new Graphics.Size(400, 260),

                Title = "",
                DataSource = new WorksheetChartDataSource(worksheet, serialNamesRange, dataRange)
                {
                    CategoryNameRange = categoryNamesRange,
                }
            };
            worksheet.FloatingObjects.Add(chart);
        }

        //废除但保留
        private void ChartRender(DataTable dataTable, string[] serialName)
        {
            var dataStartRow = 3;
            var dataStartColumn = "B";
            var categoryNameRow = 2;
            var categoryNameColumn = "A";
            var dataRange = worksheet.Ranges[$"{dataStartColumn}{dataStartRow}:{NunberToChar(dataTable.Columns.Count + 1)}{dataTable.Rows.Count + dataStartRow}"];
            var serialNamesRange = worksheet.Ranges[$"{categoryNameColumn}{dataStartRow}:{categoryNameColumn}{dataTable.Rows.Count + dataStartRow}"];
            var categoryNamesRange = worksheet.Ranges[$"{categoryNameColumn}{categoryNameRow}:{NunberToChar(serialName.Length + 1)}{categoryNameRow}"];
            //chart = new unvell.ReoGrid.Chart.LineChart()
            //{
            //    Location = new unvell.ReoGrid.Graphics.Point(0, 0),//new Graphics.Point(220, 160),
            //    Size = new unvell.ReoGrid.Graphics.Size(1200, 553),//new Graphics.Size(400, 260),

            //    Title = "",

            //    // Specify data source.
            //    // Data source is created from serial data and names for every serial data.
            //    DataSource = new WorksheetChartDataSource(worksheet, serialNamesRange, dataRange)
            //    {
            //        CategoryNameRange = categoryNamesRange,
            //    }
            //};
            //worksheet.FloatingObjects.Add(chart);
        }

        private string NunberToChar(int number)
        {
            if (1 <= number && 36 >= number)
            {
                int num = number + 64;
                System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
                byte[] btNumber = new byte[] { (byte)num };
                return asciiEncoding.GetString(btNumber).ToUpper();
            }
            return "数字不在转换范围内";
        }
        private void ClearRange(Worksheet sheet)
        {
            var range = sheet.Ranges[$"A3:V20"];
            foreach (var rangeCell in range.Cells)
            {

                rangeCell.Data = "";
            }
        }

        private void LineChart_Load(object sender, EventArgs e)
        {
            initData();
            worksheet.SetColumnsWidth(0, 1, 200);
            worksheet.AutoFitColumnWidth(0);
        }
    }
}
