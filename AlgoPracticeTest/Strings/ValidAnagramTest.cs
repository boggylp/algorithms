using AlgoPractice.Strings;
using Xunit;

namespace AlgoPracticeTest.Strings;

public sealed class ValidAnagramTest
{
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    [InlineData("ccac", "aacc", false)]
    [InlineData("dw", "ev", false)]
    public void ValidHappyFlow(string s, string t, bool expectedResult)
    {
        var result = ValidAnagram.IsAnagram(s, t);
        Assert.Equal(expectedResult, result);
    }
}
