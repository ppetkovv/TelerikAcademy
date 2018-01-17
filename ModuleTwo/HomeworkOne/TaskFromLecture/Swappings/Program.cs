
//First Way - 30 points

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Swappings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int N = Int32.Parse(Console.ReadLine());
//            //int counter = 1;
//            //int[] sequence = new int[N].Select(x => counter++).ToArray();
//            int[] nums = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();

//            LinkedList<int> linkedList = new LinkedList<int>();

//            linkedList.AddFirst(1);
//            LinkedListNode<int> currentNode = linkedList.First;

//            for (int i = 2; i < N; i++)
//            {
//                linkedList.AddAfter(currentNode, i);
//                currentNode = currentNode.Next;
//            }
//            linkedList.AddLast(N);

//            for (int i = 0; i < nums.Length; i++)
//            {
//                int currentBorder = nums[i];
//                if (linkedList.First.Value != currentBorder && linkedList.Last.Value != currentBorder)
//                {
//                    LinkedList<int> leftPartList = new LinkedList<int>();
//                    LinkedList<int> rightPartList = new LinkedList<int>();

//                    LinkedListNode<int> mainListCurrentNode = linkedList.First;
//                    LinkedListNode<int> leftPartListCurrentNode = new LinkedListNode<int>(mainListCurrentNode.Value);
//                    leftPartList.AddFirst(leftPartListCurrentNode);

//                    mainListCurrentNode = mainListCurrentNode.Next;
//                    linkedList.Remove(mainListCurrentNode.Previous);
//                    for (; mainListCurrentNode.Value != currentBorder;)
//                    {
//                        leftPartList.AddAfter(leftPartListCurrentNode, mainListCurrentNode.Value);
//                        leftPartListCurrentNode = leftPartListCurrentNode.Next;
//                        mainListCurrentNode = mainListCurrentNode.Next;
//                        linkedList.Remove(mainListCurrentNode.Previous);
//                    }

//                    mainListCurrentNode = mainListCurrentNode.Next;
//                    LinkedListNode<int> rightPartListCurrentNode = new LinkedListNode<int>(mainListCurrentNode.Value);
//                    rightPartList.AddFirst(rightPartListCurrentNode);
//                    mainListCurrentNode = mainListCurrentNode.Next;
//                    if (mainListCurrentNode != null) linkedList.Remove(mainListCurrentNode.Previous);
//                    else linkedList.Remove(linkedList.Last);
//                    for (; mainListCurrentNode != null;)
//                    {
//                        rightPartList.AddAfter(rightPartListCurrentNode, mainListCurrentNode.Value);
//                        rightPartListCurrentNode = rightPartListCurrentNode.Next;
//                        mainListCurrentNode = mainListCurrentNode.Next;
//                        if (mainListCurrentNode != null) linkedList.Remove(mainListCurrentNode.Previous);
//                        else linkedList.Remove(linkedList.Last);
//                    }

//                    mainListCurrentNode = linkedList.First;
//                    leftPartListCurrentNode = leftPartList.First;
//                    rightPartListCurrentNode = rightPartList.Last;

//                    while (leftPartListCurrentNode != null)
//                    {
//                        linkedList.AddAfter(mainListCurrentNode, leftPartListCurrentNode.Value);
//                        leftPartListCurrentNode = leftPartListCurrentNode.Next;
//                        mainListCurrentNode = mainListCurrentNode.Next;
//                    }

//                    mainListCurrentNode = linkedList.First;

//                    while (rightPartListCurrentNode != null)
//                    {
//                        linkedList.AddBefore(mainListCurrentNode, rightPartListCurrentNode.Value);
//                        rightPartListCurrentNode = rightPartListCurrentNode.Previous;
//                        mainListCurrentNode = mainListCurrentNode.Previous;
//                    }
//                }
//                else if (linkedList.First.Value == currentBorder)
//                {
//                    LinkedListNode<int> newNode = new LinkedListNode<int>(linkedList.First.Value);
//                    linkedList.Remove(linkedList.First);
//                    linkedList.AddAfter(linkedList.Last, newNode);
//                }
//                else if (linkedList.Last.Value == currentBorder)
//                {
//                    LinkedListNode<int> newNode = new LinkedListNode<int>(linkedList.Last.Value);
//                    linkedList.Remove(linkedList.Last);
//                    linkedList.AddBefore(linkedList.First, newNode);
//                }
//            }
//            Console.WriteLine(string.Join(" ", linkedList));
//        }
//    }
//}


//Second Way - 40 points

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Swappings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int N = Int32.Parse(Console.ReadLine());
//            int[] nums = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();

//            ListNode first = new ListNode(1);
//            first.Previous = null;
//            ListNode currentNode = first;

//            ListNode last = new ListNode(N);
//            last.Next = null;

//            for (int i = 2; i < N; i++)
//            {
//                currentNode.Next = new ListNode(i);
//                currentNode.Next.Previous = currentNode;
//                currentNode = currentNode.Next;
//            }

//            currentNode.Next = last;
//            currentNode.Next.Previous = currentNode;

//            //Next connections ready !!!
//            //currentNode = first;
//            //while (currentNode != last)
//            //{
//            //    Console.Write(currentNode.Value + " ");
//            //    currentNode = currentNode.Next;
//            //}
//            //Console.WriteLine(currentNode.Value);

//            //Previous connections ready !!!
//            //currentNode = last;
//            //while (currentNode != first)
//            //{
//            //    Console.Write(currentNode.Value + " ");
//            //    currentNode = currentNode.Previous;
//            //}
//            //Console.WriteLine(currentNode.Value);

//            for (int i = 0; i < nums.Length; i++)
//            {
//                int currentBorder = nums[i];

//                if (currentBorder != first.Value && currentBorder != last.Value)
//                {
//                    ListNode leftFirst = first;
//                    ListNode leftLast = first;
//                    while (leftLast.Next.Value != currentBorder)
//                    {
//                        leftLast = leftLast.Next;
//                    }
//                    ListNode currentBorderNode = leftLast.Next;

//                    ListNode rightFirst = currentBorderNode.Next;
//                    ListNode rightLast = rightFirst;
//                    while (rightLast != last)
//                    {
//                        rightLast = rightLast.Next;
//                    }
//                    //All connections ready!!!
//                    //Console.WriteLine(leftFirst.Value);
//                    //Console.WriteLine(leftLast.Value);
//                    //Console.WriteLine(currentBorderNode.Value);
//                    //Console.WriteLine(rightFirst.Value);
//                    //Console.WriteLine(rightLast.Value);
//                    currentBorderNode.Next = leftFirst;
//                    first.Previous = currentBorderNode;
//                    leftLast.Next = null;
//                    currentBorderNode.Previous = rightLast;
//                    rightLast.Next = currentBorderNode;
//                    rightFirst.Previous = null;
//                    first = rightFirst;
//                    last = leftLast;

//                    //Each shifting successful printing !!!
//                    //ListNode currNode = first;
//                    //while (currNode != null)
//                    //{
//                    //    Console.Write(currNode.Value + " ");
//                    //    currNode = currNode.Next;
//                    //}

//                }
//                else if (currentBorder == first.Value)
//                {
//                    last.Next = first;
//                    ListNode newFirst = first.Next;
//                    newFirst.Previous = null;
//                    first.Next = null;
//                    first.Previous = last;
//                    last = first;
//                    first = newFirst;
//                    //Each shifting successful printing !!!
//                    //ListNode curNode = first;
//                    //while (curNode != null)
//                    //{
//                    //    Console.Write(curNode.Value + " ");
//                    //    curNode = curNode.Next;
//                    //}
//                }
//                else if (currentBorder == last.Value)
//                {
//                    last.Previous.Next = null;
//                    last.Next = first;
//                    first = last;
//                    last = last.Previous;
//                    first.Previous = null;
//                    //Each shifting successful printing !!!
//                    //ListNode curNode = first;
//                    //while (curNode != null)
//                    //{
//                    //    Console.Write(curNode.Value + " ");
//                    //    curNode = curNode.Next;
//                    //}
//                }
//            }
//            ListNode curNode = first;
//            while (curNode.Next != null)
//            {
//                Console.Write(curNode.Value + " ");
//                curNode = curNode.Next;
//            }
//            Console.WriteLine(curNode.Value);
//        }
//    }

//    class ListNode
//    {
//        private int value;
//        private ListNode next;
//        private ListNode previous;

//        public ListNode(int value)
//        {
//            this.Value = value;
//        }

//        public int Value { get { return this.value; } set { this.value = value; } }
//        public ListNode Next { get { return this.next; } set { this.next = value; } }
//        public ListNode Previous { get { return this.previous; } set { this.previous = value; } }
//    }
//}

//Third Way - 72 points

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Swappings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int N = Int32.Parse(Console.ReadLine());
//            int[] nums = Console.ReadLine().Split(new char[] { ' ' }).Select(Int32.Parse).ToArray();

//            Dictionary<int, ListNode> dictionary = new Dictionary<int, ListNode>();

//            ListNode first = new ListNode(1);
//            first.Previous = null;

//            ListNode last = new ListNode(N);
//            last.Next = null;

//            dictionary.Add(1, first);
//            dictionary.Add(N, last);

//            ListNode currentNode;
//            ListNode previousNode;
//            for (int i = 2; i < N; i++)
//            {
//                currentNode = new ListNode(i);
//                previousNode = dictionary[i - 1];
//                previousNode.Next = currentNode;
//                currentNode.Previous = previousNode;
//                dictionary.Add(i, currentNode);
                
//            }
//            dictionary[N - 1].Next = last;
//            last.Previous = dictionary[N - 1];

//            for (int i = 0; i < nums.Length; i++)
//            {
//                int currentBorder = nums[i];
//                ListNode currentBorderNode = dictionary[currentBorder];
//                if (currentBorderNode != first && currentBorderNode != last)
//                {

//                    ListNode newFirst = currentBorderNode.Next;
//                    ListNode newLast = currentBorderNode.Previous;

//                    currentBorderNode.Previous.Next = null;
//                    currentBorderNode.Next.Previous = null;

//                    currentBorderNode.Previous = last;
//                    last.Next = currentBorderNode;
//                    currentBorderNode.Next = first;
//                    first.Previous = currentBorderNode;

//                    first = newFirst;
//                    last = newLast;
//                    first.Previous = null;
//                    last.Next = null;
//                }
//                else if (currentBorderNode == first)
//                {
//                    ListNode newFirst = first.Next;
//                    first.Previous = last;
//                    last.Next = first;
//                    last = last.Next;
//                    last.Next = null;
//                    first = newFirst;
//                    first.Previous = null;
//                }
//                else if (currentBorderNode == last)
//                {
//                    ListNode newLast = last.Previous;
//                    last.Next = first;
//                    first.Previous = last;
//                    first = first.Previous;
//                    first.Previous = null;
//                    last = newLast;
//                    last.Next = null;
//                }
//            }

//            ListNode curNode = first;
//            if (curNode != null)
//            {
//                Console.Write(curNode.Value);
//                curNode = curNode.Next;
//            }
//            for (; curNode != null;)
//            {
//                Console.Write(" " + curNode.Value);
//                curNode = curNode.Next;
//            }
//            Console.WriteLine();
//        }
//    }

//    class ListNode
//    {
//        private int value;
//        private ListNode next;
//        private ListNode previous;

//        public ListNode(int value)
//        {
//            this.Value = value;
//        }

//        public int Value { get { return this.value; } set { this.value = value; } }
//        public ListNode Next { get { return this.next; } set { this.next = value; } }
//        public ListNode Previous { get { return this.previous; } set { this.previous = value; } }
//    }
//}