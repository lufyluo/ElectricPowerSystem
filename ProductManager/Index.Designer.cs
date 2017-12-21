namespace ProductManager
{
    partial class Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.navigateTabContent = new System.Windows.Forms.Panel();
            this.transparentPanel1 = new ProductManager.Controls.Common.TransparentPanel();
            this.navigate1 = new ProductManager.Controls.Common.Navigate();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.navigateTabContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 60);
            this.panel1.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.Image = global::ProductManager.Properties.Resources.关闭;
            this.exit.Location = new System.Drawing.Point(1322, 21);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(18, 25);
            this.exit.TabIndex = 1;
            this.exit.TabStop = false;
            this.exit.Visible = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // logout
            // 
            this.logout.Image = global::ProductManager.Properties.Resources.退出;
            this.logout.Location = new System.Drawing.Point(1277, 21);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(18, 25);
            this.logout.TabIndex = 1;
            this.logout.TabStop = false;
            this.logout.Visible = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "甘孜电力生产管理系统";
            // 
            // navigateTabContent
            // 
            this.navigateTabContent.Controls.Add(this.transparentPanel1);
            this.navigateTabContent.Location = new System.Drawing.Point(212, 90);
            this.navigateTabContent.Name = "navigateTabContent";
            this.navigateTabContent.Size = new System.Drawing.Size(1137, 677);
            this.navigateTabContent.TabIndex = 2;
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.BorderColor = System.Drawing.Color.Empty;
            this.transparentPanel1.Location = new System.Drawing.Point(367, 192);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(75, 23);
            this.transparentPanel1.TabIndex = 0;
            this.transparentPanel1.Text = "transparentPanel1";
            // 
            // navigate1
            // 
            this.navigate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.navigate1.Location = new System.Drawing.Point(0, 60);
            this.navigate1.Name = "navigate1";
            this.navigate1.Size = new System.Drawing.Size(200, 708);
            this.navigate1.TabIndex = 0;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.navigateTabContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navigate1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Index_FormClosed);
            this.Load += new System.EventHandler(this.Index_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            this.navigateTabContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Common.Navigate navigate1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.Panel navigateTabContent;
        private Controls.Common.TransparentPanel transparentPanel1;
    }
}