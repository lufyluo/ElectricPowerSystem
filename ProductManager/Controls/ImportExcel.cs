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
        private string[] filePaths;
        private string showName;
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
                filePaths = fileDialog.FileNames;
                var fileNames = GetShowFilsName();
                MessageBox.Show("已选择文件:" + fileNames, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fileName.Text = fileNames;
            }
        }

        private void import_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (filePaths.Length <= 0)
                {
                    MessageBox.Show("请选择文件", "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                fileName.Text = "数据导入中....";
                bool result = false;
                foreach (var filePath in filePaths)
                {
                    result = importLogic.ImportExcel(filePath) || result;
                }
                MessageBox.Show(result ? "导入成功" : "导入失败，请重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fileName.Text = "";
                filePaths = new string[0];
            }
            catch (Exception exception)
            {
                MessageBox.Show( "导入失败，请检查文档是否符合标准！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private string GetShowFilsName()
        {
            showName = "";
            foreach (var filePath in filePaths)
            {
                showName += filePath.Split('\\').LastOrDefault()+",";
            }
            
            return showName.TrimEnd(','); 
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            fileName.Text = "";
            filePaths = new string[0];
        }
    }
}
