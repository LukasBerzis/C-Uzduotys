using System;
using GeoFigures;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Rectangle(5, 10),
                new Circle(3),
                new Triangle(3, 4),
                new Rectangle(2, 6),
                new Circle(7)
            };

            foreach (var shape in shapes)
            {
                //F2 dviem skaiciaus po kablelio
                Console.WriteLine($"Area: {shape.GetArea():F2}, Perimeter: {shape.GetPerimeter():F2}");
            }

            double totalArea = ShapeHelper.CalculateArea(shapes );
            double totalPerimeter = ShapeHelper.CalculatePerimeter(shapes);

            Console.WriteLine($"total area: {totalArea:F2}");
            Console.WriteLine($"total perimeter: {totalPerimeter:F2}");

            Circle circle1 = new Circle();
            circle1.Radius = 5;

            Circle circle2 = new Circle();
            circle1.Radius = 10;

            Circle circle3 = new Circle();
            circle1.Radius = 20;

            Circle circle4 = new Circle();
            circle1.Radius = 50;

            Circle circle5 = new Circle();
            circle1.Radius = 100;

            Circle circle6 = new Circle{ Radius = 5};

            Circle circle7 = new Circle { Radius = 90 }; ;

            Circle circle8 = new Circle { Radius = 30 }; ;

            Circle circle9 = new Circle { Radius = 70 }; ;

            Triangle triangle1 = new Triangle
            {
                Base = 10,
                Height = 6
            };

            Triangle triangle2 = new Triangle
            {
                Base = 5,
                Height = 3
            };

            Triangle triangle3 = new Triangle
            {
                Base = 20,
                Height = 12
            };

            Triangle triangle4 = new Triangle
            {
                Base = 40,
                Height = 24
            };

            Triangle triangle5 = new Triangle
            {
                Base = 60,
                Height = 48
            };

            Rectangle rectangle1 = new Rectangle();
            rectangle1.Width = 10;
            rectangle1.Height = 5;


            //rectangle1.Width = -3;

              
        }
    }
}