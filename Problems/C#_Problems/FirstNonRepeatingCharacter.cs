using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts.Problems
{

    public static class FirstNonRepeatingCharacter
    {
        // FindFirstNonRepeatingChar("swiss") // True
        // FindFirstNonRepeatingChar("aabbcc") // False
        public static char? FindFirstNonRepeatingChar(string text) 
        {
            if (!string.IsNullOrEmpty(text)) 
            {
                return null;
            }

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Pass 1: Count character frequencies
            foreach (char item in text) 
            {
                if (charCount.ContainsKey(item))
                {
                    charCount[item] = charCount[item] + 1;
                }
                else 
                {
                    charCount[item] = 1;
                }
            }

            // Pass 2: Find the first character with a count of 1
            foreach (char item in text) 
            {
                if (charCount[item] == 1) 
                {
                    return item;
                }
            }

            return null;
        }
    }

    /*
    ====================================================================================================
    PASS 1: COUNTING CHARACTER FREQUENCIES (Input: "swiss")
    ====================================================================================================
    Step | Current c | ContainsKey(c)? | Action Taken               | charCounts State After Step
    -----+-----------+-----------------+----------------------------+-----------------------------------
    1    | 's'       | false           | Adds 's' with value 1      | { 's': 1 }
    2    | 'w'       | false           | Adds 'w' with value 1      | { 's': 1, 'w': 1 }
    3    | 'i'       | false           | Adds 'i' with value 1      | { 's': 1, 'w': 1, 'i': 1 }
    4    | 's'       | true            | Increments 's' (1 + 1)     | { 's': 2, 'w': 1, 'i': 1 }
    5    | 's'       | true            | Increments 's' (2 + 1)     | { 's': 3, 'w': 1, 'i': 1 }
    ====================================================================================================
    */

}
