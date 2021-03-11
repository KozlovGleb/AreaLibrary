using AreaLibrary.Shapes.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLibrary.Shapes.Calculator
{
    public static class AreaCalculator
    {
        public static double Calculate(Shape shape)
        {
            if (ShapeValidator.IsValid(shape))
                return shape.CalculateArea();
            throw new ArgumentException();
        }
    }
}
