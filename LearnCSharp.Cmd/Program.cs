using LearnCSharp.Library;
using System;

namespace LearnCSharp.Cmd
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Enter F/M as your gender");
            var input = Console.ReadLine().ToUpper().Trim();

            switch (input)
            {
                case "MALE":
                    goto case "M";
                case "FEMALE":
                case "F":
                    Console.WriteLine("You're a female");
                    break;
                case "M":
                    Console.WriteLine("You're a Male");
                    break;
                default:
                    Console.WriteLine("Unknow Gender");
                    break;
            }
            Console.WriteLine("End of main");
        }
    }
}