using System;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace SimpleSorts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rnd.Next(0, 100);
            }
            SortableArray<Int32> array = new SortableArray<int>(intArray);
            Show(array);
            array.SetSortBehavior(new BubbleSortBehaviour<int>());
            array.Sort();
            Show(array);
        }

        private static void Show<T>(SortableArray<T> array) where T : IComparable
        {
            for (int i = 0; i < array.Lenght; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
