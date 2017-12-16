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
            initData();

        }

        void initData()
        {
            worksheet = this.reoGridControl1.CurrentWorksheet;

            // prepare the data source on worksheet
            worksheet["A2"] = new object[,] {
                { null, 2008, 2009, 2010, 2011, 2012 },
                { "City 1", 3, 2, 4, 2, 6 },
                { "City 2", 7, 5, 3, 6, 4 },
                { "City 3", 13, 10, 9, 10, 9 },
                { "City 4", 13, 10, 9, 10, 9 },
                { "City 5", 13, 10, 9, 10, 9 },
                { "City 6", 13, 10, 9, 10, 9 },
                { "City 7", 13, 10, 9, 10, 9 },
                { "Total", "=SUM(B3:B9)", "=SUM(C3:C9)", "=SUM(D3:D9)",
                    "=SUM(E3:E9)", "=SUM(F3:F9)" },
            };
            var dataRange = worksheet.Ranges["B3:F9"];
            var serialNamesRange = worksheet.Ranges["A3:A10"];
            var categoryNamesRange = worksheet.Ranges["B2:F2"];
            chart = new unvell.ReoGrid.Chart.LineChart()
            {
                Location = new unvell.ReoGrid.Graphics.Point(0, 0),//new Graphics.Point(220, 160),
                Size = new unvell.ReoGrid.Graphics.Size(1200, 553),//new Graphics.Size(400, 260),

                Title = "",

                // Specify data source.
                // Data source is created from serial data and names for every serial data.
                DataSource = new WorksheetChartDataSource(worksheet, serialNamesRange, dataRange)
                {
                    CategoryNameRange = categoryNamesRange,
                }
            };
            worksheet.FloatingObjects.Add(chart);
        }

        public void LoadData(DataTable dataTable, string[] serialName)
        {
            worksheet.Reset();
            worksheet["A2"] = serialName;
            worksheet.SetRangeData(new RangePosition(2, 0, dataTable.Rows.Count, dataTable.Columns.Count), dataTable);
            ChartRender(dataTable, serialName);
        }

        private void ChartRender(DataTable dataTable, string[] serialName)
        {
            var dataStartRow = 3;
            var dataStartColumn = "B";
            var categoryNameRow = 2;
            var categoryNameColumn = "A";
            var dataRange = worksheet.Ranges[$"{dataStartColumn}{dataStartRow}:{NunberToChar(dataTable.Columns.Count + 1)}{dataTable.Rows.Count + dataStartRow}"];
            var serialNamesRange = worksheet.Ranges[$"{categoryNameColumn}{dataStartRow}:{categoryNameColumn}{dataTable.Rows.Count + dataStartRow}"];
            var categoryNamesRange = worksheet.Ranges[$"{categoryNameColumn}{categoryNameRow}:{NunberToChar(serialName.Length + 1)}{categoryNameRow}"];
            chart.DataSource = new WorksheetChartDataSource(worksheet, serialNamesRange, dataRange)
            {
                CategoryNameRange = categoryNamesRange,
            };
            worksheet.FloatingObjects.Add(chart);
        }

        private ReferenceRange GetSerial()
        {
            return worksheet.Ranges[$"A2:A10"];
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
    }
}
