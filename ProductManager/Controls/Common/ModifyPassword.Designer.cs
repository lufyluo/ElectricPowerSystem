namespace ProductManager.Controls.Common
{
    partial class ModifyPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.repeatPassword = new System.Windows.Forms.TextBox();
            this.modifySubmit = new System.Windows.Forms.Button();
            this.roundPanel1 = new ProductManager.Controls.Common.RoundPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.modifySubmit);
            this.panel1.Controls.Add(this.repeatPassword);
            this.panel1.Controls.Add(this.newPassword);
            this.panel1.Controls.Add(this.oldPassword);
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 526);
            this.panel1.TabIndex = 1;
            // 
            // oldPassword
            // 
            this.oldPassword.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.oldPassword.Location = new System.Drawing.Point(82, 73);
            this.oldPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(448, 32);
            this.oldPassword.TabIndex = 0;
            this.oldPassword.Text = "请输入旧密码";
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(82, 167);
            this.newPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newPassword.Multiline = true;
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(448, 55);
            this.newPassword.TabIndex = 0;
            this.newPassword.Text = "请输入新密码";
            this.newPassword.TextChanged += new System.EventHandler(this.newPassword_TextChanged);
            // 
            // repeatPassword
            // 
            this.repeatPassword.Location = new System.Drawing.Point(82, 267);
            this.repeatPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.repeatPassword.Multiline = true;
            this.repeatPassword.Name = "repeatPassword";
            this.repeatPassword.Size = new System.Drawing.Size(448, 55);
            this.repeatPassword.TabIndex = 0;
            this.repeatPassword.Text = "再次输入新密码";
            // 
            // modifySubmit
            // 
            this.modifySubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(244)))));
            this.modifySubmit.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modifySubmit.ForeColor = System.Drawing.Color.White;
            this.modifySubmit.Location = new System.Drawing.Point(79, 424);
            this.modifySubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modifySubmit.Name = "modifySubmit";
            this.modifySubmit.Size = new System.Drawing.Size(449, 52);
            this.modifySubmit.TabIndex = 1;
            this.modifySubmit.Text = "提交";
            this.modifySubmit.UseVisualStyleBackColor = false;
            // 
            // roundPanel1
            // 
            this.roundPanel1.Back = System.Drawing.Color.Black;
            this.roundPanel1.Controls.Add(this.pictureBox1);
            this.roundPanel1.Controls.Add(this.label1);
            this.roundPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundPanel1.MatrixRound = 10;
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(600, 79);
            this.roundPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProductManager.Properties.Resources.关闭;
            this.pictureBox1.Location = new System.Drawing.Point(657, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "修改密码";
            // 
            // ModifyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(403, 84);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModifyPassword";
            this.Size = new System.Drawing.Size(600, 586);
            this.Load += new System.EventHandler(this.ModifyPassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundPanel roundPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button modifySubmit;
        private System.Windows.Forms.TextBox repeatPassword;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox oldPassword;
    }
}
