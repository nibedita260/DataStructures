using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(56);
            linkedListStack.Push(30);
            linkedListStack.Push(70);
            //linkedListStack.Display();
            //linkedListStack.Peek();
            //linkedListStack.Display();
            linkedListStack.Pop();
            linkedListStack.Display();
        }
    }
}
