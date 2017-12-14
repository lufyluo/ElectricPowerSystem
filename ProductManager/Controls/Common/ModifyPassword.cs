using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager.Controls.Common
{
    public partial class ModifyPassword : UserControl
    {
        private readonly string oldPasswordTip = "请输入旧密码";
        private readonly string newPasswordTip = "请输入新密码";
        private readonly string repeatPasswordTip = "再次输入新密码";
        public ModifyPassword()
        {
            InitializeComponent();
        }

        private void ModifyPassword_Load(object sender, EventArgs e)
        {
            this.oldPassword.AutoSize = false;
            this.oldPassword.Height = 40;
            this.newPassword.AutoSize = false;
            this.newPassword.Height = 40;
            this.repeatPassword.AutoSize = false;
            this.repeatPassword.Height = 40;
        }

        private void newPassword_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void oldPassword_MouseEnter(object sender, EventArgs e)
        {
            this.oldPassword.UseSystemPasswordChar = true;
            if (this.oldPassword.Text == oldPasswordTip)
            {
                this.oldPassword.Text = "";
            }
        }

        private void oldPassword_MouseLeave(object sender, EventArgs e)
        {
            if (this.oldPassword.Text.Length == 0)
            {
                this.oldPassword.Text = oldPasswordTip;
                this.oldPassword.UseSystemPasswordChar = false;
                return;
            }
            this.oldPassword.UseSystemPasswordChar = true;
        }

        private void newPassword_MouseEnter(object sender, EventArgs e)
        {
            this.newPassword.UseSystemPasswordChar = true;
            if (this.newPassword.Text == newPasswordTip)
            {
                this.newPassword.Text = "";
            }
        }

        private void newPassword_MouseLeave(object sender, EventArgs e)
        {
            if (this.newPassword.Text.Length == 0)
            {
                this.newPassword.Text = newPasswordTip;
                this.newPassword.UseSystemPasswordChar = false;
                return;
            }
            this.newPassword.UseSystemPasswordChar = true;
        }

        private void repeatPassword_MouseEnter(object sender, EventArgs e)
        {
            this.repeatPassword.UseSystemPasswordChar = true;
            if (this.repeatPassword.Text == repeatPasswordTip)
            {
                this.repeatPassword.Text = "";
            }
        }

        private void repeatPassword_MouseLeave(object sender, EventArgs e)
        {
            if (this.repeatPassword.Text.Length == 0)
            {
                this.repeatPassword.Text = repeatPasswordTip;
                this.repeatPassword.UseSystemPasswordChar = false;
                return;
            }
            this.repeatPassword.UseSystemPasswordChar = true;
        }

        private void modifySubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var oldPasswordText = oldPassword.Text;
                var newPasswordText = newPassword.Text;
                var repeatPasswordText = repeatPassword.Text;
                if (newPasswordText == repeatPasswordText && oldPasswordText.Length > 0)
                {
                    MessageBox.Show("修改成功！", "Info", MessageBoxButtons.OK);
                }
                MessageBox.Show("请输入正确参数！", "Info", MessageBoxButtons.OK);
            }
            catch (Exception exception)
            {
                MessageBox.Show("修改失败！", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
