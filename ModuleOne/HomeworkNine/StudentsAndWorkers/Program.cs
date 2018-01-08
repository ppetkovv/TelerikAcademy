using StudentsAndWorkers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Subtask

            ICollection<IStudent> students = new List<IStudent>(new Student[] { new Student("Petko","Petkov",5.00), new Student("Dobri", "Vurbanov", 5.25), new Student("Stefan","Jekov", 5.00)
            ,new Student("Angel","Novoselski",5.30), new Student("Kiril", "Kirilov", 4.75), new Student("Tung","Do",5.10), new Student("Sofia","Kiryakova",5.15)
            ,new Student("Alek", "Hristov", 5.05), new Student("Aleksandra","Petrova",5.40), new Student("Aleksandur","Markov",4.85),new Student("Nikolay","Nikolov", 4.90)});

            ICollection<IStudent> sortedStudents = students.OrderBy(student => student.Grade).ToArray();
            foreach (IStudent student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            //Second Subtask

            ICollection<IWorker> workers = new List<IWorker>(new Worker[] { new Worker("Dimitur","Stoinov",150,8), new Worker("Ivaylo","Patarinski",200,7), new Worker("Kalin","Gerganov",300,12)
            ,new Worker("Hristo","Petrov",150,10), new Worker("Vasil","Vasilev",300,12), new Worker("Stoyan","Kitanov",500,6), new Worker("Martin", "Patarinski", 400, 15), new Worker("Strahil","Miroslavov",200,3)
            ,new Worker("Milen","Hristov",200,3), new Worker("Nikola","Petkov",1000,12)});

            ICollection<IWorker> sortedWorkers = workers.OrderBy(worker => worker.MoneyPerHour()).ToArray();

            foreach (IWorker worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }

            //Third Subtask

            List<IHuman> studentsAndWorkers = new List<IHuman>();
            studentsAndWorkers.AddRange(sortedStudents);
            studentsAndWorkers.AddRange(sortedWorkers);

            ICollection<IHuman> sortedStudentsAndWorkers =
                studentsAndWorkers.OrderBy(human => human.FirstName).ThenBy(human => human.LastName)
                .ToArray();

            foreach (IHuman human in sortedStudentsAndWorkers)
            {
                Console.WriteLine(human);
            }
        }
    }
}