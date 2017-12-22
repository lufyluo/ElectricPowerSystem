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
            this.line_search = new System.Windows.Forms.Button();
            this.line_Month = new System.Windows.Forms.ComboBox();
            this.line_Year = new System.Windows.Forms.ComboBox();
            this.line_Company = new System.Windows.Forms.ComboBox();
            this.line_Property = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lineChart1 = new ProductManager.Controls.LineChart();
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
            this.tabPage1.SuspendLayout();
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
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1155, 687);
            this.tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab.TabIndex = 0;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.line_search);
            this.tabPage1.Controls.Add(this.line_Month);
            this.tabPage1.Controls.Add(this.line_Year);
            this.tabPage1.Controls.Add(this.line_Company);
            this.tabPage1.Controls.Add(this.line_Property);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lineChart1);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1147, 639);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "趋势分析图";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // line_search
            // 
            this.line_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(244)))));
            this.line_search.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.line_search.ForeColor = System.Drawing.Color.White;
            this.line_search.Location = new System.Drawing.Point(975, 19);
            this.line_search.Name = "line_search";
            this.line_search.Size = new System.Drawing.Size(90, 32);
            this.line_search.TabIndex = 5;
            this.line_search.Text = "查询";
            this.line_search.UseVisualStyleBackColor = false;
            this.line_search.Click += new System.EventHandler(this.line_search_Click);
            // 
            // line_Month
            // 
            this.line_Month.FormattingEnabled = true;
            this.line_Month.IntegralHeight = false;
            this.line_Month.Location = new System.Drawing.Point(823, 21);
            this.line_Month.Name = "line_Month";
            this.line_Month.Size = new System.Drawing.Size(121, 29);
            this.line_Month.TabIndex = 4;
            this.line_Month.SelectedIndexChanged += new System.EventHandler(this.line_Month_SelectedIndexChanged);
            // 
            // line_Year
            // 
            this.line_Year.FormattingEnabled = true;
            this.line_Year.Location = new System.Drawing.Point(581, 21);
            this.line_Year.Name = "line_Year";
            this.line_Year.Size = new System.Drawing.Size(121, 29);
            this.line_Year.TabIndex = 4;
            this.line_Year.SelectedIndexChanged += new System.EventHandler(this.line_Year_SelectedIndexChanged);
            // 
            // line_Company
            // 
            this.line_Company.FormattingEnabled = true;
            this.line_Company.IntegralHeight = false;
            this.line_Company.Location = new System.Drawing.Point(344, 21);
            this.line_Company.Name = "line_Company";
            this.line_Company.Size = new System.Drawing.Size(121, 29);
            this.line_Company.TabIndex = 4;
            this.line_Company.SelectedIndexChanged += new System.EventHandler(this.line_Company_SelectedIndexChanged);
            // 
            // line_Property
            // 
            this.line_Property.FormattingEnabled = true;
            this.line_Property.IntegralHeight = false;
            this.line_Property.Location = new System.Drawing.Point(114, 21);
            this.line_Property.Name = "line_Property";
            this.line_Property.Size = new System.Drawing.Size(121, 29);
            this.line_Property.TabIndex = 4;
            this.line_Property.SelectedIndexChanged += new System.EventHandler(this.line_Property_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label7.Location = new System.Drawing.Point(733, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "选择时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label6.Location = new System.Drawing.Point(491, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "选择年份";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(254, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "选择公司";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(24, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "趋势参数";
            // 
            // lineChart1
            // 
            this.lineChart1.Location = new System.Drawing.Point(-5, 59);
            this.lineChart1.Margin = new System.Windows.Forms.Padding(5);
            this.lineChart1.Name = "lineChart1";
            this.lineChart1.Size = new System.Drawing.Size(1136, 618);
            this.lineChart1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataReport);
            this.tabPage2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1147, 639);
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
            this.dataReport.Location = new System.Drawing.Point(1, 3);
            this.dataReport.Name = "dataReport";
            this.dataReport.Size = new System.Drawing.Size(1146, 617);
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
            this.monthSelect.IntegralHeight = false;
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
            this.companySelect.IntegralHeight = false;
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
            this.report.SheetTabWidth = 180;
            this.report.ShowScrollEndSpacing = true;
            this.report.Size = new System.Drawing.Size(1130, 531);
            this.report.TabIndex = 0;
            this.report.Text = "reoGridControl1";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tab);
            this.Name = "View";
            this.Size = new System.Drawing.Size(1155, 677);
            this.Load += new System.EventHandler(this.View_Load);
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.dataReport.ResumeLayout(false);
            this.dataReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private LineChart lineChart1;
        private System.Windows.Forms.ComboBox line_Month;
        private System.Windows.Forms.ComboBox line_Year;
        private System.Windows.Forms.ComboBox line_Company;
        private System.Windows.Forms.ComboBox line_Property;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button line_search;
        private System.Windows.Forms.Panel dataReport;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox monthSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox yearSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox companySelect;
        private System.Windows.Forms.Label label1;
        private unvell.ReoGrid.ReoGridControl report;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
