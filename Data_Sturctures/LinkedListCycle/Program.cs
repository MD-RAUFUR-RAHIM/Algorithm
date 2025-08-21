using System;

namespace LinkedListCycleDetection
{
    // Definition for singly-linked list
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                    return true;
            }

            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Build linked list: 3 -> 2 -> 0 -> -4 -> points back to node with val=2
            ListNode head = new ListNode(3);
            head.next = new ListNode(2);
            head.next.next = new ListNode(0);
            head.next.next.next = new ListNode(-4);

            // create cycle: connect last node (-4) to node with val=2
            head.next.next.next.next = head.next;

            Solution solution = new Solution();

            bool hasCycle = solution.HasCycle(head);

            Console.WriteLine("Does the linked list have a cycle? " + hasCycle);
            Console.ReadLine();
        }
    }
}
