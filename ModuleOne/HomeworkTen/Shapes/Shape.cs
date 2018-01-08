using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Contracts;

namespace Shapes
{
    public abstract class Shape : IShape
    {
        private double width;
        private double height;

        protected Shape(double height)
        {
            this.Height = height;
        }

        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get => this.width; set { if (value < 0) { throw new ArgumentOutOfRangeException(); } this.width = value; } }
        public double Height { get => this.height; set { if (value < 0) { throw new ArgumentOutOfRangeException(); } this.height = value; } }

        public abstract double CalculateSurface();
    }
}