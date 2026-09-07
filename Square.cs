using System;

namespace GeometricFigures.Backend
{
    public class Square : GeometricFigure
    {
        private double _a;

        public double A
        {
            get => _a;
            set => _a = ValidateA(value);
        }

        public Square(string name, double a) : base(name)
        {
            A = a;
        }

        protected static double ValidateA(double value)
        {
            if (value <= 0)
                throw new ArgumentException($"El lado A: {value}, no es válido.");
            return value;
        }

        public override double GetArea() => A * A;

        public override double GetPerimeter() => 4 * A;
    }
}
