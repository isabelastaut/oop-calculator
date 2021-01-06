using System;
using System.Globalization;

namespace Personal.Calculator.ProgramDependent
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("type the radius: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circumference(radius);
            double volume = Volume(radius);
            double area = SurfaceArea(radius);

            Console.WriteLine("Circumference = " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume = " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Surface area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi = " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circumference(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }

        static double SurfaceArea(double r)
        {
            return 4.0 * Pi * r * r;
        }
    }
}
