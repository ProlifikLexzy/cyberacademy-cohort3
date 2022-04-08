using System;

namespace LearnCSharp.Cmd
{
    public class Program
    {
        static void Main()
        {

            var s = new Shape();
            s.Length = 89;
            s.Height = 71;

            short s1 = 10;
            short s2 = 12;
            int[] numbers = new int[2] 
            { 
                s1, s2
            };

            int[] num = {1 , 2 };

            Point[] points = { 
                new Point { X = 82, Y = 12 },
                new Point { X = -19, Y = -100},
                new Shape()
            };

            s.Center = points;

            var s3 = new Shape()
            {
                Length = 40,
                Height = 45
            };

            s.Draw();

            var someType = new
            {
                Model = "Porche",
                Year = 3000,
            };

            var someType2 = new
            {
                Model = "Toyota",
                Year = 3000,
            };

            var customer = new
            {
                LastName = "",
                FirstName = "",
                fgsdfgf = 89
            };


            someType = someType2;

        }
    }

    public class Shape: Point
    {
        public Point[] Center { get; set; }
        private int length = 78;

        public int Length
        {
            get
            {
                return length;
            }

            set
            {
                length = value;
            }
        }

        public int Height { get; set; }

        public void Draw()
        {
            Console.WriteLine(Length);
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }  
    }
}