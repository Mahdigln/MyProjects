using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8.Features
{
    public struct Rectangle
    {
        public double Width { get; set; }

        private double _height;

        public double Height
        {
            readonly get { return _height; }
            set { _height = value; }
        }

        // we can't set value 
        public readonly double Area()
        {
            return Width * Height;
        }
    }
}
