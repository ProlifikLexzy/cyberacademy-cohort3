using System;

namespace LearnCSharp.Cmd
{
    public class Program
    {
        static void Main()
        {

        }
    }

    public class IShape
    { }

    public class Square: IShape
    { 
        public Square()
        {
        }
    }
    public class Circle
    {
        public Circle()
        { }
    }
    
    public class Shape<U, T> where U: IShape, new() where T : struct
    {

    }

    public class Triangle: Shape<Square, bool>
    {

    }


}