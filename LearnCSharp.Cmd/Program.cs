using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnCSharp.Cmd
{
    public class Program
    {
        static void Main()
        {
            var task = new Task(DoWork);

            var task2 = new Task(delegate { DoWork(); });

            var task3 = new Task(() =>
            {
                for (int i = 0; i < 100_0000; i++)
                {
                    Console.Write(i);
                }

            });

            task.Start();
          
            Console.WriteLine("End of Main......");
            Console.Read();

        }

        public async static Task DoWork()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(i);
            }
        }

        public async Task<int> Add()
        {

        }

        public async Task DoWorkAsync()
        {

        }
    }
}