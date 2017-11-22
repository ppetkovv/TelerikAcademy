using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntranceExamMyGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Task

            int year = Int32.Parse(Console.ReadLine());
            int month = Int32.Parse(Console.ReadLine());
            int day = Int32.Parse(Console.ReadLine());

            DateTime currentDate = new DateTime(year, month, day);
            currentDate.AddDays(-1);
            Console.WriteLine("d-MMM-yyyy", currentDate);
        }
    }
}
