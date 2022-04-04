using LearnCSharp.Library;
using System;

namespace LearnCSharp.Cmd
{
    public class Program
    {  
        static string name = "Seyi";
        static void Main()
        {
            var v = new Vehicle();

            Vehicle.Car bmw = new Vehicle.Car("BMW");
            bmw.DisplayManufacturerName();

            var mercedes = bmw;
            mercedes.DisplayManufacturerName();
          
            mercedes.DisplayManufacturerName();

            var volvo = new Vehicle.Car("Volvo");
            mercedes.DisplayManufacturerName();
        }

        static void SomeMethod()
        {

        }

        static void SomeMethod(int i)
        {

        }
    }
}