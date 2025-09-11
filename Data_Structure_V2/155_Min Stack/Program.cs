using _155_Min_Stack;

MinStack minStack = new MinStack();
minStack.Push(-2);
minStack.Push(0);
minStack.Push(-3);
Console.WriteLine(minStack.GetMin());// return -3
minStack.Pop();
minStack.Top();    // return 0
minStack.GetMin(); // return -2