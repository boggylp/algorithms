using System;
using System.Linq;
using AlgoPractice.Arrays;

namespace AlgoPracticeTest.Arrays;

public class ArrayIntersectionTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }, new int[] { 2, 2 })]
    [InlineData(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, new int[] { 4, 9 })]
    public void TestIntersect(int[] nums1, int[] nums2, int[] expectedResult)
    {
        var algo = new ArrayIntersection();
        var result = ArrayIntersection.Intersect(nums1, nums2);
        Assert.True(expectedResult.All(er => result.Contains(er)));
        Assert.Equal(expectedResult.Length, result.Length);
    }
}
