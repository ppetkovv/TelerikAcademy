using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] someStrings = { "sdfjksd", "asfjkaffsf", "andasjgfsafs", "adnsadsadhsadsa", "nfjabfhjsafhjaf", "asbfjsavfjsafjs", "nsfkdsfsdfsdf", "zzzsdkjffjsdfjsdhfjsdhfjkdsdb" };
            //First Way
            //Console.WriteLine(someStrings.Where(currentString => currentString.Length == someStrings.Max(str => str.Length)).First());
            //Second Way
            //Console.WriteLine(someStrings.OrderByDescending(currentString => currentString.Length).First());
        }
    }
}
