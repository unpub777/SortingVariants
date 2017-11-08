using System;
using System.Collections.Generic;

namespace TestSorting.Sorting
{
    public static class ListExt
    {
        public static void Swap<T>(this List<T> list, int firstIndex, int secondIndex, int deep)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }
            if (list.Count <= firstIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(firstIndex));
            }
            if (list.Count <= secondIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(secondIndex));
            }

            var tmp = list[secondIndex];
            list[secondIndex] = list[firstIndex];
            list[firstIndex] = tmp;
        }
    }
}
