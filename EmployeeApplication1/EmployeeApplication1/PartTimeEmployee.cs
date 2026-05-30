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
        private string first_name;
        private string last_name;
        private string department;
        private string job_title;

        public string FirstName
        {
            get { 
                return first_name; 
            }
            set { 
                first_name = value; 
            }
        }

        public string LastName
        {
            get { 
                return last_name; 
            }
            set { 
                last_name = value; 
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
                return job_title; 
            }
            set { 
                job_title = value; 
            }
        }

        public double ComputeSalary(double ratePerHour, int totalHoursWorked)
        {
            return ratePerHour * totalHoursWorked;
        }
    }
}