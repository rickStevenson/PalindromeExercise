using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Fact]

        public void Test1()
        {
            var palindromeTest = new WordSmith();
            bool result = palindromeTest.IsAPalindrome("radar");
            Assert.True(result);
        }
    }
}
