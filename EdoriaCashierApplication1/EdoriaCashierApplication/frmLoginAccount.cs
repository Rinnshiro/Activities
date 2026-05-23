using System;
using System.Windows.Forms;
using EdoriaCashierApplication1;
using UserAccountNamespace;

namespace EdoriaCashierApplication1
{
    public partial class frmLoginAccount : Form
    {
        private Cashier cashier;

        public frmLoginAccount()
        {
            InitializeComponent();

            cashier = new Cashier(
                "Raine Edoria",
                "Cashier Department",
                "cashier",
                "cashier123"
            );
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (cashier.ValidateLogin(username, password))
            {
                MessageBox.Show(
                    "Welcome " + cashier.GetFullName() + " of " + cashier.GetDepartment(),
                    "Login Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                frmPurchaseDiscountedItem purchaseForm = new frmPurchaseDiscountedItem();
                purchaseForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Invalid username or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}