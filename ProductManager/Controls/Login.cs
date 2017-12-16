using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.Logic;
using ProductManager.MessageEvent;
using ProductManager.Model.MessageModel;
using ProductManager.Model.ViewModel;

namespace ProductManager.Controls
{
    public partial class Login : UserControl
    {
        private readonly string accountTip = "请输入用户名";
        private readonly string passwordTip = "请输入密码";
        public delegate void LoginEventHandler(object sender, MessageEventArgs e);
        public event LoginEventHandler LoginEvent;
        private UserLogic userLogic = new UserLogic();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.accountInput.Text = accountTip;
            this.passwordInput.Text = passwordTip;
            accountInput.Focus();
        }
        private void accountInput_MouseEnter(object sender, EventArgs e)
        {
            if (this.accountInput.Text == accountTip)
            {
                this.accountInput.Text = "";
            }
        }

        private void accountInput_MouseLeave(object sender, EventArgs e)
        {
            if (this.accountInput.Text.Length==0)
            {
                this.accountInput.Text = accountTip;
            }
        }


        private void passwordInput_Leave(object sender, EventArgs e)
        {
            if (this.passwordInput.Text.Length == 0)
            {
                this.passwordInput.Text = passwordTip;
                this.passwordInput.UseSystemPasswordChar = false;
                return;
            }
            this.passwordInput.UseSystemPasswordChar = true;
        }

        private void passwordInput_Enter(object sender, EventArgs e)
        {
            this.passwordInput.UseSystemPasswordChar = true;
            if (this.passwordInput.Text == passwordTip)
            {
                this.passwordInput.Text = "";
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var result = userLogic.Login(this.accountInput.Text, this.passwordInput.Text);
            if (result)
            {
                RaiseEvent(nameof(Messages.Login));
            }
            else
            {
                this.loginTip.Visible = true;
            }

        }

        public void ClearPassword()
        {
            this.passwordInput.Text = passwordTip;
        }

        public void RaiseEvent(string msg)
        {

            MessageEventArgs e = new MessageEventArgs(msg);

            LoginEvent(this,e);

        }
    }
}
