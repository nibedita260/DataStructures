using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedListQueue<T> where T : IComparable
    {
        public Node<T> front;
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.front == null)
            {
                front = node;
            }
            else
            {
                Node<T> temp = front;
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
            Node<T> temp = this.front;
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
        public bool IsEmpty()
        {
            Node<T> temp = this.front;
            if (temp == null)
                return true;
            return false;
        }
        public int Size()
        {
            int count = 0;
            Node<T> temp = this.front;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }
    }
}
