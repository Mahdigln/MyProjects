using System.Collections;

Stack myStack = new Stack();
myStack.Push("Hello!!");
myStack.Push(null);
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(4);
myStack.Push(5);

foreach (var itm in myStack)
    Console.Write("\n"+ itm);

//
Console.WriteLine("\n---------------------------------------------");

Console.WriteLine("\nPeek");
Console.WriteLine(myStack.Peek());

Console.WriteLine("------------------------------------");
Console.Write("Number of elements in Stack: {0}", myStack.Count);
Console.WriteLine("");
while (myStack.Count > 0)
    Console.WriteLine(myStack.Pop());

Console.Write("Number of elements in Stack: {0}", myStack.Count);

Console.WriteLine("");
Console.WriteLine("+++++++++++++++++++++++++++");
Console.WriteLine("");
myStack.Clear(); // removes all elements

Console.Write("Number of elements in Stack: {0}", myStack.Count);