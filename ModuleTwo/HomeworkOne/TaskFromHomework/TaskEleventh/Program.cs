using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEleventh
{
    class Program
    {
        static void Main(string[] args)
        {
            ListItem<int> first = new ListItem<int>(5);
            ListItem<int> second = new ListItem<int>(6);
            ListItem<int> third = new ListItem<int>(7);
            ListItem<int> fourth = new ListItem<int>(8);

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(first);
            linkedList.AddLast(fourth);
            linkedList.AddAfter(first, second);
            linkedList.AddBefore(fourth, third);
            linkedList.AddAfter(first,4);
            linkedList.AddBefore(first, third);

            linkedList.Print();
        }
    }
}
