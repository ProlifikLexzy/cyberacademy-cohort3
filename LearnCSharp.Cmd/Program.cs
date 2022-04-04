using LearnCSharp.Cmd.Shapes;
using LearnCSharp.Library;
using System;

namespace LearnCSharp.Cmd
{
    public class Program
    {  
        static string name = "Seyi";
        static void Main()
        {
            Circle c = new Circle();
            var c1 = new Circle();
            Circle c2 = SomeMethod();
        }

        static Circle SomeMethod()
        {
            Circle c2 = new();
            return c2;

        }
    }
}