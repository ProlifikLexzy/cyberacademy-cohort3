using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Cmd
{
    public class Vehicle
    {
        public class Car
        {
            private static string _manufacturer; //private instance global field
            public Car(string manufacturer)
            {
                _manufacturer = manufacturer;
            }

            public void DisplayManufacturerName()
            {
                Console.WriteLine(_manufacturer);
            }

        }
    }
}
