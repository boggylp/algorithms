using AlgoPractice.DynamicProgramming;

namespace AlgoPracticeTest.DynamicProgramming;

public sealed class FibonacciTest
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(0, 0)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    [InlineData(5, 5)]
    [InlineData(6, 8)]
    public void ValidHappyFlow(int input, int expectedResult)
    {
        var result = Fibonacci.Calculate(input);
        Assert.Equal(expectedResult, result);
    }
}
