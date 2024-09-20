using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        
        public bool IsAPalindrome(string word)
        {
            char[] chars = word.ToCharArray();
            Array.Reverse(chars);
            string reversedWord = new string(chars);
            Console.WriteLine($"{word} {reversedWord}");

            return word == reversedWord;
        }
    }
}
