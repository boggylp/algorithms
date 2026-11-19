using AlgoPractice.Strings;

namespace AlgoPracticeTest.Strings;

public sealed class PalindromeTest
{
    [Test]
    [Arguments("A man, a plan, a canal: Panama", true)]
    [Arguments("race a car", false)]
    [Arguments(" ", true)]
    public async Task ValidHappyFlow(string input, bool expectedResult)
    {
        var result = Palindrome.IsPalindrome(input);
        await Assert.That(result).IsEqualTo(expectedResult);
    }
}
