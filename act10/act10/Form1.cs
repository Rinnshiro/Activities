using System;
using System.Windows.Forms;
using UserNamespace;

namespace WinFormsUserAdmin
{
    public partial class Form1 : Form
    {
        private Administrator admin;

        public Form1()
        {
            InitializeComponent();

            admin = new Administrator("Admin", "admin1", "admin123");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtUserId.Text;
            string password = txtPassword.Text;

            if (admin.verifyLogin(id, password))
            {
                lblResult.Text = "Login successful!";
                lblResult.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblResult.Text = "Invalid user ID or password.";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please enter a new password.");
                return;
            }

            admin.updatePassword(newPassword);

            MessageBox.Show("Password updated successfully!");
            txtNewPassword.Clear();
        }

        private void btnUpdateName_Click(object sender, EventArgs e)
        {
            string newName = txtAdminName.Text;

            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Please enter a new admin name.");
                return;
            }

            admin.updateAdminName(newName);

            MessageBox.Show("Admin name updated successfully!");
            lblAdminName.Text = "Admin Name: " + admin.GetAdminName();
            txtAdminName.Clear();
        }
    }
}