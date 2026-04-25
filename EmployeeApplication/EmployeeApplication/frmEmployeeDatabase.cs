using System;
using System.ComponentModel;
using System.Windows.Forms;
using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        private BindingList<Employee> employeeList = new BindingList<Employee>();

        public frmEmployeeDatabase()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            employeeList.Add(new Employee("20190001", "Raine", "Edoria", "Supervisor"));
            employeeList.Add(new Employee("20160005", "Cris Erick", "Ibay", "Manager"));
            employeeList.Add(new Employee("20210046", "Jhirro", "Meneses", "Staff"));

            listEmployees.AutoGenerateColumns = false;
            listEmployees.DataSource = employeeList;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text.Trim() == "" ||
                txtFirstName.Text.Trim() == "" ||
                txtLastName.Text.Trim() == "" ||
                txtPosition.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Employee emp = new Employee(
                txtEmployeeID.Text.Trim(),
                txtFirstName.Text.Trim(),
                txtLastName.Text.Trim(),
                txtPosition.Text.Trim()
            );

            employeeList.Add(emp);

            txtEmployeeID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPosition.Clear();

            txtEmployeeID.Focus();
        }
    }
}