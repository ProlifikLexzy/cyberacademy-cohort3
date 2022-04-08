using System;

namespace LearnCSharp.Cmd
{

   
    public class Program
    {
        static void Main()
        {
            var p = new Point[9];
            var line = new Line(p);
        }
    }

    public struct Line
    {
        public Line(Point[] points)
        {
            Points = points;
        }

        public Point[] Points { get; set; }
    }

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }   
    }

}