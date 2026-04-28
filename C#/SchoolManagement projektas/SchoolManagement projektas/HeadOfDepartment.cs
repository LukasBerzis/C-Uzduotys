using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement_projektas
{
    internal class HeadOfDepartment : Teacher
    {
        public int TeamSize { get; set; }
        public string DepartmentVision { get; set; }

        public HeadOfDepartment() : base()
        {
            TeamSize = 0;
            DepartmentVision = "";
        }

        public HeadOfDepartment (string firstname, string lastname, DateTime birthday, string email, int employeeid, string department, decimal salary, DateTime hiredate, string subjectarea, List<string> coursestaught, double teachingrating, int teamsize, string departemntvision) : base(firstname, lastname, birthday, email, employeeid, department, salary, hiredate, subjectarea, coursestaught, teachingrating)
        {
            TeamSize = teamsize;
            DepartmentVision = departemntvision;
        }

        public override string GetRole()
        {
            return "Head Of Department";
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
                $"Hire Date: {HireDate:yyyy-MM-dd}\n" +
                $"Subject area: {SubjectArea}\n" +
                $"Courses Taught: {string.Join(", ", CoursesTaught)}\n" +
                $"Teaching rating: {TeachingRating}\n" +
                $"Team size: {TeamSize}\n" +
                $"Department vision: {DepartmentVision}";
        }

        public override string GetContactInfo()
        {
            return $"Email: {Email}, Department: {Department} (Head)";
        }

        public override decimal CalculateAnnualBonus()
        {
            decimal bonus = base.CalculateAnnualBonus();
            bonus += bonus * 1.15m;
            return bonus;
        }
    }
}
