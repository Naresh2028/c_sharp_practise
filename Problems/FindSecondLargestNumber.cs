using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts.Problems
{
    // Find the Second Largest Element in an Array

    // Write a C# method SecondLargest that takes an array of integers (int[] numbers) and returns the
    // second largest unique number in the array as a nullable integer (int?).
    public class FindSecondLargestNumber
    {
        // Input: [12, 35, 1, 10, 34, 1]
        // Output: 34
        public int? FindNumberUsingLoops(int[] numbers) 
        {
            if (numbers == null || numbers.Length < 2) 
            {
                return null;
            }

            int largestNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largestNumber) 
                {
                    largestNumber = numbers[i];
                }
            }

            int? secondLargestNumber = null;

            for (int j = 0; j < numbers.Length; j++) 
            {
                if (numbers[j] < largestNumber) 
                {
                    if (secondLargestNumber == null || secondLargestNumber < numbers[j])
                    {
                        secondLargestNumber = numbers[j];
                    }
                }
            }

            return secondLargestNumber;
        }
        /*
         * Dry Run Trace for Second Loop (largestNumber = 35)
         * Input: [12, 35, 1, 10, 34, 1]
         * -----------------------------------------------------------------------------------------
         * Index (j) | Current | Is < 35? (Filter 1)  | Is > secondLargest? (Filter 2) | secondLargest
         * -----------------------------------------------------------------------------------------
         * 0         | 12      | Yes (12 < 35)        | Yes (secondLargest is null)    | 12
         * 1         | 35      | No  (35 < 35 false)  | Skipped                        | 12
         * 2         | 1       | Yes (1 < 35)         | No  (1 > 12 is false)          | 12
         * 3         | 10      | Yes (10 < 35)        | No  (10 > 12 is false)         | 12
         * 4         | 34      | Yes (34 < 35)        | Yes (34 > 12 is true)          | 34
         * 5         | 1       | Yes (1 < 35)         | No  (1 > 34 is false)          | 34
         * -----------------------------------------------------------------------------------------
         * Final Output: 34
         */

    }
}
