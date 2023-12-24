namespace AlgoPractice.Arrays;

public class MoveZeroesSolution
{
    /// <summary>
    /// Given an integer array nums, move all 0's to the end of it 
    /// while maintaining the relative order of the non-zero elements.
    /// Note that you must do this in-place without making a copy of the array.
    /// 
    /// Example 1:
    /// Input: nums = [0,1,0,3,12]
    /// Input: nums = [1,0,4,3,12]
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
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0 && zeroIndex < 0 || (zeroIndex >= 0 && nums[zeroIndex] != 0))
            {
                zeroIndex = i;
            }
            else if (zeroIndex < i && zeroIndex >= 0 && nums[i] != 0)
            {
                nums[zeroIndex] = nums[i];
                nums[i] = 0;
                zeroIndex++;
            }
        }
    }
}
