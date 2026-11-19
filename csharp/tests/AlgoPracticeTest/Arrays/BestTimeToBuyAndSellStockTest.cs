using AlgoPractice.Arrays;

namespace AlgoPracticeTest.Arrays;

public class BestTimeToBuyAndSellStockTest
{
    [Test]
    [Arguments(new[] { 7, 1, 5, 3, 6, 4 }, 7)]
    [Arguments(new[] { 7, 1, 5, 3, 6, 1, 4, 8 }, 14)]
    [Arguments(new[] { 1, 2, 3, 4, 5 }, 4)]
    [Arguments(new[] { 7, 6, 4, 3, 1 }, 0)]
    public async Task TestMaxProfit(int[] prices, int expectedMaxProfit)
    {
        int maxProfit = BestTimeToBuyAndSellStock.MaxProfit(prices);
        await Assert.That(maxProfit).IsEqualTo(expectedMaxProfit);
    }
}
