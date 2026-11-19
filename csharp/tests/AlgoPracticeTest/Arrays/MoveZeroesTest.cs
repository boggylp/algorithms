using AlgoPractice.Arrays;
using TUnit.Assertions.Enums;

namespace AlgoPracticeTest.Arrays;

public class MoveZeroesTest
{
    [Test]
    [Arguments(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0 })]
    [Arguments(new[] { 0 }, new[] { 0 })]
    [Arguments(new[] { 0, 0, 3, 0, 0, 10, 0, 4 }, new[] { 3, 10, 4, 0, 0, 0, 0, 0 })]
    [Arguments(new[] { 1 }, new[] { 1 })]
    public async Task TestMoveZeroes(int[] nums, int[] expectedResult)
    {
        MoveZeroesSolution.MoveZeroes(nums);
        await Assert.That(nums).IsEquivalentTo(expectedResult, CollectionOrdering.Matching);
    }
}
