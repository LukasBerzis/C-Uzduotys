using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement_projektas
{
    internal class Student : Person
    {
        public int StudentId { get; set; }
        public string Program { get; set; }

        public double GPA { get; set; }

        public int EnrollmentYear { get; set; }

        public Student() : base()
        {
            StudentId = 0;
            Program = "";
            GPA = 0;
        }

        public Student(string firstname, string lastname, DateTime birthday, string email ,int studentId, string program, double gpa, int enrollmentYear) : base(firstname, lastname, birthday, email)
        {
            StudentId = studentId;
            Program = program;
            GPA = gpa;
            EnrollmentYear = enrollmentYear;
        }

        public override string GetRole()
        {
            return "Student";
        }

        public override string GetProfile()
        {
            return 
                 $"STUDENT PRFILE\n" +
                 $"Name: {FirstName} {LastName}\n" +
                 $"Birthday: {Birthday:yyyy-MM-dd}\n" +
                 $"Email: {Email}\n" +
                 $"Student ID: {StudentId}\n" +
                 $"Program: {Program}\n" +
                 $"GPA: {GPA}\n" +
                 $"Enrollment Year: {EnrollmentYear}";
        }

        public virtual string GetAcademicStanding()
        {
            if (GPA < 2.00)
            {
                return $"GPA: {GPA} Academic Probation";
            }
            else if(GPA >= 2.00 && GPA < 3.00)
            {
                return $"GPA: {GPA} Satisfactory Academic Progress";
            }
            else if (GPA >= 3.00 && GPA < 3.50)
            {
                return $"GPA: {GPA} Good Standing";
            }
            else
            {
                return $"GPA: {GPA} Dean's List";
            }
        }
    }
}
