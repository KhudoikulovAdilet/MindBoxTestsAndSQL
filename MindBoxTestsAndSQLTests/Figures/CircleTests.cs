using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxTestsAndSQL.Figures;
using System;

namespace MindBoxTestsAndSQL.Figures.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void AreaTest()
        {
            var circle = new Circle
            {
                Radius = 12
            };
            circle.Area();
        }
        [TestMethod()]
        public void TriangleTest()
        {
            var triangle = new Triangle
            {
                Side1 = 11,
                Side2 = 12,
                Side3 = 13,
            };
            triangle.Area();
            triangle.Ploshad();
        }
    }
}