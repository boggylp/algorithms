using AlgoPractice.DynamicProgramming;

namespace AlgoPracticeTest.DynamicProgramming;

public sealed class GridTravelTest
{
    [Test]
    [Arguments(3, 7, 28)]
    [Arguments(3, 2, 3)]
    [Arguments(3, 3, 6)]
    [Arguments(23, 12, 193536720)]
    public async Task ValidHappyFlow(int m, int n, int expectedResult)
    {
        var result = GridTravel.UniquePaths(m, n);
        await Assert.That(result).IsEqualTo(expectedResult);
    }
}
