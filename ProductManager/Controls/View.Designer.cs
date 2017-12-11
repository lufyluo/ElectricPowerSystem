namespace ProductManager.Controls
{
    partial class View
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataReport = new System.Windows.Forms.Panel();
            this.report = new unvell.ReoGrid.ReoGridControl();
            this.tab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.dataReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab.ItemSize = new System.Drawing.Size(98, 40);
            this.tab.Location = new System.Drawing.Point(3, 3);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1126, 671);
            this.tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1118, 623);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "趋势分析图";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataReport);
            this.tabPage2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1118, 623);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据报表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataReport
            // 
            this.dataReport.Controls.Add(this.report);
            this.dataReport.Location = new System.Drawing.Point(0, 0);
            this.dataReport.Name = "dataReport";
            this.dataReport.Size = new System.Drawing.Size(1118, 617);
            this.dataReport.TabIndex = 0;
            // 
            // report
            // 
            this.report.BackColor = System.Drawing.Color.White;
            this.report.ColumnHeaderContextMenuStrip = null;
            this.report.LeadHeaderContextMenuStrip = null;
            this.report.Location = new System.Drawing.Point(6, 59);
            this.report.Name = "report";
            this.report.RowHeaderContextMenuStrip = null;
            this.report.Script = null;
            this.report.SheetTabContextMenuStrip = null;
            this.report.SheetTabNewButtonVisible = true;
            this.report.SheetTabVisible = true;
            this.report.SheetTabWidth = 60;
            this.report.ShowScrollEndSpacing = true;
            this.report.Size = new System.Drawing.Size(1106, 518);
            this.report.TabIndex = 0;
            this.report.Text = "reoGridControl1";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tab);
            this.Name = "View";
            this.Size = new System.Drawing.Size(1126, 677);
            this.tab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.dataReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel dataReport;
        private unvell.ReoGrid.ReoGridControl report;
    }
}
