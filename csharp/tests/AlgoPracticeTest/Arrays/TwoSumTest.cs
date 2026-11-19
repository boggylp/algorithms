using AlgoPractice.Arrays;
using TUnit.Assertions.Enums;

namespace AlgoPracticeTest.Arrays;

public class TwoSumTest
{
    [Test]
    [Arguments(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [Arguments(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [Arguments(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    public async Task TestTwoSum(int[] nums, int target, int[] expectedResult)
    {
        var result = TwoSumSolution.TwoSum(nums, target);
        await Assert.That(result).IsEquivalentTo(expectedResult, CollectionOrdering.Matching);
    }
}
