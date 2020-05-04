using System;

namespace SimpleSorts
{
    public class SelectionSortBehavior<T> : ISortBehaviour<T> where T : IComparable
    {
        public T[] Sort(T[] arrayToSort)
        {
            int minItemIndex;
            for (int outerIndex = 0; outerIndex < arrayToSort.Length - 1; outerIndex++)
            {
                T minItem = arrayToSort[outerIndex];
                minItemIndex = outerIndex;
                for (int innerIndex = outerIndex + 1; innerIndex < arrayToSort.Length; innerIndex++)
                {
                    if (arrayToSort[innerIndex].CompareTo(minItem) < 0)
                    {
                        minItem = arrayToSort[innerIndex];
                        minItemIndex = innerIndex;
                    }
                }
                arrayToSort[minItemIndex] = arrayToSort[outerIndex];
                arrayToSort[outerIndex] = minItem;
            }

            return arrayToSort;
        }
    }
}
