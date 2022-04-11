using System;

namespace LearnCSharp.Cmd
{
    public class Program
    {
        static void Main()
        {
            var c = new Circle<int, bool>(90);
        }
    }

    public class Shape<P>
    {
        public P Radius { get; set; }
    }

    public class Circle<P, L> : Shape<P>
    {
        public Circle(P p1)
        {

        }
    }



}