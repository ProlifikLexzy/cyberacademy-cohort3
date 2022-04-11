using System;

namespace LearnCSharp.Cmd
{
    public class Program
    {
        static void Main()
        {
            var sum = new Addition<int, Shape, string>();
            sum.Add(new Shape(), 67, 90);

        }
    }


    public class Addition<T, R, V>
    {
        public void Add(R parameter1, T parameter2, int p3)
        {

        }
    }


    public class Shape { }
}