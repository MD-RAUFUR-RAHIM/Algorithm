using System;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new ListNode();
        ListNode current = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;            
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        if (list1 != null) current.next = list1;
        if (list2 != null) current.next = list2;

        return dummy.next;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create list1: 1 → 2 → 4
        ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));

        // Create list2: 1 → 4 → 5
        ListNode list2 = new ListNode(1, new ListNode(4));

        Solution sol = new Solution();
        ListNode merged = sol.MergeTwoLists(list1, list2);

        // Print merged list
        PrintList(merged);
    }

    static void PrintList(ListNode head)
    {
        ListNode current = head;
        while (current != null)
        {
            Console.Write(current.val);
            if (current.next != null) Console.Write(" → ");
            current = current.next;
        }
        Console.WriteLine();
    }
}
