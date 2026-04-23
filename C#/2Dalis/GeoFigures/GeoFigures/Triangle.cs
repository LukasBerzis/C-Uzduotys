using System;
using System.Collections.Generic;
using System.Text;

namespace GeoFigures
{
    internal class Triangle : Shape
    {
            public int Base { get; set; }
            public int Height { get; set; }

        public Triangle() : this(0, 0)
        {
            Base = 1;
            Height = 1;
        }

        public Triangle(int triangleBase, int triangleHeight)
        {
            Base = triangleBase;
            Height = triangleHeight;
        }

        public override double GetArea()
        {
            return (Base * Height) / 2.0;
        }

        public override double GetPerimeter()
        {
            double izambine = Math.Sqrt(Base * Base + Height * Height);
            return Base + Height + izambine;
        }
    }
}
