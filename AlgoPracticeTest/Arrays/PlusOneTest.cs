using Xunit;
using AlgoPractice.Arrays;

namespace AlgoPracticeTest.Arrays;

public class PlusOneTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
    [InlineData(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
    [InlineData(new int[] { 9 }, new int[] { 1, 0 })]
    [InlineData(new int[] { 3, 9, 9 }, new int[] { 4, 0, 0 })]
    [InlineData(new int[] { 2, 3, 9, 9 }, new int[] { 2, 4, 0, 0 })]
    public void TestPlusOne(int[] nums, int[] expectedResult)
    {
        var sln = new PlusOneSolution();
        var result = sln.PlusOne(nums);
        Assert.Equal(expectedResult, result);
    }
}