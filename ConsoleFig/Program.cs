using System;
using Figures;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure figure = new Circle(50.0);
            IFigure figure2 = new Triangle(10.0, 4.0, 2.0);
            Figure figure3 = new Triangle(10.0, 4.0, 2.0);

            Console.WriteLine(figure.Square);
            Console.WriteLine(figure.Perimeter);
            Console.WriteLine(figure2.Square);
            Console.WriteLine(figure2.Perimeter);
            Console.WriteLine(figure3.Square);
            Console.WriteLine(figure3.Perimeter);

        }
    }
}
