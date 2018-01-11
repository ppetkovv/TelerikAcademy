using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEleven
{
    class LinkedList<T>
    {
        private ListItem<T> head;

        public LinkedList() { }

        public LinkedList(ListItem<T> element)
        {
            this.Head = element;
        }

        public ListItem<T> Head { get => this.head; set => this.head = value; }

        public void AddFirst(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Cannot add element which is null!");
            }

            ListItem<T> newItem = new ListItem<T>(element);

            if (this.Head == null)
            {
                this.Head = newItem;
            }
            else
            {
                newItem.NextItem = this.head;
                this.head = newItem;
            }
        }

        public void AddFirst(ListItem<T> element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Cannot add element which is null!");
            }

            if (this.Head == null)
            {
                this.Head = element;
            }
            else
            {
                element.NextItem = this.head;
                this.head = element;
            }
        }

        public void AddLast(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Cannot add element which is null!");
            }

            ListItem<T> newItem = new ListItem<T>(element);
            ListItem<T> currentItem = this.head;

            while (currentItem.NextItem != null)
            {
                currentItem = currentItem.NextItem;
            }

            currentItem.NextItem = newItem;
        }

        public void AddLast(ListItem<T> element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Cannot add element which is null!");
            }

            ListItem<T> currentItem = this.head;

            while (currentItem.NextItem != null)
            {
                currentItem = currentItem.NextItem;
            }

            currentItem.NextItem = element;
        }

        public void AddBefore(ListItem<T> listItem, T element)
        {
            if (listItem == null)
            {
                throw new ArgumentNullException("Cannot refer to null!");
            }
            if (element == null)
            {
                throw new ArgumentNullException("Cannot add element which is null!");
            }

            if (this.head == listItem)
            {
                this.AddFirst(element);
            }
            else
            {
                ListItem<T> currentItem = this.head;
                while (currentItem.NextItem != listItem && currentItem.NextItem != null)
                {
                    currentItem = currentItem.NextItem;
                }
                if (currentItem.NextItem != null)
                {
                    ListItem<T> newNode = new ListItem<T>(element);
                    newNode.NextItem = currentItem.NextItem;
                    currentItem.NextItem = newNode;
                }
            }
        }

        public void AddBefore(ListItem<T> listItem, ListItem<T> element)
        {
            if (listItem == null)
            {
                throw new ArgumentNullException("Cannot refer to null!");
            }
            if (element == null)
            {
                throw new ArgumentNullException("Cannot add element which is null!");
            }

            if (this.head == listItem)
            {
                this.AddFirst(element);
            }
            else
            {
                ListItem<T> currentItem = this.head;
                while (currentItem.NextItem != listItem && currentItem.NextItem != null)
                {
                    currentItem = currentItem.NextItem;
                }
                if (currentItem.NextItem != null)
                {
                    element.NextItem = currentItem.NextItem;
                    currentItem.NextItem = element;
                }
            }
        }

        public void AddAfter(ListItem<T> listItem, T element)
        {
            if (listItem == null)
            {
                throw new ArgumentNullException("Cannot refer to null!");
            }
            if (element == null)
            {
                throw new ArgumentNullException("Cannot add element which is null!");
            }

            if (this.head == listItem)
            {
                this.AddBefore(this.head.NextItem, element);
            }

            ListItem<T> currentItem = this.head;
            while (currentItem != listItem && currentItem != null)
            {
                currentItem = currentItem.NextItem;
            }
            if (currentItem != null && currentItem.NextItem != null)
            {
                ListItem<T> newNode = new ListItem<T>(element);
                newNode.NextItem = currentItem.NextItem;
                currentItem.NextItem = newNode;
            }
            else if (currentItem != null && currentItem.NextItem == null)
            {
                ListItem<T> newNode = new ListItem<T>(element);
                currentItem.NextItem = newNode;
            }
        }

        public void AddAfter(ListItem<T> listItem, ListItem<T> element)
        {
            if (listItem == null)
            {
                throw new ArgumentNullException("Cannot refer to null!");
            }
            if (element == null)
            {
                throw new ArgumentNullException("Cannot add element which is null!");
            }

            if (this.head == listItem)
            {
                this.AddBefore(this.head.NextItem, element);
            }

            ListItem<T> currentItem = this.head;
            while (currentItem != listItem && currentItem != null)
            {
                currentItem = currentItem.NextItem;
            }
            if (currentItem != null && currentItem.NextItem != null)
            {
                element.NextItem = currentItem.NextItem;
                currentItem.NextItem = element;
            }
            else if (currentItem != null && currentItem.NextItem == null)
            {
                currentItem.NextItem = element;
            }
        }

        public void Print()
        {
            ListItem<T> currentItem = this.head;
            while (currentItem != null)
            {
                Console.Write(currentItem.Value + " ");
            }
            Console.WriteLine();
        }
    }
}