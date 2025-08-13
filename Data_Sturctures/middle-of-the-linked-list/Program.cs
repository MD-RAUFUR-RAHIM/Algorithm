
ListNode node1 = new ListNode(1);
ListNode node2 = new ListNode(3);
ListNode node3 = new ListNode(4);
ListNode node4 = new ListNode(5);
ListNode node5 = new ListNode(6);


node1.next = node2;
node2.next = node3;
node3.next = node4;
node4.next = node5;

Solution sol = new Solution();


ListNode middle = sol.MiddleNode(node1);


Console.WriteLine("Linked list from middle node:");
while (middle != null)
{
    Console.Write(middle.val + " ");
    middle = middle.next;
}
        
public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
       this.val = val;
       this.next = next;
      }
}
 
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        ListNode temp = head;
        int count = 1;
        while(temp != null)
        {
            count++;
            temp = temp.next;
        }
       int mid = (int)Math.Ceiling(count / 2.0);
        temp = head; // start from the beginning again
        for (int i = 1; i < mid; i++)
        {
            temp = temp.next;
        }
        return temp;
    }
}
