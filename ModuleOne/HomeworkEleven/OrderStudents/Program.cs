using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IStudent> someStudents = new List<IStudent>(new IStudent[] { new Student("Ivan", "Ivanof", 13), new Student("Ivan", "Ivanov", 13), new Student("Petur", "Petrov", 17), new Student("Gosho", "Goshev", 19), new Student("Pesho", "Peshev", 25), new Student("Milen", "Savov", 23), new Student("Yordan", "Minev", 19), new Student("Bat", "Kiro", 10) });
            foreach (IStudent sortedStudent in someStudents.OrderByDescending(currentStudent => currentStudent.FirstName).ThenByDescending(currentStudent => currentStudent.LastName).ToArray())
            {
                Console.WriteLine((Student)sortedStudent);
            }
        }
    }
}