using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace monotestv3
{
    public enum ShapeTypes
    {
        Circle,
        Triangle
    }

    public class Shape
    {
        public Shape(ShapeTypes type)
        {
            Type = type;
        }

        public ShapeTypes Type { get; }
        public double Area { get; }
    }

    public class Circle : Shape
    {
        public Circle(double radius) : base(ShapeTypes.Circle)
        {
            if (radius < 1 || radius >= double.MaxValue) // проверка на нулевой и отрицательный радиус и перегрузку
                throw new ArgumentOutOfRangeException();
            Area = Math.PI * radius * radius;
        }
        public new double Area { get; }
    }

    public sealed class Triangle : Shape
    {
        public Triangle(double a, double b, double c) : base(ShapeTypes.Triangle)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException();
            if (a >= double.MaxValue || b >= double.MaxValue || c >= double.MaxValue)
                throw new ArgumentOutOfRangeException();
            pPerimetr = 0.5 * (a + b + c);
            Area = Math.Sqrt(pPerimetr * (pPerimetr - a) * (pPerimetr - b) * (pPerimetr - c)); // формула Герона

            if ((a * a) + (b * b) == (c * c) || (a * a) + (c * c) == (b * b) || (b * b) + (c * c) == (a * a)) // проверка на прямой угол
                RightTriangle = true;
            else
                RightTriangle = false;
        }
        private double pPerimetr;
        public new double Area { get; }
        public bool RightTriangle { get; }
    }
}