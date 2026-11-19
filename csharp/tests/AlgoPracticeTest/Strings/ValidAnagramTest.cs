using AlgoPractice.Strings;

namespace AlgoPracticeTest.Strings;

public sealed class ValidAnagramTest
{
    [Test]
    [Arguments("anagram", "nagaram", true)]
    [Arguments("rat", "car", false)]
    [Arguments("ccac", "aacc", false)]
    [Arguments("dw", "ev", false)]
    public async Task ValidHappyFlow(string s, string t, bool expectedResult)
    {
        var result = ValidAnagram.IsAnagram(s, t);
        await Assert.That(result).IsEqualTo(expectedResult);
    }
}
