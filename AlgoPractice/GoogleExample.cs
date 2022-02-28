using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractice
{
    public class GoogleExample
    {
        /// <summary>
        /// For given SORTED ASC array of nums, return pair which gives the given sum.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public int[] FindSumOfPairs(int[] nums, int sum)
        {
            if (nums == null || nums.Length == 0)
                return null;

            int i = 0;
            int j = nums.Length - 1;
            while (i != j && i < nums.Length && j >= 0)
            {
                int currentSum = nums[i] + nums[j];
                if (currentSum > sum)
                {
                    j--;
                }
                if (currentSum < sum)
                {
                    i++;
                }
                if (currentSum == sum)
                {
                    return new int[] { nums[i], nums[j] };
                }
            }

            return null;
        }
    }
}
