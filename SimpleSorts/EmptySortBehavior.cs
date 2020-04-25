using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSorts
{
    public class EmptySortBehavior<T> : ISortBehaviour<T> where T : IComparable
    {
        public T[] Sort(T[] arrayToSort)
        {
            throw new InvalidOperationException("Set sortion type first");
        }
    }
}
