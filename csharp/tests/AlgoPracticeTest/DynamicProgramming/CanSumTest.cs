using AlgoPractice.DynamicProgramming;

namespace AlgoPracticeTest.DynamicProgramming;

public sealed class CanSumTest
{
    [Test]
    [Arguments(7, new[] { 5, 3, 4, 7 }, true)]
    [Arguments(7, new[] { 2, 4 }, false)]
    [Arguments(8, new[] { 2, 3, 5 }, true)]
    [Arguments(300, new[] { 7, 14 }, false)]
    public async Task ValidHappyFlow(int targetSum, int[] numbers, bool expectedResult)
    {
        var result = CanSum.Run(targetSum, numbers);
        await Assert.That(result).IsEqualTo(expectedResult);
    }
}
