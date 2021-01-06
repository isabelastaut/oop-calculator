using System;
using System.Collections.Generic;
using System.Text;

namespace Personal.Calculator.StaticMembers
{
    class Calculator
    {
        public static double Pi = 3.14;

        public static double Circumference(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }

        public static double SurfaceArea(double r)
        {
            return 4.0 * Pi * r * r;
        }
    }
}
