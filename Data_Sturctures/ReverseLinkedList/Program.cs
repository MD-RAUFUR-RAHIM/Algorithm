using System;

public class ListNode
{
    public int Data;
    public ListNode? Next;

    public ListNode(int data)
    {
        Data = data;   
    }
}

public class MyLinkedList
{
    private ListNode? head;
    private ListNode? tail;
    private int count;

   

    public void AddFirst(int data)
    {
        var newNode = new ListNode(data);
        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head = newNode;
        }
        count++;
    }

    public void AddLast(int data)
    {
        var newNode = new ListNode(data);
        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
        count++;
    }

    public void PrintList()
    {
        var current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    public void Reverse()
    {
        head = ReverseCore(head);
    }

    private ListNode? ReverseCore(ListNode? head)
    {
        ListNode? prev = null;
        ListNode? current = head;

        while (current != null)
        {
            ListNode? next = current.Next;  
            current.Next = prev;             
            prev = current;                  
            current = next;                  
        }
         
       
        tail = head;   
        return prev;   
    }

}

class Program
{
    static void Main()
    {
        MyLinkedList list = new MyLinkedList();
        list.AddLast(10);
        list.AddLast(20);
        list.AddLast(30);
        list.AddLast(40);

        Console.WriteLine("Original List:");
        list.PrintList();

        list.Reverse();

        Console.WriteLine("Reversed List:");
        list.PrintList();
    }
}
