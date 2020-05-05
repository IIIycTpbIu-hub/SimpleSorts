using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSorts
{
    public class InsertionSortBehavior<T> : ISortBehaviour<T> where T : IComparable
    {
        public T[] Sort(T[] arrayToSort)
        {
            T temp;
            for (int outer = 1; outer < arrayToSort.Length; outer++)
            {
                temp = arrayToSort[outer];
                int found = outer;
                for (int inner = outer - 1; inner >= 0; inner--)
                {
                    if (temp.CompareTo(arrayToSort[inner]) < 0)
                    {
                        arrayToSort[inner + 1] = arrayToSort[inner];
                        found = inner;
                    }
                    else
                    {
                        break;
                    }
                }

                arrayToSort[found] = temp;
            }

            return arrayToSort;
        }
    }
}
