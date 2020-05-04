using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSorts
{
    public interface ISortBehaviour<T> where T : IComparable
    {
        public T[] Sort(T[] arrayToSort);
    }
}
