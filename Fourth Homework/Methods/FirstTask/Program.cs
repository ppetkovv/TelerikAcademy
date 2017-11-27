using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Program.SayHello(name);
        }

        private static void SayHello(string name)
        {
            Console.WriteLine(string.Format("Hello, {0}!", name));
        }
    }
}
