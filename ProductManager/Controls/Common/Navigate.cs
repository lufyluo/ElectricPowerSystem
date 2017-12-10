using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.MessageEvent;
using ProductManager.Properties;

namespace ProductManager.Controls.Common
{
    public partial class Navigate : UserControl
    {
        private readonly string barLinePrefix = "_line";
        private readonly string barPicPrefix = "_pic";
        private readonly string barLabelPrefix = "_label";
        private Control _currentSelectedPanel;

        public Navigate()
        {
            InitializeComponent();
            SetBarState(homeBar, Resources.首页_选中, Color.FromArgb(255, 0, 166, 244), true);
            _currentSelectedPanel = homeBar;
        }

        #region 首页

        private void homeBar_MouseHover(object sender, EventArgs e)
        {
            Control panel = GetContainor(sender);
            SetBarState(panel, Resources.首页_非选中, Color.White);
        }
        private void homeBar_MouseLeave(object sender, EventArgs e)
        {
            Control panel = GetContainor(sender);
            SetBarState(panel, Resources.首页_非选中1, Color.Silver);
        }

        private void homeBar_Click(object sender, EventArgs e)
        {
            Control panel = GetContainor(sender);
            if (_currentSelectedPanel != null && _currentSelectedPanel.Name == panel.Name)
            {
                return;
            }
            ResetBarsState(panel);
            SetBarState(panel, Resources.首页_选中, Color.FromArgb(255,0, 166, 244), true);
            _currentSelectedPanel = panel;

        }


        #endregion


        #region 表格导入

        private void excelImportBar_MouseHover(object sender, EventArgs e)
        {
            Control panel = GetContainor(sender);
            SetBarState(panel, Resources.表格导入_非选中, Color.White);
        }

        private void excelImportBar_MouseLeave(object sender, EventArgs e)
        {
            Control panel = GetContainor(sender);
            SetBarState(panel, Resources.表格导入_非选中1, Color.Silver);
        }
        private void excelImport_Click(object sender, EventArgs e)
        {
            Control panel = GetContainor(sender);
            if (_currentSelectedPanel != null && _currentSelectedPanel.Name == panel.Name)
            {
                return;
            }
            ResetBarsState(panel);
            SetBarState(panel, Resources.表格导入_选中, Color.FromArgb(255,0, 166, 244), true);
            _currentSelectedPanel = panel;
        }

        #endregion

        #region 查看报表

        private void viewReportBar_MouseHover(object sender, EventArgs e)
        {
            Control panel = GetContainor(sender);
            SetBarState(panel, Resources.查看报表_非选中, Color.White);
        }

        private void viewReportBar_MouseLeave(object sender, EventArgs e)
        {
            Control panel = GetContainor(sender);
            SetBarState(panel, Resources.查看报表_非选中1, Color.Silver);
        }
        private void viewReportBar_Click(object sender, EventArgs e)
        {
            Control panel = GetContainor(sender);
            if (_currentSelectedPanel != null && _currentSelectedPanel.Name == panel.Name)
            {
                return;
            }
            ResetBarsState(panel);
            SetBarState(panel, Resources.查看报表_选中, Color.FromArgb(255, 0, 166, 244), true);
            _currentSelectedPanel = panel;
        }

        #endregion

        #region 设置

        private void setBar_MouseHover(object sender, EventArgs e)
        {
            Control panel = GetContainor(sender);
            SetBarState(panel, Resources.查看报表_非选中, Color.White);
        }

        private void setBar_MouseLeave(object sender, EventArgs e)
        {
            Control panel = GetContainor(sender);
            SetBarState(panel, Resources.查看报表_非选中1, Color.Silver);
        }
        private void setBar_Click(object sender, EventArgs e)
        {
            Control panel = GetContainor(sender);
            if (_currentSelectedPanel != null && _currentSelectedPanel.Name == panel.Name)
            {
                return;
            }
            ResetBarsState(panel);
            SetBarState(panel, Resources.查看报表_选中, Color.FromArgb(255, 0, 166, 244), true);
            _currentSelectedPanel = panel;
            RaiseEvent("Set");
        }


        #endregion
        private void ResetBarsState(Control containor)
        {
            if (_currentSelectedPanel != null && _currentSelectedPanel.Name == containor.Name)
            {
                return;
            }
            ChangeState(homeBar, Resources.首页_非选中1, Color.Silver);
            ChangeState(excelImportBar, Resources.表格导入_非选中1, Color.Silver);
            ChangeState(viewReportBar, Resources.查看报表_非选中1, Color.Silver);
            ChangeState(setBar, Resources.个人设置_非选中1, Color.Silver);
        }

        private void SetBarState(Control containor, Image pic, Color foreColor, bool lineVsible=false)
        {
            if (_currentSelectedPanel != null && _currentSelectedPanel.Name == containor.Name)
            {
                return;
            }
            ChangeState(containor,pic,foreColor,lineVsible);
        }

        private void ChangeState(Control containor, Image pic, Color foreColor, bool lineVsible=false)
        {
            containor.Controls[containor.Name + barLinePrefix].Visible = lineVsible;
            containor.Controls[containor.Name + barPicPrefix].BackgroundImage = pic;
            containor.Controls[containor.Name + barLabelPrefix].ForeColor = foreColor;
        }

        private Control GetContainor(object sender)
        {
            Control panel;
            if (sender is FlowLayoutPanel)
            {
                panel = sender as Control;

            }
            else
            {
                panel = (sender as Control).Parent;
            }
            return panel;
        }


        public delegate void NavigateEventHandler(object sender, MessageEventArgs e);
        public event NavigateEventHandler NavigateEvent;
        public void RaiseEvent(string msg)
        {

            MessageEventArgs e = new MessageEventArgs(msg);

            NavigateEvent(this, e);

        }
    }
}
