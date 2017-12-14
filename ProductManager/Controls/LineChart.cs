using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unvell.ReoGrid.Chart;
using unvell.ReoGrid.Graphics;

namespace ProductManager.Controls
{
    public partial class LineChart : UserControl
    {
        public LineChart()
        {
            InitializeComponent();
            initData();
            
        }

        void initData()
        {
            var worksheet = this.reoGridControl1.CurrentWorksheet;

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
            Chart c = new unvell.ReoGrid.Chart.LineChart()
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
            worksheet.FloatingObjects.Add(c);
        }
    }
}
