using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace SimpleSorts
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int[] intArray = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rnd.Next(0, 100);
            }
            SortableArray<Int32> array = new SortableArray<int>(intArray);
            array.SetSortBehavior(new SelectionSortBehavior<int>());

            stopwatch.Start();
            Show(array);
            array.Sort();
            Show(array);
            stopwatch.Stop();

            Console.WriteLine("затраченое время на сортировку {0} элементов: {1}", intArray.Length, stopwatch.Elapsed);
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
