using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.Helper;
using ProductManager.ImportExcel;
using ProductManager.Logic;
using ProductManager.Model.MessageModel;
using ProductManager.Model.ParamModel;

namespace ProductManager
{
    public partial class Login : Form
    {
        private Index content;
        private int _top;
        public Login()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.login1.LoginEvent += LoginEvent;
            content = new Index();
            content.IndexEvent += Dispatcher_MessageEvent;
            _top = Top;

            //var importLogic = new ImportLogic();
            //var xx1 = importLogic.ImportExcel(@"C:\Users\zhaob\Desktop\luofly\财务类型表\财务快报-其他指标表_国网四川省电力公司.xls");
            //var xx2 = importLogic.ImportExcel(@"C:\Users\zhaob\Desktop\luofly\财务类型表\财务快报-成本费用表_国网四川省电力公司.xls");
            //var xx3 = importLogic.ImportExcel(@"C:\Users\zhaob\Desktop\luofly\财务类型表\财务快报-利润表_国网四川省电力公司.xls");

            //var dataReportLogic = new DataReportLogic();
            //var xx = dataReportLogic.GetBudgetReportData(new BaseParam());

            //var importLogic = new ImportLogic();

            //var xx1 = importLogic.ImportExcel(@"C:\Users\zhaob\Desktop\luofly\财务类型表\财务快报-其他指标表_国网四川省电力公司.xls");
            //var xx2 = importLogic.ImportExcel(@"C:\Users\zhaob\Desktop\luofly\财务类型表\财务快报-成本费用表_国网四川省电力公司.xls");
            //var xx3 = importLogic.ImportExcel(@"C:\Users\zhaob\Desktop\luofly\财务类型表\财务快报-利润表_国网四川省电力公司.xls");
        }

        private void LoginEvent(object sender, MessageEvent.MessageEventArgs e)
        {
            login1.ClearPassword();
            VisibleForm(false);
            if(content==null)
                content = new Index();
            content.ShowDialog();
        }

        private void Dispatcher_MessageEvent(object sender, MessageEvent.MessageEventArgs e)
        {
            switch (e.Message)
            {
                case nameof(Messages.Logout):
                    content.Hide();
                    VisibleForm(true);
                    break;
                case nameof(Messages.Exit):
                    System.Environment.Exit(0);
                    break;
            }
        }

        private void VisibleForm(bool visible)
        {
            if(!visible)this.Hide();
            else
            {
                this.Show();
            }
        }

        private void login1_Load(object sender, EventArgs e)
        {
            
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            this.login1.SetFucos();
        }
    }
}
