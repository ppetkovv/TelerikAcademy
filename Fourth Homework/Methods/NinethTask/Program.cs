using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinethTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            Array.Sort(array);
            Console.Write(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
        }
    }
}
