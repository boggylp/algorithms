namespace AlgoPractice.LinkedList;

/// <summary>
/// You are given the heads of two sorted linked lists list1 and list2. Merge the two lists into one sorted list.
/// The list should be made by splicing together the nodes of the first two lists.
/// Return the head of the merged linked list.
/// </summary>
class MergeTwoSortedLists
{
    public static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        ListNode head = list1.val < list2.val ? list1 : list2;
        var currentLeft = list1;
        var currentRight = list2;
        var current = head;

        while (true)
        {
            if (currentLeft == null && currentRight == null)
            {
                break;
            }

            if (currentLeft == null && currentRight != null)
            {
                current.next = currentRight;
                current = current.next;
                currentRight = currentRight.next;
                continue;
            }

            if (currentLeft != null && currentRight == null)
            {
                current.next = currentLeft;
                current = current.next;
                currentLeft = currentLeft.next;
                continue;
            }

            if (currentLeft.val < currentRight.val)
            {
                current.next = currentLeft;
                current = current.next;
                currentLeft = currentLeft.next;
                continue;
            }
            else
            {
                current.next = currentRight;
                current = current.next;
                currentRight = currentRight.next;
                continue;
            }
        }

        return head;
    }
}
