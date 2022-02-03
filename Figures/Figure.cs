using System;

namespace Figures
{
    public class Figure : IFigure
    {
        /// <summary>
        /// perimeter
        /// </summary>
        public virtual double Perimeter => throw new NotImplementedException();

        /// <summary>
        /// square
        /// </summary>
        public virtual double Square => throw new NotImplementedException();

        /// <summary>
        /// is valid figure
        /// </summary>
        public virtual bool IsValid => throw new NotImplementedException();
    }
}
