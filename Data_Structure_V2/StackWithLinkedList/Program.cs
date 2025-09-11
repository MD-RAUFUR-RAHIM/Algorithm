using StackWithLinkedList;

StackWithLL stack = new StackWithLL();

// Push elements
stack.Push(10);
stack.Push(20);
stack.Push(30);

// Peek / Top element
Console.WriteLine("Top element: " + stack.Top()); // 30

// Pop element
int popped = stack.Pop();
Console.WriteLine("Popped element: " + popped);  // 30

// Peek after pop
Console.WriteLine("Top element now: " + stack.Top()); // 20

// Check if empty
Console.WriteLine("Is stack empty? " + stack.IsEmpty()); // False

// Pop all elements
stack.Pop();
stack.Pop();
Console.WriteLine("Is stack empty now? " + stack.IsEmpty()); // True