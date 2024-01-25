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
        private uint size;
        private uint capacity;

        public DynamicArray(uint capacity)
        {
            this.capacity = capacity;
            this.array = new T[capacity];
            this.size = 0;
        }

        public void Add(uint index, T item)
        {
            if (index >= capacity)
            {
                uint newCapacity;
                if (index >= capacity * 2) newCapacity = index + 1;
                else newCapacity = capacity * 2;
                
                T[] newArray = new T[newCapacity];
                Array.Copy(array, newArray, capacity);
                array = newArray;
                capacity = newCapacity;
            }

            array[index] = item;
            size++;
        }

        public T this[uint index]
        {
            get
            {
                if (index >= size)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                return array[index];
            }
        }

        public uint Count
        {
            get { return size; }
        }

    }
}
