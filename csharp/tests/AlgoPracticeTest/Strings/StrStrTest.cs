using AlgoPractice.Strings;

namespace AlgoPracticeTest.Strings;

public class StrStrTest
{
    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    public void ValidHappyFlow(string haystack, string needle, int expectedResult)
    {
        var result = StrStr.Run(haystack, needle);
        Assert.Equivalent(expectedResult, result);
    }
}
