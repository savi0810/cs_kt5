using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_kt5.Shapes
{
    internal class Triangle : Shape
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private readonly IValidateTriangle validator;

        public Triangle(double sideA, double sideB, double sideC, IValidateTriangle validator = null)
        {
            ValidatePositiveValue(sideA, nameof(sideA));
            ValidatePositiveValue(sideB, nameof(sideB));
            ValidatePositiveValue(sideC, nameof(sideC));

            this.validator = validator ?? new ValidateTriangle();

            if (!this.validator.IsValidTriangle(sideA, sideB, sideC))
                throw new ArgumentException("Не существует треугольника с такими сторонами");

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public override double Area
        {
            get
            {
                double halfPerimeter = this.Perimeter / 2;
                return Math.Sqrt(halfPerimeter * (halfPerimeter - this.sideA) *
                                (halfPerimeter - this.sideB) * (halfPerimeter - this.sideC));
            }
        }

        public override double Perimeter => this.sideA + this.sideB + this.sideC;

        public override string ToString()
        {
            return $"\nТреугольник\nсторона а: {sideA}, сторона б: {sideB}, сторона с: {sideC}, площадь: {Area}, периметр: {Perimeter}";
        }
    }
}
