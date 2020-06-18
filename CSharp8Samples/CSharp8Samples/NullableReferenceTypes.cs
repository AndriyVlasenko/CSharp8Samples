using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSharp8Samples
{
    public class NullableReferenceTypes
    {
        public static void Demo()
        {
            var person = new Person("Bill", "Gates");
            var middleNameLength = GetMiddleNameLength(person);
        }

        private static object GetMiddleNameLength(Person person)
        {
            //if (person is { FirstName: "Bill", LastName: var last })
            //{
            //    return last.Length;
            //}
            var middleName = person.MiddleName;
            return middleName.Length;
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string name, string lastName)
        {
            FirstName = name;
            LastName = lastName;
        }

        public Person(string name, string middleName, string lastName) : this(name, lastName)
        {
            MiddleName = middleName;
        }
    }
}
