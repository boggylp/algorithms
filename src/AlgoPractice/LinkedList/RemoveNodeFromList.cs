namespace AlgoPractice.LinkedList;

public static class RemoveNodeFromList
{
    public static ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        if (head.next == null)
        {
            return null;
        }

        static void RemoveCurrentNode(ListNode? previous, ListNode? current)
        {
            if (previous is not null && current is not null)
                previous.next = current.next;
            // head
            if (previous is null && current is not null)
            {
                current.val = current.next!.val;
                current.next = current.next.next;
            }
        }

        var candidate = head;
        ListNode? previous = null;
        while (candidate != null)
        {
            var temp = candidate.next;
            for (int i = 0; i < n; i++)
            {
                if (temp == null)
                {
                    RemoveCurrentNode(previous, candidate);
                    return head;
                }

                temp = temp.next;
            }

            previous = candidate;
            candidate = candidate.next;
        }

        if (previous == null)
        {
            return candidate;
        }

        return head;
    }
}
