using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    public static class PathStorage
    {
        private static List<Path> paths;

        public static List<Path> Paths
        {
            get { return paths; }
            set { paths = value; }
        }

        public static List<Path> LoadPathsFromFile(string fileDestination)
        {
            List<Path> allPathsFromFile = new List<Path>();
            using (StreamReader currentStreamReader = new StreamReader(fileDestination))
            {
                Path currentPath;
                string[] currentLine3DPoints;
                double[] currentPointValues;

                while (currentStreamReader.Peek() >= 0)
                {
                    currentPath = new Path();
                    currentLine3DPoints = currentStreamReader.ReadLine().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    for (int i = 0; i < currentLine3DPoints.Length; i++)
                    {
                        currentPointValues = currentLine3DPoints[i].Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries).Select(Double.Parse).ToArray();
                        currentPath.AddPoint(new Point3D(currentPointValues[0], currentPointValues[1], currentPointValues[2]));
                    }
                    allPathsFromFile.Add(currentPath);
                }
            }
            return allPathsFromFile;
        }

        public static void SavePathsToFile(string fileDestination)
        {
            List<string> wholefileData = new List<string>();
            StringBuilder currentLineFileData = new StringBuilder();
            Path currentPath;
            List<Point3D> currentPathPoints;
            Point3D currentPoint;
            for (int i = 0; i < paths.Count; i++)
            {
                currentPath = paths[i];
                currentPathPoints = currentPath.SomePoints;
                for (int j = 0; j < currentPathPoints.Count; j++)
                {
                    currentPoint = currentPathPoints[j];
                    currentLineFileData.Append(currentPoint.X).Append(", ");
                    currentLineFileData.Append(currentPoint.Y).Append(", ");
                    currentLineFileData.Append(currentPoint.Z).Append(";");
                }
                wholefileData.Add(currentLineFileData.ToString());
                currentLineFileData.Clear();
            }
            using (StreamWriter currentStreamWriter = new StreamWriter(fileDestination))
            {
                for (int i = 0; i < wholefileData.Count; i++)
                {
                    currentStreamWriter.WriteLine(wholefileData[i]);
                }
            }
        }
    }
}