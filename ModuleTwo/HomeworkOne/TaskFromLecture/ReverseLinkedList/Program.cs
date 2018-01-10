using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            ListNode second = new ListNode(2);
            ListNode third = new ListNode(3);
            ListNode fourth = new ListNode(4);

            head.Next = second;
            second.Next = third;
            third.Next = fourth;

            ListNode previous = null;
            ListNode current = head;
            ListNode next;

            while (current.Next != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }
            current.Next = previous;

            while (current != null)
            {
                Console.Write(current.Value+" ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

    class ListNode
    {
        private int value;
        private ListNode next;

        public ListNode(int value)
        {
            this.Value = value;
        }

        public int Value { get => this.value; set => this.value = value; }
        public ListNode Next { get => this.next; set => this.next = value; }
    }
}