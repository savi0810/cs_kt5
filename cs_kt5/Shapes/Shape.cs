using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_kt5.Shapes
{
    internal abstract class Shape : IShape
    {
        public abstract double Area { get; }
        public abstract double Perimeter { get; }

        protected void ValidatePositiveValue(double value, string paramName)
        {
            if (value <= 0)
                throw new ArgumentException($"{paramName} должен быть > 0", paramName);
        }
    }
}
