using AlgoPractice.Arrays;

namespace AlgoPracticeTest.Arrays;

public class ContainsDuplicateTest
{
    [Test]
    [Arguments(new[] { 1, 2, 3, 1 }, true)]
    [Arguments(new[] { 1, 2, 3, 4 }, false)]
    [Arguments(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    public async Task TestContainsDuplicate(int[] nums, bool expectedResult)
    {
        var result = ContainsDuplicateSolution.ContainsDuplicate(nums);
        await Assert.That(result).IsEqualTo(expectedResult);
    }
}
