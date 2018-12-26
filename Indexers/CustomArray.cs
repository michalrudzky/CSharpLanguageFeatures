using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class CustomArray<T>
    {
        private T[] array;

        public CustomArray(int size)
        {
            array = new T[size];
        }

        public int Length => array.Length;

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}
