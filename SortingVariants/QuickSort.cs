using System;
using System.Collections.Generic;
using System.Linq;

namespace TestSorting.Sorting
{
	public class QuickSort<T> : ISorting<T>
	{
		IComparer<T> _comparer;
		List<T> _result;
		Random _random;

		public IEnumerable<T> Sort(IEnumerable<T> inputData, IComparer<T> comparer)
		{
			if (inputData == null)
			{
				throw new ArgumentNullException(nameof(inputData));
			}
			if (comparer == null)
			{
				throw new ArgumentNullException(nameof(comparer));
			}
			_comparer = comparer;
			_result = inputData.ToList();

			QuickSortProcess(0, inputData.Count() - 1, 0);

			return _result;
		}

		private void QuickSortProcess(int lowIndex, int highIndex, int deep)
		{
			var supportIndex = lowIndex + ((highIndex - lowIndex) / 2) + ((highIndex - lowIndex) % 2);
			var supportValue = _result[supportIndex];
			var low = lowIndex; var high = highIndex;

			while (highIndex > lowIndex)
			{
				while (_comparer.Compare(_result[lowIndex], supportValue) < 0)
				{
					lowIndex++;
				}
				while (_comparer.Compare(_result[highIndex], supportValue) > 0)
				{
					highIndex--;
				}
				if (highIndex > lowIndex)
				{
					_result.Swap(lowIndex++, highIndex--, deep);
				}
			}

			if (high - low > 1)
			{
				QuickSortProcess(low, highIndex, deep++);
				QuickSortProcess(lowIndex, high, deep++);
			}
		}
	}
}
