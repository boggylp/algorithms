using AlgoPractice.DynamicProgramming;

namespace AlgoPracticeTest.DynamicProgramming;

public sealed class GridTravelTest
{
    [Theory]
    [InlineData(3, 7, 28)]
    [InlineData(3, 2, 3)]
    [InlineData(23, 12, 193536720)]
    public void ValidHappyFlow(int m, int n, int expectedResult)
    {
        var result = GridTravel.UniquePaths(m, n);
        Assert.Equal(expectedResult, result);
    }
}
