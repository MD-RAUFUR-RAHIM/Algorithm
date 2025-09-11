using StackWithArray;

Stack stack = new Stack();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(50);
Console.WriteLine(stack.Peek()); // 20
Console.WriteLine(stack.Pop());  // 20
Console.WriteLine(stack.Peek());