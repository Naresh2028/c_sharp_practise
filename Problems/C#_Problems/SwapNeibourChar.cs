using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts.Problems
{
    /// <summary>
    /// Question: Given a string text, swap every two adjacent (neighboring) characters in pairs and return the newly formed string. 
    /// If the string has an odd number of characters, leave the last character in its original place. 
    /// </summary>
    public static class SwapNeibourChar
    {

        public static string SwapNeibourChars(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            char[] charCount = text.ToCharArray();
            char temp;

            for (int i = 0; i < charCount.Length - 1; i += 2) 
            {
                temp = charCount[i];
                charCount[i] = charCount[i + 1];
                charCount[i + 1] = temp;
            }
            return new string(charCount);
        }
    }
    /*
     * Dry Run Trace: Swap Neighbor Characters (Odd Length Example)
     * Input: text = "abcde"
     * Init:  charCount = ['a', 'b', 'c', 'd', 'e'] (Length = 5, Loop condition: i < 4)
     * -----------------------------------------------------------------------------------------------
     * i | Condition (i < 4) | Pair Swapped (i & i+1) | temp | charCount Array State      | Next i (i+=2)
     * -----------------------------------------------------------------------------------------------
     * 0 | 0 < 4 (True)      | 'a' and 'b'            | 'a'  | ['b', 'a', 'c', 'd', 'e']  | 2
     * 2 | 2 < 4 (True)      | 'c' and 'd'            | 'c'  | ['b', 'a', 'd', 'c', 'e']  | 4
     * 4 | 4 < 4 (False)     | Loop Terminates ('e' stays untouched)                                 | -
     * -----------------------------------------------------------------------------------------------
     * Final Output: "badce"
     */
}
