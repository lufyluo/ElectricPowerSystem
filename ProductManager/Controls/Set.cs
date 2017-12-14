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

namespace ProductManager.Controls
{
    public partial class Set : UserControl
    {
        public Set()
        {
            InitializeComponent();
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
                var changes = new CompanyLogic().Add(companysItems);
                MessageBox.Show($"添加{changes}条记录成功", "Info", MessageBoxButtons.OK);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show($"发生错误:{exception.Message}", "Error", MessageBoxButtons.OK);
            }
            

        }
    }
}
