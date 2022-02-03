using NUnit.Framework;
using Figures;
using System;

namespace FigureTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCircle1()
        {
            double radius = 10;
            var square = Math.PI * radius * radius;
            var perimeter = 2 * Math.PI * radius;

            IFigure circle = new Circle(radius);
            Assert.AreEqual(circle.Square, square);
            Assert.AreEqual(circle.Perimeter, perimeter);
        }


        [Test]
        public void TestCircle2()
        {
            double radius = 0;

            IFigure circle = new Circle(radius);

            Assert.Throws<ParamException>(() => { var s = circle.Square; });
            Assert.Throws<ParamException>(() => { var p = circle.Perimeter; });
        }


        [Test]
        public void TestCircle3()
        {
            double radius = -10;

            IFigure circle = new Circle(radius);

            Assert.Throws<ParamException>(() => { var s = circle.Square; });
            Assert.Throws<ParamException>(() => { var p = circle.Perimeter; });
        }

        [Test]
        public void TestTriangle1()
        {
            double a = 4.0;
            double b = 2.0;
            double c = 3.0;

            var perimeter = a + b + c;
            var p = perimeter / 2;
            var square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            IFigure triangle = new Triangle(a, b, c);
            Assert.AreEqual(triangle.Square, square);
            Assert.AreEqual(triangle.Perimeter, perimeter);
            Assert.AreEqual((triangle as Triangle).IsRectangular, false);
        }

        [Test]
        public void TestTriangle2()
        { 
            double a = 5.0;
            double b = 4.0;
            double c = 3.0;

            IFigure triangle = new Triangle(a, b, c);

            Assert.AreEqual((triangle as Triangle).IsRectangular, true);
        }

        [Test]
        public void TestTriangle3()
        {
            double a = 1.0;
            double b = 2.0;
            double c = 6.0;

            var perimeter = a + b + c;
            var p = perimeter / 2;
            var square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            IFigure triangle = new Triangle(a, b, c);
            Assert.Throws<ParamException>(() => { var s = triangle.Square; });
            Assert.Throws<ParamException>(() => { var p = triangle.Perimeter; });
        }


        [Test]
        public void TestTriangle4()
        {
            double a = 5.0;
            double b = 2.0;
            double c = -4.0;

            var perimeter = a + b + c;
            var p = perimeter / 2;
            var square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            IFigure triangle = new Triangle(a, b, c);
            Assert.Throws<ParamException>(() => { var s = triangle.Square; });
            Assert.Throws<ParamException>(() => { var p = triangle.Perimeter; });
        }
    }
}