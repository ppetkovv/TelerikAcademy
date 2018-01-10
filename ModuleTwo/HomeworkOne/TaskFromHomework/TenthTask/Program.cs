using System;
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
            Node N = new Node(Int32.Parse(Console.ReadLine()));
            Node M = new Node(Int32.Parse(Console.ReadLine()));

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(N);
            Node currentElement = queue.Dequeue();
            while (currentElement.Value != M.Value)
            {
                Node firstChild = new Node(currentElement.Value + 1, currentElement);
                Node secondChild = new Node(currentElement.Value + 2, currentElement);
                Node thirdChild = new Node(currentElement.Value * 2, currentElement);
                queue.Enqueue(firstChild);
                queue.Enqueue(secondChild);
                queue.Enqueue(thirdChild);

                currentElement = queue.Dequeue();
            }

            Stack<int> finalSequence = new Stack<int>();

            while (currentElement.Value != N.Value)
            {
                finalSequence.Push(currentElement.Value);
                currentElement = currentElement.Previous;
            }
            finalSequence.Push(currentElement.Value);

            while(finalSequence.Count != 0)
            {
                Console.Write(finalSequence.Pop()+" ");
            }
            Console.WriteLine();
        }
    }

    class Node
    {
        int value;
        Node previous;

        public Node(int value)
        {
            this.Value = value;
        }

        public Node(int value, Node previous)
        {
            this.Value = value;
            this.Previous = previous;
        }

        public int Value { get => this.value; set => this.value = value; }
        public Node Previous { get => this.previous; set => this.previous = value; }
    }
}