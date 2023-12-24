using Xunit;
using AlgoPractice;

namespace AlgoPracticeTest;

public class GoogleExampleTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 9 }, 8, null)]
    [InlineData(new int[] { 1, 2, 4, 4 }, 8, new int[] { 4, 4 })]
    [InlineData(new int[] { 1, 2, 4, 7 }, 8, new int[] { 1, 7 })]
    [InlineData(new int[] { 1, 2, 4, 7 }, 9, new int[] { 2, 7 })]
    public void TestPlusOne(int[] nums, int sum, int[] expectedResult)
    {
        var sln = new GoogleExample();
        var result = sln.FindSumOfPairs(nums, sum);
        Assert.Equal(expectedResult, result);
    }
}