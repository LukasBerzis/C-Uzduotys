using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement_projektas
{
    internal class GraduateStudent : Student
    {
        public string ThesisTitle { get; set; }
        public string Supervisor { get; set; }
        public bool ThesisSubmitted { get; set; }

        public GraduateStudent() : base()
        {
            ThesisTitle = "";
            Supervisor = "";
            ThesisSubmitted = false;
        }

        public GraduateStudent(string firstname, string lastname, DateTime birthday, string email, int studentid, string program, double gpa, int enrollmentyear, string thesistitle, string supervisor, bool thesissubmitted) : base(firstname, lastname, birthday, email, studentid, program, gpa, enrollmentyear)
        {
            ThesisTitle = thesistitle;
            Supervisor = supervisor;
            ThesisSubmitted = thesissubmitted;
        }

        public override string GetRole()
        {
            return "Graduate Student";
        }

        public override string GetProfile()
        {
            return
                $"STUDENT PROFILE\n" +
                 $"Name: {FirstName} {LastName}\n" +
                 $"Birthday: {Birthday:yyyy-MM-dd}\n" +
                 $"Email: {Email}\n" +
                 $"Student ID: {StudentId}\n" +
                 $"Program: {Program}\n" +
                 $"GPA: {GPA}\n" +
                 $"Enrollment Year: {EnrollmentYear}\n" +
                 $"Thesis title: {ThesisTitle}\n" +
                 $"Supervisor: {Supervisor}\n" +
                 $"Thesis Submitted: {ThesisSubmitted}";
        }

        public override string GetAcademicStanding()
        {
            if (GPA < 2.0)
                { return $"GPA: {GPA} - At Risk"; }

            if (GPA < 3.0)
                { return $"GPA: {GPA} - Pass"; }

            if (GPA < 3.5)
               { return $"GPA: {GPA} - Merit"; }

            return $"GPA: {GPA} - Distinction";

        }
    }
}
