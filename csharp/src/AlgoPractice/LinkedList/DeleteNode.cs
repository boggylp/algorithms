namespace AlgoPractice.LinkedList;

public static class DeleteNode
{
    public static void Run(ListNode node)
    {
        node.Val = node.Next!.Val;
        node.Next = node.Next.Next;
    }
}
