using System;
using AlgoPractice.Strings;
using Xunit;

namespace AlgoPracticeTest;

public class RerverseStringTest
{
    [Theory]
    [InlineData(new char[] { 'h', 'e', 'l', 'l', 'o' }, new char[] { 'o', 'l', 'l', 'e', 'h' })]
    [InlineData(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new char[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
    public void ValidHappyFlow(char[] input, char[] expectedOutput)
    {
        ReverseString.Run(input);
        Assert.Equivalent(expectedOutput, input);
    }
}
