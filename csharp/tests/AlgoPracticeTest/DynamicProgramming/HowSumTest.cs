using AlgoPractice.DynamicProgramming;

namespace AlgoPracticeTest.DynamicProgramming;

public sealed class HowSumTest
{
    [Test]
    [Arguments(7, new[] { 5, 3, 4, 7 }, new[] { 3, 4 })]
    [Arguments(8, new[] { 2, 3, 5 }, new[] { 2, 2, 2, 2 })]
    public async Task ValidHappyFlow(int targetSum, int[] numbers, int[] expectedResult)
    {
        var result = HowSum.Run(targetSum, numbers);
        await Assert.That(result).IsEquivalentTo(expectedResult);
    }

    [Test]
    [Arguments(7, new[] { 2, 4 })]
    [Arguments(300, new[] { 7, 14 })]
    public async Task NoCombination(int targetSum, int[] numbers)
    {
        var result = HowSum.Run(targetSum, numbers);
        await Assert.That(result).IsNull();
    }
}
