using System;

namespace GeometricFigures.Backend
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public double R
        {
            get => _r;
            set => _r = ValidateR(value);
        }

        public Circle(string name, double r) : base(name)
        {
            R = r;
        }

        private static double ValidateR(double value)
        {
            if (value <= 0)
                throw new ArgumentException($"El radio: {value}, no es válido.");
            return value;
        }

        public override double GetArea() => Math.PI * R * R;

        public override double GetPerimeter() => 2 * Math.PI * R;
    }
}
