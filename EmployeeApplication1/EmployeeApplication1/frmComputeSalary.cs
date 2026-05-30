using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeNamespace;

namespace EmployeeApplication1
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void btnComputeSalary_Click(object sender, EventArgs e)
        {
            PartTimeEmployee employee = new PartTimeEmployee();

            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.Department = txtDepartment.Text;
            employee.JobTitle = txtJobTitle.Text;

            double ratePerHour = Convert.ToDouble(txtRatePerHour.Text);
            int HoursWorked = Convert.ToInt32(txtHoursWorked.Text);

            employee.computeSalary(ratePerHour, HoursWorked);
            double salary = employee.getSalary;

            lblFullName.Text = employee.FirstName + " " + employee.LastName;
            lblDepartment.Text = employee.Department;
            lblJobTitle.Text = employee.JobTitle;
            lblSalary.Text = salary.ToString("C");
        }
    }
}