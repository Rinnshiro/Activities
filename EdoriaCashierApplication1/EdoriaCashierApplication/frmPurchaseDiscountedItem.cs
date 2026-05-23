using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemNamespace;

namespace EdoriaCashierApplication1
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private DiscountedItem discountedItem;

        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string itemName = txtItem.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            double discount = Convert.ToDouble(txtDiscount.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);

            discountedItem = new DiscountedItem(itemName, price, quantity, discount);

            double totalAmount = discountedItem.GetTotalPrice();

            lblTotalAmount.Text = totalAmount.ToString("0.00");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double payment = Convert.ToDouble(txtPayment.Text);

            discountedItem.SetPayment(payment);

            lblChange.Text = discountedItem.GetChange().ToString("0.00");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginAccount loginForm = new frmLoginAccount();
            loginForm.Show();

            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}