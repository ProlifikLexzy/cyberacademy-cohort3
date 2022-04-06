using LearnCSharp.Library;
using System;

namespace LearnCSharp.Cmd
{
    public class Program
    {  
        static void Main()
        {
            Shape s = new Shape(89);
            s.Draw();

            Shape c = new Circle(70);
            c.Draw();

            SuperCircle sc = new SuperCircle(90);
            sc.Draw();
        }
    }
}