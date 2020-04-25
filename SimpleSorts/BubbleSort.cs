using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSorts
{
    public class BubbleSort<T> : BaseSort<T> where T : IComparable
    {
        public BubbleSort(T[] arrayToSort) : base(arrayToSort)
        {

        }
    }
}
