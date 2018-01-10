using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            Stack<int> someNums = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                someNums.Push(Int32.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(someNums.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}