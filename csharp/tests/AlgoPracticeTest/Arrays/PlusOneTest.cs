using AlgoPractice.Arrays;
using TUnit.Assertions.Enums;

namespace AlgoPracticeTest.Arrays;

public class PlusOneTest
{
    [Test]
    [Arguments(new[] { 1, 2, 3 }, new[] { 1, 2, 4 })]
    [Arguments(new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 2 })]
    [Arguments(new[] { 9 }, new[] { 1, 0 })]
    [Arguments(new[] { 3, 9, 9 }, new[] { 4, 0, 0 })]
    [Arguments(new[] { 2, 3, 9, 9 }, new[] { 2, 4, 0, 0 })]
    public async Task TestPlusOne(int[] nums, int[] expectedResult)
    {
        var result = PlusOneSolution.PlusOne(nums);
        await Assert.That(result).IsEquivalentTo(expectedResult, CollectionOrdering.Matching);
    }
}
