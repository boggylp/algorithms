using AlgoPractice.Strings;

namespace AlgoPracticeTest.Strings;

public sealed class FirstUniqueCharInStringTest
{
    [Test]
    [Arguments("leetcode", 0)]
    [Arguments("loveleetcode", 2)]
    [Arguments("aabb", -1)]
    [Arguments("z", 0)]
    [Arguments("dddccdbba", 8)]
    [Arguments("cdabcaabb", 1)]
    public async Task ValidHappyFlow(string input, int expectedResult)
    {
        var result = FirstUniqueCharInString.Run(input);
        await Assert.That(result).IsEqualTo(expectedResult);
    }
}
