using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInterface;

namespace EmployeeNamespace
{
    public class PartTimeEmployee : IEmployee
    {
        private string Fname;
        private string Lname;
        private string department;
        private string jobTitle;
        private double salary;

        public string FirstName
        {
            get { 
                return Fname; 
            }
            set { 
                Fname = value; 
            }
        }

        public string LastName
        {
            get { 
                return Lname; 
            }
            set { 
                Lname = value; 
            }
        }

        public string Department
        {
            get { 
                return department; 
            }
            set { 
                department = value; 
            }
        }

        public string JobTitle
        {
            get {
                return jobTitle; 
            }
            set { 
                jobTitle = value; 
            }
        }
        public double getSalary
        {
            get { 
                return salary; 
            }
        }

        public void computeSalary(double ratePerHour, int hoursWorked)
        {
            salary = ratePerHour * hoursWorked;
        }
    }
}