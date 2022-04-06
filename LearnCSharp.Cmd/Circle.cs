using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Cmd
{
    public class Circle : Shape
    {

        public Circle(double radius):base(radius)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }

        public override void Print()
        {
            
        }
    }
}
