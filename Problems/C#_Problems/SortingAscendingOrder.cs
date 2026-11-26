using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts.Problems.C__Problems
{
    public class SortingAscendingOrder
    {
        /// <summary>
        /// Problem: Given an array of integers numbers, sort the elements in ascending order (from smallest to largest) 
        /// in-place without using built-in sorting functions like Array.Sort(), and return the sorted array.
        /// </summary>
        public void Main() 
        {
            int[] nums = { 5, 3, 8, 4, 2 };
            int[] sorted = SortAscending(nums);

            Console.WriteLine(string.Join(", ", sorted)); // Output: 2, 3, 4, 5, 8
        }

        public static int[] SortAscending(int[] input) 
        {
            if (input == null || input.Length <= 1)
            {
                return input;
            }

            for (int i = 0; i < input.Length - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < input.Length - 1; j++)
                {
                    if (input[j] > input[j + 1]) 
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
            return input;

        }
        /*
         * Dry Run Trace: Bubble Sort (Ascending Order)
         * Input: input = { 5, 3, 8, 4, 2 } (Length = 5)
         *
         * PASS 1 (i = 0, j runs from 0 to 3): Bubbles largest element (8) to index 4
         * ---------------------------------------------------------------------------------
         * j | Compare (input[j] > input[j+1]) | Action              | Array State
         * ---------------------------------------------------------------------------------
         * 0 | 5 > 3 (True)                    | Swap(5, 3)          | { 3, 5, 8, 4, 2 }
         * 1 | 5 > 8 (False)                   | No Swap             | { 3, 5, 8, 4, 2 }
         * 2 | 8 > 4 (True)                    | Swap(8, 4)          | { 3, 5, 4, 8, 2 }
         * 3 | 8 > 2 (True)                    | Swap(8, 2)          | { 3, 5, 4, 2, 8 }
         * ---------------------------------------------------------------------------------
         * End of Pass 1 -> swapped = true | Locked: [8]
         *
         * PASS 2 (i = 1, j runs from 0 to 2): Bubbles next largest (5) to index 3
         * ---------------------------------------------------------------------------------
         * j | Compare (input[j] > input[j+1]) | Action              | Array State
         * ---------------------------------------------------------------------------------
         * 0 | 3 > 5 (False)                   | No Swap             | { 3, 5, 4, 2, 8 }
         * 1 | 5 > 4 (True)                    | Swap(5, 4)          | { 3, 4, 5, 2, 8 }
         * 2 | 5 > 2 (True)                    | Swap(5, 2)          | { 3, 4, 2, 5, 8 }
         * ---------------------------------------------------------------------------------
         * End of Pass 2 -> swapped = true | Locked: [5, 8]
         *
         * PASS 3 (i = 2, j runs from 0 to 1): Bubbles next largest (4) to index 2
         * ---------------------------------------------------------------------------------
         * j | Compare (input[j] > input[j+1]) | Action              | Array State
         * ---------------------------------------------------------------------------------
         * 0 | 3 > 4 (False)                   | No Swap             | { 3, 4, 2, 5, 8 }
         * 1 | 4 > 2 (True)                    | Swap(4, 2)          | { 3, 2, 4, 5, 8 }
         * ---------------------------------------------------------------------------------
         * End of Pass 3 -> swapped = true | Locked: [4, 5, 8]
         *
         * PASS 4 (i = 3, j runs 0 to 0): Bubbles next largest (3) to index 1
         * ---------------------------------------------------------------------------------
         * j | Compare (input[j] > input[j+1]) | Action              | Array State
         * ---------------------------------------------------------------------------------
         * 0 | 3 > 2 (True)                    | Swap(3, 2)          | { 2, 3, 4, 5, 8 }
         * ---------------------------------------------------------------------------------
         * End of Pass 4 -> swapped = true | Locked: [2, 3, 4, 5, 8]
         *
         * Final Output: { 2, 3, 4, 5, 8 }
         */

    }
}
