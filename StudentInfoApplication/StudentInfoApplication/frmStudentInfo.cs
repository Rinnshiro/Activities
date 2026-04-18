using System;
using System.Windows.Forms;
using StudentNamespace;

namespace StudentInfoApplication
{
	public partial class frmStudentInfo : Form
	{
		public frmStudentInfo()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtStudentNo.Text) ||
				string.IsNullOrWhiteSpace(txtLastName.Text) ||
				string.IsNullOrWhiteSpace(txtFirstName.Text))
			{
				MessageBox.Show("Please enter all student information.",
								"Missing Input",
								MessageBoxButtons.OK,
								MessageBoxIcon.Warning);
				return;
			}
			StudentInfo student = new StudentInfo(
				txtStudentNo.Text.Trim(),
				txtLastName.Text.Trim(),
				txtFirstName.Text.Trim()
			);

			lstStudentNo.Items.Add(student.StudentNo);
			lstLastName.Items.Add(student.LastName);
			lstFirstName.Items.Add(student.FirstName);

			txtStudentNo.Clear();
			txtLastName.Clear();
			txtFirstName.Clear();

			txtStudentNo.Focus();
		}
	}
}