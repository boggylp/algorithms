using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractice.Arrays
{
    /// <summary>
    /// Given an array, rotate the array to the right by k steps, where k is non-negative.
    /// </summary>
    public class RotateArray
    {
        /// <summary>
        /// Example 1:
        /// Input: nums = [1,2,3,4,5,6,7], k = 3
        /// Output: [5,6,7,1,2,3,4]
        /// Explanation:
        /// rotate 1 steps to the right: [7,1,2,3,4,5,6]
        /// rotate 2 steps to the right: [6,7,1,2,3,4,5]
        /// rotate 3 steps to the right: [5,6,7,1,2,3,4]
        /// Example 2:
        /// 
        /// Input: nums = [-1,-100,3,99], k = 2
        /// Output: [3,99,-1,-100]
        /// Explanation: 
        /// rotate 1 steps to the right: [99,-1,-100,3]
        /// rotate 2 steps to the right: [3,99,-1,-100]
        /// 
        /// Constraints:
        /// 1 <= nums.length <= 10^5
        /// -2^31 <= nums[i] <= 2^31 - 1
        /// 0 <= k <= 10^5
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static void Rotate(int[] nums, int k)
        {
            if (nums.Length <= 1)
                return;

            var shiftedArray = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                int newIndex = i + k;
                while(newIndex >= nums.Length)
                {
                    newIndex -= nums.Length;
                }

                shiftedArray[newIndex] = nums[i];
            }

            for(int i = 0; i < shiftedArray.Length; i++)
            {
                nums[i] = shiftedArray[i];
            }
        }
    }
}
