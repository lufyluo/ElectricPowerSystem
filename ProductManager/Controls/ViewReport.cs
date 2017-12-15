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
using unvell.ReoGrid.IO;

namespace ProductManager.Controls
{
    public partial class ViewReport : UserControl
    {
        public Worksheet sheet;
        public ViewReport()
        {
            InitializeComponent();
            sheet = excel.CurrentWorksheet;
            //sheet.InsertColumns(0,23);
            InitHeader();
        }

        private void InitHeader()
        {
            FileFormat format = FileFormat.Excel2007;
            var path = Environment.CurrentDirectory;
            excel.Load(path + "\\Template\\StatisticsTemplate.xlsx", FileFormat.Excel2007);
        }

        public void LoadData(string name)
        {
            
        }
    }
}
