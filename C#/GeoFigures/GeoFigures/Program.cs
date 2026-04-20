using System;
using GeoFigures;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
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