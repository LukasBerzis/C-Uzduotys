using System;
using System.Collections.Generic;
using System.Text;

namespace GeoFigures
{
    internal class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle()
        {
            Radius = 1;
        }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
