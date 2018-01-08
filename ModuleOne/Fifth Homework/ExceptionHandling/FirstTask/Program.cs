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
            try
            {
                double number = Double.Parse(Console.ReadLine());
                if(number < 0)
                {
                    throw new FormatException();
                }
                Console.WriteLine("{0:F3}", Math.Sqrt(number));

            } catch (FormatException ex)
            {
                ex = new FormatException("Invalid number");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
