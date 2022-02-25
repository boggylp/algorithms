using Xunit;
using AlgoPractice.Arrays;
using System;

namespace AlgoPracticeTest.Arrays;

public class SingleNumberTest
{
    [Theory]
    [InlineData(new int[] { 2, 2, 1 }, 1)]
    [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
    [InlineData(new int[] { 1 }, 1)]
    [InlineData(new int[] { 1, 8, 3, 7, 8, 1, 3 }, 7)]
    public void TestSingleNumner(int[] nums, int expectedResult)
    {
        var algo = new SingleNumberSolution();
        var result = algo.SingleNumber(nums);
        Assert.Equal(expectedResult, result);
    }
}