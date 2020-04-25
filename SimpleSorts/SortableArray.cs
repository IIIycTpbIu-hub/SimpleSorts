using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSorts
{
    public class SortableArray<T> where T : IComparable
    {
        private ISortBehaviour<T> _sortExecuter;
        private T[] _array;

        public SortableArray(T[] array)
        {
            _array = array;
            _sortExecuter = new EmptySortBehavior<T>();
        }

        public void SetSortBehavior(ISortBehaviour<T> sortBehaviour)
        {
            _sortExecuter = sortBehaviour;
        }

        public void Sort()
        {
            _array = _sortExecuter.Sort(_array);
        }
    }
}
