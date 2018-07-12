using System;

namespace GoodsStore.Mock
{
	public static class MockNumber
	{
		public static int GetNumber()
		{
			Random rnd = new Random();
			return rnd.Next();
		}

		public static int GetNumber(int minValue, int maxValue)
		{
			Random rnd = new Random();
			return rnd.Next(minValue, maxValue);
		}
	}
}
