using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement_projektas
{
    internal class UndergraduateStudent : Student
    {
        public string Major { get; set; }
        public string Minor { get; set; }
        public double TotalCredits { get; set; }

        public UndergraduateStudent()
        {
            Major = "";
            Minor = "";
            TotalCredits = 0;
        }

        public UndergraduateStudent(string firstname, string lastname,DateTime birthday, string email, int studentid,string program,double gpa,int enrollmentyear, string major, string minor, double totalCredits) : base(firstname, lastname, birthday, email, studentid, program, gpa, enrollmentyear)
        {
            Major = major;
            Minor = minor;
            TotalCredits = totalCredits;
        }

        public override string GetRole()
        {
            return "Undergraduate Student";
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
                 $"Enrollment Year: {EnrollmentYear}" +
                 $"Major: {Major}\n" +
                 $"Minor: {Minor}\n" +
                 $"Total Credits: {TotalCredits}";
        }

        public override string GetAcademicStanding()
        {
            string standing = base.GetAcademicStanding();

            string courseLevel;

            if (TotalCredits < 30)
            {
                courseLevel = "Freshman";
            }
            else if (TotalCredits < 60)
            {
                courseLevel = "Sophomore";
            }
            else if (TotalCredits < 90)
            {
                courseLevel = "Junior";
            }
            else
            {
                courseLevel = "Senior";
            }

            return $"{standing} - {courseLevel}";
        }
    }
}
