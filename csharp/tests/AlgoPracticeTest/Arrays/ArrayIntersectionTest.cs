using AlgoPractice.Arrays;

namespace AlgoPracticeTest.Arrays;

public class ArrayIntersectionTest
{
    [Test]
    [Arguments(new[] { 1, 2, 2, 1 }, new[] { 2, 2 }, new[] { 2, 2 })]
    [Arguments(new[] { 4, 9, 5 }, new[] { 9, 4, 9, 8, 4 }, new[] { 4, 9 })]
    public async Task TestIntersect(int[] nums1, int[] nums2, int[] expectedResult)
    {
        var result = ArrayIntersection.Intersect(nums1, nums2);
        await Assert.That(expectedResult.All(er => result.Contains(er))).IsTrue();
        await Assert.That(result.Length).IsEqualTo(expectedResult.Length);
    }
}
