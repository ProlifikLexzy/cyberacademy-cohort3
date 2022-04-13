using System;

namespace LearnCSharp.Cmd
{
    public delegate int ArithmeticOperationDelegate(int i, int j);
    public class Program
    {
        static void Main()
        {
            Action<int, int, int> action = ArithmeticOperation.Method;
            Func<int, bool, string> func = (i, b) => 
            { 
                return ""; 
            };
           var c =  func(1, true);

            var func2 = new Func<int, bool, string>[3];
            func2[0] = ArithmeticOperation.Method2;
        }
    }

    public class ArithmeticOperation
    {
        public static string Method2( int i, bool b)
        {
            return "";
        }
        public static void Method(int i, int j, int k)
        {

        }
        public static int Add(int i, int j)
        {
            return i + j;
        }

        public static int Minus(int i, int j)
        {
            return i - j;
        }
        public static int Multiply(int i, int j)
        {
            return i * j;
        }


    }
}