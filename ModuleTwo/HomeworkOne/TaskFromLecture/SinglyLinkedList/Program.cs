using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicList singlyLinkedList = new DynamicList();
            singlyLinkedList.AddFront(1);
            singlyLinkedList.AddLast(4);
            singlyLinkedList.AddAfter(singlyLinkedList[0], 2);
            singlyLinkedList.AddBefore(singlyLinkedList[2], 3);
            singlyLinkedList.Print();
            //Remove first element
            //singlyLinkedList.Remove(singlyLinkedList[0]);
            //singlyLinkedList.Print();
            //Remove second element
            //singlyLinkedList.Remove(singlyLinkedList[1]);
            //singlyLinkedList.Print();
            //Remove third element
            //singlyLinkedList.Remove(singlyLinkedList[2]);
            //singlyLinkedList.Print();
            //Remove fourth element
            //singlyLinkedList.Remove(singlyLinkedList[3]);
            //singlyLinkedList.Print();
        }
    }
}