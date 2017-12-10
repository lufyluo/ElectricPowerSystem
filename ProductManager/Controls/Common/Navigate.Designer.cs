namespace ProductManager.Controls.Common
{
    partial class Navigate
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
            this.homeBar_line = new System.Windows.Forms.Label();
            this.homeBar = new System.Windows.Forms.FlowLayoutPanel();
            this.homeBar_pic = new System.Windows.Forms.PictureBox();
            this.homeBar_label = new System.Windows.Forms.Label();
            this.excelImportBar = new System.Windows.Forms.FlowLayoutPanel();
            this.excelImportBar_line = new System.Windows.Forms.Label();
            this.excelImportBar_pic = new System.Windows.Forms.PictureBox();
            this.excelImportBar_label = new System.Windows.Forms.Label();
            this.viewReportBar = new System.Windows.Forms.FlowLayoutPanel();
            this.viewReportBar_line = new System.Windows.Forms.Label();
            this.viewReportBar_pic = new System.Windows.Forms.PictureBox();
            this.viewReportBar_label = new System.Windows.Forms.Label();
            this.setBar = new System.Windows.Forms.FlowLayoutPanel();
            this.setBar_line = new System.Windows.Forms.Label();
            this.setBar_pic = new System.Windows.Forms.PictureBox();
            this.setBar_label = new System.Windows.Forms.Label();
            this.homeBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeBar_pic)).BeginInit();
            this.excelImportBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.excelImportBar_pic)).BeginInit();
            this.viewReportBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewReportBar_pic)).BeginInit();
            this.setBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setBar_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // homeBar_line
            // 
            this.homeBar_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(244)))));
            this.homeBar_line.Enabled = false;
            this.homeBar_line.Location = new System.Drawing.Point(0, 0);
            this.homeBar_line.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.homeBar_line.Name = "homeBar_line";
            this.homeBar_line.Size = new System.Drawing.Size(3, 44);
            this.homeBar_line.TabIndex = 1;
            this.homeBar_line.Visible = false;
            // 
            // homeBar
            // 
            this.homeBar.Controls.Add(this.homeBar_line);
            this.homeBar.Controls.Add(this.homeBar_pic);
            this.homeBar.Controls.Add(this.homeBar_label);
            this.homeBar.Location = new System.Drawing.Point(0, 31);
            this.homeBar.Name = "homeBar";
            this.homeBar.Size = new System.Drawing.Size(200, 44);
            this.homeBar.TabIndex = 0;
            this.homeBar.WrapContents = false;
            this.homeBar.Click += new System.EventHandler(this.homeBar_Click);
            this.homeBar.MouseLeave += new System.EventHandler(this.homeBar_MouseLeave);
            this.homeBar.MouseHover += new System.EventHandler(this.homeBar_MouseHover);
            // 
            // homeBar_pic
            // 
            this.homeBar_pic.BackgroundImage = global::ProductManager.Properties.Resources.首页_非选中1;
            this.homeBar_pic.Location = new System.Drawing.Point(21, 14);
            this.homeBar_pic.Margin = new System.Windows.Forms.Padding(15, 14, 3, 3);
            this.homeBar_pic.Name = "homeBar_pic";
            this.homeBar_pic.Size = new System.Drawing.Size(18, 18);
            this.homeBar_pic.TabIndex = 2;
            this.homeBar_pic.TabStop = false;
            this.homeBar_pic.Click += new System.EventHandler(this.homeBar_Click);
            this.homeBar_pic.MouseHover += new System.EventHandler(this.homeBar_MouseHover);
            // 
            // homeBar_label
            // 
            this.homeBar_label.AutoSize = true;
            this.homeBar_label.BackColor = System.Drawing.Color.Transparent;
            this.homeBar_label.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.homeBar_label.ForeColor = System.Drawing.Color.Silver;
            this.homeBar_label.Location = new System.Drawing.Point(50, 13);
            this.homeBar_label.Margin = new System.Windows.Forms.Padding(8, 13, 3, 0);
            this.homeBar_label.Name = "homeBar_label";
            this.homeBar_label.Size = new System.Drawing.Size(37, 20);
            this.homeBar_label.TabIndex = 3;
            this.homeBar_label.Text = "首页";
            this.homeBar_label.Click += new System.EventHandler(this.homeBar_Click);
            this.homeBar_label.MouseHover += new System.EventHandler(this.homeBar_MouseHover);
            // 
            // excelImportBar
            // 
            this.excelImportBar.Controls.Add(this.excelImportBar_line);
            this.excelImportBar.Controls.Add(this.excelImportBar_pic);
            this.excelImportBar.Controls.Add(this.excelImportBar_label);
            this.excelImportBar.Location = new System.Drawing.Point(0, 71);
            this.excelImportBar.Name = "excelImportBar";
            this.excelImportBar.Size = new System.Drawing.Size(200, 44);
            this.excelImportBar.TabIndex = 4;
            this.excelImportBar.WrapContents = false;
            this.excelImportBar.Click += new System.EventHandler(this.excelImport_Click);
            this.excelImportBar.MouseLeave += new System.EventHandler(this.excelImportBar_MouseLeave);
            this.excelImportBar.MouseHover += new System.EventHandler(this.excelImportBar_MouseHover);
            // 
            // excelImportBar_line
            // 
            this.excelImportBar_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(244)))));
            this.excelImportBar_line.Enabled = false;
            this.excelImportBar_line.Location = new System.Drawing.Point(0, 0);
            this.excelImportBar_line.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.excelImportBar_line.Name = "excelImportBar_line";
            this.excelImportBar_line.Size = new System.Drawing.Size(3, 44);
            this.excelImportBar_line.TabIndex = 1;
            this.excelImportBar_line.Visible = false;
            // 
            // excelImportBar_pic
            // 
            this.excelImportBar_pic.BackgroundImage = global::ProductManager.Properties.Resources.表格导入_非选中1;
            this.excelImportBar_pic.Location = new System.Drawing.Point(21, 14);
            this.excelImportBar_pic.Margin = new System.Windows.Forms.Padding(15, 14, 3, 3);
            this.excelImportBar_pic.Name = "excelImportBar_pic";
            this.excelImportBar_pic.Size = new System.Drawing.Size(18, 18);
            this.excelImportBar_pic.TabIndex = 2;
            this.excelImportBar_pic.TabStop = false;
            this.excelImportBar_pic.Click += new System.EventHandler(this.excelImport_Click);
            this.excelImportBar_pic.MouseHover += new System.EventHandler(this.excelImportBar_MouseHover);
            // 
            // excelImportBar_label
            // 
            this.excelImportBar_label.AutoSize = true;
            this.excelImportBar_label.BackColor = System.Drawing.Color.Transparent;
            this.excelImportBar_label.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.excelImportBar_label.ForeColor = System.Drawing.Color.Silver;
            this.excelImportBar_label.Location = new System.Drawing.Point(50, 13);
            this.excelImportBar_label.Margin = new System.Windows.Forms.Padding(8, 13, 3, 0);
            this.excelImportBar_label.Name = "excelImportBar_label";
            this.excelImportBar_label.Size = new System.Drawing.Size(65, 20);
            this.excelImportBar_label.TabIndex = 3;
            this.excelImportBar_label.Text = "表格导入";
            this.excelImportBar_label.Click += new System.EventHandler(this.excelImport_Click);
            this.excelImportBar_label.MouseHover += new System.EventHandler(this.excelImportBar_MouseHover);
            // 
            // viewReportBar
            // 
            this.viewReportBar.Controls.Add(this.viewReportBar_line);
            this.viewReportBar.Controls.Add(this.viewReportBar_pic);
            this.viewReportBar.Controls.Add(this.viewReportBar_label);
            this.viewReportBar.Location = new System.Drawing.Point(0, 115);
            this.viewReportBar.Name = "viewReportBar";
            this.viewReportBar.Size = new System.Drawing.Size(200, 44);
            this.viewReportBar.TabIndex = 4;
            this.viewReportBar.WrapContents = false;
            this.viewReportBar.Click += new System.EventHandler(this.viewReportBar_Click);
            this.viewReportBar.MouseLeave += new System.EventHandler(this.viewReportBar_MouseLeave);
            this.viewReportBar.MouseHover += new System.EventHandler(this.viewReportBar_MouseHover);
            // 
            // viewReportBar_line
            // 
            this.viewReportBar_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(244)))));
            this.viewReportBar_line.Enabled = false;
            this.viewReportBar_line.Location = new System.Drawing.Point(0, 0);
            this.viewReportBar_line.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.viewReportBar_line.Name = "viewReportBar_line";
            this.viewReportBar_line.Size = new System.Drawing.Size(3, 44);
            this.viewReportBar_line.TabIndex = 1;
            this.viewReportBar_line.Visible = false;
            // 
            // viewReportBar_pic
            // 
            this.viewReportBar_pic.BackgroundImage = global::ProductManager.Properties.Resources.查看报表_非选中1;
            this.viewReportBar_pic.Location = new System.Drawing.Point(21, 14);
            this.viewReportBar_pic.Margin = new System.Windows.Forms.Padding(15, 14, 3, 3);
            this.viewReportBar_pic.Name = "viewReportBar_pic";
            this.viewReportBar_pic.Size = new System.Drawing.Size(18, 18);
            this.viewReportBar_pic.TabIndex = 2;
            this.viewReportBar_pic.TabStop = false;
            // 
            // viewReportBar_label
            // 
            this.viewReportBar_label.AutoSize = true;
            this.viewReportBar_label.BackColor = System.Drawing.Color.Transparent;
            this.viewReportBar_label.Enabled = false;
            this.viewReportBar_label.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.viewReportBar_label.ForeColor = System.Drawing.Color.Silver;
            this.viewReportBar_label.Location = new System.Drawing.Point(50, 13);
            this.viewReportBar_label.Margin = new System.Windows.Forms.Padding(8, 13, 3, 0);
            this.viewReportBar_label.Name = "viewReportBar_label";
            this.viewReportBar_label.Size = new System.Drawing.Size(65, 20);
            this.viewReportBar_label.TabIndex = 3;
            this.viewReportBar_label.Text = "查看报表";
            // 
            // setBar
            // 
            this.setBar.Controls.Add(this.setBar_line);
            this.setBar.Controls.Add(this.setBar_pic);
            this.setBar.Controls.Add(this.setBar_label);
            this.setBar.Location = new System.Drawing.Point(0, 159);
            this.setBar.Name = "setBar";
            this.setBar.Size = new System.Drawing.Size(200, 44);
            this.setBar.TabIndex = 4;
            this.setBar.WrapContents = false;
            this.setBar.Click += new System.EventHandler(this.setBar_Click);
            this.setBar.MouseLeave += new System.EventHandler(this.setBar_MouseLeave);
            this.setBar.MouseHover += new System.EventHandler(this.setBar_MouseHover);
            // 
            // setBar_line
            // 
            this.setBar_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(244)))));
            this.setBar_line.Enabled = false;
            this.setBar_line.Location = new System.Drawing.Point(0, 0);
            this.setBar_line.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.setBar_line.Name = "setBar_line";
            this.setBar_line.Size = new System.Drawing.Size(3, 44);
            this.setBar_line.TabIndex = 1;
            this.setBar_line.Visible = false;
            // 
            // setBar_pic
            // 
            this.setBar_pic.BackgroundImage = global::ProductManager.Properties.Resources.个人设置_非选中1;
            this.setBar_pic.Location = new System.Drawing.Point(21, 14);
            this.setBar_pic.Margin = new System.Windows.Forms.Padding(15, 14, 3, 3);
            this.setBar_pic.Name = "setBar_pic";
            this.setBar_pic.Size = new System.Drawing.Size(18, 18);
            this.setBar_pic.TabIndex = 2;
            this.setBar_pic.TabStop = false;
            this.setBar_pic.Click += new System.EventHandler(this.setBar_Click);
            this.setBar_pic.MouseHover += new System.EventHandler(this.setBar_MouseHover);
            // 
            // setBar_label
            // 
            this.setBar_label.AutoSize = true;
            this.setBar_label.BackColor = System.Drawing.Color.Transparent;
            this.setBar_label.Enabled = false;
            this.setBar_label.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setBar_label.ForeColor = System.Drawing.Color.Silver;
            this.setBar_label.Location = new System.Drawing.Point(50, 13);
            this.setBar_label.Margin = new System.Windows.Forms.Padding(8, 13, 3, 0);
            this.setBar_label.Name = "setBar_label";
            this.setBar_label.Size = new System.Drawing.Size(37, 20);
            this.setBar_label.TabIndex = 3;
            this.setBar_label.Text = "设置";
            this.setBar_label.Click += new System.EventHandler(this.setBar_Click);
            this.setBar_label.MouseHover += new System.EventHandler(this.setBar_MouseHover);
            // 
            // Navigate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.excelImportBar);
            this.Controls.Add(this.homeBar);
            this.Controls.Add(this.viewReportBar);
            this.Controls.Add(this.setBar);
            this.Name = "Navigate";
            this.Size = new System.Drawing.Size(200, 708);
            this.homeBar.ResumeLayout(false);
            this.homeBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeBar_pic)).EndInit();
            this.excelImportBar.ResumeLayout(false);
            this.excelImportBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.excelImportBar_pic)).EndInit();
            this.viewReportBar.ResumeLayout(false);
            this.viewReportBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewReportBar_pic)).EndInit();
            this.setBar.ResumeLayout(false);
            this.setBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setBar_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label homeBar_line;
        private System.Windows.Forms.FlowLayoutPanel homeBar;
        private System.Windows.Forms.PictureBox homeBar_pic;
        private System.Windows.Forms.Label homeBar_label;
        private System.Windows.Forms.FlowLayoutPanel excelImportBar;
        private System.Windows.Forms.Label excelImportBar_line;
        private System.Windows.Forms.PictureBox excelImportBar_pic;
        private System.Windows.Forms.Label excelImportBar_label;
        private System.Windows.Forms.FlowLayoutPanel viewReportBar;
        private System.Windows.Forms.Label viewReportBar_line;
        private System.Windows.Forms.PictureBox viewReportBar_pic;
        private System.Windows.Forms.Label viewReportBar_label;
        private System.Windows.Forms.FlowLayoutPanel setBar;
        private System.Windows.Forms.Label setBar_line;
        private System.Windows.Forms.PictureBox setBar_pic;
        private System.Windows.Forms.Label setBar_label;
    }
}
