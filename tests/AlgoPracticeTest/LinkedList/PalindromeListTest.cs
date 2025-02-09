using AlgoPractice.LinkedList;

namespace AlgoPracticeTest.LinkedList;

public class PalindromeListTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 2, 1 }, true)]
    public void ValidHappyFlow(int[] list, bool expectedResult)
    {
        var linkedList = LinkedListFactory.FromValues(list);

        var result = PalindromeList.IsPalindrome(linkedList);

        Assert.Equal(expectedResult, result);
    }
}
