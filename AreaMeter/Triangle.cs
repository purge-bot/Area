using System;
using System.Collections.Generic;
using System.Text;

namespace AreaMeter
{
    public class Triangle : Figure
    {
        public bool IsRightTriangle { get => RightTriangleCheck(); }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c, int? presicion = null) : base(presicion)
        {
            if (!CheckExistence(a, b, c))
                throw new ArgumentException("Invalid triangle");

            A = a;
            B = b;
            C = c;
        }

        protected override double AreaMath()
        {
            if (!CheckExistence(A, B, C))
                throw new ArgumentException("Invalid triangle");

            // Calculate Semiperimeter
            double p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        private bool CheckExistence(double a, double b, double c)
        {
            bool paramsIsSpecified = (a > 0) && (b > 0) && (c > 0);
            bool hasValidSides = (a + b > c) && (a + c > b) && (b + c > a);

            return paramsIsSpecified && hasValidSides;
        }

        private bool RightTriangleCheck()
        {
            if (!CheckExistence(A, B, C))
                throw new ArgumentException("Invalid triangle");

            List<double> powSides = new List<double>
            {
                Math.Pow(A, 2),
                Math.Pow(B, 2),
                Math.Pow(C, 2)
            };

            powSides.Sort();

            return (powSides[0] + powSides[1] == powSides[2]);
        }
    }
}
