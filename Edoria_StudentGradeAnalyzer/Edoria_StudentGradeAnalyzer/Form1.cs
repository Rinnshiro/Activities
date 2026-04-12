using System;
using System.Windows.Forms;

namespace Edoria_StudentGradeAnalyzer
{
	public partial class Form1 : Form
	{
		private struct StudentInfo
		{
			public string StudentNumber;
			public string StudentName;
			public double PrelimGrade;
			public double MidtermGrade;
			public double FinalGrade;
			public double Average;
			public string Remarks;
		}

		public Form1()
		{
			InitializeComponent();
		}
		private double ComputeAverage(double prelim, double midterm, double finalGrade)
		{
			return (prelim + midterm + finalGrade) / 3.0;
		}
		private double ComputeAverage(double grade1, double grade2)
		{
			return (grade1 + grade2) / 2.0;
		}
		private static string GetRemarks(double average)
		{
			return average >= 75 ? "Passed" : "Failed";
		}
		private void DisplayStudentInfo(StudentInfo student)
		{
			lstOutput.Items.Clear();
			lstOutput.Items.Add("===== STUDENT GRADE REPORT =====");
			lstOutput.Items.Add("Student Number : " + student.StudentNumber);
			lstOutput.Items.Add("Student Name   : " + student.StudentName);
			lstOutput.Items.Add("Prelim Grade   : " + student.PrelimGrade.ToString("F2"));
			lstOutput.Items.Add("Midterm Grade  : " + student.MidtermGrade.ToString("F2"));
			lstOutput.Items.Add("Final Grade    : " + student.FinalGrade.ToString("F2"));
			lstOutput.Items.Add("--------------------------------");
			lstOutput.Items.Add("Average        : " + student.Average.ToString("F2"));
			lstOutput.Items.Add("Remarks        : " + student.Remarks);

			double firstTwoAverage = ComputeAverage(student.PrelimGrade, student.MidtermGrade);
			lstOutput.Items.Add("--------------------------------");
			lstOutput.Items.Add("Average of Prelim and Midterm only: " + firstTwoAverage.ToString("F2"));
		}

		private void btnCompute_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtStudentNumber.Text) ||
				string.IsNullOrWhiteSpace(txtStudentName.Text) ||
				string.IsNullOrWhiteSpace(txtPrelim.Text) ||
				string.IsNullOrWhiteSpace(txtMidterm.Text) ||
				string.IsNullOrWhiteSpace(txtFinal.Text))
			{
				MessageBox.Show("Please fill in all fields.", "Missing Input",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (!double.TryParse(txtPrelim.Text, out double prelim) ||
				!double.TryParse(txtMidterm.Text, out double midterm) ||
				!double.TryParse(txtFinal.Text, out double finalGrade))
			{
				MessageBox.Show("Please enter valid numeric grades.", "Invalid Input",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (prelim < 0 || prelim > 100 ||
				midterm < 0 || midterm > 100 ||
				finalGrade < 0 || finalGrade > 100)
			{
				MessageBox.Show("Grades must be between 0 and 100.", "Invalid Grade Range",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			StudentInfo student = new StudentInfo
			{
				StudentNumber = txtStudentNumber.Text.Trim(),
				StudentName = txtStudentName.Text.Trim(),
				PrelimGrade = prelim,
				MidtermGrade = midterm,
				FinalGrade = finalGrade
			};

			student.Average = ComputeAverage(student.PrelimGrade, student.MidtermGrade, student.FinalGrade);
			student.Remarks = GetRemarks(student.Average);
			DisplayStudentInfo(student);
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtStudentNumber.Clear();
			txtStudentName.Clear();
			txtPrelim.Clear();
			txtMidterm.Clear();
			txtFinal.Clear();
			lstOutput.Items.Clear();

			txtStudentNumber.Focus();
		}
	}
}