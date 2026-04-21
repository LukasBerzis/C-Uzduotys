using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement_projektas
{
    internal class Staff : Person
    {
        public int EmployeeId { get; set; }
        public string Department {  get; set; }
        public double Salary { get; set; }
        public DateTime HireDate { get; set; }

        public Staff() : base()
        {
            EmployeeId = 0;
            Department = "";
            Salary = 0;
            HireDate = DateTime.MinValue;
        }

        public Staff(string firstname, string lastname, DateTime birthday, string email, int employeeid, string department, double salary, DateTime hiredate) : base(firstname,lastname, birthday, email)
        {
            EmployeeId=employeeid;
            Department=department;
            Salary=salary;
            HireDate = hiredate;
        }

    }
}
