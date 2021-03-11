using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaLibrary.Shapes
{
    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;
        public double p;
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }

        public override double CalculateArea()
        {
            p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override bool Validation()
        {
            double[] sides = new double[] { a, b, c };
            if (sides.Any(side => side < 0))
                return false;
            if (a + b <= c | a + c <= b | c + b <= a)
            {
                return false;
            }
            return true;
        }
    }
}
