using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //PathStorage.Paths = PathStorage.LoadPathsFromFile("C:\\users\\petko\\Desktop\\Paths.txt");
            //PathStorage.SavePathsToFile("C:\\users\\petko\\Desktop\\SecondPaths.txt");
            //List<string> someStrings = new List<string>();

            //Matrix<int> firstMatrix = new Matrix<int>(4,5);
            //Matrix<int> secondMatrix = new Matrix<int>(4,5);
            //firstMatrix[0, 0] = 40;
            //secondMatrix[0, 0] = 10;
            //int[,] resultedMatrix = firstMatrix * secondMatrix;
            //Console.WriteLine(resultedMatrix[0, 0]);

            //Assembly currentAssembly = Assembly.GetExecutingAssembly();
            //Console.WriteLine(currentAssembly.FullName);
            //var types = currentAssembly.GetTypes();
            //foreach (Type currentType in types)
            //{
            //    Console.WriteLine("Type: " + currentType.FullName);
            //    var typeFields = currentType.GetFields();
            //    foreach (var field in typeFields)
            //    {
            //        Console.WriteLine("\tField: " + field.Name + "; Field type: " + field.GetType());
            //    }
            //    var typeProperties = currentType.GetProperties();
            //    foreach (var property in typeProperties)
            //    {
            //        Console.WriteLine("\tProperty: " + property.Name + "; Property type: " + property.PropertyType);
            //    }
            //    var typeMethods = currentType.GetMethods();
            //    foreach (var method in typeMethods)
            //    {
            //        Console.WriteLine("\tMethod: " + method.Name + "; Method type: " + method.GetType());
            //    }
            //}

            Assembly currentlyExecutingAssembly = Assembly.GetExecutingAssembly();
            var attributedTypes = currentlyExecutingAssembly.GetTypes().Where(currentType => currentType.GetCustomAttributes<Version>().Count() > 0);
            foreach (var item in attributedTypes)
            {
                Console.WriteLine(item.GetCustomAttribute<Version>().Versions);
            }
        }
    }
}