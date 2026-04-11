using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {

            daySelect.Items.Clear();
            for (int i = 1; i <= 31; i++)
            {
                daySelect.Items.Add(i.ToString());
            }
            monthSelect.Items.Clear();
            monthSelect.Items.Add("January");
            monthSelect.Items.Add("February");
            monthSelect.Items.Add("March");
            monthSelect.Items.Add("April");
            monthSelect.Items.Add("May");
            monthSelect.Items.Add("June");
            monthSelect.Items.Add("July");
            monthSelect.Items.Add("August");
            monthSelect.Items.Add("September");
            monthSelect.Items.Add("October");
            monthSelect.Items.Add("November");
            monthSelect.Items.Add("December");

            yearSelect.Items.Clear();

            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                yearSelect.Items.Add(i.ToString());
            }

            selectProgrambox.Items.Clear();
            selectProgrambox.Items.Add("Bachelor of Science in Computer Science");
            selectProgrambox.Items.Add("Bachelor of Science in Information Technology");
            selectProgrambox.Items.Add("Bachelor of Science in Information Systems");
            selectProgrambox.Items.Add("Bachelor of Science in Accountancy");
            selectProgrambox.Items.Add("Bachelor of Science in Business Administration");
        }

        private void uploadPhotoButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    studentPictureBox.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message,
                        "Image Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        public void StudentInfo(string firstName, string lastName)
        {
            MessageBox.Show(
                "Student name: " + firstName + " " + lastName +
                "\nProgram: " + selectProgrambox.Text,
                "Student Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public void StudentInfo(string firstName, string middleName, string lastName)
        {
            MessageBox.Show(
                "Student name: " + firstName + " " + middleName + " " + lastName +
                "\nProgram: " + selectProgrambox.Text,
                "Student Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public void StudentInfo(string firstName, string middleName, string lastName,
                                string gender, string day, string month, string year)
        {
            MessageBox.Show(
                "Student name: " + firstName + " " + middleName + " " + lastName +
                "\nGender: " + gender +
                "\nDate of birth: " + day + "/" + month + "/" + year +
                "\nProgram: " + selectProgrambox.Text,
                "Student Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameBox.Text.Trim();
            string middleName = middleNameBox.Text.Trim();
            string lastName = lastNameBox.Text.Trim();

            string gender = "";
            if (maleRadio.Checked)
            {
                gender = "Male";
            }
            else if (femaleRadio.Checked)
            {
                gender = "Female";
            }

            string day = daySelect.Text;
            string month = monthSelect.Text;
            string year = yearSelect.Text;
            string program = selectProgrambox.Text;

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(middleName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(day) ||
                string.IsNullOrWhiteSpace(month) ||
                string.IsNullOrWhiteSpace(year) ||
                string.IsNullOrWhiteSpace(program))
            {
                MessageBox.Show("Please complete all required fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            StudentInfo(firstName, middleName, lastName);                 
            StudentInfo(firstName, lastName);                              
            StudentInfo(firstName, middleName, lastName, gender, day, month, year); 
        }
    }
}