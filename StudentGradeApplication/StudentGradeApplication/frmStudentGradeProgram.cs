using System;
using System.Windows.Forms;
using System.Xml;

namespace StudentGradeApplication
{
    public partial class frmStudentGradeProgram : Form
    {
       
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
		private void label2_Click_1(object sender, EventArgs e)
		{

		}
		private void name_Click(object sender, EventArgs e)
		{

		}
		private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void englishGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void mathGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void scienceGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void filipinoGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void historyGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentName = nameBox.Text.Trim();
            if (string.IsNullOrEmpty(studentName))
            {
                MessageBox.Show("Please enter the student's name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(englishGrade.Text, out double english) ||
                !double.TryParse(mathGrade.Text, out double math) ||
                !double.TryParse(scienceGrade.Text, out double science) ||
                !double.TryParse(filipinoGrade.Text, out double filipino) ||
                !double.TryParse(historyGrade.Text, out double history))
            {
                MessageBox.Show("Please enter valid numeric grades for all subjects.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double average = (english + math + science + filipino + history) / 5.0;

            string status = average >= 60? "Passed" : "Failed";

            resultOutput.Text = $"The general average of {studentName} is {average:F2}.";
            resultOutput.Visible = true;

			statusResult.Text = $"The student was {status}.";
			statusResult.Visible = true;


		}
	}
}
