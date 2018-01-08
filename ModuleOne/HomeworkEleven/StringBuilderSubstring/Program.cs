using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("I am twenty years old!");
            Console.WriteLine(str.Substring(5, 16));
        }
    }
}
