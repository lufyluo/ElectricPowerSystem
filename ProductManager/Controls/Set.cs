using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.Controls.Common;
using ProductManager.Logic;
using ProductManager.MessageEvent;
using ProductManager.Model.ItemModel;
using ProductManager.Model.ViewModel;

namespace ProductManager.Controls
{
    public partial class Set : UserControl
    {
        private List<string> companies;
        private CompanyLogic companyLogic;
        public Set()
        {
            InitializeComponent();
            this.Load += Set_Load;
        }

        private void Set_Load(object sender, EventArgs e)
        {
            companyLogic = new CompanyLogic();
            iniExistCompanyNames();
        }

        private void iniExistCompanyNames()
        {
            companies = companyLogic.GetCompanys().Select(n => n.Name).ToList();
            foreach (var name in companies)
            {
                this.companyBox.Text += name + "\r\n";
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            this.companyBox.AutoSize = false;
        }

        private void modifyPassword_Click(object sender, EventArgs e)
        {
            //RaiseEvent("modifyPassword");
            PopModifyPassowrd pmp = new PopModifyPassowrd();
            pmp.ShowDialog();
        }
        public delegate void SetEventHandler(object sender, MessageEventArgs e);
        public event SetEventHandler SetEvent;
        public void RaiseEvent(string msg)
        {

            MessageEventArgs e = new MessageEventArgs(msg);

            SetEvent(this, e);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var companysItems = companyBox.Lines.Select(n => new CompanyItem()
                {
                    Name = n
                }).ToList();

                DeleteCompanys(companysItems);
                companyLogic.Add(companysItems);
                MessageBox.Show($"保存成功", "Info", MessageBoxButtons.OK);
                companies = companyLogic.GetCompanys().Select(n => n.Name).ToList();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show($"发生错误:{exception.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void DeleteCompanys(List<CompanyItem> companysItems)
        {
            var intersectedList = companies.Except(companysItems.Select(n => n.Name)).ToList();
            companyLogic.Delete(intersectedList);
        }
    }
}
