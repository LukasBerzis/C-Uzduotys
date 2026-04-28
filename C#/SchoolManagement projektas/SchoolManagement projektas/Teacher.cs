using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement_projektas
{
    internal class Teacher : Staff
    {
        public string SubjectArea { get; set; }
        public List<string> CoursesTaught {  get; set; }
        public double TeachingRating {  get; set; }

        public Teacher() : base()
        {
            SubjectArea = "";
            CoursesTaught = new List<string>();
            TeachingRating = 0;
        }

        public Teacher(string firstname, string lastname, DateTime birthday, string email, int employeeid, string department, decimal salary, DateTime hiredate, string subjectarea, List<string> coursestaught, double teachingrating) : base( firstname,  lastname,  birthday,  email,  employeeid,  department,  salary,  hiredate)
        {
            SubjectArea = subjectarea;
            TeachingRating = teachingrating;
            CoursesTaught = coursestaught ?? new List<string>();
        }

        public override string GetRole()
        {
            return "Teacher";
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
                $"Teaching rating: {TeachingRating}";
        }
    }
}
