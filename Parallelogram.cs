using System;

namespace GeometricFigures.Backend
{
    public class Parallelogram : Rectangle
    {
        private double _h;

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }

        protected static double ValidateH(double value)
        {
            if (value <= 0)
                throw new ArgumentException($"La altura H: {value}, no es válida.");
            return value;
        }

        public override double GetArea() => B * H;

        public override double GetPerimeter() => 2 * (A + B);
    }
}
