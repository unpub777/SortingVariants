using System.Collections.Generic;

namespace TestSorting.Sorting
{
	public static class Sorting
	{
		public static IEnumerable<T> Sort<T>(IEnumerable<T> inputData, IComparer<T> comparer, SortType sortType)
		{
			ISorting<T> sorting = null;

			if (sortType == SortType.BubbleSort)
			{
				sorting = new BubbleSort<T>();
			}
			else if (sortType == SortType.QuickSort)
			{
				sorting = new QuickSort<T>();
			}

			return sorting.Sort(inputData, comparer);
		}
	}
}
