using System;

namespace LearnCSharp.Cmd
{
    public class Program
    {
        static void Main()
        {
            var anything = new int[4]{9, 3, 88, 45 };

            int s = anything[3] + 1;
            anything[3] =s;
            anything[2] = anything[0];

            Console.WriteLine(anything[2]);

            bool[] bidemi = new bool[3] { true, true, false };
        }
    }
}