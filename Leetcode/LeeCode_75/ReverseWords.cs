using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_Sharp_Concepts.Leetcode.LeeCode_75
{
    /// <summary>
    /// 151. Reverse Words in a String
    /// Given an input string s, reverse the order of the words.
    /// A word is defined as a sequence of non-space characters.The words in s will be separated by at least one space.
    /// Return a string of the words in reverse order concatenated by a single space.
    /// Note that s may contain leading or trailing spaces or multiple spaces between 
    /// two words.The returned string should only have a single space separating the words. Do not include any extra spaces.
    /// </summary>
    public class ReverseWords
    {
        public string ReverseWord(string text) 
        {
            string[] splittedText = text.Split(" ");
            string result = string.Empty;

            for (int i = splittedText.Length - 1; i >= 0; i--)
            {
                if (splittedText[i] == "") 
                {
                    continue;
                }

                if (result.Length > 0) 
                { 
                    result += " ";
                }

                result += splittedText[i];
            }


            return result;
        }
    }
    /*
     * Dry Run Trace: Reverse Words in a String (LeetCode 151)
     * Input: s = "  hello   world  "
     * Step 1 Split: words = ["", "", "hello", "", "", "world", "", ""] (Length = 8)
     * Init: result = ""
     * ---------------------------------------------------------------------------------------------------------
     * i | words[i] | words[i] == ""? | result.Length > 0? (Space?) | Action Taken            | result State
     * ---------------------------------------------------------------------------------------------------------
     * 7 | ""       | True            | -                           | Skip (continue)         | ""
     * 6 | ""       | True            | -                           | Skip (continue)         | ""
     * 5 | "world"  | False           | False (Length = 0)          | Append "world"          | "world"
     * 4 | ""       | True            | -                           | Skip (continue)         | "world"
     * 3 | ""       | True            | -                           | Skip (continue)         | "world"
     * 2 | "hello"  | False           | True  (Length = 5 -> + " ") | Append " " + "hello"    | "world hello"
     * 1 | ""       | True            | -                           | Skip (continue)         | "world hello"
     * 0 | ""       | True            | -                           | Skip (continue)         | "world hello"
     * ---------------------------------------------------------------------------------------------------------
     * Final Output: "world hello"
     */
}
