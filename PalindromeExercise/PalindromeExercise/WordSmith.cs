using System;
namespace PalindromeExercise
{
	public class WordSmith
	{
		public WordSmith()
		{
		}
		public bool IsAPalindrome(string word)
        {
			string antiWord = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
				antiWord += word[i];
            }
            if (word == antiWord)
            {
				return true;
            }
			return false;
        }
	}
}

