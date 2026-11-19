using AlgoPractice.Strings;

namespace AlgoPracticeTest.Strings;

public class LongestCommonPrefixTest
{
    [Theory]
    [InlineData(new[] { "a" }, "a")]
    [InlineData(new[] { "ab", "a" }, "a")]
    [InlineData(new[] { "flower", "flower", "flower", "flower" }, "flower")]
    public void ValidHappyFlow(string[] input, string expectedResult)
    {
        var result = LongestCommonPrefix.Run(input);
        Assert.Equal(expectedResult, result);
    }
}
