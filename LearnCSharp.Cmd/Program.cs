using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace LearnCSharp.Cmd
{
    public class Program
    {
        static async Task Main()
        {
            var http = new HttpClient();
            var response = await http.PostAsync(default, default);

            var taskResult = MethodAsync();

            for (int i = 0; i < 5; i++)
            {
                PrintWriteLine($"B{i}");
                Task.Delay(1000).Wait();
            }

            PrintWriteLine("Waiting for MethodAsync to finish");
            int k = await taskResult;

            Console.WriteLine("dkfkdgdg");
            Console.WriteLine($"{k}");

            Console.Read();
        }

        public static async Task<int> MethodAsync()
        {
            for (int i = 0; i < 5; i++)
            {
                await Task.Delay(2000);
                PrintWriteLine($"A{i}");

            }

            int result = 123;
            Console.WriteLine($"It returns {result}");

            return result;
        }

        static void PrintWriteLine(string msg)
        {
            int threadId = Thread.CurrentThread.ManagedThreadId;
            Console.ForegroundColor = threadId == 1 ? ConsoleColor.Cyan : ConsoleColor.Red;
            string tab = new string(' ', 37 - msg.Length);
            Console.WriteLine("{0}{1}Thread{2}", msg, tab, threadId);
        }
    }
}