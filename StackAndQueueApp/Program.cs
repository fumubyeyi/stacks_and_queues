// See https://aka.ms/new-console-template for more information

using Queue;
using Stack;

Console.WriteLine("Hello, World!");

MyStack<int> myStack = new();
MyQueue<string> myQueue = new();

for(int i = 0; i < 7; i++)
{
    myStack.Push(i);
    string? weekday = Enum.GetName(typeof(DayOfWeek), i);
    if (weekday !=null)
        myQueue.Enqueue(weekday);
}

Console.Write("Stack elements: ");
while (!myStack.IsEmpty())
{
    int val = myStack.Pop(); // return top element and remove node
    Console.Write($"{val} ");
}
Console.WriteLine();

// check if stack is empty
Console.WriteLine($"Is Stack empty? {(myStack.IsEmpty() ? "Yes" : "No")} ");

Console.Write("Queue elements: ");
while (!myQueue.IsEmpty())
{
    string val = myQueue.Dequeue(); // return top element and remove node
    Console.Write($"{val} ");
}
Console.WriteLine();

// check if stack is empty
Console.WriteLine($"Is Queue empty? {(myQueue.IsEmpty() ? "Yes" : "No")} ");

