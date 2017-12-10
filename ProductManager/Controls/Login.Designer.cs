namespace ProductManager.Controls
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.loginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordInput = new ProductManager.Controls.Common.ColorBoderTextBox();
            this.accountInput = new ProductManager.Controls.Common.ColorBoderTextBox();
            this.loginTip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(244)))));
            this.loginBtn.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(11, 283);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(385, 50);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "登陆";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "用户登录";
            // 
            // groupBox1
            // 
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(14, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 10);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // passwordInput
            // 
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordInput.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(170)))));
            this.passwordInput.Location = new System.Drawing.Point(12, 180);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(385, 40);
            this.passwordInput.TabIndex = 3;
            this.passwordInput.Text = "请输入密码";
            this.passwordInput.WordWrap = false;
            this.passwordInput.Enter += new System.EventHandler(this.passwordInput_Enter);
            this.passwordInput.Leave += new System.EventHandler(this.passwordInput_Leave);
            // 
            // accountInput
            // 
            this.accountInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountInput.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(157)))), ((int)(((byte)(170)))));
            this.accountInput.Location = new System.Drawing.Point(12, 113);
            this.accountInput.Name = "accountInput";
            this.accountInput.Size = new System.Drawing.Size(385, 40);
            this.accountInput.TabIndex = 2;
            this.accountInput.Text = "请输入账号";
            this.accountInput.WordWrap = false;
            this.accountInput.Enter += new System.EventHandler(this.accountInput_MouseEnter);
            this.accountInput.Leave += new System.EventHandler(this.accountInput_MouseLeave);
            // 
            // loginTip
            // 
            this.loginTip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTip.ForeColor = System.Drawing.Color.Red;
            this.loginTip.Location = new System.Drawing.Point(14, 241);
            this.loginTip.Name = "loginTip";
            this.loginTip.Size = new System.Drawing.Size(100, 14);
            this.loginTip.TabIndex = 6;
            this.loginTip.Text = "账号或密码错误！";
            this.loginTip.Visible = false;
            this.loginTip.WordWrap = false;
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.loginTip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.accountInput);
            this.Controls.Add(this.loginBtn);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(410, 382);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button loginBtn;
        private Common.ColorBoderTextBox accountInput;
        private Common.ColorBoderTextBox passwordInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox loginTip;
    }
}
