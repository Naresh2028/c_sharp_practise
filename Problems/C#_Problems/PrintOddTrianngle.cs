using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts.Problems.C__Problems
{
    /// <summary>
    /// Given a positive integer n representing the number of rows in a triangular number pattern, 
    /// where the 1st row contains the first odd number (1), the 2nd row contains the next two 
    /// consecutive odd numbers (3, 5), the 3rd row contains the next three (7, 9, 11), and so on.
    /// 
    /// Print all the odd numbers belonging to the first n rows on a single line, separated by spaces.
    /// Note: Your solution must use an instance method rather than a static helper method.
    /// 
    /// </summary>
    /// <param name="n">The number of rows to include from the odd-number triangle.</param>
    /// <example>
    /// Input: n = 3
    /// Output: 1 3 5 7 9 11
    /// Explanation: 
    /// Row 1: 1
    /// Row 2: 3 5
    /// Row 3: 7 9 11
    /// Combining the first 3 rows gives: 1 3 5 7 9 11.
    /// </example>

    public class PrintOddTrianngle
    {
        public void PrintOddTriangle(int n)
        {
            int currentValue = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.WriteLine($"{currentValue} ");
                    currentValue += 2;
                }
            }

            Console.WriteLine();
        }
    }
    /*
     * =========================================================================================
     * DEBUG TRACE EXAMPLE: n = 3 (Initial: currentValue = 1)
     * =========================================================================================
     * Row | Column | column <= row Check | Console Output | currentValue += 2 (Next Value)
     * -----------------------------------------------------------------------------------------
     * 1   | 1      | 1 <= 1 -> True      | "1 "           | 1 + 2 = 3
     * 1   | 2      | 2 <= 1 -> False     | (Exit Inner)   | 3
     * -----------------------------------------------------------------------------------------
     * 2   | 1      | 1 <= 2 -> True      | "3 "           | 3 + 2 = 5
     * 2   | 2      | 2 <= 2 -> True      | "5 "           | 5 + 2 = 7
     * 2   | 3      | 3 <= 2 -> False     | (Exit Inner)   | 7
     * -----------------------------------------------------------------------------------------
     * 3   | 1      | 1 <= 3 -> True      | "7 "           | 7 + 2 = 9
     * 3   | 2      | 2 <= 3 -> True      | "9 "           | 9 + 2 = 11
     * 3   | 3      | 3 <= 3 -> True      | "11 "          | 11 + 2 = 13
     * 3   | 4      | 4 <= 3 -> False     | (Exit Inner)   | 13
     * -----------------------------------------------------------------------------------------
     * END OF OUTER LOOP (row = 4 > 3): Prints newline -> Final Output: "1 3 5 7 9 11 "
     * =========================================================================================
     */

}
