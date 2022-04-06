using LearnCSharp.Library;
using System;

namespace LearnCSharp.Cmd
{
    public class Program
    {
        static void Main()
        {
            int i = 0;
            if (!(i < 9 || false))
            {
                i = 2;
            }
            else if (i <= -10 || i != 5)
            {
                i = 1;
            }
            else if (i == 0)
            {
                i = 7;
            }
            else
            {
                i = 3;
            }
            Console.WriteLine(i);
        }
    }
}