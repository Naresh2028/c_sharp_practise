using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_Sharp_Concepts.Problems.C__Problems
{
    /// <summary>
    /// Problem: Find Most Frequent Character
    /// 
    /// Given a string input, find the character that appears the most number of times and return both the character
    /// and its frequency count formatted as "Character: <char>, Frequency: <count>".
    /// 
    /// Example: Input: "Hello well" → Output: "Character: l, Frequency: 4"
    /// </summary>
    public class FindHigestFrequencyChar
    {
        public void Mains() 
        {
            string text = "hello world";
            FindHighestFrequencyChars(text);
        }

        public Dictionary<char, int> FindHighestFrequencyChars(string text) 
        {

            if (string.IsNullOrEmpty(text)) 
            {
                return new Dictionary<char, int>();
            }

            Dictionary<char, int> result = new Dictionary<char, int>();

            int maxCount = 0;
            char highestFrequencyChar = '\0';

            foreach (char c in text) 
            {
                if (!result.ContainsKey(c))
                {
                    result[c] = 1;
                }
                else 
                {
                    result[c] += 1;
                }

                if (result[c] > maxCount) 
                {
                    maxCount = result[c];
                    highestFrequencyChar = c;
                }
            }

            return new Dictionary<char, int>() 
            {
                { highestFrequencyChar,maxCount}
            };
        }
    }

    /*
     * Dry Run Trace: Highest Frequency Character
     * Input: "Hello well" (Length = 10)
     * Init: freq = {}, maxChar = '\0', maxCount = 0
     * -----------------------------------------------------------------------------------------------------------------
     * Step | char (c) | freq.ContainsKey(c)? | Dictionary Action     | freq[c] | freq[c] > maxCount? | maxChar | maxCount
     * -----------------------------------------------------------------------------------------------------------------
     * 1    | 'H'      | False                | Add 'H' -> freq['H']=1| 1       | True (1 > 0)        | 'H'     | 1
     * 2    | 'e'      | False                | Add 'e' -> freq['e']=1| 1       | False (1 > 1)       | 'H'     | 1
     * 3    | 'l'      | False                | Add 'l' -> freq['l']=1| 1       | False (1 > 1)       | 'H'     | 1
     * 4    | 'l'      | True                 | Increment -> freq['l']| 2       | True (2 > 1)        | 'l'     | 2
     * 5    | 'o'      | False                | Add 'o' -> freq['o']=1| 1       | False (1 > 2)       | 'l'     | 2
     * 6    | ' '      | False                | Add ' ' -> freq[' ']=1| 1       | False (1 > 2)       | 'l'     | 2
     * 7    | 'w'      | False                | Add 'w' -> freq['w']=1| 1       | False (1 > 2)       | 'l'     | 2
     * 8    | 'e'      | True                 | Increment -> freq['e']| 2       | False (2 > 2)       | 'l'     | 2
     * 9    | 'l'      | True                 | Increment -> freq['l']| 3       | True (3 > 2)        | 'l'     | 3
     * 10   | 'l'      | True                 | Increment -> freq['l']| 4       | True (4 > 3)        | 'l'     | 4
     * -----------------------------------------------------------------------------------------------------------------
     * Final Output: Character: l, Frequency: 4
     */


}
