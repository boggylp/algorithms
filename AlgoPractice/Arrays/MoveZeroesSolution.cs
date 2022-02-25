using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractice.Arrays
{
    public class MoveZeroesSolution
    {
        /// <summary>
        /// Given an integer array nums, move all 0's to the end of it 
        /// while maintaining the relative order of the non-zero elements.
        /// Note that you must do this in-place without making a copy of the array.
        /// 
        /// Example 1:
        /// Input: nums = [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// 
        /// Example 2:
        /// Input: nums = [0]
        /// Output: [0]
        /// </summary>
        /// <param name="nums"></param>
        public void MoveZeroes(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return;

            int zeroIndex = -1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] != 0 && i > zeroIndex)
                {
                    zeroIndex = i;
                }
                else if (nums[i] == 0)
                {
                    nums[i] = nums[zeroIndex];
                    nums[zeroIndex] = 0;
                    zeroIndex--;
                }
                else
                {

                }
            }
        }
    }
}
