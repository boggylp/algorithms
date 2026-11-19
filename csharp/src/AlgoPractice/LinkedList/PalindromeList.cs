namespace AlgoPractice.LinkedList;

public static class PalindromeList
{
    public static bool IsPalindrome(ListNode head)
    {
        if (head == null || head.Next == null)
        {
            return true;
        }

        var stack = new Stack<ListNode>();
        var current = head;
        while (current != null)
        {
            stack.Push(current);
            current = current?.Next;
        }

        current = head;
        while (current != null)
        {
            var value = stack.Pop().Val;
            if (current.Val != value)
            {
                return false;
            }

            current = current.Next;
        }

        return true;
    }
}
