using System;

namespace LearnCSharp.Cmd
{
    public delegate int ArithmeticOperationDelegate(int i, int j);
    public class Program
    {
        static void Main()
        {
            var delegateArray = new ArithmeticOperationDelegate[3];
          
            for (int i = 0; i < delegateArray.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        delegateArray[i] = ArithmeticOperation.Add;
                        break;
                    case 1:
                        delegateArray[i] = ArithmeticOperation.Minus;
                        break;
                    case 2:
                        delegateArray[i] = ArithmeticOperation.Multiply;
                        break;
                }

                var del = delegateArray[i];
                Console.WriteLine(del(8, 9));
            }
        }
    }

    public class ArithmeticOperation
    {
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