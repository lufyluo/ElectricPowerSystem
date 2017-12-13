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
            this.search = new System.Windows.Forms.Button();
            this.monthSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yearSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.companySelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tab.ItemSize = new System.Drawing.Size(121, 40);
            this.tab.Location = new System.Drawing.Point(3, 3);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1126, 671);
            this.tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
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
            this.dataReport.Controls.Add(this.search);
            this.dataReport.Controls.Add(this.monthSelect);
            this.dataReport.Controls.Add(this.label3);
            this.dataReport.Controls.Add(this.yearSelect);
            this.dataReport.Controls.Add(this.label2);
            this.dataReport.Controls.Add(this.companySelect);
            this.dataReport.Controls.Add(this.label1);
            this.dataReport.Controls.Add(this.report);
            this.dataReport.Location = new System.Drawing.Point(0, 0);
            this.dataReport.Name = "dataReport";
            this.dataReport.Size = new System.Drawing.Size(1118, 617);
            this.dataReport.TabIndex = 0;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(244)))));
            this.search.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(727, 15);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(90, 32);
            this.search.TabIndex = 3;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // monthSelect
            // 
            this.monthSelect.FormattingEnabled = true;
            this.monthSelect.Location = new System.Drawing.Point(574, 17);
            this.monthSelect.Name = "monthSelect";
            this.monthSelect.Size = new System.Drawing.Size(121, 29);
            this.monthSelect.TabIndex = 2;
            this.monthSelect.SelectedIndexChanged += new System.EventHandler(this.monthSelect_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(484, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "选择时间";
            // 
            // yearSelect
            // 
            this.yearSelect.FormattingEnabled = true;
            this.yearSelect.Location = new System.Drawing.Point(341, 17);
            this.yearSelect.Name = "yearSelect";
            this.yearSelect.Size = new System.Drawing.Size(121, 29);
            this.yearSelect.TabIndex = 2;
            this.yearSelect.SelectedIndexChanged += new System.EventHandler(this.yearSelect_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(251, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择年份";
            // 
            // companySelect
            // 
            this.companySelect.FormattingEnabled = true;
            this.companySelect.Location = new System.Drawing.Point(109, 17);
            this.companySelect.Name = "companySelect";
            this.companySelect.Size = new System.Drawing.Size(121, 29);
            this.companySelect.TabIndex = 2;
            this.companySelect.SelectedIndexChanged += new System.EventHandler(this.companySelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择公司";
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
            this.dataReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel dataReport;
        private unvell.ReoGrid.ReoGridControl report;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox monthSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox yearSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox companySelect;
        private System.Windows.Forms.Label label1;
    }
}
