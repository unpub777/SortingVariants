using System;
using Xunit;
using TestSorting.Sorting;
using System.Collections.Generic;

namespace SortingVariants.Tests
{
    public class Tests
    {
        [Fact]
        public void BubbleSortTest()
        {
			var data = new int[] { 1, 5, 4, 2, 3};
			var expected = new int[] { 1, 2, 3, 4, 5 };

			var bubbleSort = new BubbleSort<int>();
			var result = bubbleSort.Sort(data, Comparer<int>.Default);
			Assert.Equal(expected, result);
        }

		[Fact]
		public void QuickSortTest()
		{
			var data = new int[] { 1, 5, 4, 2, 3 };
			var expected = new int[] { 1, 2, 3, 4, 5 };

			var quickSort = new QuickSort<int>();
			var result = quickSort.Sort(data, Comparer<int>.Default);
			Assert.Equal(expected, result);
		}
	}
}
