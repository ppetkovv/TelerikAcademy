using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractStudentsByMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IStudent> someStudents = new List<IStudent>(new IStudent[] { new Student("Ivan", "Ivanov", 13, new List<decimal>() { 4, 5, 5, 5 }), new Student("Petur", "Petrov", 17, new List<decimal>() { 5, 5, 5, 4 }), new Student("Gosho", "Goshev", 19, new List<decimal>() { 5, 6, 6, 6 }), new Student("Pesho", "Peshev", 25, new List<decimal>() { 3, 3, 4, 4 }), new Student("Milen", "Savov", 23, new List<decimal>() { 5, 5, 4, 5 }), new Student("Yordan", "Minev", 19, new List<decimal>() { 2, 3, 4, 4, 5 }), new Student("Bat", "Kiro", 10, new List<decimal>() { 5, 6, 4, 4, 6 }) });
            var anonymousCollection = someStudents.Where(currentStudent => currentStudent.Marks.Any(currentMark => currentMark == 6)).Select(currentStudent => new { currentStudent.FullName, currentStudent.GetMarksAsString });
            foreach (var sortedStudent in anonymousCollection)
            {
                Console.WriteLine(sortedStudent);
            }
        }
    }
}