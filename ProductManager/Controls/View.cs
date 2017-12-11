using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unvell.ReoGrid.IO;

namespace ProductManager.Controls
{
    public partial class View : UserControl
    {
        public View()
        {
            InitializeComponent();
            InitHeader();
        }
        private void InitHeader()
        {
            FileFormat format = FileFormat.Excel2007;
            var path = Environment.CurrentDirectory;
            report.Load(path + "\\Template\\StatisticsTemplate.xlsx", FileFormat.Excel2007);
        }
    }
}
