using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        public Square(double height) : base(height)
        {
            this.Width = this.Height;
        }

        public override double CalculateSurface()
        {
            return this.Height * this.Height;
        }
    }
}