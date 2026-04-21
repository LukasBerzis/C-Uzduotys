using System;
using System.Collections.Generic;
using System.Text;

namespace GeoFigures
{
    internal abstract class Shape
    {
        public virtual double GetArea()
        {
            return 0;
        }
        public virtual double GetPerimeter()
        {
            return 0;
        }
    }
}
