using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement_projektas
{
    internal class Staff : Person
    {
        public int EmployeeId { get; set; }
        public string Department {  get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        public Staff() : base()
        {
            EmployeeId = 0;
            Department = "";
            Salary = 0;
            HireDate = DateTime.MinValue;
        }

        public Staff(string firstname, string lastname, DateTime birthday, string email, int employeeid, string department, decimal salary, DateTime hiredate) : base(firstname,lastname, birthday, email)
        {
            EmployeeId=employeeid;
            Department=department;
            Salary=salary;
            HireDate = hiredate;
        }

        public override string GetRole()
        {
            return "Staff";
        }

        public override string GetProfile()
        {
            return
                $"STAFF PROFILE\n" +
                $"Name: {FirstName} {LastName}\n" +
                $"Birthday: {Birthday:yyyy-MM-dd}\n" +
                $"Email: {Email}\n" +
                $"Employee ID: {EmployeeId}\n" +
                $"Department: {Department}\n" +
                $"Salary: {Salary}\n" +
                $"Hire Date: {HireDate:yyyy-MM-dd}";
        }

        public override string GetContactInfo()
        {
            return $"Email: {Email}, Department: {Department}";
        }

        public virtual decimal CalculateAnnualBonus()
        {
           decimal BazinisBonusas = 5m;
           int BonusoMetuStazas = 5;
           DateTime Today = DateTime.Now;

            int yearsWorked = Today.Year - HireDate.Year;

            if (Today < HireDate.AddYears(yearsWorked))
            {
                yearsWorked--;
            }

            if (yearsWorked >= 5)
            {
                int multiplier = (int)Math.Floor((double)yearsWorked / BonusoMetuStazas);

                decimal totalBonusPercent = BazinisBonusas * multiplier;

                return Salary * (totalBonusPercent / 100);
            }

            return 0;
            
        }

    }
}
