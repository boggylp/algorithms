using AlgoPractice.DynamicProgramming;

namespace AlgoPracticeTest.DynamicProgramming;

public sealed class FibonacciTest
{
    [Test]
    [Arguments(1, 1)]
    [Arguments(2, 1)]
    [Arguments(0, 0)]
    [Arguments(3, 2)]
    [Arguments(4, 3)]
    [Arguments(5, 5)]
    [Arguments(6, 8)]
    public async Task ValidHappyFlow(int input, int expectedResult)
    {
        var result = Fibonacci.Calculate(input);
        await Assert.That(result).IsEqualTo(expectedResult);
    }
}
