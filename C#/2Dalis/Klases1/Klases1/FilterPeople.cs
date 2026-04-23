using System;
using System.Collections.Generic;
using System.Text;

namespace Klases1
{
    internal class FilterPeople
    {
        //public static IEnumerable<Person> Filter(List<Person> people, string filterInput)
        //{
        //    var filters = filterInput.Split(',', StringSplitOptions.RemoveEmptyEntries);

        //    IEnumerable<Person> result = people;

        //    foreach (var f in filters)
        //    {
        //        var parts = f.Split('=', StringSplitOptions.RemoveEmptyEntries);

        //        if (parts.Length != 2)
        //            continue;

        //        var key = parts[0].Trim().ToLower();
        //        var value = parts[1].Trim();

        //        result = ApplyFilter(result, key, value);
        //    }

        //    return result;
        //}

        //private static IEnumerable<Person> ApplyFilter(IEnumerable<Person> people, string key, string value)
        //{
        //    return key switch
        //    {
        //        "firstname" => people.Where(p => p.FirstName.Equals(value, StringComparison.OrdinalIgnoreCase)),
        //        "lastname" => people.Where(p => p.LastName.Equals(value, StringComparison.OrdinalIgnoreCase)),
        //        "city" => people.Where(p => p.City.Equals(value, StringComparison.OrdinalIgnoreCase)),
        //        "age" => int.TryParse(value, out int age)
        //                            ? people.Where(p => p.Age == age)
        //                            : people,
        //        _ => people
        //    };
        //}

        public static List<Person> ByCity(List<Person> people, string city)
        {
            return people.Where(p => p.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static List<Person> ByFirstName(List<Person> people, string name)
        {
            return people.Where(p => p.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static List<Person> ByLastName(List<Person> people, string lname)
        {
            return people.Where(p => p.LastName.Equals(lname, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static List<Person> ByAge(List<Person> people, int age)
        {
            return people.Where(p => p.Age == age).ToList();
        }
    }
}
