using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSorts
{
    public class BubbleSortBehaviour<T> : ISortBehaviour<T> where T : IComparable
    {
        public T[] Sort(T[] arrayToSort)
        {
            int outer;
            int inside;
            for (outer = arrayToSort.Length - 1; outer > 1; outer--)
            {
                for (inside = 0; inside < outer; inside++)
                {
                    if (arrayToSort[inside].CompareTo(arrayToSort[inside + 1]) > 0)
                    {
                        T temp = arrayToSort[inside];
                        arrayToSort[inside] = arrayToSort[inside + 1];
                        arrayToSort[inside + 1] = temp;
                        Show(arrayToSort);
                    }
                }
            }

            return arrayToSort;
        }

        private void Show(T[] arrayToShow)
        {
            foreach (var item in arrayToShow)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
