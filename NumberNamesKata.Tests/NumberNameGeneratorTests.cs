using NUnit.Framework;

namespace NumberNamesKata.Tests
{
	[TestFixture]
	public class NumberNameGeneratorTests
	{
		[SetUp]
		public void Setup()
		{
			_numberToNameGenerator = new NumberToWordGenerator();
		}

		private NumberToWordGenerator _numberToNameGenerator;

		[Test]
		public void GetName_When0_ReturnZero()
		{
			var result = _numberToNameGenerator.GetWord(0);

			Assert.AreEqual("Zero", result);
		}

		[Test]
		public void GetName_When_100_Return_Hundred()
		{
			var result = _numberToNameGenerator.GetWord(100);

			Assert.AreEqual("One Hundred", result);
		}

		[Test]
		public void GetName_When_10_Return_Ten()
		{
			var result = _numberToNameGenerator.GetWord(10);

			Assert.AreEqual("Ten", result);
		}

		[Test]
		public void GetName_When_11_Return_Eleven()
		{
			var result = _numberToNameGenerator.GetWord(11);

			Assert.AreEqual("Eleven", result);
		}

		[Test]
		public void GetName_When_1_Return_One()
		{
			var result = _numberToNameGenerator.GetWord(1);

			Assert.AreEqual("One", result);
		}

		[Test]
		public void GetName_When_21_Return_TwentyOne()
		{
			var result = _numberToNameGenerator.GetWord(21);

			Assert.AreEqual("Twenty One", result);
		}

		[Test]
		public void GetName_When_300_Return_ThreeHundred()
		{
			var result = _numberToNameGenerator.GetWord(300);

			Assert.AreEqual("Three Hundred", result);
		}

		[Test]
		public void GetName_When_310_Return_ThreeHundredAndTen()
		{
			var result = _numberToNameGenerator.GetWord(310);

			Assert.AreEqual("Three Hundred And Ten", result);
		}

		[Test]
		public void GetName_When_30_Return_Thirty()
		{
			var result = _numberToNameGenerator.GetWord(30);

			Assert.AreEqual("Thirty", result);
		}

		[Test]
		public void GetName_When_340_Return_ThreeHundredAndFourty()
		{
			var result = _numberToNameGenerator.GetWord(340);

			Assert.AreEqual("Three Hundred And Fourty", result);
		}

		[Test]
		public void GetName_When_548_Return_FiveHundredAndFourtyEight()
		{
			var result = _numberToNameGenerator.GetWord(548);

			Assert.AreEqual("Five Hundred And Fourty Eight", result);
		}

		[Test]
		public void GetName_When_58_Return_FiftyEight()
		{
			var result = _numberToNameGenerator.GetWord(58);

			Assert.AreEqual("Fifty Eight", result);
		}

		[Test]
		public void GetName_When_694_Return_SixHundredAndNintyFour()
		{
			var result = _numberToNameGenerator.GetWord(694);

			Assert.AreEqual("Six Hundred And Ninty Four", result);
		}
	}
}