using AlgoPractice.DynamicProgramming;

namespace AlgoPracticeTest.DynamicProgramming;

public sealed class HowSumTest
{
    [Theory]
    [InlineData(7, new[] { 5, 3, 4, 7 }, new[] { 3, 4 })]
    [InlineData(7, new[] { 2, 4 }, null)]
    [InlineData(8, new[] { 2, 3, 5 }, new[] { 2, 2, 2, 2 })]
    [InlineData(300, new[] { 7, 14 }, null)]
    public void ValidHappyFlow(int targetSum, int[] numbers, int[]? expectedResult)
    {
        var result = HowSum.Run(targetSum, numbers);
        Assert.Equivalent(expectedResult, result);
    }
}
