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
                Console.WriteLine("Choose 1:LinkedList" );
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
                        linkedList.Display();
                        break;
                    default:
                        Console.WriteLine("choose valid one");
                        break;
                }
            }

        }
    }
}