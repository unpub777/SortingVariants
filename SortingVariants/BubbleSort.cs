using System.Linq;
using System;
using System.Collections.Generic;

namespace TestSorting.Sorting
{
	public class BubbleSort<T> : ISorting<T>
	{
		public IList<T> Sort(IEnumerable<T> inputData, IComparer<T> comparer)
		{
			if (inputData == null)
			{
				throw new ArgumentNullException(nameof(inputData));
			}
			if (comparer == null)
			{
				throw new ArgumentNullException(nameof(comparer));
			}

			var result = inputData.ToList();
			var n = result.Count;
			bool wasSwap;

			for (int j = 1; j < n - 1; j++)
			{
				wasSwap = false;
				for (int i = 0; i < n - j; i++)
				{
					if (comparer.Compare(result[i], result[i + 1]) > 0)
					{
						result.Swap(i, i + 1);
						wasSwap = true;
					}
				}
				if (!wasSwap)
				{
					break;
				}
			}

			return result;
		}
	}
}
