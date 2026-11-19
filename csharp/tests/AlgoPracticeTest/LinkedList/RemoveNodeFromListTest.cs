using AlgoPractice.LinkedList;
using System;

namespace AlgoPracticeTest.LinkedList;

public class RemoveNodeFromListTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 1, 2, 3, 5 })]
    [InlineData(new[] { 1, 2 }, 2, new[] { 2 })]
    public void ValidHappyFlow(int[] input, int n, int[] expectedResult)
    {
        var inputList = LinkedListFactory.FromValues(input);
        var result = LinkedListFactory.ToValues(RemoveNodeFromList.RemoveNthFromEnd(inputList, n));
        Assert.Equal(expectedResult, result);
    }
}
