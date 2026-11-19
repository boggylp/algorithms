using AlgoPractice.Arrays;

namespace AlgoPracticeTest.Arrays;

public class SingleNumberTest
{
    [Test]
    [Arguments(new[] { 2, 2, 1 }, 1)]
    [Arguments(new[] { 4, 1, 2, 1, 2 }, 4)]
    [Arguments(new[] { 1 }, 1)]
    [Arguments(new[] { 1, 8, 3, 7, 8, 1, 3 }, 7)]
    public async Task TestSingleNumner(int[] nums, int expectedResult)
    {
        var result = SingleNumberSolution.SingleNumber(nums);
        await Assert.That(result).IsEqualTo(expectedResult);
    }
}
