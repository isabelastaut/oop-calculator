using System;
using System.Collections.Generic;
using System.Text;

namespace Personal.Calculator.InstanceMembers
{
    class Calculator
    {
        public double Pi = 3.14;

        public double Circumference(double r)
        {
            return 2.0 * Pi * r;
        }

        public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }

        public double SurfaceArea(double r)
        {
            return 4.0 * Pi * r * r;
        }
    }
}
