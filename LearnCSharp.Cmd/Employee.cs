using System;

namespace LearnCSharp.Cmd
{

    public class Employee
    {
        public string LastName { get; }
        public string FirstName { get; }

        public int Age { get; set; }

        public Employee(string lastName, string firstName, int age = 0) // method
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
        }


        public string GetFullName()
        {
            return $"{this.LastName} {this.FirstName}";
        }
    }
}
