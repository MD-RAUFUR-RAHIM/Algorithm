Solution solution = new Solution();

// Test case 1: Palindrome list [1,2,2,1]
Console.WriteLine("Test Case 1: [1,2,2,1]");
ListNode head1 = CreateList(new int[] { 1, 2, 2, 1 });
Console.WriteLine("Is palindrome: " + solution.IsPalindrome(head1));
Console.WriteLine();

// Test case 2: Non-palindrome list [1,2]
Console.WriteLine("Test Case 2: [1,2]");
ListNode head2 = CreateList(new int[] { 1, 2 });
Console.WriteLine("Is palindrome: " + solution.IsPalindrome(head2));
Console.WriteLine();
static ListNode CreateList(int[] values)
{
    if (values == null || values.Length == 0) return null;

    ListNode head = new ListNode(values[0]);
    ListNode current = head;

    for (int i = 1; i < values.Length; i++)
    {
        current.next = new ListNode(values[i]);
        current = current.next;
    }

    return head;
}

// Helper method to print a linked list (for debugging)
static void PrintList(ListNode head)
{
    ListNode current = head;
    while (current != null)
    {
        Console.Write(current.val + " ");
        current = current.next;
    }
    Console.WriteLine();
}

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
    public bool IsPalindrome(ListNode head)
    {
        if (head == null) return true;

        ListNode originalCopy = CopyList(head);

        ListNode prev = null;
        ListNode current = head;
        while (current != null)
        {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        ListNode reversedHead = prev;

        ListNode p1 = originalCopy;
        ListNode p2 = reversedHead;
        while (p1 != null && p2 != null)
        {
            if (p1.val != p2.val)
            {
                return false;
            }
            p1 = p1.next;
            p2 = p2.next;
        }
        return true;
    }

    private ListNode CopyList(ListNode head)
    {
        if (head == null) return null;
        ListNode newHead = new ListNode(head.val);
        ListNode current = newHead;
        ListNode originalCurrent = head.next;
        while (originalCurrent != null)
        {
            current.next = new ListNode(originalCurrent.val);
            current = current.next;
            originalCurrent = originalCurrent.next;
        }
        return newHead;
    }
}

