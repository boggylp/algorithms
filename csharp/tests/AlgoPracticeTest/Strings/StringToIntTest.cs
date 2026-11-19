using AlgoPractice.Strings;

namespace AlgoPracticeTest.Strings;

public sealed class StringToIntTest
{
    [Test]
    [Arguments("     -42", -42)]
    [Arguments("0-1", 0)]
    [Arguments("words and 987", 0)]
    [Arguments("-91283472332", int.MinValue)]
    [Arguments("991283472332", int.MaxValue)]
    [Arguments("21474836460", int.MaxValue)]
    [Arguments("-+12", 0)]
    [Arguments("+-12", 0)]
    public async Task ValidHappyFlow(string input, int expectedResult)
    {
        var result = StringToInt.Run(input);
        await Assert.That(result).IsEqualTo(expectedResult);
    }
}
