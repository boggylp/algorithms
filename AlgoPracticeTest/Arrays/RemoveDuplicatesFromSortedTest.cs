using Xunit;
using AlgoPractice.Arrays;

namespace AlgoPracticeTest.Arrays;

public class RemoveDuplicatesFromSortedTest
{
    [Theory]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    public void TestMaxProfit(int[] prices, int expectedResult)
    {
        int result = RemoveDuplicatesFromSorted.RemoveDuplicates(prices);
        Assert.Equal(result, expectedResult);
    }
}