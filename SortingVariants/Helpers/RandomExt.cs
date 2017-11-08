using System;

namespace TestSorting.Sorting
{
	public static class RandomExt
	{
		internal static long NextLong(this Random random, long min, long max)
		{
			byte[] buf = new byte[8];
			random.NextBytes(buf);
			long longRand = BitConverter.ToInt64(buf, 0);

			return (longRand % (max - min)) + min;
		}

		internal static long NextLong(this Random random, long max)
		{
			byte[] buf = new byte[8];
			random.NextBytes(buf);
			long longRand = BitConverter.ToInt64(buf, 0);

			return longRand % max;
		}

		internal static long NextLong(this Random random)
		{
			byte[] buf = new byte[8];
			random.NextBytes(buf);
			long longRand = BitConverter.ToInt64(buf, 0);

			return longRand;
		}
	}
}
