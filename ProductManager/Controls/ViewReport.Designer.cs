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
            this.SuspendLayout();
            // 
            // excel
            // 
            this.excel.BackColor = System.Drawing.Color.White;
            this.excel.ColumnHeaderContextMenuStrip = null;
            this.excel.LeadHeaderContextMenuStrip = null;
            this.excel.Location = new System.Drawing.Point(3, 6);
            this.excel.Name = "excel";
            this.excel.RowHeaderContextMenuStrip = null;
            this.excel.Script = null;
            this.excel.SheetTabContextMenuStrip = null;
            this.excel.SheetTabNewButtonVisible = true;
            this.excel.SheetTabVisible = true;
            this.excel.SheetTabWidth = 60;
            this.excel.ShowScrollEndSpacing = true;
            this.excel.Size = new System.Drawing.Size(1110, 630);
            this.excel.TabIndex = 0;
            this.excel.Text = "reoGridControl1";
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.excel);
            this.Name = "ViewReport";
            this.Size = new System.Drawing.Size(1126, 677);
            this.ResumeLayout(false);

        }

        #endregion

        private unvell.ReoGrid.ReoGridControl excel;
    }
}
