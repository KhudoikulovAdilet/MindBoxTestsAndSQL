using System;

namespace MindBoxTestsAndSQL.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }
        public double CircleArea { get; set; }
        public double Area()
        {
            if(Radius < 0)
            {
                throw new ArgumentException("Неправильный ввод данных", nameof(Radius));
            }
            else
            {
                CircleArea = Math.PI * Math.Pow(Radius, 2);
                return CircleArea;
            }
        }
        
    }
}
