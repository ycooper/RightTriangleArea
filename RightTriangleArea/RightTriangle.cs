using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightTriangleArea
{
    public class RightTriangle
    {
        private double a;
        private double b;
        private double c;

        public const string NegativeSideErrorMessage = "Sides cannot be negative";
        public const string PythagoreanErrorMessage = "Triangle is not right";

        private RightTriangle()
        {

        }

        public RightTriangle(double side1, double side2, double side3)
        {
            double[] sides = { side1, side2, side3 };
            if (side1 < 0 || side2 < 0 || side3 < 0)
            {
                throw new ArgumentException(NegativeSideErrorMessage);
            }
            Array.Sort(sides);
            if (sides[2]*sides[2]!=(sides[0]*sides[0]+sides[1]*sides[1]))//теорема Пифагора
            {
                throw new ArgumentException(PythagoreanErrorMessage);
            }
            a = sides[0];
            b = sides[1];
            c = sides[2];
        }

        public double Area()
        {
            double sp = (a + b + c) / 2;//полупериметр
            return (sp - a) * (sp - b);//Формула Герона
        }
    }
}
