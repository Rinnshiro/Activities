namespace WinFormsUserAdmin
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblNewAdminName;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAdminName;

        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtAdminName;

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button btnUpdateName;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblNewAdminName = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();

            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();

            this.btnLogin = new System.Windows.Forms.Button();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.btnUpdateName = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(105, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(278, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Administrator Login Form";

            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(55, 85);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(48, 15);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "User ID:";

            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(180, 82);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(220, 23);
            this.txtUserId.TabIndex = 2;

            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(55, 125);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 15);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(180, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;

            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(180, 160);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(220, 32);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Verify Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(180, 205);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 6;

            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(55, 255);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(88, 15);
            this.lblNewPassword.TabIndex = 7;
            this.lblNewPassword.Text = "New Password:";

            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(180, 252);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(220, 23);
            this.txtNewPassword.TabIndex = 8;
            this.txtNewPassword.UseSystemPasswordChar = true;

            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Location = new System.Drawing.Point(180, 290);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(220, 32);
            this.btnUpdatePassword.TabIndex = 9;
            this.btnUpdatePassword.Text = "Update Password";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);

            // 
            // lblNewAdminName
            // 
            this.lblNewAdminName.AutoSize = true;
            this.lblNewAdminName.Location = new System.Drawing.Point(55, 355);
            this.lblNewAdminName.Name = "lblNewAdminName";
            this.lblNewAdminName.Size = new System.Drawing.Size(109, 15);
            this.lblNewAdminName.TabIndex = 10;
            this.lblNewAdminName.Text = "New Admin Name:";

            // 
            // txtAdminName
            // 
            this.txtAdminName.Location = new System.Drawing.Point(180, 352);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(220, 23);
            this.txtAdminName.TabIndex = 11;

            // 
            // btnUpdateName
            // 
            this.btnUpdateName.Location = new System.Drawing.Point(180, 390);
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(220, 32);
            this.btnUpdateName.TabIndex = 12;
            this.btnUpdateName.Text = "Update Admin Name";
            this.btnUpdateName.UseVisualStyleBackColor = true;
            this.btnUpdateName.Click += new System.EventHandler(this.btnUpdateName_Click);

            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Location = new System.Drawing.Point(180, 440);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(116, 15);
            this.lblAdminName.TabIndex = 13;
            this.lblAdminName.Text = "Admin Name: Admin";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 491);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.lblNewAdminName);
            this.Controls.Add(this.txtAdminName);
            this.Controls.Add(this.btnUpdateName);
            this.Controls.Add(this.lblAdminName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User and Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}