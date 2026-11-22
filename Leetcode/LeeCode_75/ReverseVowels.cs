using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts.Leetcode.LeeCode_75
{
    /// <summary>
    /// Given a string s, reverse only all the vowels in the string and return it.
    /// The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and 
    /// upper cases, more than once.
    /// </summary>
    public class ReverseVowels
    {
        public void Main2() 
        {
            string text = "IceCreAm"; // Output: "AceCreIm"

            //The vowels in s are ['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".

            ReverseVowel(text);
        }

        public string ReverseVowel(string text) 
        {
            char[] textArray = text.ToCharArray();

            int left = 0;                       // Ascending pointer (starts at first index)
            int right = textArray.Length - 1;   // Descending pointer (starts at last index)
            bool isLeftVowel = false;
            bool isRightVowel = false;
            char temp;
            string? result = string.Empty;

            // Keep going until ascending 'left' and descending 'right' meet in the middle
            while (left < right) 
            {
                isLeftVowel = IsCharVowel(textArray[left]);
                isRightVowel = IsCharVowel(textArray[right]);

                // Both pointers found vowels -> Swap them, then ascend 'left' and descend 'right'
                if (isLeftVowel && isRightVowel) 
                {
                    temp = textArray[left];
                    textArray[left] = textArray[right];
                    textArray[right] = temp;

                    left++;
                    right--;
                }

                // Left is NOT a vowel -> Ascend 'left' to check next character
                else if (!isLeftVowel) 
                {
                    left++;
                }

                // Right is NOT a vowel -> Descend 'right' to check previous character
                else if (!isRightVowel) 
                {
                    right--;
                }
            }

            result = new string(textArray);

            if (!string.IsNullOrEmpty(result))
            {
                return result;
            }
            else 
            {
               return string.Empty;
            }
        }

        private bool IsCharVowel(char x) 
        {
            char lowerChar = char.ToLower(x);

            if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
            {
                return true;
            }

            return false;
        }
    }
    /*
     * Dry Run Trace: Reverse Vowels of a String (LeetCode 345)
     * Input: text = "IceCreAm" (Length = 8)
     * Init:  textArray = ['I', 'c', 'e', 'C', 'r', 'e', 'A', 'm'], left = 0, right = 7
     * -----------------------------------------------------------------------------------------------------------------
     * left | right | textArray[left] | textArray[right] | Action Taken                         | textArray State
     * -----------------------------------------------------------------------------------------------------------------
     * 0    | 7     | 'I' (Vowel)     | 'm' (Not Vowel)  | Right not vowel -> right--           | ['I','c','e','C','r','e','A','m']
     * 0    | 6     | 'I' (Vowel)     | 'A' (Vowel)      | Both vowels -> SWAP 'I' & 'A',       | ['A','c','e','C','r','e','I','m']
     *      |       |                 |                  | left++, right--                      |
     * 1    | 5     | 'c' (Not Vowel) | 'e' (Vowel)      | Left not vowel -> left++             | ['A','c','e','C','r','e','I','m']
     * 2    | 5     | 'e' (Vowel)     | 'e' (Vowel)      | Both vowels -> SWAP 'e' & 'e',       | ['A','c','e','C','r','e','I','m']
     *      |       |                 |                  | left++, right--                      |
     * 3    | 4     | 'C' (Not Vowel) | 'r' (Not Vowel)  | Both not vowel -> left++, right--    | ['A','c','e','C','r','e','I','m']
     * 4    | 3     | Loop Terminates (left < right is 4 < 3 -> False)                                                     |
     * -----------------------------------------------------------------------------------------------------------------
     * Final Output: "AceCreIm"
     */
}
