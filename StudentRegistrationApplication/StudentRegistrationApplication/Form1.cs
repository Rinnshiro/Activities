using System;
using System.Collections;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
            LoadDate();
            LoadPrograms();
        }

        private void LoadDate()
        {
            
            string[] months = {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };

            foreach (string month in months)
            {
                monthSelect.Items.Add(month);
            }

            for (int i = DateTime.Now.Year; i >= 1950; i--)
                yearSelect.Items.Add(i.ToString());

            monthSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            daySelect.DropDownStyle = ComboBoxStyle.DropDownList;
            yearSelect.DropDownStyle = ComboBoxStyle.DropDownList;


            monthSelect.SelectedIndexChanged += AdjustDays;
            yearSelect.SelectedIndexChanged += AdjustDays;
        }

        private void LoadPrograms()
        {
            ArrayList programs = new ArrayList();
            programs.Add("Bachelor of Science in Computer Science");
            programs.Add("Bachelor of Science in Information Technology");
            programs.Add("Bachelor of Science in Information Systems");
            programs.Add("Bachelor of Science in Computer Engineering");
            foreach (string program in programs)
            {
                selectProgrambox.Items.Add(program);
            }

            selectProgrambox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AdjustDays(object sender, EventArgs e)
        {
            if (monthSelect.SelectedIndex == -1 || yearSelect.SelectedIndex == -1)
                return;

            int month = monthSelect.SelectedIndex + 1;
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
            string program = selectProgrambox.SelectedItem?.ToString();
            string day = daySelect.SelectedItem?.ToString();
            string month = monthSelect.SelectedItem?.ToString();
            string year = yearSelect.SelectedItem?.ToString();

            string gender = maleRadio.Checked ? "Male" : (femaleRadio.Checked ? "Female" : "");

            if (string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(program) ||
                daySelect.SelectedIndex == -1 || monthSelect.SelectedIndex == -1 || yearSelect.SelectedIndex == -1)
            {
                MessageBox.Show("Please complete all required fields!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Name: {firstName} {middleName} {lastName}" +
                                $"\nGender: {gender}" +
                                $"\nDate of birth: {month} {day}, {year}" +
                                $"\nProgram: {program}",
                                "Student Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
