using AreaLibrary.Shapes;
using AreaLibrary.Shapes.Calculator;
using AreaLibrary.Shapes.Validators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Tests
{
    [TestClass]
    public class ShapesTest
    {
        [TestMethod]
        public void TestCircle()
        {
            var circle = new Circle(5);
            Assert.AreEqual(78.53981633974483, AreaCalculator.Calculate(circle));
            var falseCircle = new Circle(-6);
            Assert.IsFalse(ShapeValidator.IsValid(falseCircle));
        }
        [TestMethod]
        public void TestTriangle()
        {
            var triangle = new Triangle(1, 2, 2);
            Assert.AreEqual(0.9682458365518543, AreaCalculator.Calculate(triangle));
            var falseTriangle = new Triangle(2, 1, -2);
            Assert.IsFalse(ShapeValidator.IsValid(falseTriangle));
        }
    }
}