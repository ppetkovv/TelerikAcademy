using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class DynamicList
    {
        private class ListNode : IListNode
        {
            private int value;
            private IListNode next;

            public ListNode(int value)
            {
                this.value = value;
            }

            public ListNode(int value, ListNode next)
            {
                this.Value = value;
                this.Next = next;
            }

            public int Value { get => this.value; set => this.value = value; }
            public IListNode Next { get => this.next; set => this.next = value; }
        }
        private IListNode head;
        private IListNode tail;
        private int currentIndex;

        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.currentIndex = 0;
        }

        public void AddFront(int value)
        {
            ListNode newNode = new ListNode(value);
            if (head == null)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
            this.currentIndex++;
        }

        public void AddLast(int value)
        {
            ListNode newNode = new ListNode(value);
            if (head == null)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                this.tail.Next = newNode;
                this.tail = newNode;
            }
            this.currentIndex++;
        }

        public void AddBefore(IListNode node, int item)
        {
            if (node == null)
                throw new ArgumentNullException("Cannot have node with value null!");
            IListNode currentNode = this.head;
            if (node == currentNode)
            {
                this.AddFront(item);
            }
            else
            {
                IListNode newNode = new ListNode(item);
                while (currentNode.Next != node)
                {
                    currentNode = currentNode.Next;
                }
                //First Way
                //newNode.Next = currentNode.Next;
                //currentNode.Next = newNode;
                //Second Way
                this.AddAfter(currentNode, item);
            }
            this.currentIndex++;
        }

        public void AddAfter(IListNode node, int item)
        {
            if (node == null)
                throw new ArgumentNullException("Cannot have node with value null!");
            IListNode nodeNext = node.Next;
            if (nodeNext == null)
            {
                ListNode newNode = new ListNode(item);
                this.tail.Next = newNode;
                this.tail = newNode;
            }
            else
            {
                ListNode newNode = new ListNode(item);
                node.Next = newNode;
                newNode.Next = nodeNext;
            }
            this.currentIndex++;
        }

        public IListNode this[int index]
        {
            get
            {
                if (index >= currentIndex || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                          "Invalid index: " + index);
                }

                IListNode currentNode = this.head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                return currentNode;
            }

            set
            {
                if (index >= currentIndex || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                          "Invalid index: " + index);
                }

                IListNode currentNode = this.head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                currentNode = value;
            }
        }

        public void Remove(IListNode nodeForRemoving)
        {
            if (nodeForRemoving == null)
            {
                throw new ArgumentNullException();
            }

            IListNode currentNode = this.head;
            if (nodeForRemoving == currentNode)
            {
                this.head = currentNode.Next;
            }
            else if (nodeForRemoving == this.tail)
            {
                while (currentNode.Next != this.tail)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = null;
                this.tail = currentNode;
            }
            else
            {
                while (currentNode != null && currentNode.Next != nodeForRemoving)
                {
                    currentNode = currentNode.Next;
                }
                IListNode nodeForDel = currentNode.Next;
                currentNode.Next = nodeForDel.Next;
            }
        }

        public void Print()
        {
            IListNode currentNode = head;
            while (currentNode != null)
            {
                Console.Write(currentNode.Value + " ");
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }
    }
}