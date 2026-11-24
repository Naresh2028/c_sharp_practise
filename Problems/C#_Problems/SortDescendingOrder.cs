using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts.Problems
{
    /// <summary>
    /// Question: Given an array of integers numbers, sort the elements in descending order (from largest to smallest) 
    /// in-place without using built-in sorting functions like Array.Sort(), and return the sorted array.
    /// </summary>
    public static class SortDescendingOrder
    {
        public static int[] SortDescendingOrders(int[] numbers) 
        {
            int n = numbers.Length;
            int temp = 0;

            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] < numbers[j+1]) 
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }

            return numbers;
        }
    }
    /*
     * Dry Run Trace: Bubble Sort (Descending Order)
     * Input: numbers = [3, 1, 4, 2] (n = 4)
     * -------------------------------------------------------------------------------------------------------------
     * i | j | Compare (j vs j+1) | numbers[j] < numbers[j+1]? | Action Taken       | swapped | Array State
     * -------------------------------------------------------------------------------------------------------------
     * 0 | 0 | 3 vs 1             | False (3 < 1 is false)     | No Swap            | false   | [3, 1, 4, 2]
     * 0 | 1 | 1 vs 4             | True  (1 < 4 is true)      | Swap 1 and 4       | true    | [3, 4, 1, 2]
     * 0 | 2 | 1 vs 2             | True  (1 < 2 is true)      | Swap 1 and 2       | true    | [3, 4, 2, 1]
     *   |   | [End of Pass i=0: swapped is true, continue]                                                    |
     * -------------------------------------------------------------------------------------------------------------
     * 1 | 0 | 3 vs 4             | True  (3 < 4 is true)      | Swap 3 and 4       | true    | [4, 3, 2, 1]
     * 1 | 1 | 3 vs 2             | False (3 < 2 is false)     | No Swap            | true    | [4, 3, 2, 1]
     *   |   | [End of Pass i=1: swapped is true, continue]                                                    |
     * -------------------------------------------------------------------------------------------------------------
     * 2 | 0 | 4 vs 3             | False (4 < 3 is false)     | No Swap            | false   | [4, 3, 2, 1]
     *   |   | [End of Pass i=2: !swapped is true -> BREAK EARLY]                                                |
     * -------------------------------------------------------------------------------------------------------------
     * Final Output: [4, 3, 2, 1]
     */

}
