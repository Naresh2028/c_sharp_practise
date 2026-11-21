using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_Sharp_Concepts.Leetcode.LeeCode_75
{

    /// <summary>
    /// There are n kids with candies. You are given an integer array candies, where each candies[i] represents the 
    /// number of candies the ith kid has, and an integer extraCandies, denoting the number of extra candies that you have.
    /// Return a boolean array result of length n, where result[i] is true if, after giving the ith kid all 
    /// the extraCandies, they will have the greatest number of candies among all the kids, or false otherwise.
    /// Note that multiple kids can have the greatest number of candies.
    /// </summary>
    public static class KidsWithCandies
    {
        public static void Mains() 
        {

            int[] candies = { 2, 3, 5, 1, 3 };
            int extraCandies = 3;

            KidsWithCandy(candies, extraCandies);
        }

        public static IList<bool> KidsWithCandy(int[] candies, int extraCandies) 
        {
            // Step 1: Find the highest number of candies among kid
            int maxNumber = 0;

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] > maxNumber) 
                {
                    maxNumber = candies[i];
                }
            }

            IList<bool> result = new List<bool>();

            // Step 2: Check each kid with the extraCandies added
            for (int j = 0; j < candies.Length ; j++)
            {
                if (candies[j] + extraCandies >= maxNumber)
                {
                    result.Add(true);
                }
                else 
                {
                    result.Add(false);
                }
            }

            return result;
        }
        /*
         * Dry Run Trace: Kids With the Greatest Number of Candies (LeetCode 1431)
         * Input: candies =, extraCandies = 3
         * Step 1 Result: maxCandies = 5 (Highest value in candies array)
         * ---------------------------------------------------------------------------------------------------------
         * i | candies[i] | Total (candies[i] + 3) | Total >= 5? (Condition) | result List State
         * ---------------------------------------------------------------------------------------------------------
         * 0 | 2          | 2 + 3 = 5              | Yes (5 >= 5 is true)    | [true]
         * 1 | 3          | 3 + 3 = 6              | Yes (6 >= 5 is true)    | [true, true]
         * 2 | 5          | 5 + 3 = 8              | Yes (8 >= 5 is true)    | [true, true, true]
         * 3 | 1          | 1 + 3 = 4              | No  (4 >= 5 is false)   | [true, true, true, false]
         * 4 | 3          | 3 + 3 = 6              | Yes (6 >= 5 is true)    | [true, true, true, false, true]
         * ---------------------------------------------------------------------------------------------------------
         * Final Output: [true, true, true, false, true]
         */

    }
}
