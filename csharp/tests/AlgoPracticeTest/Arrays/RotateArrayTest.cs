using AlgoPractice.Arrays;
using TUnit.Assertions.Enums;

namespace AlgoPracticeTest.Arrays;

public class RotateArrayTest
{
    [Test]
    [Arguments(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new[] { 5, 6, 7, 1, 2, 3, 4 })]
    [Arguments(new[] { -1, -100, 3, 99 }, 2, new[] { 3, 99, -1, -100 })]
    [Arguments(new[] { 1, 2 }, 3, new[] { 2, 1 })]
    public async Task TestRotateArray(int[] nums, int k, int[] expectedResult)
    {
        RotateArray.Rotate(nums, k);
        await Assert.That(nums).IsEquivalentTo(expectedResult, CollectionOrdering.Matching);
    }
}
