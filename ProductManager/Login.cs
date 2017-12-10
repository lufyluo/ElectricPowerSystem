using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.Model.MessageModel;

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
        }

        private void LoginEvent(object sender, MessageEvent.MessageEventArgs e)
        {
            login1.ClearPassword();
            VisibleForm(false);
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
    }
}
