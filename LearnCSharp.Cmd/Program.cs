using System;

namespace LearnCSharp.Cmd
{
    public class Program
    {
        static void Main()
        {
            Point[] points = new Point[20];

            for (int i = 0; i < points.Length; i++)
            {
                //if (i % 2 == 0)
                //    continue;

                points[i] = new Point() { X = i * 2, Y = i * 3 };
            }

            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine(points[i]);
            }
        }
    }

    public class Point
    {
        public int X { get; set; } = -1;
        public int Y { get; set; } = -1;

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}";
        }
    }
}