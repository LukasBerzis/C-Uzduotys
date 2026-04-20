using System;
using System.Collections.Generic;
using System.Text;

namespace GeoFigures
{
    internal class Rectangle
    {
        private int width;
        private int height;

        public int Width
        {
            get { return width; }
            set
            {
                if (value <=0)
                {
                    throw new ArgumentException("Width must be positive");
                }
                width = value;
            }

        }

        public int Height
        {
            get { return height; }
            set
            {
                if (value <=0)
                {
                    throw new ArgumentException("Height mus be positive");
                }
                height = value;
            }
        }

        public Rectangle() : this(1, 1)
        {
            Width = 1;
            Height = 1;
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return width * height;
        }

        public double GetPerimeter()
        {
            return 2 * (width + height);
        }
    }
}
