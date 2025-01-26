namespace AlgoPractice.LinkedList;

/// <summary>
/// Given the head of a singly linked list, reverse the list, and return the reversed list.
/// Input: head = [1,2,3,4,5]
/// Output: [5, 4, 3, 2, 1]
/// </summary>
public class ReverseLinkedList
{
    public static ListNode? ReverseList(ListNode head)
    {
        if (head?.next == null)
        {
            return head;
        }

        var current = head;
        ListNode? previous = null;

        while (current != null)
        {
            var temp = current.next;
            current.next = previous;
            previous = current;
            current = temp;
        }

        return previous;
    }
}
