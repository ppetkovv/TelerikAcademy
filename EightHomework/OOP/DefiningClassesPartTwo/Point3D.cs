using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    public struct Point3D
    {
        private static readonly Point3D o = new Point3D(0, 0, 0);

        public Point3D(Double x, Double y, Double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Double X { get; set; }
        public Double Y { get; set; }
        public Double Z { get; set; }
        public static Point3D O { get { return o; } }
        public override string ToString()
        {
            return string.Format("Point X: {0:F2}\nPoint Y: {1:F2}\nPoint Z: {2:F2}\n", this.X, this.Y, this.Z);
        }
    }
}