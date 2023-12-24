using Xunit;
using AlgoPractice.Arrays;

namespace AlgoPracticeTest.Arrays;

public class TwoSumTest
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TestTwoSum(int[] nums, int target, int[] expectedResult)
    {
        var algo = new TwoSumSolution();
        var result = algo.TwoSum(nums, target);
        Assert.Equal(expectedResult, result);
    }
}