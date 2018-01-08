using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Groups
{
    class Program
    {
        static void Main(string[] args)
        {
            Group[] someGroups = new Group[] { new Group(1, "Mathematics"), new Group(2, "Biology"), new Group(3, "Chemistry") };

            IList<IStudent> someStudents = new List<IStudent>(new IStudent[] { new Student("Bat", "Spiro", 15, new List<decimal>() { 2, 6, 4, 4, 6 }, "223406", 1), new Student("Ivan", "Ivanov", 13, new List<decimal>() { 4, 5, 5, 5 }, "939385", 2), new Student("Petur", "Petrov", 17, new List<decimal>() { 5, 5, 5, 4 }, "989876", 1), new Student("Gosho", "Goshev", 19, new List<decimal>() { 5, 6, 6, 6 }, "645456", 1), new Student("Pesho", "Peshev", 25, new List<decimal>() { 3, 3, 4, 4 }, "543262", 2), new Student("Milen", "Savov", 23, new List<decimal>() { 5, 5, 4, 5 }, "334433", 3), new Student("Yordan", "Minev", 19, new List<decimal>() { 2, 3, 4, 4, 5 }, "444222", 3), new Student("Bat", "Kiro", 10, new List<decimal>() { 3, 6, 4, 4, 6 }, "123406", 2), new Student("Bat", "Miro", 13, new List<decimal>() { 4, 6, 4, 4, 6 }, "223406", 1) });
            int mathematicsGroupNumber = someGroups.Where(currentGroup => currentGroup.DepartmentName == "Mathematics").First().GroupNumber;
            IStudent[] allStudentsFromMathematicsDepartment = someStudents.Where(currentStudent => currentStudent.GroupNumber == mathematicsGroupNumber).ToArray();
            Console.WriteLine(string.Join(", ", allStudentsFromMathematicsDepartment.Select(currentStudent => currentStudent.ToString())));
        }
    }
}