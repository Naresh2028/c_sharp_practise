using C_Sharp_Concepts.Leetcode.LeeCode_75;
using C_Sharp_Concepts.Problems.C__Problems;

namespace C_Sharp_Concepts_And_OOP
{
    public class Program
    {        
        static void Main(string[] args)
        {
            FindMissingNumber obj = new FindMissingNumber();

            int[] num = [3,0,1];

            Console.WriteLine(obj.FindMissingNumbers(num));
            Console.ReadLine();
            
        }

    }


    
}
