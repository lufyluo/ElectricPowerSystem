using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.ImportExcel;

namespace ProductManager.Controls
{
    public partial class ImportExcel : UserControl
    {
        private string file;
        private ImportLogic importLogic;
        public ImportExcel()
        {
            InitializeComponent();
            importLogic = new ImportLogic();
        }

        private void openFile_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有Excel(*.xlsx)|*.xls";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                file = fileDialog.FileName;
                MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fileName.Text = file.Split('\\').LastOrDefault();
            }
        }

        private void import_btn_Click(object sender, EventArgs e)
        {
            var result = importLogic.ImportExcel(file);
            MessageBox.Show(result ? "导入成功" : "导入失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
