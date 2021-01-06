using System;
using System.Globalization;

namespace Personal.Calculator.InstanceMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.Write("Type the radius: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circumference(radius);
            double volume = calc.Volume(radius);
            double area = calc.SurfaceArea(radius);

            Console.WriteLine("Circumference = " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume = " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Surface Area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi = " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
