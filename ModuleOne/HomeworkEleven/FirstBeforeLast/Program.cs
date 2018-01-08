using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBeforeLast
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IStudent> someStudents = new List<IStudent>(new IStudent[] { new Student("Ivan", "Ivanov"), new Student("Petur", "Petrov"), new Student("Gosho", "Goshev"), new Student("Pesho", "Peshev"), new Student("Milen", "Savov"), new Student("Yordan", "Minev"), new Student("Bat", "Kiro") });
            foreach (IStudent sortedStudent in someStudents.Where(currentStudent=>currentStudent.FirstName.CompareTo(currentStudent.LastName) < 0).ToArray())
            {
                Console.WriteLine((Student)sortedStudent);
            }
        }
    }
}
