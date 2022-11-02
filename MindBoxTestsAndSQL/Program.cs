using MindBoxTestsAndSQL.Figures;
using System;

namespace MindBoxTestsAndSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("S - вычислить площадь круга");
            Circle circle = new Circle();
            Console.WriteLine("D - вычислить площадь треугольника");
            Triangle triangle = new Triangle();

            var key = Console.ReadKey();
            Console.WriteLine();
            switch (key.Key)
            {
                case ConsoleKey.S:
                    Console.WriteLine("Введите радиус круга");
                    circle.Radius = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Площадь круга радиусом {circle.Radius} равна {circle.Area()}");
                    break;
                case ConsoleKey.D:
                    Console.WriteLine("Введите значение стороны 1");
                    triangle.Side1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение стороны 2");
                    triangle.Side2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение стороны 3");
                    triangle.Side3 = Convert.ToInt32(Console.ReadLine());
                    triangle.isRightTriangle();
                    break;
            }
            Console.ReadLine();
         }
    }
}
