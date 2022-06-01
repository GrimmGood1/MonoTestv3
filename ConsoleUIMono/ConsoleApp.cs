using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using monotestv3;

namespace ConsoleUIMono
{
    class ConsoleApp
    {
        static void Main()
        {
            int comand = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Выберите фигуру: ");
                Console.WriteLine("1. Круг");
                Console.WriteLine("2. Треугольник");
                ConsoleKeyInfo key = Console.ReadKey();
                char cKey = key.KeyChar;
                double S = 0;
                if (cKey == '1')
                {
                    Console.WriteLine("Введите радиус: ");
                    double radius = Convert.ToDouble(Console.ReadLine());

                    S = new Circle(radius).Area;

                    Console.WriteLine("Площадь фигуры: " + S);

                    Console.ReadKey();
                }
                if (cKey == '2')
                {
                    Console.WriteLine("\nВведите стороны треугольника: ");
                    Console.WriteLine("Первая сторона: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Вторая сторона: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Третья сторона: ");
                    double c = Convert.ToDouble(Console.ReadLine());

                    S = new Triangle(a, b, c).Area;
                    bool rt = new Triangle(a, b, c).RightTriangle;

                    if (rt == true)
                        Console.WriteLine("Треугольник прямоугольный.");

                    Console.WriteLine("Площадь фигуры: " + S);

                    Console.ReadKey();

                }
                comand = (int)(cKey - '0');
            } while (comand <= 1 || comand >= 2);
        }

    }

}







