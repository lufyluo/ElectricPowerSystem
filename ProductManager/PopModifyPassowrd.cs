using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class PopModifyPassowrd : Form
    {
        public PopModifyPassowrd()
        {
            InitializeComponent();
        }

        private void PopWindow_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
            modifyPassword1.VisibleChanged += ModifyPassword1_VisibleChanged;
        }

        private void ModifyPassword1_VisibleChanged(object sender, EventArgs e)
        {
            if(modifyPassword1.Visible ==false)
                this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
