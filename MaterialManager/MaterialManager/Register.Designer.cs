namespace MaterialManager
{
    partial class Register
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.lblLoginPwd = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPwdAgain = new System.Windows.Forms.Label();
            this.txtPwdAgain = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblTip1 = new System.Windows.Forms.Label();
            this.lblTip2 = new System.Windows.Forms.Label();
            this.lblTip3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(134, 114);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(98, 18);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "用户昵称：";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(234, 110);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(180, 28);
            this.txtUserName.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(137, 410);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 34);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(186, 34);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "注册用户信息";
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Location = new System.Drawing.Point(134, 186);
            this.lblLoginName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(98, 18);
            this.lblLoginName.TabIndex = 4;
            this.lblLoginName.Text = "登录账户：";
            // 
            // lblLoginPwd
            // 
            this.lblLoginPwd.AutoSize = true;
            this.lblLoginPwd.Location = new System.Drawing.Point(134, 258);
            this.lblLoginPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginPwd.Name = "lblLoginPwd";
            this.lblLoginPwd.Size = new System.Drawing.Size(98, 18);
            this.lblLoginPwd.TabIndex = 7;
            this.lblLoginPwd.Text = "登录密码：";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(232, 182);
            this.txtLoginName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoginName.MaxLength = 15;
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(180, 28);
            this.txtLoginName.TabIndex = 5;
            this.txtLoginName.Text = "admin";
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.Location = new System.Drawing.Point(232, 254);
            this.txtLoginPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoginPwd.MaxLength = 15;
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '*';
            this.txtLoginPwd.Size = new System.Drawing.Size(180, 28);
            this.txtLoginPwd.TabIndex = 8;
            this.txtLoginPwd.Text = "123456";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(311, 410);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPwdAgain
            // 
            this.lblPwdAgain.AutoSize = true;
            this.lblPwdAgain.Location = new System.Drawing.Point(134, 336);
            this.lblPwdAgain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwdAgain.Name = "lblPwdAgain";
            this.lblPwdAgain.Size = new System.Drawing.Size(98, 18);
            this.lblPwdAgain.TabIndex = 10;
            this.lblPwdAgain.Text = "确认密码：";
            // 
            // txtPwdAgain
            // 
            this.txtPwdAgain.Location = new System.Drawing.Point(232, 332);
            this.txtPwdAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPwdAgain.MaxLength = 15;
            this.txtPwdAgain.Name = "txtPwdAgain";
            this.txtPwdAgain.PasswordChar = '*';
            this.txtPwdAgain.Size = new System.Drawing.Size(180, 28);
            this.txtPwdAgain.TabIndex = 11;
            this.txtPwdAgain.Text = "123456";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.ForeColor = System.Drawing.Color.Red;
            this.lblTip.Location = new System.Drawing.Point(424, 114);
            this.lblTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(17, 18);
            this.lblTip.TabIndex = 3;
            this.lblTip.Text = "*";
            // 
            // lblTip1
            // 
            this.lblTip1.AutoSize = true;
            this.lblTip1.ForeColor = System.Drawing.Color.Red;
            this.lblTip1.Location = new System.Drawing.Point(423, 186);
            this.lblTip1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTip1.Name = "lblTip1";
            this.lblTip1.Size = new System.Drawing.Size(17, 18);
            this.lblTip1.TabIndex = 6;
            this.lblTip1.Text = "*";
            // 
            // lblTip2
            // 
            this.lblTip2.AutoSize = true;
            this.lblTip2.ForeColor = System.Drawing.Color.Red;
            this.lblTip2.Location = new System.Drawing.Point(424, 258);
            this.lblTip2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTip2.Name = "lblTip2";
            this.lblTip2.Size = new System.Drawing.Size(17, 18);
            this.lblTip2.TabIndex = 9;
            this.lblTip2.Text = "*";
            // 
            // lblTip3
            // 
            this.lblTip3.AutoSize = true;
            this.lblTip3.ForeColor = System.Drawing.Color.Red;
            this.lblTip3.Location = new System.Drawing.Point(423, 336);
            this.lblTip3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTip3.Name = "lblTip3";
            this.lblTip3.Size = new System.Drawing.Size(17, 18);
            this.lblTip3.TabIndex = 12;
            this.lblTip3.Text = "*";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 509);
            this.Controls.Add(this.lblTip3);
            this.Controls.Add(this.lblTip2);
            this.Controls.Add(this.lblTip1);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.txtPwdAgain);
            this.Controls.Add(this.lblPwdAgain);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.lblLoginPwd);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册账号";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.Label lblLoginPwd;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPwdAgain;
        private System.Windows.Forms.TextBox txtPwdAgain;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblTip1;
        private System.Windows.Forms.Label lblTip2;
        private System.Windows.Forms.Label lblTip3;
    }
}