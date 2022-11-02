using System;

namespace MindBoxTestsAndSQL
{
    public class Triangle : IFigure
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double PoluPerimetr { get; set; }
        public double TrianSq { get; set; }
        public double Plosh { get; set; }

        public double Area()
        {
            if(Side1 < 0 || Side2 < 0 || Side3 < 0)
            {
                throw new ArgumentException("Неверный формат данных");
            }
            else
            {
            PoluPerimetr = (Side1 + Side2 + Side3) / 2;
                TrianSq = Math.Sqrt(PoluPerimetr * (PoluPerimetr - Side1) * (PoluPerimetr - Side2) * (PoluPerimetr - Side3));
            }
            return TrianSq;
        }
        public double Ploshad()
        {
            Plosh = 0.5 * Side1 * Side2;
            return Plosh;
        }
        public bool isRightTriangle()
        {
            if (Math.Pow(Side3, 2) == Math.Pow(Side2, 2) + Math.Pow(Side1, 2))
            {
                Console.WriteLine("У вас прямоугольный треугольник");
                Console.WriteLine($"Площадь прямоугольного треугольника равна {Ploshad()}");
            }
            else
            {
                Console.WriteLine($"Площадь треугольника равна {Area()}");
            }
            return true;
        }
    }
}
