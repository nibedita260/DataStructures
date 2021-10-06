using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int options;
            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine("Choose 1:LinkedList 2:LinkedListStack 3.LinkedListQueue 4.BankingCashCounter");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        LinkedList linkedList = new LinkedList();
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.AddReverseData(70);
                        linkedList.AddReverseData(30);
                        linkedList.AddReverseData(56);
                        linkedList.InsertedAtPosition(30, 1);
                        linkedList.RemoveFirstElem();
                        linkedList.RemoveLastElem();
                        linkedList.InsertedAtPosition(40, 2);
                        linkedList.Search(40);
                        linkedList.RemoveFirstElem();
                        linkedList.Display();
                        break;
                    case 2:
                        LinkedListStack linkedListStack = new LinkedListStack();
                        linkedListStack.Push(56);
                        linkedListStack.Push(30);
                        linkedListStack.Push(70);
                        linkedListStack.Peek();
                        linkedListStack.Pop();
                        linkedListStack.IsEmpty();
                        linkedListStack.Display();
                        break;
                    case 3:LinkedListQueue<string> linkedListQueue = new LinkedListQueue<string>();
                        linkedListQueue.Enqueue("Nibedita");
                        linkedListQueue.Enqueue("is");
                        linkedListQueue.Enqueue("talented");
                        linkedListQueue.Dequeue();
                        linkedListQueue.Display();
                        break;
                    case 4:BankCashCounter bankingCashCounter = new BankCashCounter();
                        bankingCashCounter.CashCounter();
                        break;
                    default:Console.WriteLine("choose valid one");
                        break;
                }
            }
           
        }
    }
}
