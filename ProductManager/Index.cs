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
using ProductManager.Controls.Common;
using ProductManager.MessageEvent;
using ProductManager.Model.MessageModel;
using unvell.ReoGrid;

namespace ProductManager
{
    public partial class Index : Form
    {
        public delegate void IndexEventHandler(object sender, MessageEventArgs e);
        public event IndexEventHandler IndexEvent;
        private Set setControl;
        private ViewReport homeControl;
        private Controls.View view ;
        private Controls.ImportExcel importExcel;
        private Worksheet sheet;
        private MyOpaqueLayer m_OpaqueLayer = null;//半透明蒙板层
        public Index()
        {
            InitializeComponent();
            setControl = new Set();
            setControl.SetEvent += SetControl_SetEvent;
            homeControl = new ViewReport();
            view = new Controls.View();
            navigate1.NavigateEvent += Navigate1_NavigateEvent;
            navigateTabContent.Controls.Add(homeControl);
            importExcel = new Controls.ImportExcel();
            //this.Closed += Index_Closed;
        }

        private void M_OpaqueLayer_Click(object sender, EventArgs e)
        {
            HideOpaqueLayer();
        }

        private void SetControl_SetEvent(object sender, MessageEventArgs e)
        {
            switch (e.Message)
            {
                case "modifyPassword":
                    ShowOpaqueLayer(this, 175, false);
                    break;
            }
           
        }

        private void Navigate1_NavigateEvent(object sender, MessageEventArgs e)
        {
            navigateTabContent.Controls.Clear();
            switch (e.Message)
            {
                case "Home":
                    navigateTabContent.Controls.Add(homeControl);
                    sheet = homeControl.sheet;
                    break;
                case "Import":
                    navigateTabContent.Controls.Add(importExcel);
                    sheet = null;
                    break;
                case "View":
                    navigateTabContent.Controls.Add(view);
                    sheet = homeControl.sheet;
                    break;
                case "Set":
                    navigateTabContent.Controls.Add(setControl);
                    sheet = null;
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
            if (sheet != null)
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Multiselect = true;
                fileDialog.Title = "请选择文件";
                fileDialog.Filter = "所有Excel(*.xlsx)";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var file = fileDialog.FileName;
                    sheet.Save(file, unvell.ReoGrid.IO.FileFormat.Excel2007);
                    MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("无导出内容", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //private void logout_Click(object sender, EventArgs e)
        //{
        //    RaiseEvent(nameof(Messages.Logout));
        //}

        private void exit_Click(object sender, EventArgs e)
        {
            RaiseEvent(nameof(Messages.Exit));
        }
        public void RaiseEvent(string msg)
        {
            MessageEventArgs e = new MessageEventArgs(msg);

            if (IndexEvent != null) IndexEvent(this, e);
        }
        /// <summary>
        /// 显示遮罩层
        /// </summary>
        /// <param name="control"></param>
        /// <param name="alpha"></param>
        /// <param name="showLoadingImage"></param>
        protected void ShowOpaqueLayer(Control control, int alpha, bool showLoadingImage)
        {
            if (this.m_OpaqueLayer == null)
            {
                this.m_OpaqueLayer = new MyOpaqueLayer(alpha, showLoadingImage);
                control.Controls.Add(this.m_OpaqueLayer);
                this.m_OpaqueLayer.Dock = DockStyle.Fill;
                this.m_OpaqueLayer.BringToFront();
                m_OpaqueLayer.Click += M_OpaqueLayer_Click;
            }
            this.m_OpaqueLayer.Enabled = true;
            this.m_OpaqueLayer.Visible = true;


        }

        /// <summary>
        /// 隐藏遮罩层
        /// </summary>
        protected void HideOpaqueLayer()
        {
            if (this.m_OpaqueLayer != null)
            {
                this.m_OpaqueLayer.Enabled = false;
                this.m_OpaqueLayer.Visible = false;
            }
        }
    }
}
