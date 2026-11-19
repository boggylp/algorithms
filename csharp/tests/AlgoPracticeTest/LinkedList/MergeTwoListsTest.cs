using System;
using AlgoPractice.LinkedList;

namespace AlgoPracticeTest.LinkedList;

public class MergeTwoListsTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 })]
    public void ValidHappyFlow(int[] first, int[] second, int[] expectedResult)
    {
        var firstList = LinkedListFactory.FromValues(first);
        var secondList = LinkedListFactory.FromValues(second);

        var result = LinkedListFactory.ToValues(MergeTwoSortedLists.MergeTwoLists(firstList, secondList));

        Assert.Equal(expectedResult, result);
    }
}
