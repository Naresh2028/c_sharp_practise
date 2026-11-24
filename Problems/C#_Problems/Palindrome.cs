using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts.Problems
{
    /// Checks whether a given string is a palindrome.
    /// PALINDROME:
    /// A palindrome is a word, phrase, number, or sequence of characters that reads 
    /// the same backward as it does forward
    // Eg:
    // Panama
    // Madam
    // 1221
    public static class Palindrome
    {
        // IsPolindrom("madam")  // true

        // IsPolindrom("madam")  // false

        public static bool IsPolindrom(string text) 
        {
            int left = 0;
            int right = text.Length - 1;


            while (left < right) 
            {
                if (char.ToLower(text[left]) != char.ToLower(text[right])) 
                {
                    return false;
                }

                left++;
                right--;
            }
            return true;
        }
    }
}
