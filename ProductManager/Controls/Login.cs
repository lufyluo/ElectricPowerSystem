﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.Controls.Common;
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
        private string path = "";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.accountInput.Text = accountTip;
            this.passwordInput.Text = passwordTip;
            rememberMe.Checked = CacheHelper.GetCache().IsRememberedAccount;
            if (rememberMe.Checked)
            {
                this.accountInput.Text = CacheHelper.GetCache().Account;
                this.passwordInput.Text = CacheHelper.GetCache().Password;
                this.passwordInput.UseSystemPasswordChar = true;
            }
            
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
                StoreUserInfo();
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

        public void SetFucos()
        {
            accountInput.Focus();

        }

        private void rememberMe_CheckedChanged(object sender, EventArgs e)
        {
            var check = sender as CheckBox;
            var IsChecked = check.Checked;
        }

        private void StoreUserInfo()
        {
            var cache = CacheHelper.GetCache();
            cache.Account = accountInput.Text;
            cache.Password = passwordInput.Text;
            cache.IsRememberedAccount = rememberMe.Checked;
            CacheHelper.SetCache(cache);
        }
    }
}
