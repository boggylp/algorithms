using Xunit;
using AlgoPractice.Arrays;

namespace AlgoPracticeTest.Arrays;

public class BestTimeToBuyAndSellStockTest
{
    [Theory]
    [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
    [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void TestMaxProfit(int[] prices, int expectedMaxProfit)
    {
        int maxProfit = BestTimeToBuyAndSellStock.MaxProfit(prices);
        Assert.Equal(maxProfit, expectedMaxProfit);
    }
}