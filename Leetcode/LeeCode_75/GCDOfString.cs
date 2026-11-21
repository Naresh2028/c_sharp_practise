using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts.Leetcode.LeeCode_75
{
    /// <summary>
    /// QUESTION:
    /// For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t
    /// (i.e., t is concatenated with itself one or more times).
    /// Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.
    ///
    /// Example 1:
    /// Input: str1 = "ABCABC", str2 = "ABC"
    /// Output: "ABC"
    /// </summary>
    public static class GCDOfString
    {

        public static string FindGCDOfString(string str1, string str2) 
        {
            // Step 1: Verify if both strings are built from the same repeating pattern
            if (str1 + str2 != str2 + str1) 
            {
                return "";
            }

            string result = string.Empty;

            // Step 2: Get the shorter string's length, since the answer cannot be longer than the smaller string
            int length = Math.Min(str1.Length,str2.Length);

            for (int i = length; i >= 1; i--)
            {
                // Step 3: Check if size 'i' divides both lengths cleanly, then return that piece of str1
                if (str1.Length % i == 0 && str2.Length % i == 0) 
                {
                    result = str1.Substring(0,i);
                    break;
                }
            }

            return result;
        }

        /*
         * Dry Run Trace: Full Loop Walkthrough
         * Input: str1 = "ABABAB" (Length = 6), str2 = "ABAB" (Length = 4)
         * Step 1 Check: "ABABAB" + "ABAB" == "ABAB" + "ABABAB" -> True (Proceed)
         * Step 2 Init:  length = Math.Min(6, 4) -> 4
         * ---------------------------------------------------------------------------------------------------------
         * i | str1.Length % i == 0 | str2.Length % i == 0 | Both True? (Condition) | result
         * ---------------------------------------------------------------------------------------------------------
         * 4 | 6 % 4 == 2 (False)   | 4 % 4 == 0 (True)    | No  (False && True)    | ""
         * 3 | 6 % 3 == 0 (True)    | 4 % 3 == 1 (False)   | No  (True && False)    | ""
         * 2 | 6 % 2 == 0 (True)    | 4 % 2 == 0 (True)    | Yes (True && True)     | "AB" -> BREAK
         * ---------------------------------------------------------------------------------------------------------
         * Final Output: "AB"
         */
    }
}
