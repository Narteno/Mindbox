using System;

namespace Mindbox_task
{
    public class Circle
    {
        public double Radius { get; }
        public Circle(double R)
        {
            if (R < 0)
                throw new ArgumentOutOfRangeException("Ввод некорректен");
            Radius = R;
        }
        public double SquareOfCircle()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2),2);
        }

    }
}
