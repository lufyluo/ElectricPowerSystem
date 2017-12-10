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
    }
}
