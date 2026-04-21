using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement_projektas
{
    internal abstract class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; } 

        public DateTime Birthday { get; set; }

        public string Email { get; set; }

        protected Person()
        {
            FirstName = "";
            LastName = "";
            Email = "";
        }

        protected Person(string firstName, string lastName, DateTime birthday, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            Email = email;
        }

        public virtual string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public abstract string GetRole();

        public abstract string GetProfile();

        public virtual string GetContactInfo()
        {
            return Email;
        }
    }
}
