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
        if (head == null)
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

    public void AddAtV2(int data, int index)
    {
        if (index < 0 || index > count)
            throw new IndexOutOfRangeException();
        else if (index == 0)
            AddFirst(data);
        else if (count == index)
            AddLast(data);
        else
        {
            Node? temp = head;
            for (int i = 0; i < index - 1; i++)
            {
                temp = temp.Next;
            }
            Node newNode = new Node(data);
            newNode.Next = temp.Next;
            temp.Next = newNode;
            count++;
        }
    }
    public void AddAt(int data, int position)
    {
        if (position <= 0)
        {
            throw new ArgumentOutOfRangeException("position");
        }
        else if (position == 1)
        {
            AddFirst(data);
            return;
        }
        else
        {
            Node? temp = head;
            for (int i = 1; i < position - 1 ; i++)
            {
                if(temp == null)
                {
                    Console.WriteLine("Invalid position");
                    return;
                }
                temp = temp.Next;
            }
            Node newNode = new Node(data);
            newNode.Next = temp.Next;
            temp.Next = newNode;

        }
    }
    public void RemoveFromFirst()
    {
        if (head == null)
        {
            Console.Write("The list is empty");
            return;
        }
        if (head == tail)
        {
            // Only one node in the list
            head = null;
            tail = null;
            count--;
            return;
        }
        Node? temp = head;
        head = head.Next;
        temp.Next = null;
        count--;
    }
    public void RemoveFromLast()
    {
        if (head == null)
        {
            Console.Write("The list is empty");
            return;
        }
        if (head == tail)
        {
            // Only one node in the list
            head = null;
            tail = null;
            count--;
            return;
        }
        Node? temp = head;
        while (temp.Next != null && temp.Next != tail)
        {
            temp = temp.Next;
        }
        temp.Next = null;
        tail = temp;
        count--;
    }
    public void GetAll()
    {
        if (head == null)
        {
            Console.WriteLine("The Linked List is empty");
        }
        Node? temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.Data);
            temp = temp.Next;
        }
    }
    public int Search(int target)
    {
        if(head  == null)
        {
            Console.WriteLine("The Linked List is empty");
        }
        Node temp = head;
        int index = 0;
        while (temp != null) { 
            if(temp.Data == target)
                return temp.Data;
            temp = temp.Next;
            index++;
        }
        return -1;
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
        list.AddLast(50);
        list.AddLast(5000);
        list.AddAt(0, 1);
        list.GetAll();
        //Console.WriteLine("------Linked List Remove From Last Example---------");
        //list.RemoveFromLast();
        //list.GetAll();
        LinkedList list2 = new LinkedList();
        Console.WriteLine("------Linked List 2---------");
        list2.AddFirst(5);
        list2.AddFirst(6);
        list2.AddFirst(7);
        list2.AddLast(8);
        list2.RemoveFromFirst();
        list2.RemoveFromLast();
        list2 .RemoveFromLast();
        list2.RemoveFromLast();
    //    list2.AddAtV2(100, 1);
        list2.GetAll();
        Console.WriteLine(list2.Search(5));
    }
}