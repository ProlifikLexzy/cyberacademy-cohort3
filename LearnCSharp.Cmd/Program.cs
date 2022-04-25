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
            List<Product> prod = new List<Product>()
            {
                new Product(){Name = "Milo", Quantity = 10},
                 new Product(){Name = "Peak", Quantity = 12},
                  new Product(){Name = "Sugar", Quantity = 3},
                   new Product(){Name = "Indomie", Quantity = 60},
                    new Product(){Name = "Soap", Quantity = 5},
                     new Product(){Name = "Cream", Quantity = 2},
                      new Product(){Name = "Shoe", Quantity = 3},
                       new Product(){Name = "Brush", Quantity = 2},
                        new Product(){Name = "Biscuit", Quantity = 30},
                         new Product(){Name = "Perfume", Quantity = 1},
            };

            prod.Sort(new Comparer<Product>());
            foreach (var p in prod)
            {
                Console.WriteLine("{0}\t{1} ", p.Name, p.Quantity);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        public class Product: IOrder
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public int Order { set; get; }

            public override string ToString()
            {
                return $"Name: {Name}, Quantity: {Quantity}";
            }
        }

        public class Comparer<T> : IComparer<T> where T : IOrder
        {
            //public T Order { get; set; }
            public int Compare(T x, T y)
            {

                if (x.Order < y.Order)
                    return 1;
                else if (x.Order > y.Order)
                    return -1;
                else
                    return 0;

            }


        }

        public interface IOrder
        {
            public int Order { get; set; }
        }

    }
}