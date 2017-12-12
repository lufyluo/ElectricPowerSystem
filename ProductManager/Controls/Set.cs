﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.Controls.Common;

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

            PopModifyPassowrd pmp = new PopModifyPassowrd();
            pmp.ShowDialog();
        }
    }
}