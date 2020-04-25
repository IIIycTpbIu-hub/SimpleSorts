using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSorts
{
    interface ISortBehaviour<T> where T : IComparable
    {
        public T[] Sort(T[] arrayToSort);
    }
}
