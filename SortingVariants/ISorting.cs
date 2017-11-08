using System.Collections.Generic;

namespace TestSorting.Sorting
{
	public interface ISorting<T>
	{
		IEnumerable<T> Sort(IEnumerable<T> inputData, IComparer<T> comparer);
	}
}
