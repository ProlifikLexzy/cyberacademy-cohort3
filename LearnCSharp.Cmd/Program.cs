using System;

namespace LearnCSharp.Cmd
{
    public class Program
    {
        static void Main()
        {
            object o = new object();
            int i = 9;
            string s = "Prolifik,Lexzy, Segun";

            var p = new Person() { LastName = "Prolifik", FirstName = "Lexzy" };
            var p2 = new Person() { LastName = "Paul" };
            var p3 = new Person();

            Console.WriteLine(p);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }

    public class Person
    {
        public Person()
        {
            FirstName = "Unknown";
            LastName = "Unknown";
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.LastName + " " + this.FirstName;
        }
    }

    public class Shape
    {
        public static void WriteLine(Person p)
        {
            p.ToString();
        }
    }
}