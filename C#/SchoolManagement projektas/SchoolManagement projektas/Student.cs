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
    }
}
