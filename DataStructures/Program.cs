﻿using System;

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
<<<<<<< HEAD
                Console.WriteLine("Choose 1:LinkedList 2.");
=======
                Console.WriteLine("Choose 1:LinkedListGenerics 2:LinkedListStackGenerics 3.LinkedListQueueGenerics");
>>>>>>> UC3-Queue
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        LinkedList<int> linkedList = new LinkedList<int>();
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.AddReverseData(70);
                        linkedList.AddReverseData(30);
                        linkedList.AddReverseData(56);
                        linkedList.InsertedAtPosition(40, 1);
                        linkedList.RemoveFirstElem();
                        linkedList.RemoveLastElem();
                        linkedList.InsertedAtPosition(45, 2);
                        linkedList.Search(40);
                        //linkedList.RemoveFirstElem();
                        //linkedList.Display();
                        linkedList.Size();
                        //linkedList.Sort();
<<<<<<< HEAD
                        //linkedList.RemoveFirstElem();
                        linkedList.Display();
                        break;
                    default:Console.WriteLine("choose valid options");
=======
                        linkedList.Display();
                        break;
                    case 2:
                        LinkedListStack<string> linkedListStack = new LinkedListStack<string>();
                        linkedListStack.Push("I am");
                        linkedListStack.Push("not");
                        linkedListStack.Push("contents");
                        linkedListStack.Peek();
                        linkedListStack.Pop();
                        linkedListStack.IsEmpty();
                        linkedListStack.Display();
                        break;
                    case 3:
                        LinkedListQueue<string> linkedListQueue = new LinkedListQueue<string>();
                        linkedListQueue.Enqueue("Nibedita");
                        linkedListQueue.Enqueue("is");
                        linkedListQueue.Enqueue("talented");
                        linkedListQueue.Dequeue();
                        linkedListQueue.Display();
                        break;
                    default:
                        Console.WriteLine("choose valid one");
>>>>>>> UC3-Queue
                        break;
                }
            }
        }
    }
}