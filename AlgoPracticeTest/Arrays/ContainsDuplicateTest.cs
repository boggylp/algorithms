using Xunit;
using AlgoPractice.Arrays;
using System;

namespace AlgoPracticeTest.Arrays;

public class ContainsDuplicateTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    public void TestContainsDuplicate(int[] nums, bool expectedResult)
    {
        var algo = new ContainsDuplicateSolution();
        var result = algo.ContainsDuplicate(nums);
        Assert.Equal(expectedResult, result);
    }
}