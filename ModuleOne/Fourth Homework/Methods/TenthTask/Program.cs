using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Program.CalculateFactoriel(N));
        }

        private static BigInteger CalculateFactoriel(int n)
        {
            BigInteger factoriel = 1;
            while(n > 1)
            {
                factoriel *= n;
                n--;
            }
            return factoriel;
        }
    }
}
