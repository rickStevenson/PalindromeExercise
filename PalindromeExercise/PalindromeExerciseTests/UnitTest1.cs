using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("radar")]
        [InlineData("madam")]
        [InlineData("level")]
        [InlineData("rotor")]
        [InlineData("noon")]

        public void Test1(string word)
        {
            var palindromeTest = new WordSmith();
            bool result = palindromeTest.IsAPalindrome(word);
            Assert.True(result);
        }
    }
}
