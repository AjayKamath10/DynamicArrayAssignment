using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayAssignment
{
    public class DynamicArray<T>
    {
        private T[] array;
        private int size;
        private int capacity;

        public DynamicArray(int capacity)
        {
            this.capacity = capacity;
            this.array = new T[capacity];
            this.size = 0;
        }

        public void Add(int index, T item)
        {
            if (index >= capacity)
            {
                // Resize the array if the index is beyond the current capacity
                int newCapacity = capacity * 2;
                T[] newArray = new T[newCapacity];
                Array.Copy(array, newArray, capacity);
                array = newArray;
                capacity = newCapacity;
            }

            array[index] = item;
            size++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= size)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                return array[index];
            }
        }

        public int Count
        {
            get { return size; }
        }

    }


}
