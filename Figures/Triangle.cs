using System;

namespace Figures
{
    public class Triangle : Figure
    {
        private readonly double RECTENGULAR_ANGLE = Math.PI / 2;

        /// <summary>
        /// side a
        /// </summary>
        public double A { get; }

        /// <summary>
        /// side b
        /// </summary>
        public double B { get; }

        /// <summary>
        /// side c
        /// </summary>
        public double C { get; }

        /// <summary>
        /// is valid triangle
        /// </summary>
        public override bool IsValid => (A > 0) && (B > 0) && (C > 0) && (A + B >= C) && (B + C >= A) && (A + C >= B);

        /// <summary>
        /// is rectengular triangle
        /// </summary>
        public bool IsRectangular => AB == RECTENGULAR_ANGLE || BC == RECTENGULAR_ANGLE || AC == RECTENGULAR_ANGLE;

        /// <summary>
        /// angle between a and b
        /// </summary>
        public double AB => GetAngle(A, B, C);

        /// <summary>
        /// angle between b and c
        /// </summary>
        public double BC => GetAngle(C, B, A);

        /// <summary>
        /// angle between a and c
        /// </summary>
        public double AC => GetAngle(A, C, B);

        /// <summary>
        /// triangle by thee sides
        /// </summary>
        /// <param name="a">side a lenght</param>
        /// <param name="b">side b lenght</param>
        /// <param name="c">side c lenght</param>
        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        /// <summary>
        /// sqare
        /// </summary>
        public override double Square
        {
            get
            {
                if (IsValid)
                {
                    double p = Perimeter / 2;
                    return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
                }
                else
                {
                    throw new ParamException("Ошибка входных данных");
                }
            }
        }

        /// <summary>
        /// perimeter
        /// </summary>
        public override double Perimeter => IsValid ? A + B + C : throw new ParamException("Ошибка входных данных");

        private double GetAngle(double contiguousSide1, double contiguousSide2, double oppositside)
            => IsValid
                ? Math.Acos(((contiguousSide1 * contiguousSide1) + (contiguousSide2 * contiguousSide2) - (oppositside * oppositside)) / (2 * contiguousSide1 * contiguousSide2))
                : double.NaN;
    }
}
