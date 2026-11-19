using AlgoPractice.Strings;

namespace AlgoPracticeTest.Strings;

public class LongestCommonPrefixTest
{
    [Test]
    [Arguments(new[] { "a" }, "a")]
    [Arguments(new[] { "ab", "a" }, "a")]
    [Arguments(new[] { "flower", "flower", "flower", "flower" }, "flower")]
    public async Task ValidHappyFlow(string[] input, string expectedResult)
    {
        var result = LongestCommonPrefix.Run(input);
        await Assert.That(result).IsEqualTo(expectedResult);
    }
}
