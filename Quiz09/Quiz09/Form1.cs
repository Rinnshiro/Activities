using System;
using System.Windows.Forms;

namespace Quiz09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double getCircleDiameter(double radius)
        {
            return radius * 2;
        }

        private void btnComputeDiameter_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(txtRadius.Text);
            double diameter = getCircleDiameter(radius);

            lblDiameterResult.Text = "Diameter: " + diameter.ToString();
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            Product product;

            product.code = txtCode.Text;
            product.description = txtDescription.Text;
            product.price = Convert.ToDouble(txtPrice.Text);

            lblProductResult.Text = "Product Info: " +
                                    product.code + " - " +
                                    product.description + " - " +
                                    product.price.ToString();
        }

        private void btnCreatePerson_Click(object sender, EventArgs e)
        {
            Person person = new Person();

            lblPersonResult.Text = "Person: " + person.full_name;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Accounts.Account account = new Accounts.Account();

            account.account_number = txtAccountNumber.Text;

            lblAccountResult.Text = "Account: " + account.account_number;
        }
    }
    public struct Product
    {
        public string code;
        public string description;
        public double price;
    }
}