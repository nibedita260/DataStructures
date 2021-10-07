using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedListStack<T> where T : IComparable
    {
        public Node<T> top;
        public void Push(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.top == null)
            {
                node.Next = null;
            }
            else
            {
                node.Next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed into Stack", data);
        }
        public void Display()
        {
            Node<T> temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.Next;
            }
        }
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is the top of the stack", this.top.data);
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty,Deletion not possible!!");
                return;
            }
            Console.WriteLine("data popped is{0}", this.top.data);
            this.top = this.top.Next;
        }
        public bool IsEmpty()
        {
            if (this.top == null)
                return true;
            else
                return false;
        }
    }
}