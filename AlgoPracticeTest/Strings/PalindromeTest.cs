using AlgoPractice.Strings;

namespace AlgoPracticeTest.Strings;

public sealed class PalindromeTest
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(" ", true)]
    public void ValidHappyFlow(string input, bool expectedResult)
    {
        var result = Palindrome.IsPalindrome(input);
        Assert.Equal(expectedResult, result);
    }
}
