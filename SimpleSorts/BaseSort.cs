using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSorts
{
    public class BaseSort<T> where T : IComparable
    {
        private T[] _array;

        public BaseSort(T[] arrayToSort)
        {
            _array = arrayToSort;
        }

        public virtual T[] Sort()
        {
            throw new InvalidOperationException("Используй производные классы для сортировок");
        }
    }
}
