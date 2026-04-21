using System;
using System.Collections.Generic;
using System.Text;

namespace GeoFigures
{
    internal class ShapeHelper
    {
        public static double CalculateArea(List<Shape> shapes)
        {
            double totalArea = 0;

            foreach (Shape shape in shapes)
            {
                totalArea += shape.GetArea();
            }

            return totalArea;
        }

        public static double CalculatePerimeter(List<Shape> shapes)
        {
            double totalPerimeter = 0;

            foreach (Shape shape in shapes)
            {
                totalPerimeter += shape.GetPerimeter();
            }

            return totalPerimeter;
        }
    }
}
