using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedListQueue
    {
        public Node front;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (this.front == null)
            {
                front = node;
            }
            else
            {
                Node temp = front;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} enqueued into Queue", data);
        }
        public void Display()
        {
            Node temp = this.front;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.Next;
            }
        }
        public void Dequeue()
        {
            if (this.front == null)
            {
                Console.WriteLine("Queue is empty,Deletion not possible!!");
                return;
            }
            Console.WriteLine("data dequeued is {0} ", this.front.data);
            this.front = this.front.Next;
        }
    }
}
