using AlgoPractice.Strings;

namespace AlgoPracticeTest.Strings;

public sealed class ReverseStringTest
{
    [Test]
    [Arguments(new[] { 'h', 'e', 'l', 'l', 'o' }, new[] { 'o', 'l', 'l', 'e', 'h' })]
    [Arguments(new[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
    public async Task ValidHappyFlow(char[] input, char[] expectedOutput)
    {
        ReverseString.Run(input);
        await Assert.That(input).IsEquivalentTo(expectedOutput);
    }
}
