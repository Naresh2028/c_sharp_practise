using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts.Problems
{
    // Given an array of integers (numbers) and an integer target, find the indices of the
    // two numbers in the array that add up to the target.
    public class TwoSum
    {
        // Basic for loop
        // numbers = [2, 7, 11, 15]
        // target = 9
        public int[] TwoSumUsingLoop(int[] numbers, int target) 
        {
            int[] result = [];

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target) 
                    {
                        result = new int[2];    
                        result[0] = i;          
                        result[1] = j;          
                        
                        return result;          
                    }
                }
            }

            return result;
            
        }
        /*
         * Dry Run Trace 2: Full Loop Walkthrough (target = 26)
         * Input: [2, 7, 11, 15]
         * -----------------------------------------------------------------------------------------
         * i | numbers[i] | j | numbers[j] | Sum (i + j)   | Is == 26? (Condition) | result
         * -----------------------------------------------------------------------------------------
         * 0 | 2          | 1 | 7          | 2 + 7 = 9     | No  (9 == 26 false)   | []
         * 0 | 2          | 2 | 11         | 2 + 11 = 13   | No  (13 == 26 false)  | []
         * 0 | 2          | 3 | 15         | 2 + 15 = 17   | No  (17 == 26 false)  | []
         * 1 | 7          | 2 | 11         | 7 + 11 = 18   | No  (18 == 26 false)  | []
         * 1 | 7          | 3 | 15         | 7 + 15 = 22   | No  (22 == 26 false)  | []
         * 2 | 11         | 3 | 15         | 11 + 15 = 26  | Yes (26 == 26 true)   | [2, 3] -> RETURN
         * -----------------------------------------------------------------------------------------
         * Final Output: [2, 3]
         */
    }
}
