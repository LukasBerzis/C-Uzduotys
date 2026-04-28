using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement_projektas
{
    internal class Administrator : Staff
    {
        public string Office {  get; set; }
        public List<string> Responsabilities { get; set; }

        public Administrator() : base()
        {
            Office = "";
            Responsabilities = new List<string>();
        }

        public Administrator(string firstname, string lastname, DateTime birthday, string email, int employeeid, string department, decimal salary, DateTime hiredate, string office, List<string> responsabilities) : base(firstname, lastname, birthday, email, employeeid, department, salary, hiredate)
        {
            Office = office;
            Responsabilities = responsabilities ?? new List<string>();
        }

        public override string GetRole()
        {
            return "Adminsistrator";
        }

        public override string GetProfile()
        {
            return
                $"ADMINISTRATOR  PROFILE\n" +
                $"Name: {FirstName} {LastName}\n" +
                $"Birthday: {Birthday:yyyy-MM-dd}\n" +
                $"Email: {Email}\n" +
                $"Employee ID: {EmployeeId}\n" +
                $"Department: {Department}\n" +
                $"Salary: {Salary}\n" +
                $"Hire Date: {HireDate:yyyy-MM-dd}\n" +
                $"Office: {Office}\n" +
                $"Responsabilities: {string.Join(", ", Responsabilities)}";
        }

        public override decimal CalculateAnnualBonus()
        {
            decimal bonus = base.CalculateAnnualBonus();
            bonus += 500m;
            return bonus;
        }
    }
}
