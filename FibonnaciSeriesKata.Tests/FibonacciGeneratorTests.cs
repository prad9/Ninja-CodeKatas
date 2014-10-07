using System;
using NUnit.Framework;

namespace FibonnaciSeriesKata.Tests
{
	[TestFixture]
	public class FibonacciGeneratorTests
	{
		[Test]
		public void GetNumber_When_0_Return_0()
		{
			var fSeries = new FibonacciGenerator();

			var result = fSeries.GetNumber(0);

			Assert.IsTrue(result == 0);
		}

		[Test]
		public void GetNumber_When_1_Return_1()
		{
			var fSeries = new FibonacciGenerator();

			var result = fSeries.GetNumber(1);

			Assert.IsTrue(result == 1);
		}

		[Test]
		public void GetNumber_When_2_Return_1()
		{
			var fSeries = new FibonacciGenerator();

			var result = fSeries.GetNumber(2);

			Assert.AreEqual(1, result);
		}

		[Test]
		public void GetNumber_When_4_Return_3()
		{
			var fSeries = new FibonacciGenerator();

			var result = fSeries.GetNumber(4);

			Assert.AreEqual(3, result);
		}

		[Test]
		public void GetNumber_When_6_Return_8()
		{
			var fSeries = new FibonacciGenerator();

			var result = fSeries.GetNumber(6);

			Assert.AreEqual(8, result);
		}

		[Test]
		public void GetNumber_When_8_Return_21()
		{
			var fSeries = new FibonacciGenerator();

			var result = fSeries.GetNumber(8);

			Assert.AreEqual(21, result);
		}

		[Test]
		public void PrintFizzBuzz()
		{
			var fSeries = new FibonacciGenerator();

			for (var i = 0; i < 10; i++)
			{
				var result = fSeries.GetNumber(i);
				if (result % 3 == 0 && result % 5 == 0) Console.WriteLine("FizzBuzz");
				else if (result % 3 == 0) Console.WriteLine("Fizz");
				else if (result % 5 == 0) Console.WriteLine("Buzz");
				else Console.WriteLine(result);
			}
		}
	}
}