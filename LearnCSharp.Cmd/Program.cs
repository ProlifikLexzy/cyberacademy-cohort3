using System;

namespace LearnCSharp.Cmd
{

    public class Program
    {
        static void Main()
        {

            People p = new People();

            Person person = p[1];
            Console.WriteLine(person.Name);



            ShoppingBag<Bag> shoppingBag = new ShoppingBag<Bag>();
            shoppingBag.AddItem(new Bag() { ProductName = "Tomato Paste", ProductCount = 67 });
            shoppingBag.AddItem(new Bag() { ProductName = "Corn Flakes", ProductCount = 7 });
            shoppingBag.AddItem(new Bag() { ProductName = "Indomie", ProductCount = 67 });
            shoppingBag.AddItem(new Bag() { ProductName = "Hypo", ProductCount = 67 });

            var counter = 0;
            while (counter < 4)
            {
                Console.WriteLine(shoppingBag[counter]); //indexing
                counter++;
            }
        }
    }

    public class ShoppingBag<T> where T : Bag
    {
        private T[] _items = new T[10];
        private int _index = 0;
        public void AddItem(T item)
        {
            _items[_index++] = item;
        }

        public T GetItem(int index)
        {
            return _items[index];
        }

        public T this[int position]
        {
            get
            {
                return _items[position];
            }
        }
    }

    public class Bag
    {
        public string ProductName { get; set; }
        public int ProductCount { get; set; }


        public override string ToString()
        {
            return $"{ProductName} - {ProductCount}";
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }

    public class People
    {
        private readonly Person[] names = {

            new Person{ Name = "Bill Gates" },
            new Person{Name = "Prolifik Lexzy"},
            new Person{Name = "Scott Allen" },
            new Person{Name ="Scott Guthrie" }
        };

        public Person this[int position]
        {
            get
            {
                return names[position];
            }
        }
    }
}