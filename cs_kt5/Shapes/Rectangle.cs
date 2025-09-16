using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_kt5.Shapes
{
    internal class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            ValidatePositiveValue(width, nameof(width));
            ValidatePositiveValue(height, nameof(height));
            this.width = width;
            this.height = height;
        }

        public override double Area => this.width * this.height;
        public override double Perimeter => 2 * (this.width + this.height);

        public override string ToString()
        {
            return $"\nПрямоугольник\nширина: {width}, высота: {height}, площадь: {Area}, периметр: {Perimeter}";
        }
    }
}
