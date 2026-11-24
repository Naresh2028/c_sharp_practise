using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts.Leetcode.LeeCode_75
{

    /// <summary>
    /// Leetcode Question:
    /// Given an integer array nums, return an array answer such that answer[i] is equal to the product of 
    /// all the elements of nums except nums[i].
    /// 
    /// Translated Question: 
    /// You are given a list of whole numbers. Create and return a new list of the exact same length, 
    /// where each spot contains the result of multiplying all the other numbers from the original list together 
    /// (skipping the number currently in that spot).
    /// 
    /// Leetcode Question:
    /// You must write an algorithm that runs in O(n) time and without using the division operation.
    /// 
    /// Translated Question: 
    /// Your solution must walk straight through the list without using slow loops inside of loops, and 
    /// you are not allowed to use the divide (/) symbol anywhere in your code.
    /// </summary>
    public class ProductOfArray
    {
        public void Mains()
        {
            int[] nums = {1,2,3,4};
            ProductOfArrays(nums);
        }
        public int[] ProductOfArrays(int[] nums) 
        {
            int n = nums.Length;
            int[] answer = new int[n];

            // Fill every spot with 1 first so we can safely multiply (*=) from both ends
            Array.Fill(answer,1);

            int left = 0;
            int right = nums.Length - 1;

            int leftProduct = 1;
            int rightProduct = 1;

            while (left < n) 
            {
                answer[left] *= leftProduct;
                leftProduct *= nums[left];
                left++;

                answer[right] *= rightProduct;
                rightProduct *= nums[right];
                right--;
            }

            return answer;
        }
    }
    /*
     * Dry Run Trace: Product of Array Except Self (Single While Loop)
     * Input: nums = [1, 2, 3, 4] (Length = 4)
     * Init: answer =[0,0,0,0], left = 0, right = 3, leftProduct = 1, rightProduct = 1
     * -------------------------------------------------------------------------------------------------------------
     * Step | left | right | Left Action (answer[left] *= leftProd) | Right Action (answer[right] *= rightProd) | answer State
     * -------------------------------------------------------------------------------------------------------------
     * 1    | 0    | 3     | answer[0] *= 1 -> 1 (leftProd = 1)     | answer[3] *= 1 -> 1 (rightProd = 4)     | [1, 1, 1, 1]
     * 2    | 1    | 2     | answer[1] *= 1 -> 1 (leftProd = 2)     | answer[2] *= 4 -> 4 (rightProd = 12)    | [1, 1, 4, 1]
     * 3    | 2    | 1     | answer[2] *= 2 -> 8 (leftProd = 6)     | answer[1] *= 12 -> 12 (rightProd = 24)  | [1, 12, 8, 1]
     * 4    | 3    | 0     | answer[3] *= 6 -> 6 (leftProd = 24)    | answer[0] *= 24 -> 24 (rightProd = 24)  | [24, 12, 8, 6]
     * -------------------------------------------------------------------------------------------------------------
     * Loop ends when left == 4 (and right == -1)
     * Final Output: [24, 12, 8, 6]
     */

}
