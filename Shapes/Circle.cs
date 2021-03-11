using AreaLibrary.Shapes.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLibrary.Shapes
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }

        }
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override bool Validation()
        {
            var result = radius > 0;
            return result;
        }
    }
}
