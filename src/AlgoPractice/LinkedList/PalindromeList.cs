namespace AlgoPractice.LinkedList;

public class PalindromeList
{
    public static bool IsPalindrome(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return true;
        }

        var stack = new Stack<ListNode>();
        var current = head;
        while (current != null)
        {
            stack.Push(current);
            current = current?.next;
        }

        current = head;
        while (current != null)
        {
            var value = stack.Pop().val;
            if (current.val != value)
            {
                return false;
            }

            current = current.next;
        }

        return true;
    }
}
