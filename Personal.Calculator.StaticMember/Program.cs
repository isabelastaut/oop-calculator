using System;
using System.Globalization;

namespace Personal.Calculator.StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the radius: ");
            double radius = double.Parse(Console.ReadLine());

            double circ = Calculator.Circumference(radius);
            double volume = Calculator.Volume(radius);
            double area = Calculator.SurfaceArea(radius);

            Console.WriteLine("Circumferece = " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume = " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Surface Area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi = " + Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
