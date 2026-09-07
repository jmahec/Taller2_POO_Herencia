using System;

namespace GeometricFigures.Backend
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;

        public double C
        {
            get => _c;
            set => _c = ValidateC(value);
        }

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            C = c;
            H = h;
        }

        protected static double ValidateC(double value)
        {
            if (value <= 0)
                throw new ArgumentException($"El lado C: {value}, no es válido.");
            return value;
        }

        protected static double ValidateH(double value)
        {
            if (value <= 0)
                throw new ArgumentException($"La altura H: {value}, no es válida.");
            return value;
        }

        public override double GetArea() => (B * H) / 2;

        public override double GetPerimeter() => A + B + C;
    }
}
