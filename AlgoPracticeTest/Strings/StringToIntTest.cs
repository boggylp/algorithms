using AlgoPractice.Strings;

namespace AlgoPracticeTest.Strings;

public sealed class StringToIntTest
{
    [Theory]
    [InlineData("     -42", -42)]
    [InlineData("0-1", 0)]
    [InlineData("words and 987", 0)]
    [InlineData("-91283472332", int.MinValue)]
    [InlineData("991283472332", int.MaxValue)]
    [InlineData("21474836460", int.MaxValue)]
    [InlineData("-+12", 0)]
    [InlineData("+-12", 0)]
    public void ValidHappyFlow(string input, int expectedResult)
    {
        var result = StringToInt.Run(input);
        Assert.Equivalent(expectedResult, result);
    }
}
