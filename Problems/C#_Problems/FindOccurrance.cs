using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace C_Sharp_Concepts.Problems
{
    public static class FindOccurrance
    {
        /// <summary>
        ///  Question: Given a string text, count how many times each character appears in the string and return the counts
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static Dictionary<char, int> FindOccurance(string text) 
        {
            Dictionary<char, int> resultCount = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (resultCount.ContainsKey(text[i]))
                {
                    resultCount[text[i]] += 1 ;
                }
                else 
                {
                    resultCount[text[i]] = 1;
                }
            }

            return resultCount;
        }

        /*
         * Dry Run Trace: Character Frequency Count
         * Input: text = "hello" (Length = 5)
         * Init:  resultCount = {} (Empty Dictionary)
         * -----------------------------------------------------------------------------------------
         * i | text[i] | ContainsKey(text[i])? | Action Taken              | resultCount State
         * -----------------------------------------------------------------------------------------
         * 0 | 'h'     | False                 | resultCount['h'] = 1      | {'h':1}
         * 1 | 'e'     | False                 | resultCount['e'] = 1      | {'h':1, 'e':1}
         * 2 | 'l'     | False                 | resultCount['l'] = 1      | {'h':1, 'e':1, 'l':1}
         * 3 | 'l'     | True                  | resultCount['l'] += 1     | {'h':1, 'e':1, 'l':2}
         * 4 | 'o'     | False                 | resultCount['o'] = 1      | {'h':1, 'e':1, 'l':2, 'o':1}
         * -----------------------------------------------------------------------------------------
         * Final Output: {'h': 1, 'e': 1, 'l': 2, 'o': 1}
         */

    }
}
