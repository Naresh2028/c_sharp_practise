using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts.Problems
{

    // Write a C# method IsBalanced that takes a string text as input and
    // determines whether the brackets inside the string are properly balanced and nested.
    public class BalanancedBrackets
    {
        // Input: "{[()]}"
        // Output: true

        public bool IsBalanced(string text) 
        {
            // Initial check
            if (text == null) 
            {
                return false;
            }

            Stack<char> expectedClosing = new Stack<char>();

            foreach (char item in text) 
            {

                if (item == '(')
                {
                    expectedClosing.Push(')');
                }
                else if (item == '[')
                {
                    expectedClosing.Push(']');
                }
                else if (item == '{')
                {
                    expectedClosing.Push('}');
                }
                else if (item == ')' || item == ']' || item == '}') 
                {
                    if (expectedClosing.Count == 0) 
                    {
                        return false;
                    }

                    char expectedChar = expectedClosing.Pop();

                    if (item != expectedChar) 
                    {
                        return false;
                    }
                }
            }

            if (expectedClosing.Count == 0) 
            {
                return true;
            }

            return false;
        }

     /*
     * =========================================================================================
     * DEBUG TRACE EXAMPLE: text = "{[()]}"
     * =========================================================================================
     * Iteration | item | Action Taken      | Stack (Top -> Bottom) | item != expectedChar Check
     * -----------------------------------------------------------------------------------------
     * 1         | '{'  | Push '}'          | }                     | Skipped (opening)
     * 2         | '['  | Push ']'          | ], }                  | Skipped (opening)
     * 3         | '('  | Push ')'          | ), ], }               | Skipped (opening)
     * 4         | ')'  | Pop ')' & compare | ], }                  | ')' != ')' -> False (Match!)
     * 5         | ']'  | Pop ']' & compare | }                     | ']' != ']' -> False (Match!)
     * 6         | '}'  | Pop '}' & compare | (Empty)               | '}' != '}' -> False (Match!)
     * -----------------------------------------------------------------------------------------
     * END OF LOOP: expectedClosing.Count == 0 -> Returns true!
     * =========================================================================================
     */
    }
}
