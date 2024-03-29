﻿namespace AlgoPractice.Arrays;

public static class RemoveDuplicatesFromSorted
{
    /// <summary>
    /// Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.
    /// The relative order of the elements should be kept the same.
    /// Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums.
    /// More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result.
    /// It does not matter what you leave beyond the first k elements.
    /// Return k after placing the final result in the first k slots of nums.
    /// Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.
    ///
    /// Example 1:
    ///Input: nums = [1,1,2]
    ///Output: 2, nums = [1,2, _]
    ///Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
    ///It does not matter what you leave beyond the returned k(hence they are underscores).
    ///
    /// Example 2:
    /// Input: nums = [0,0,1,1,1,2,2,3,3,4]
    /// Output: 5, nums = [0,1,2,3,4, _, _, _, _, _]
    /// Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
    /// It does not matter what you leave beyond the returned k(hence they are underscores).
    /// </summary>
    /// <param name="nums">Array of numbers</param>
    ///
    /// Constraints:
    /// 0 <= nums.length <= 3 * 104
    /// -100 <= nums[i] <= 100
    /// nums is sorted in non-decreasing order.
    ///
    /// <returns>Array without duplicates</returns>
    public static int RemoveDuplicates(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }
        if (nums.Length == 1)
        {
            return 1;
        }

        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == int.MinValue)
            {
                continue;
            }

            result++;

            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] == nums[i])
                {
                    nums[j] = int.MinValue;
                }
                else if (nums[j] != int.MinValue && nums[i + 1] == int.MinValue)
                {
                    nums[i + 1] = nums[j];
                    nums[j] = int.MinValue;
                    break;
                }
            }
        }

        return result;
    }
}
