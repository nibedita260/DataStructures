using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList<T> where T : IComparable
    {
        public Node<T> head;
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} inserted into linkedList", node.data);
        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.Next;
            }
        }
        public void AddReverseData(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<T> temp = this.head;
                head = newNode;
                head.Next = temp;
            }
        }
        public void InsertedAtPosition(T data, int pos)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            if (pos == 0)
            {
                newNode.Next = head;
                this.head = newNode;
            }
            Node<T> prev = null;
            Node<T> curr = this.head;
            int count = 0;
            while (curr != null && count < pos)
            {
                prev = curr;
                curr = curr.Next;
                count++;
            }
            newNode.Next = prev.Next;
            prev.Next = newNode;
        }
        public Node<T> RemoveElem(T value)
        {
            Node<T> temp = this.head;
            Node<T> prev = this.head;
            if (this.head == null)
            {
                this.head = null;
            }
            while (temp != null)
            {
                if (temp.data.Equals(value))
                {
                    prev.Next = temp.Next;
                    Console.WriteLine("data is searched");
                    Console.WriteLine("searched data is removing:" + temp.data + " ");
                    return temp;
                }
                prev = temp;
                temp = temp.Next;
            }
            return this.head;
        }
        public Node<T> RemoveFirstElem()
        {
            if (this.head == null)
            {
                this.head = null;
            }
            this.head = this.head.Next;
            return this.head;
        }
        public Node<T> RemoveLastElem()
        {
            if (this.head == null)
            {
                this.head = null;
            }
            if (head.Next == null)
            {
                head.Next = null;
            }
            Node<T> newNode = head;
            while (newNode.Next.Next != null)
            {
                newNode = newNode.Next;
            }
            newNode.Next = null;
            return head;
        }
        public bool Search(int value)
        {
            Node<T> temp = this.head;
            while (temp != null)
            {
                if (temp.data.Equals(value))
                {
                    Console.WriteLine("searched data is:" + temp.data + " ");

                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }
        public void Size()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            int count = 0;
            while (temp != null)
            {
                //Console.WriteLine(temp.data + " ");
                temp = temp.Next;
                count++;
            }
            Console.WriteLine("Size of the LinkedList is " + count);
        }
        //public void Sort()
        //{
        //    Node<T> temp = this.head;
        //    if (temp == null)
        //    {
        //        temp = this.head;
        //    }
        //    Node<T> prev = this.head;
        //    Node<T> curr = this.head.Next;
        //    while (prev != null) {
        //        curr = prev.Next;
        //        while (curr != null)
        //        {
        //            if (prev.data.CompareTo(curr.data)>0)
        //            {
        //                temp = prev.data;
        //                prev.data = curr.data;
        //                curr.data = temp;
        //                Console.WriteLine(curr + " ");
        //            }
        //            curr = curr.Next;
        //        }
        //        prev = prev.Next;
        //    }
        //}
    }
}