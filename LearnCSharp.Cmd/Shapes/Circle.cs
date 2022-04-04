using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Cmd.Shapes
{
    public class Circle
    {
        public const double pi = 3.14;

        public static void Area(double radius)
        {
            Console.WriteLine(pi * (radius * radius));
        }
    }
}
