using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.Controls;
using ProductManager.MessageEvent;
using ProductManager.Model.MessageModel;

namespace ProductManager
{
    public partial class Index : Form
    {
        public delegate void IndexEventHandler(object sender, MessageEventArgs e);
        public event IndexEventHandler IndexEvent;
        private Set setControl;
        public Index()
        {
            InitializeComponent();
            setControl = new Set();
            navigate1.NavigateEvent += Navigate1_NavigateEvent;
            //this.Closed += Index_Closed;
        }

        private void Navigate1_NavigateEvent(object sender, MessageEventArgs e)
        {
            navigateTabContent.Controls.Clear();
            switch (e.Message)
            {
                case "Set":
                    navigateTabContent.Controls.Add(setControl);
                    break;
                case "ModifyPassword":
                    break;
            }
        }

        private void Index_Closed(object sender, EventArgs e)
        {
            RaiseEvent(nameof(Messages.Exit));
        }

        private void logout_Click(object sender, EventArgs e)
        {
            RaiseEvent(nameof(Messages.Logout));
        }

        private void exit_Click(object sender, EventArgs e)
        {
            RaiseEvent(nameof(Messages.Exit));
        }
        public void RaiseEvent(string msg)
        {
            MessageEventArgs e = new MessageEventArgs(msg);

            if (IndexEvent != null) IndexEvent(this, e);
        }
    }
}
