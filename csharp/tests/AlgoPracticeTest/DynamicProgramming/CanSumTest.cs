using AlgoPractice.DynamicProgramming;

namespace AlgoPracticeTest.DynamicProgramming;

public sealed class CanSumTest
{
    [Theory]
    [InlineData(7, new[] { 5, 3, 4, 7 }, true)]
    [InlineData(7, new[] { 2, 4 }, false)]
    [InlineData(8, new[] { 2, 3, 5 }, true)]
    [InlineData(300, new[] { 7, 14 }, false)]
    public void ValidHappyFlow(int targetSum, int[] numbers, bool expectedResult)
    {
        var result = CanSum.Run(targetSum, numbers);
        Assert.Equal(expectedResult, result);
    }
}
