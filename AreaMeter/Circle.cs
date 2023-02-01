using System;

namespace AreaMeter
{
    public class Circle : Figure
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("Radius couldn't be less then 0");

                _radius = value; 
            }
        }

        public Circle(double radius, int? precision = null) : base(precision)
        {
            Radius = radius;
        }

        protected override double AreaMath()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
