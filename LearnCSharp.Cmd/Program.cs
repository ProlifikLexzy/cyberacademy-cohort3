using System;

namespace LearnCSharp.Cmd
{
    public delegate int Arithmetic(int first, int second);

    public delegate Shape DrawDelegate();

    public class Shape
    {

    }

    public class Triangle: Shape
    {

    }
    public class Program
    {

        static Triangle DrawTriangle()
        {
            return new Triangle();
        }

        static void Main()
        {
            DrawDelegate drawDelegate = DrawTriangle;

            Arithmetic del = Add;
            //del += Minus;
            var result = del(39, 8);
            Console.WriteLine(result);

            //Console.WriteLine("+++++++++++++++++");
            //del -= MyMethod2;
            //del(80);

        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Minus(int x, int y)
        {
            return x - y;
        }

    }
}