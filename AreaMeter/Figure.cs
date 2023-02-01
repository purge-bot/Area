using System;
using System.Collections.Generic;
using System.Text;

namespace AreaMeter
{
    public abstract class Figure
    {
        public virtual double Area { get => Precision.HasValue ? Math.Round(AreaMath(), (int)Precision) : AreaMath(); }

        private int? _precision;
        public int? Precision
        {
            get { return _precision; }
            set
            {
                if (value < 0 || value > 15)
                    throw new ArgumentOutOfRangeException("Precision" ,"Rounding digits must be between 0 and 15");

                _precision = value;
                
            }
        }

        public Figure(int? precision) { Precision = precision; }

        protected abstract double AreaMath();
    }
}
