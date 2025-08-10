using System;

public class LinkedList
{
    private Node? head;
    private Node? tail;
    private int count;

    public void AddFirst(int data)
    {
        if (head == null)
        {
            head = new Node(data);
            tail = head;
        }
        else
        {
            Node? temp = head;
            head = new Node(data);
            head.Next = temp;
        }
        count++;
    }

    public void AddLast(int data)
    {
        if(head == null)
        {
            head = new Node(data);
            tail = head;
        }
    else
        {  
            tail.Next = new Node(data);
            tail = tail.Next;
        }
        count++;
    }

    public void AddAt(int data, int index)
    {
        if(count+1 <= index)
            throw new IndexOutOfRangeException();
        if(index == 0)
            AddFirst(data);
        else if(count+1 == index)
            AddLast(data);
        else
        {
            Node? temp = head;

        }
    }

    public void GetAll()
    {
        Node? temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.Data);
            temp = temp.Next;
        }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }

        public Node(int data)
        {
            Data = data;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("------Linked List---------");
        LinkedList list = new LinkedList();
        list.AddFirst(10);
        list.AddFirst(20);
        list.AddFirst(30);
        //list.AddLast(50);
        //list.AddLast(35);
        list.GetAll();
    }
}