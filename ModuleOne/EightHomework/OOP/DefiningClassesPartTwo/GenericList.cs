using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    class GenericList<T> where T:IComparable
    {
        private static int currentCount = 0;
        private T[] arrayElements;

        public GenericList()
        {
            this.arrayElements = new T[4];
        }

        public GenericList(int size)
        {
            if (size < 0)
            {
                throw new ArgumentException("The size cannot be with negative value!!!");
            }
            this.arrayElements = new T[size];
        }

        public void Add(T element)
        {
            ResizeIfNecessary();
            this.arrayElements[currentCount] = element;
            currentCount++;
        }

        public T this[int index]
        {
            get { if (index < 0 || index >= this.arrayElements.Length) { throw new IndexOutOfRangeException(); } return this.arrayElements[index]; }
            set { if (index < 0 || index >= this.arrayElements.Length) { throw new IndexOutOfRangeException(); } this.arrayElements[index] = value; }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.arrayElements.Length)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = index; i < this.arrayElements.Length - 1; i++)
            {
                this.arrayElements[index] = this.arrayElements[index + 1];
            }
            T[] arrayOfElementsCopy = new T[this.arrayElements.Length - 1];
            for (int i = 0; i < arrayOfElementsCopy.Length; i++)
            {
                arrayOfElementsCopy[i] = this.arrayElements[i];
            }
            this.arrayElements = arrayOfElementsCopy;
            currentCount--;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index >= this.arrayElements.Length)
            {
                throw new IndexOutOfRangeException();
            }
            T[] arrayOfElementsCopy = new T[this.arrayElements.Length + 1];
            for (int i = 0; i < arrayOfElementsCopy.Length; i++)
            {
                if (i == index)
                {
                    arrayOfElementsCopy[i] = item;
                }
                else if (i < index)
                {
                    arrayOfElementsCopy[i] = this.arrayElements[i];
                }
                else if (i > index)
                {
                    arrayOfElementsCopy[i] = this.arrayElements[i - 1];
                }
            }
            currentCount++;
        }

        public void Clear()
        {
            this.arrayElements = new T[4];
            currentCount = 0;
        }

        public bool Contains(T item)
        {
            bool isContaining = false;
            for (int i = 0; i < this.arrayElements.Length; i++)
            {
                if (this.arrayElements[i].Equals(item))
                {
                    isContaining = true;
                    break;
                }
            }
            return isContaining;
        }

        private void ResizeIfNecessary()
        {
            if (currentCount == this.arrayElements.Length)
            {
                T[] arrayCopy = new T[this.arrayElements.Length * 2];
                for (int i = 0; i < this.arrayElements.Length; i++)
                {
                    arrayCopy[i] = this.arrayElements[i];
                }
                this.arrayElements = arrayCopy;
            }
        }

        public T Min()
        {
            T minValue = this.arrayElements[0];
            for (int i = 1; i < this.arrayElements.Length; i++)
            {
                if(this.arrayElements[i].CompareTo(minValue) < 0)
                {
                    minValue = this.arrayElements[i];
                }
            }
            return minValue;
        }

        public T Max()
        {
            T maxValue = this.arrayElements[0];
            for (int i = 1; i < this.arrayElements.Length; i++)
            {
                if (this.arrayElements[i].CompareTo(maxValue) > 0)
                {
                    maxValue = this.arrayElements[i];
                }
            }
            return maxValue;
        }

        public override string ToString()
        {
            StringBuilder finalResult = new StringBuilder();
            finalResult.Append(this.arrayElements[0].ToString());
            for (int i = 1; i < this.arrayElements.Length; i++)
            {
                finalResult.Append(", ").Append(this.arrayElements[i].ToString());
            }
            return finalResult.ToString();
        }
    }
}