using AlgoPractice.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoPracticeTest.LinkedList;

public static class LinkedListFactory
{
    public static ListNode FromValues(int[] values)
    {
        if (values.Length == 0)
        {
            throw new ArgumentException("Values array must not be empty");
        }

        var head = new ListNode(values[0]);
        var current = head;
        foreach (var value in values.Skip(1))
        {
            current.next = new ListNode(value);
            current = current.next;
        }
        return head;
    }

    public static int[] ToValues(ListNode? head)
    {
        if (head == null)
        {
            return Array.Empty<int>();
        }

        var result = new List<int>();
        var current = head;
        while (current != null)
        {
            result.Add(current.val);
            current = current.next;
        }
        return [.. result];
    }
}
