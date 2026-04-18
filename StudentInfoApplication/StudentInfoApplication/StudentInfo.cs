using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentNamespace
{
	public class StudentInfo
	{
		private string studentNo;
		private string lastName;
		private string firstName;

		public StudentInfo()
		{
			this.studentNo = "";
			this.lastName = "";
			this.firstName = "";
		}

		public StudentInfo(string studentNo)
		{
			this.studentNo = studentNo;
			this.lastName = "";
			this.firstName = "";
		}

		public StudentInfo(string studentNo, string lastName, string firstName)
		{
			this.studentNo = studentNo;
			this.lastName = lastName;
			this.firstName = firstName;
		}

		public string StudentNo
		{
			get { return studentNo; }
			set { studentNo = value; }
		}

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}
	}
}