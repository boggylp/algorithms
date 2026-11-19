using AlgoPractice.LinkedList;
using TUnit.Assertions.Enums;

namespace AlgoPracticeTest.LinkedList;

public class MergeTwoListsTest
{
    [Test]
    [Arguments(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 })]
    public async Task ValidHappyFlow(int[] first, int[] second, int[] expectedResult)
    {
        var firstList = LinkedListFactory.FromValues(first);
        var secondList = LinkedListFactory.FromValues(second);

        var result = LinkedListFactory.ToValues(MergeTwoSortedLists.MergeTwoLists(firstList, secondList));

        await Assert.That(result).IsEquivalentTo(expectedResult, CollectionOrdering.Matching);
    }
}
