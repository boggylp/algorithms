using AlgoPractice.LinkedList;

namespace AlgoPracticeTest.LinkedList;

public class PalindromeListTest
{
    [Test]
    [Arguments(new[] { 1, 2, 2, 1 }, true)]
    public async Task ValidHappyFlow(int[] list, bool expectedResult)
    {
        var linkedList = LinkedListFactory.FromValues(list);

        var result = PalindromeList.IsPalindrome(linkedList);

        await Assert.That(result).IsEqualTo(expectedResult);
    }
}
