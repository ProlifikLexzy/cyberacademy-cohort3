using System;
using System.Collections;
using System.Collections.Generic;
using LearnCSharp.Library;

namespace LearnCSharp.Cmd
{
    public class Program
    {
        public static void Main()
        {
            var employeeDictionary = new Dictionary<string, Employee>() 
            {
                { "EMP-001", new Employee(){ FullName  = "Paul Wal"} }
            };

            Employee employee = employeeDictionary["EMP-001"];

            var intDictionary = new Dictionary<string, int>()
            {
                { "item1", 1},
                { "item2", 2},
                {"item3", 3 }
            };
            var dictionary = new Dictionary<string, string>()
            {
                { "item3", "item Three"},
                { "item4", "item four"}
            };
            dictionary["item1"] = "Item One";
            dictionary["item2"] = "Item Two";
            //foreach (KeyValuePair<string, string> item in dictionary)
            //{
            //        Console.WriteLine(item.Value);
            //}

            Console.WriteLine(dictionary["item2"]);
            return;

            var sortedSet = new SortedSet<int>() { 2, 1, 300, 3, 20, 19 };
            foreach (var set in sortedSet)
            {
                Console.WriteLine(set);
            }

            return;

            var queue = new Queue<string>();
            queue.Enqueue("item1");
            queue.Enqueue("item2");
            queue.Enqueue("item3");
            queue.Enqueue("item4");

            var q = queue.Dequeue();
            q = queue.Peek();


            return;

            Stack<string> stack = new Stack<string>();
            stack.Push("item1");
            stack.Push("item2");
            stack.Push("item3");

            var item1 = stack.Pop();
            Console.WriteLine(item1);
            Console.WriteLine(stack.Count);
            item1 = stack.Pop();
            Console.WriteLine(item1);
            Console.WriteLine(stack.Count);
            item1 = stack.Peek();
            Console.WriteLine(item1);
            Console.WriteLine(stack.Count);
            return;

            var uniqueNameSet = new HashSet<string>();

            uniqueNameSet.Add("James Mike");
            uniqueNameSet.Add("JAMES Mike");
            uniqueNameSet.Add("Segun Owa");

            foreach (var item in uniqueNameSet)
            {
                Console.WriteLine(item);
            }

            return;

            //var list = new List<string>()
            //{
            //   "James Mike",
            //   "James Mike",
            //   "James Mike",
            //   "James Mike",
            //}; 
            //Console.WriteLine($"Capacity: {list.Capacity}");

            //list.Add("James Mike");
            //Console.WriteLine($"Capacity: {list.Capacity}");
            //Console.WriteLine($"Count: {list.Count}");
            //list.Add("James Mike");
            //list.Add("James Mike");
            //list.Add("James Mike");
            //list.Add("James Mike");
            //Console.WriteLine($"Capacity: {list.Capacity}");
            //Console.WriteLine($"Count: {list.Count}");

            //var employees = new Employee[]
            //{
            //    new Employee(){ FullName = "Warren Buffet"},
            //    new Employee(){ FullName = "Steve Jobs"},
            //    new Employee{ FullName ="Bill Gates"}
            //};

            //var employees2 = new Employee[]
            //{
            //    new Employee(){ FullName = "Jim Ovia"},
            //    new Employee(){ FullName = "Aliko Dangote"},
            //    new Employee{ FullName ="Mike Adenuga"}
            //};

            //var staffs = new Staffs(employees);

            //var enumerator = staffs.GetEnumerator();

            //while (enumerator.MoveNext())
            //{
            //    var item = enumerator.Current;
            //    Console.WriteLine(item);
            //}
            //while (enumerator.MoveNext())
            //{
            //    var item = enumerator.Current;
            //    Console.WriteLine(item);
            //}

            var word = "Hello World";

            foreach (var item in word)
            {

                Console.WriteLine(item);
            }

            word += "C Sharp";

            foreach (var item in word)
            {

                Console.WriteLine(item);
            }

            //var staffs2 = new Staffs(employees2);


            //foreach (var item in staffs)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("=================");
            //foreach (var item in staffs)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadLine();
        }
    }
}