using System;
using System.Linq;
using System.Collections.Generic;

namespace Mindbox_task
{
    public class Triangle
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public Triangle (double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentOutOfRangeException("Ввод некорректен");
            A = a;B = b;C = c;
        }

        public double TriangleSquare()
        {
            double p = (A + B + C) / 2;
            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)),2);
        }
        public bool IsRightTriangle()
        {
            List<double> list = new List<double> { A, B, C };
            double max = list.Max();
            list.RemoveAt(list.IndexOf(list.Max()));
            return Math.Pow(max,2) == Math.Pow(list[0],2) + Math.Pow(list[1],2);
        }

    }
}
