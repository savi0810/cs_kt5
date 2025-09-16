using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_kt5.Shapes
{
    internal class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            ValidatePositiveValue(radius, nameof(radius));
            this.radius = radius;
        }

        public override double Area => Math.PI * this.radius * this.radius;
        public override double Perimeter => 2 * Math.PI * this.radius;

        public override string ToString()
        {
            return $"\nКруг\nрадиус: {radius}, площадь: {Area}, периметр: {Perimeter}";
        }
    }
}
