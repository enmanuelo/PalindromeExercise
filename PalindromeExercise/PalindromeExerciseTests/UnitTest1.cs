using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("bib", true)]
        [InlineData("mom", true)]
        [InlineData("pam", false)]
        [InlineData("dad", true)]
        [InlineData("bad", false)]
        public void Test1(string word, bool expected)
        {
            //arrange
            var smith = new WordSmith();
            //act
            var actual = smith.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
