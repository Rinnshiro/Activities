using System;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
	public partial class frmStudentRegistration : Form
	{
		public frmStudentRegistration()
		{
			InitializeComponent();
			LoadDate();
		}

		private void LoadDate()
		{
			for (int i = 1; i <= 12; i++)
				monthSelect.Items.Add(i.ToString());

			for (int i = DateTime.Now.Year; i >= 1950; i--)
				yearSelect.Items.Add(i.ToString());

			monthSelect.DropDownStyle = ComboBoxStyle.DropDownList;
			daySelect.DropDownStyle = ComboBoxStyle.DropDownList;
			yearSelect.DropDownStyle = ComboBoxStyle.DropDownList;

			monthSelect.SelectedIndexChanged += AdjustDays;
			yearSelect.SelectedIndexChanged += AdjustDays;
		}

		private void AdjustDays(object sender, EventArgs e)
		{
			if (monthSelect.SelectedIndex == -1 || yearSelect.SelectedIndex == -1)
				return;

			int month = int.Parse(monthSelect.Text);
			int year = int.Parse(yearSelect.Text);

			int daysInMonth = DateTime.DaysInMonth(year, month);

			int currentDay = daySelect.SelectedIndex != -1 ? int.Parse(daySelect.Text) : 0;

			daySelect.Items.Clear();

			for (int i = 1; i <= daysInMonth; i++)
				daySelect.Items.Add(i.ToString());

			if (currentDay <= daysInMonth && currentDay != 0)
				daySelect.SelectedItem = currentDay.ToString();
		}

		private void registerButton_Click(object sender, EventArgs e)
		{
			string lastName = lastNameBox.Text.Trim();
			string firstName = firstNameBox.Text.Trim();
			string middleName = middleNameBox.Text.Trim();

			string gender = "";

			if (maleRadio.Checked)
				gender = "Male";
			else if (femaleRadio.Checked)
				gender = "Female";

			if (lastName == "" || firstName == "" || middleName == "" ||
				gender == "" ||
				daySelect.SelectedIndex == -1 ||
				monthSelect.SelectedIndex == -1 ||
				yearSelect.SelectedIndex == -1)
			{
				MessageBox.Show("Please complete all required fields!",
								"Missing Information",
								MessageBoxButtons.OK,
								MessageBoxIcon.Warning);
				return;
			}

			string day = daySelect.Text;
			string month = monthSelect.Text;
			string year = yearSelect.Text;

			MessageBox.Show(
				"Student name: " + firstName + " " + middleName + " " + lastName +
				"\nGender: " + gender +
				"\nDate of birth: " + day + "/" + month + "/" + year,
				"Student Information",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);

			lastNameBox.Clear();
			firstNameBox.Clear();
			middleNameBox.Clear();
			maleRadio.Checked = false;
			femaleRadio.Checked = false;
			daySelect.Items.Clear();
			monthSelect.SelectedIndex = -1;
			yearSelect.SelectedIndex = -1;
		}
	}
}