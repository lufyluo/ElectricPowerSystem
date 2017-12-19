using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
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
            File.SetAttributes(Path.Combine("Db", "ProductManagerDB.db"), FileAttributes.Normal);
            //SetAccess(System.Environment.UserName, Environment.CurrentDirectory);
            //SetFileAccess(System.Environment.UserName,Path.Combine(Environment.CurrentDirectory,"Db", "ProductManagerDB.db"));
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
        private static bool SetAccess(string user, string folder)
        {
            //定义为完全控制的权限
            const FileSystemRights Rights = FileSystemRights.FullControl;

            //添加访问规则到实际目录
            var AccessRule = new FileSystemAccessRule(user, Rights,
                InheritanceFlags.None,
                PropagationFlags.NoPropagateInherit,
                AccessControlType.Allow);

            var Info = new DirectoryInfo(folder);
            var Security = Info.GetAccessControl(AccessControlSections.Access);

            bool Result;
            Security.ModifyAccessRule(AccessControlModification.Set, AccessRule, out Result);
            if (!Result) return false;

            //总是允许再目录上进行对象继承
            const InheritanceFlags iFlags = InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit;

            //为继承关系添加访问规则
            AccessRule = new FileSystemAccessRule(user, Rights,
                iFlags,
                PropagationFlags.InheritOnly,
                AccessControlType.Allow);

            Security.ModifyAccessRule(AccessControlModification.Add, AccessRule, out Result);
            if (!Result) return false;

            Info.SetAccessControl(Security);

            return true;
        }

        private static bool SetFileAccess(string user, string filePath)
        {
            System.IO.FileInfo fileInfo = new FileInfo(filePath);
            FileSecurity fs = fileInfo.GetAccessControl();
            fs.AddAccessRule(new FileSystemAccessRule(user, FileSystemRights.Modify, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow));
            fileInfo.SetAccessControl(fs);

            return true;
        }
    }
}
