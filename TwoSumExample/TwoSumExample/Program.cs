
using System;

namespace TwoSumExample
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j <i; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { j, i }; // Return the indices
                    }
                }
            }
            return null; // If no pair is found (though problem states there will be one)
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            // Example input
            int[] nums = { 2, 7, 11, 15 };
            int target = 4;

            // Call the TwoSum method
            int[] result = solution.TwoSum(nums, target);

            // Output the result
            if (result != null)
            {
                Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
            }
            else
            {
                Console.WriteLine("No two sum solution found.");
            }

            // Keep the console window open
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
