using Xunit;
using AlgoPractice.Arrays;
using System;

namespace AlgoPracticeTest.Arrays;

public class RotateArrayTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
    [InlineData(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
    [InlineData(new int[] { 1, 2 }, 3, new int[] { 2, 1 })]
    public void TestRotateArray(int[] nums, int k, int[] expectedResult)
    {
        RotateArray.Rotate(nums, k);
        Assert.Equal(expectedResult, nums);
    }
}