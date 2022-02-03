using System;

namespace Figures
{
    public class Circle : Figure
    {
        /// <summary>
        /// radius
        /// </summary>
        public double Radius { get; }

        public override bool IsValid => Radius > 0;

        /// <summary>
        /// diameter
        /// </summary>
        public double Diameter => IsValid ? 2 * Radius : throw new ParamException("Ошибка входных данных");

        /// <summary>
        /// circle
        /// </summary>
        /// <param name="radius">circle radius</param>
        public Circle(double radius) => this.Radius = radius;

        /// <summary>
        /// perimeter
        /// </summary>
        public override double Perimeter => IsValid ? Math.PI * Diameter : throw new ParamException("Ошибка входных данных");

        /// <summary>
        /// squre
        /// </summary>
        public override double Square => IsValid ? Math.PI * Radius * Radius : throw new ParamException("Ошибка входных данных");
    }
}
