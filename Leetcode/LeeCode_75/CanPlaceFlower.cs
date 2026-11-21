using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts.Leetcode.LeeCode_75
{
    /// <summary>
    /// 605. Can Place Flowers
    /// You have a long flowerbed in which some of the plots are planted, and some are not. However, 
    /// flowers cannot be planted in adjacent plots.
    /// Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and 
    /// an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent
    /// - flowers rule and false otherwise.
    /// </summary>
    public static class CanPlaceFlower
    {
        static void Mains() 
        {
            int[] input = [1, 0, 0, 0, 1];
            int n = 2;

            CanPlaceFlowers(input, n);
        }

        static bool CanPlaceFlowers(int[] input, int n) 
        {
            // Edge case: if no flowers need to be planted, return true immediately
            if (n == 0)
            {
                return true;
            }

            for (int i = 0; i < input.Length; i++)
            {
                // 1. Current plot vacant check (Gatekeeper)
                if (input[i] == 0) 
                {
                    bool isAtStart = false;
                    bool isAtEnd = false;
                    bool isLeftEmpty = false;
                    bool isRightEmpty = false;

                    if (i == 0)
                    {
                        isAtStart = true;
                    }


                    if (i == input.Length - 1)
                    {
                        isAtEnd = true;
                    }

                    // Left neighbor check
                    if (isAtStart)
                    {
                        isLeftEmpty = true;
                    }
                    else if (input[i - 1] == 0)
                    {
                        isLeftEmpty = true;
                    }

                    // Right neighbor check
                    if (isAtEnd)
                    {
                        isRightEmpty = true;
                    }
                    else if (input[i + 1] == 0)
                    {
                        isRightEmpty = true;
                    }


                    if (isLeftEmpty && isRightEmpty)
                    {
                        input[i] = 1;  // Mark current plot as planted

                        n--;        // Reduce remaining flowers needed
                    }

                    // Stop early as soon as all 'n' flowers are planted
                    if (n == 0)
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }
    }
    /*
     * Dry Run Trace: Can Place Flowers (LeetCode 605)
     * Input: input =[1,0,0,0,1] n = 2
     * -----------------------------------------------------------------------------------------------------------------
     * i | input[i] | isAtStart | isAtEnd | isLeftEmpty | isRightEmpty | Planted? | input State     | Remaining n
     * -----------------------------------------------------------------------------------------------------------------
     * 0 | 1        | -         | -       | -           | -            | Skip (1) | [1, 0, 0, 0, 1] | 2
     * 1 | 0        | false     | false   | false (L=1) | true  (R=0)  | No       | [1, 0, 0, 0, 1] | 2
     * 2 | 0        | false     | false   | true  (L=0) | true  (R=0)  | Yes (1)  | [1, 0, 1, 0, 1] | 1
     * 3 | 0        | false     | false   | false (L=1) | false (R=1)  | No       | [1, 0, 1, 0, 1] | 1
     * 4 | 1        | -         | -       | -           | -            | Skip (1) | [1, 0, 1, 0, 1] | 1
     * -----------------------------------------------------------------------------------------------------------------
     * Loop Ends: n is still 1 (n != 0) -> Final Output: false
     */
}
