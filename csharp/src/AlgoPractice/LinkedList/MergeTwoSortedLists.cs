namespace AlgoPractice.LinkedList;

/// <summary>
/// You are given the heads of two sorted linked lists list1 and list2. Merge the two lists into one sorted list.
/// The list should be made by splicing together the nodes of the first two lists.
/// Return the head of the merged linked list.
/// </summary>
public static class MergeTwoSortedLists
{
    public static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        if (list1 == null)
            return list2;
        if (list2 == null)
            return list1;

        ListNode? head;
        var currentLeft = list1;
        var currentRight = list2;
        if (list1.Val < list2.Val)
        {
            head = new ListNode(list1.Val);
            currentLeft = currentLeft.Next;
        }
        else
        {
            head = new ListNode(list2.Val);
            currentRight = currentRight.Next;
        }
        var current = head;

        while (current != null)
        {
            if (currentLeft == null && currentRight == null)
            {
                break;
            }

            if (currentLeft == null && currentRight != null)
            {
                current.Next = currentRight;
                current = current.Next;
                currentRight = currentRight.Next;
                continue;
            }

            if (currentLeft != null && currentRight == null)
            {
                current.Next = currentLeft;
                current = current.Next;
                currentLeft = currentLeft.Next;
                continue;
            }

            if (currentLeft?.Val < currentRight?.Val)
            {
                current.Next = currentLeft;
                current = current.Next;
                currentLeft = currentLeft.Next;
                continue;
            }
            else
            {
                current.Next = currentRight;
                current = current.Next;
                currentRight = currentRight?.Next;
                continue;
            }
        }

        return head;
    }
}
