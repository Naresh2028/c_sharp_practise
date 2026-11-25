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
         * Dry Run Trace: Two Sum - Basic Nested For Loop (LeetCode 1)
         * Input: numbers = [2, 7, 11, 15] (Length = 4), target = 9
         * Init: result = []
         * -----------------------------------------------------------------------------------------------------------------
         * Outer (i) | numbers[i] | Inner (j = i + 1) | numbers[j] | Sum (numbers[i] + numbers[j]) | Sum == 9? | Action Taken
         * -----------------------------------------------------------------------------------------------------------------
         * 0         | 2          | 1                 | 7          | 2 + 7 = 9                     | True      | result =, return immediately
         * -----------------------------------------------------------------------------------------------------------------
         * (Remaining iterations i = 0, j = 2..3 and i = 1..3 are skipped because method returns on first match)
         *
         * Final Output: [0, 1]
         */
    }
}
