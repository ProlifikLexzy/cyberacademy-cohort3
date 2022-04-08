using System;

namespace LearnCSharp.Cmd
{

    public enum Gender
    {
        Male,
        Female
    }

    public enum UnitTypes
    {
        M ,
        KM,
        CM = 12,
        MM
    }
    public class Program
    {
        static void Main()
        {
            const string male = "M";
            const string female = "F";


            var p = new Point();
            p.Unit = UnitTypes.M;

            UnitTypes unit = (UnitTypes)0;
            Console.WriteLine(unit);
        }
    }

    public class Point
    {
        public UnitTypes Unit { get; set; }
        public int X { get; set; } = -1;
        public int Y { get; set; } = -1;

        public override string ToString()
        {
            return $"X = {X} {Unit}, Y = {Y} {Unit}";
        }
    }
}