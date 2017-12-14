namespace ProductManager.Controls
{
    partial class ImportExcel
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
            this.label1 = new System.Windows.Forms.Label();
            this.roundPanel1 = new ProductManager.Controls.Common.RoundPanel();
            this.openFile_btn = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.import_btn = new System.Windows.Forms.Button();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(303, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择文件：";
            // 
            // roundPanel1
            // 
            this.roundPanel1.Back = System.Drawing.Color.White;
            this.roundPanel1.Controls.Add(this.fileName);
            this.roundPanel1.Controls.Add(this.openFile_btn);
            this.roundPanel1.Location = new System.Drawing.Point(415, 40);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundPanel1.MatrixRound = 8;
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(553, 52);
            this.roundPanel1.TabIndex = 2;
            // 
            // openFile_btn
            // 
            this.openFile_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.openFile_btn.Location = new System.Drawing.Point(22, 11);
            this.openFile_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.openFile_btn.Name = "openFile_btn";
            this.openFile_btn.Size = new System.Drawing.Size(87, 33);
            this.openFile_btn.TabIndex = 0;
            this.openFile_btn.Text = "浏览...";
            this.openFile_btn.UseVisualStyleBackColor = true;
            this.openFile_btn.Click += new System.EventHandler(this.openFile_btn_Click);
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.fileName.Location = new System.Drawing.Point(131, 16);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(90, 21);
            this.fileName.TabIndex = 1;
            this.fileName.Text = "未选择文件";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(412, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "文件请严格按照单位名称-表名-日期命名";
            // 
            // import_btn
            // 
            this.import_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(244)))));
            this.import_btn.ForeColor = System.Drawing.Color.White;
            this.import_btn.Location = new System.Drawing.Point(437, 156);
            this.import_btn.Name = "import_btn";
            this.import_btn.Size = new System.Drawing.Size(87, 33);
            this.import_btn.TabIndex = 4;
            this.import_btn.Text = "导入";
            this.import_btn.UseVisualStyleBackColor = false;
            this.import_btn.Click += new System.EventHandler(this.import_btn_Click);
            // 
            // ImportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.import_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roundPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ImportExcel";
            this.Size = new System.Drawing.Size(1314, 973);
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Common.RoundPanel roundPanel1;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Button openFile_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button import_btn;
    }
}
