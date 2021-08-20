using Mindbox_task;
using NUnit.Framework;
using System;

namespace TaskTests
{
    public class Tests
    {
        [Test]
        public void MinusRadius()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10));
        }
        [Test]
        public void MinusSides()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-123, 0, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -123, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -123));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, -1, -1));
        }
        [Test]
        public void CircleTest()
        {
            var circle = new Circle(14.4);
            var circleSquare = circle.SquareOfCircle();
            Assert.AreEqual(circleSquare, 651.44);
        }
        [Test]
        public void TriangleTest()
        {
            var tri = new Triangle(5,7,9);
            var triSquare = tri.TriangleSquare();
            Assert.AreEqual(triSquare, 17.41);
        }
        [Test]
        public void IsRightTri()
        {
            var tri = new Triangle(24, 10, 26);
            Assert.IsTrue(tri.IsRightTriangle());
        }
    }
}