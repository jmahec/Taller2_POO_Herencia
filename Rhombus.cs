using System;

namespace GeometricFigures.Backend
{
    public class Rhombus : Square
    {
        private double _d1;
        private double _d2;

        public double D1
        {
            get => _d1;
            set => _d1 = ValidateD1(value);
        }

        public double D2
        {
            get => _d2;
            set => _d2 = ValidateD2(value);
        }

        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = d1;
            D2 = d2;
        }

        protected static double ValidateD1(double value)
        {
            if (value <= 0)
                throw new ArgumentException($"La diagonal D1: {value}, no es válida.");
            return value;
        }

        protected static double ValidateD2(double value)
        {
            if (value <= 0)
                throw new ArgumentException($"La diagonal D2: {value}, no es válida.");
            return value;
        }

        public override double GetArea() => (D1 * D2) / 2;

        public override double GetPerimeter() => 4 * A;
    }
}
