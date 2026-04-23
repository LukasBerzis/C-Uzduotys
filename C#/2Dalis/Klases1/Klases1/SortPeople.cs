using System;
using System.Collections.Generic;
using System.Text;

namespace Klases1
{
    internal class SortPeople
    {

        public static IEnumerable<Person> Sort(List<Person> people, string sort)
        {
            var sorts = sort.ToLower().Split(',', StringSplitOptions.RemoveEmptyEntries);

            IOrderedEnumerable<Person>? result = null;

            foreach (var s in sorts.Select(x => x.Trim()))
            {
                result = ApplySort(result, people, s);
            }

            return result ?? people.AsEnumerable();
        }

        private static IOrderedEnumerable<Person> ApplySort(IOrderedEnumerable<Person>? current, List<Person> people, string sort)
        {
            return (current, sort) switch
            {
                (null, "firstname") => people.OrderBy(p => p.FirstName),
                (null, "lastname") => people.OrderBy(p => p.LastName),
                (null, "city") => people.OrderBy(p => p.City),
                (null, "age") => people.OrderBy(p => p.Age),
                (null, "birthdate") => people.OrderBy(p => p.BirthDate),

                (_, "firstname") => current!.ThenBy(p => p.FirstName),
                (_, "lastname") => current!.ThenBy(p => p.LastName),
                (_, "city") => current!.ThenBy(p => p.City),
                (_, "age") => current!.ThenBy(p => p.Age),
                (_, "birthdate") => current!.ThenBy(p => p.BirthDate),

                _ => current!
            };
        }
    }
}
