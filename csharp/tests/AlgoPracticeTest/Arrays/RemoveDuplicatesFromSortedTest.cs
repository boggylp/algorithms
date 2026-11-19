using AlgoPractice.Arrays;

namespace AlgoPracticeTest.Arrays;

public class RemoveDuplicatesFromSortedTest
{
    [Test]
    [Arguments(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    public async Task TestDuplicates(int[] prices, int expectedResult)
    {
        int result = RemoveDuplicatesFromSorted.RemoveDuplicates(prices);
        await Assert.That(result).IsEqualTo(expectedResult);
    }
}
