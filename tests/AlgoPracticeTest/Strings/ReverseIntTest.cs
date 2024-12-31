using AlgoPractice.Strings;
using Xunit;

namespace AlgoPracticeTest.Strings;

public sealed class ReverseIntTest
{
    [Theory]
    [InlineData(123, 321)]
    [InlineData(-123, -321)]
    [InlineData(120, 21)]
    public void ValidHappyFlow(int input, int expectedResult)
    {
        var result = ReverseInt.Run(input);
        Assert.Equal(expectedResult, result);
    }
}
