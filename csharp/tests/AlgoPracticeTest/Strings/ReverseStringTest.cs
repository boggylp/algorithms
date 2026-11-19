using AlgoPractice.Strings;
using Xunit;

namespace AlgoPracticeTest.Strings;

public sealed class ReverseStringTest
{
    [Theory]
    [InlineData(new[] { 'h', 'e', 'l', 'l', 'o' }, new[] { 'o', 'l', 'l', 'e', 'h' })]
    [InlineData(new[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
    public void ValidHappyFlow(char[] input, char[] expectedOutput)
    {
        ReverseString.Run(input);
        Assert.Equivalent(expectedOutput, input);
    }
}
