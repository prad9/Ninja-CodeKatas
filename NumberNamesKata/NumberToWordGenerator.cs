using System.Collections.Generic;

namespace NumberNamesKata
{
	public class NumberToWordGenerator
	{
		public string GetWord(int number)
		{
			var word = string.Empty;

			if (number >= 0 && number < 10)
			{
				word = GetWordRangeZeroToNine(number);
			}
			if (number > 9 && number < 20)
			{
				word = GetWordRangeTenAndNinteen(number);
			}
			else if (number > 19 && number < 100)
			{
				word = GetWordRangeTwentyAndNintyNine(number);
			}
			else if (number > 99 && number < 999)
			{
				word = GetWordRangeHundredAndThousand(number);
			}

			return word;
		}

		private string GetWordRangeHundredAndThousand(int number)
		{
			var firstDigit = number / 100;
			var secondDigit = (number % 100) / 10;
			var thirdDigit = number % 10;
			var firstWord = GetWordRangeZeroToNine(firstDigit);
			string secondWord;
			if (secondDigit > 0)
				secondWord = " Hundred And " + GetWordRangeForTens(secondDigit);
			else
			{
				secondWord = " Hundred";
			}

			var thirdWord = string.Empty;
			if (thirdDigit > 0) thirdWord = " " + GetWordRangeZeroToNine(thirdDigit);
			var word = firstWord + secondWord + thirdWord;
			return word;
		}

		private string GetWordRangeTwentyAndNintyNine(int number)
		{
			var firstDigit = number / 10;
			var secondDigit = number % 10;
			var firstWord = GetWordRangeForTens(firstDigit);
			var secondWord = string.Empty;
			if (secondDigit > 0) secondWord = " " + GetWordRangeZeroToNine(secondDigit);
			var word = firstWord + secondWord;
			return word;
		}

		private string GetWordRangeTenAndNinteen(int number)
		{
			string word;
			if (number == 10)
			{
				var firstDigit = number / 10;
				word = GetWordRangeForTens(firstDigit);
			}
			else word = GetWordRangeElevenToNinteen(number);
			return word;
		}

		private string GetWordRangeForTens(int tenthIndex)
		{
			var tensToWord = new SortedDictionary<int, string>
			{
				{1, "Ten"},
				{2, "Twenty"},
				{3, "Thirty"},
				{4, "Fourty"},
				{5, "Fifty"},
				{6, "Sixty"},
				{7, "Seventy"},
				{8, "Eighty"},
				{9, "Ninty"}
			};
			var firstWord = string.Empty;
			if (tensToWord.ContainsKey(tenthIndex))
			{
				tensToWord.TryGetValue(tenthIndex, out firstWord);
			}
			return firstWord;
		}

		private string GetWordRangeZeroToNine(int number)
		{
			var numbersToWord = new SortedDictionary<int, string>
			{
				{0, "Zero"},
				{1, "One"},
				{2, "Two"},
				{3, "Three"},
				{4, "Four"},
				{5, "Five"},
				{6, "Six"},
				{7, "Seven"},
				{8, "Eight"},
				{9, "Nine"}
			};
			var word = string.Empty;
			if (numbersToWord.ContainsKey(number))
			{
				numbersToWord.TryGetValue(number, out word);
			}
			return word;
		}

		private string GetWordRangeElevenToNinteen(int number)
		{
			var numbersToWord = new SortedDictionary<int, string>
			{
				{11, "Eleven"},
				{12, "Twelve"},
				{13, "Thirteen"},
				{14, "Fourteen"},
				{15, "Fifteen"},
				{16, "Sixteen"},
				{17, "Seventeen"},
				{18, "Eighteen"},
				{19, "Ninteen"}
			};
			var word = string.Empty;
			if (numbersToWord.ContainsKey(number))
			{
				numbersToWord.TryGetValue(number, out word);
			}
			return word;
		}
	}
}