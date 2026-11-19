using AlgoPractice.Strings;

namespace AlgoPracticeTest.Strings;

public class StrStrTest
{
    [Test]
    [Arguments("sadbutsad", "sad", 0)]
    [Arguments("leetcode", "leeto", -1)]
    public async Task ValidHappyFlow(string haystack, string needle, int expectedResult)
    {
        var result = StrStr.Run(haystack, needle);
        await Assert.That(result).IsEqualTo(expectedResult);
    }
}
