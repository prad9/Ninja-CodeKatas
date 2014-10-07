using System.Collections.Generic;

namespace FibonnaciSeriesKata
{
	public class FibonacciGenerator
	{
		public int GetNumber(int index)
		{
			if (index == 0) return 0;
			if (index == 1) return 1;
			return GetNumber(index - 1) + GetNumber(index - 2);
		}
	}
}