namespace AlgoPractice.LinkedList;

/// <summary>
/// Given head, the head of a linked list, determine if the linked list has a cycle in it.
// There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer.
// Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.
/// Return true if there is a cycle in the linked list. Otherwise, return false.
/// </summary>
public class LinkedListCycle
{
    public static bool HasCycle(ListNode head)
    {
        if (head is null)
            return false;

        var list = new List<ListNode>();
        var currentNode = head;
        while (currentNode.next != null)
        {
            if (list.Contains(currentNode))
            {
                return true;
            }

            list.Add(currentNode);
            currentNode = currentNode.next;
        }

        return false;
    }
}
