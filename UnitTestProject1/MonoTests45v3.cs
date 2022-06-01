using System;
using Xunit;
using monotestv3;

namespace monotestv2Tests
{
    public class CalcAreaTests
    {
        [Fact]
        public void CircleAreaTest()
        {
            double radius = 5;

            double Area = Math.PI * radius * radius;

            Assert.Equal<double>(Area, new Circle(radius).Area);

        }
        [Fact]
        public void CircleOverdraft()
        {
            double radius = double.MaxValue + 1;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));

        }
        [Fact]
        public void CircleZeroRadius()
        {
            double radius = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));

        }
        [Fact]
        public void IsTriangleRight()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            bool ITR = (a * a) + (b * b) == (c * c);

            Assert.Equal<bool>(ITR, new Triangle(a, b, c).RightTriangle);
        }
        [Fact]
        public void TriangleAreaTest()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double pp = 0.5 * (a + b + c);

            double Area = Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));

            Assert.Equal<double>(Area, new Triangle(a, b, c).Area);

        }
        [Fact]
        public void TriangleOverdraft()
        {
            double a = double.MaxValue;
            double b = 4;
            double c = 5;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a, b, c));

        }
        [Fact]
        public void TriangZeroData()
        {
            double a = 0;
            double b = 4;
            double c = 5;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a, b, c));

        }
    }
}