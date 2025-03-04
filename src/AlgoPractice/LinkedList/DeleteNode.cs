namespace AlgoPractice.LinkedList;

public static class DeleteNode
{
    public static void Run(ListNode node)
    {
        node.val = node.next!.val;
        node.next = node.next.next;
    }
}
