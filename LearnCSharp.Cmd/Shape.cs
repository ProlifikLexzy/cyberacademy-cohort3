using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Cmd
{
    public abstract class Shape
    {
        public Shape(double radius)
        {

        }
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }

        public abstract void Print();
    }
}
