using AlgoPractice.LinkedList;
using TUnit.Assertions.Enums;

namespace AlgoPracticeTest.LinkedList;

public class RemoveNodeFromListTest
{
    [Test]
    [Arguments(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 1, 2, 3, 5 })]
    [Arguments(new[] { 1, 2 }, 2, new[] { 2 })]
    public async Task ValidHappyFlow(int[] input, int n, int[] expectedResult)
    {
        var inputList = LinkedListFactory.FromValues(input);
        var result = LinkedListFactory.ToValues(RemoveNodeFromList.RemoveNthFromEnd(inputList, n));
        await Assert.That(result).IsEquivalentTo(expectedResult, CollectionOrdering.Matching);
    }
}
