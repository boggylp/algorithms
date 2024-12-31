using AlgoPractice.Strings;

namespace AlgoPracticeTest.Strings;

public sealed class FirstUniqueCharInStringTest
{
    [Theory]
    [InlineData("leetcode", 0)]
    [InlineData("loveleetcode", 2)]
    [InlineData("aabb", -1)]
    [InlineData("z", 0)]
    [InlineData("dddccdbba", 8)]
    [InlineData("cdabcaabb", 1)]
    public void ValidHappyFlow(string input, int expectedResult)
    {
        var result = FirstUniqueCharInString.Run(input);
        Assert.Equal(expectedResult, result);
    }
}
