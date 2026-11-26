using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts.Problems.C__Problems
{

    /// <summary>
    /// Problem:
    /// Given an array nums containing n distinct numbers taken from the range 1 to n + 1 (or 0 to n),
    /// return the only number in the range that is missing from the array.
    /// 
    /// Example 1: Input: [1, 2, 4, 5] → Output: 3
    /// Example 2: Input: [3, 0, 1] → Output: 2 
    /// </summary>
    public class FindMissingNumber
    {
        public void Mains() 
        {
            int[] num = [1,2,3,5];

            FindMissingNumbers(num);
        }
        public int? FindMissingNumbers(int[] numbers) 
        {
            if (numbers == null || numbers.Length == 0) 
            {
                return null;
            }

            int actualSum = 0;

            int totalExpectedCount = numbers.Length;

            /// • Starts at 1 ([1, 2, 4, 5]): Use int n = numbers.Length + 1;
            /// • Starts at 0 ([3, 0, 1]): Use int n = numbers.Length;
            
            int totalExpectedSum = totalExpectedCount * (totalExpectedCount + 1) / 2;

            foreach (int currentNumber in numbers) 
            {
                actualSum += currentNumber;
            }

            int missingNumber = totalExpectedSum - actualSum;

            return missingNumber;
        }
    }
    /*
     * Dry Run Trace: Find Missing Number (0-Based Range: 0 to numbers.Length)
     * Input: numbers = [3, 0, 1] (Length = 3)
     *
     * STEP 1: Calculate totalExpectedSum
     * - maxExpectedNumber = numbers.Length  ->  3
     * - totalExpectedSum  = maxExpectedNumber * (maxExpectedNumber + 1) / 2
     *                     = 3 * (3 + 1) / 2
     *                     = 3 * 4 / 2
     *                     = 12 / 2
     *                     = 6   (Expected sum of 0 + 1 + 2 + 3)
     *
     * STEP 2: Calculate actualSum (Init: actualSum = 0)
     * -------------------------------------------------------------------
     * Step | currentNumber | actualSum += currentNumber | actualSum State
     * -------------------------------------------------------------------
     * 1    | 3             | 0 + 3                      | 3
     * 2    | 0             | 3 + 0                      | 3
     * 3    | 1             | 3 + 1                      | 4
     * -------------------------------------------------------------------
     * Result of Step 2 -> actualSum = 4
     *
     * STEP 3: Find Missing Number
     * - missingNumber = totalExpectedSum - actualSum
     *                 = 6 - 4
     *                 = 2
     *
     * Final Output: 2
     */

}
