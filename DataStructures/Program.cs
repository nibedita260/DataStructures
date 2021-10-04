using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            //linkedList.AddReverseData(70);
            //linkedList.AddReverseData(30);
            //linkedList.AddReverseData(56);
            //linkedList.InsertedAtPosition(30, 1);
            //linkedList.RemoveFirstElem();
            //linkedList.RemoveLastElem();
            linkedList.InsertedAtPosition(40, 2);
            //linkedList.Search(40);
            //linkedList.RemoveFirstElem();
            linkedList.Display();

        }
    }
}
