using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    [Version(Versions = "2.11")]
    public class Path
    { 
        private List<Point3D> somePoints;

        public Path(){ somePoints = new List<Point3D>(); }

        public Path(List<Point3D> somePoints):this()
        {
            this.somePoints = somePoints;
        }

        public List<Point3D> SomePoints { get { return this.somePoints; } }

        public void AddPoint(Point3D currentPoint)
        {
            somePoints.Add(currentPoint);
        }

        public override string ToString()
        {
            StringBuilder finalResult = new StringBuilder();
            foreach (Point3D currentPoint in this.SomePoints)
            {
                finalResult.Append(currentPoint.ToString());
            }
            finalResult.Append("\n");
            return finalResult.ToString();
        }
    }
}