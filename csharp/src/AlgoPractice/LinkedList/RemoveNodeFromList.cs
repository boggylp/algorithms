namespace AlgoPractice.LinkedList;

public static class RemoveNodeFromList
{
    public static ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        if (head.Next == null)
        {
            return null;
        }

        static void RemoveCurrentNode(ListNode? previous, ListNode? current)
        {
            if (previous is not null && current is not null)
                previous.Next = current.Next;
            // head
            if (previous is null && current is not null)
            {
                current.Val = current.Next!.Val;
                current.Next = current.Next.Next;
            }
        }

        var candidate = head;
        ListNode? previous = null;
        while (candidate != null)
        {
            var temp = candidate.Next;
            for (int i = 0; i < n; i++)
            {
                if (temp == null)
                {
                    RemoveCurrentNode(previous, candidate);
                    return head;
                }

                temp = temp.Next;
            }

            previous = candidate;
            candidate = candidate.Next;
        }

        if (previous == null)
        {
            return candidate;
        }

        return head;
    }
}
