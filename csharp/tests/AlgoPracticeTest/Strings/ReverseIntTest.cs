using AlgoPractice.Strings;

namespace AlgoPracticeTest.Strings;

public sealed class ReverseIntTest
{
    [Test]
    [Arguments(123, 321)]
    [Arguments(-123, -321)]
    [Arguments(120, 21)]
    public async Task ValidHappyFlow(int input, int expectedResult)
    {
        var result = ReverseInt.Run(input);
        await Assert.That(result).IsEqualTo(expectedResult);
    }
}
