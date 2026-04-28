using System;
using System.Dynamic;
using SchoolManagement_projektas;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            UndergraduateStudent undergrad = new UndergraduateStudent(
                "Jonas",
                "Jonaitis",
                new DateTime(2003, 5, 12),
                "jonas.jonaitis@uni.lt",
                1001,
                "Computer Science",
                3.4,
                2022,
                "Software Engineering",
                "Mathematics",
                75
                );

            GraduateStudent graduate = new GraduateStudent(
                "Aiste",
                "Petrauskaite",
                new DateTime(1999, 8, 21),
                "aiste.petrauskaite@uni.lt",
                2001,
                "Data Science",
                3.8,
                2021,
                "Machine Learning Optimization",
                "Dr. Kazlauskas",
                true
            );

            Teacher teacher = new Teacher(
                "Tomas",
                "Kazlauskas",
                new DateTime(1985, 3, 10),
                "tomas.kazlauskas@uni.lt",
                3001,
                "IT Department",
                2500,
                new DateTime(2015, 9, 1),
                "Programming",
                new List<string> { "C#", "Databases" },
                4.6
            );

            HeadOfDepartment head = new HeadOfDepartment(
                "Inga",
                "Jankauskiene",
                new DateTime(1978, 11, 5),
                "inga.jankauskiene@uni.lt",
                4001,
                "IT Department",
                3500,
                new DateTime(2010, 2, 15),
                "Software Engineering",
                new List<string> { "Architecture", "Design Patterns" },
                4.8,
                15,
                "Innovative and industry-focused education"
            );


            Administrator admin = new Administrator(
                "Petras",
                "Petraitis",
                new DateTime(1980, 6, 18),
                "petras.petraitis@uni.lt",
                5001,
                "Administration",
                2200,
                new DateTime(2012, 4, 10),
                "Room 204",
                new List<string> { "HR Management", "Scheduling", "Budget Planning" }
            );

            List<Person> PersonList = new List<Person>(); 
            PersonList.Add(undergrad);
            PersonList.Add(graduate);
            PersonList.Add(teacher);
            PersonList.Add(head);
            PersonList.Add(admin);

            foreach (Person item in PersonList)
            {
                Console.WriteLine(item.GetProfile());
                Console.WriteLine("-------------------");
            }

            List<Staff> StaffList = new List<Staff>();
            StaffList.Add(teacher);
            StaffList.Add(head);
            StaffList.Add(admin);

            foreach (Staff item in StaffList)
            {
                Console.WriteLine($"{item.FirstName} - {item.GetRole()} - {item.CalculateAnnualBonus()}");
                Console.WriteLine("-------------------");
            }

            List<Student> StudentList = new List<Student>();
            StudentList.Add(undergrad);
            StudentList.Add(graduate);

            foreach (Student item in StudentList)
            {
                Console.WriteLine($"{item.FirstName} - {item.GPA} - {item.GetAcademicStanding()}");
                Console.WriteLine("-------------------");
            }
        }
    }
}