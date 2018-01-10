using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> someNums = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            List<int> distinct = someNums.Distinct().ToList();

            for (int i = 0; i < distinct.Count; i++)
            {
                if (someNums.Where(x => x == distinct[i]).Count() > someNums.Count / 2)
                {
                    Console.WriteLine(distinct[i]);
                    break;
                }
            }
        }
    }
}
