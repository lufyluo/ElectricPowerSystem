namespace ProductManager.Controls
{
    partial class ViewReport
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
            this.excel = new unvell.ReoGrid.ReoGridControl();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.exportBtn = new System.Windows.Forms.Panel();
            this.exportImage = new System.Windows.Forms.PictureBox();
            this.exportLabel = new System.Windows.Forms.Label();
            this.exportBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportImage)).BeginInit();
            this.SuspendLayout();
            // 
            // excel
            // 
            this.excel.BackColor = System.Drawing.Color.White;
            this.excel.ColumnHeaderContextMenuStrip = null;
            this.excel.LeadHeaderContextMenuStrip = null;
            this.excel.Location = new System.Drawing.Point(0, 47);
            this.excel.Name = "excel";
            this.excel.RowHeaderContextMenuStrip = null;
            this.excel.Script = null;
            this.excel.SheetTabContextMenuStrip = null;
            this.excel.SheetTabNewButtonVisible = true;
            this.excel.SheetTabVisible = true;
            this.excel.SheetTabWidth = 60;
            this.excel.ShowScrollEndSpacing = true;
            this.excel.Size = new System.Drawing.Size(1135, 588);
            this.excel.TabIndex = 0;
            this.excel.Text = "reoGridControl1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "首页";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(783, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 29);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(244)))));
            this.exportBtn.Controls.Add(this.exportLabel);
            this.exportBtn.Controls.Add(this.exportImage);
            this.exportBtn.Location = new System.Drawing.Point(1011, 8);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(100, 30);
            this.exportBtn.TabIndex = 3;
            this.exportBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.exportBtn_Paint);
            // 
            // exportImage
            // 
            this.exportImage.Image = global::ProductManager.Properties.Resources.导出图标_2x;
            this.exportImage.Location = new System.Drawing.Point(13, 9);
            this.exportImage.Name = "exportImage";
            this.exportImage.Size = new System.Drawing.Size(16, 14);
            this.exportImage.TabIndex = 0;
            this.exportImage.TabStop = false;
            // 
            // exportLabel
            // 
            this.exportLabel.AutoSize = true;
            this.exportLabel.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exportLabel.ForeColor = System.Drawing.Color.White;
            this.exportLabel.Location = new System.Drawing.Point(35, 4);
            this.exportLabel.Name = "exportLabel";
            this.exportLabel.Size = new System.Drawing.Size(37, 20);
            this.exportLabel.TabIndex = 1;
            this.exportLabel.Text = "导出";
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.excel);
            this.Name = "ViewReport";
            this.Size = new System.Drawing.Size(1135, 635);
            this.Load += new System.EventHandler(this.ViewReport_Load);
            this.exportBtn.ResumeLayout(false);
            this.exportBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private unvell.ReoGrid.ReoGridControl excel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel exportBtn;
        private System.Windows.Forms.Label exportLabel;
        private System.Windows.Forms.PictureBox exportImage;
    }
}
