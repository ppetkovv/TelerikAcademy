using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IStudent> someStudents = new List<IStudent>(new IStudent[] { new Student("Bat", "Spiro", 15, new List<decimal>() { 2, 6, 4, 4, 6 }, "223406"), new Student("Ivan", "Ivanov", 13, new List<decimal>() { 4, 5, 5, 5 }, "939385"), new Student("Petur", "Petrov", 17, new List<decimal>() { 5, 5, 5, 4 }, "989876"), new Student("Gosho", "Goshev", 19, new List<decimal>() { 5, 6, 6, 6 }, "645456"), new Student("Pesho", "Peshev", 25, new List<decimal>() { 3, 3, 4, 4 }, "543262"), new Student("Milen", "Savov", 23, new List<decimal>() { 5, 5, 4, 5 }, "334433"), new Student("Yordan", "Minev", 19, new List<decimal>() { 2, 3, 4, 4, 5 }, "444222"), new Student("Bat", "Kiro", 10, new List<decimal>() { 3, 6, 4, 4, 6 }, "123406"), new Student("Bat", "Miro", 13, new List<decimal>() { 4, 6, 4, 4, 6 }, "223406") });
            string[] anonymousCollection = someStudents.Where(currentStudent => currentStudent.FacultyNumber.Substring(4).Equals("06")).Select(currentStudent => currentStudent.GetMarksAsString).ToArray();
            foreach (var sortedStudent in anonymousCollection)
            {
                Console.WriteLine(sortedStudent);
            }
        }
    }
}