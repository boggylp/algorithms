﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractice.Arrays
{
    public class TwoSumSolution
    {
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can return the answer in any order.
        /// 
        /// Example 1:
        /// Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        /// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
        /// 
        /// Example 2:
        /// Input: nums = [3,2,4], target = 6
        /// Output: [1,2]
        /// 
        /// Example 3:
        /// Input: nums = [3,3], target = 6
        /// Output: [0,1]
        /// 
        /// Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            var values = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int missingNum = target - nums[i];
                if (values.ContainsKey(missingNum))
                {
                    return new int[] { values[missingNum], i };
                }
                else
                {
                    values[nums[i]] = i;
                }
            }

            return null;
        }
    }
}
