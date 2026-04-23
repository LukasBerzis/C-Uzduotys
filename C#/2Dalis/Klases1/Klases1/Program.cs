using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Klases1;

namespace MyApp
{
    internal static class Program
    {
        static void ReadFromFileToList(List<Person> Lst)
        {
            var lines = File.ReadAllLines("sarasasPerson.txt");
            foreach (var line in lines)
            {
                var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length >= 4 && DateTime.TryParse(parts[3], out DateTime birthdate))
                {
                    var person = new Person
                    {
                        FirstName = parts[0],
                        LastName = parts[1],
                        City = parts[2],
                        BirthDate = birthdate
                    };

                    Lst.Add(person);
                }
            }
        }

        static string ReadRequiredInput(string  message)
        {
            while (true)
            {
                Console.WriteLine(message);
                var input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }

                Console.WriteLine("ivestis negali buti tuscia. Bandykite dar karta.");
            }
        }

        static void PrintPeople(IEnumerable<Person> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}, Age: {person.Age}, City: {person.City}");
            }
        }

        static void Main(string[] args)
        {
            List<Person> people2 = new List<Person>();
            ReadFromFileToList(people2);
        
            string filter = ReadRequiredInput("Pagal ka norite filtruoti? FirstName, LastName, Age arba City");
            filter = filter.ToLower();

            if (filter == "city")
            {               
                string miestas = ReadRequiredInput("Iveskite pagal kuri miesta filtruoti:");

                var people = FilterPeople.ByCity(people2, miestas);

                PrintPeople(people);
            }
            else if (filter == "firstname")
            { 
                string firstname = ReadRequiredInput("Iveskite pagal kuri varda filtruoti:");

                var people = FilterPeople.ByFirstName(people2, firstname);

                PrintPeople(people);
            }
            else if (filter == "lastname")
            {
                string LastName = ReadRequiredInput("Iveskite pagal kuria pavarde filtruoti:");

                var people = FilterPeople.ByLastName(people2, LastName);

                PrintPeople(people);
            }
            else if (filter == "age")
            {
                if (int.TryParse(ReadRequiredInput("Iveskite amziu:"), out int age))
                {
                    var people = FilterPeople.ByAge(people2, age);

                    PrintPeople(people);
                }
                else
                {
                    Console.WriteLine("Neteisingas amzius.");
                }
            }

            string sort = ReadRequiredInput("Pagal ka sortinti? City,LastName,FirstName");

            var sortedPeople = SortPeople.Sort(people2, sort);

            PrintPeople(sortedPeople);

            List<Person> people1 = new List<Person>()
            {
                new Person { FirstName = "Jonas", LastName = "Jonaitis", City = "Vilnius", BirthDate = new DateTime(1999, 5, 12)},
                new Person { FirstName = "Ona", LastName = "Onaite", City = "Kaunas", BirthDate = new DateTime(1994, 11, 3)},
                new Person { FirstName = "Petras", LastName = "Petraitis", City = "Klaipėda", BirthDate = new DateTime(1980, 2, 20)},
                new Person { FirstName = "Ieva", LastName = "Ievaite", City = "Šiauliai", BirthDate = new DateTime(2002, 7, 14)},
                new Person { FirstName = "Tomas", LastName = "Tomaitis", City = "Panevėžys", BirthDate = new DateTime(1988, 1, 30)},
                new Person { FirstName = "Rasa", LastName = "Rasaite", City = "Alytus", BirthDate = new DateTime(1996, 9, 9)}
            };

            var top5 = people1.OrderByDescending(p => p.Age).Take(5).ToList();

            Console.WriteLine(" ");

            PrintPeople(top5);

            File.WriteAllLines("sarasas.txt", top5.Select(p => $"{p.FirstName} {p.LastName}, Age: {p.Age}, City: {p.City}"));
        }
    }
}