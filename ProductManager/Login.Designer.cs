namespace ProductManager
{
    partial class Login
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.login1 = new ProductManager.Controls.Login();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.White;
            this.login1.Location = new System.Drawing.Point(478, 176);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(410, 382);
            this.login1.TabIndex = 0;
            this.login1.Load += new System.EventHandler(this.login1_Load);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProductManager.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.login1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电力生产管理系统";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Login login1;
    }
}

