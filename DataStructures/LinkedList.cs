using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} inserted into linkedList" ,node.data);
        }
        public void Display()
        {
            Node temp = this.head;
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
        public void AddReverseData(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.Next = temp;
            }
        }
        public void InsertedAtPosition(int data,int pos)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head= newNode; 
            }
            if (pos == 0)
            {
                newNode.Next = head;
                this.head = newNode;
            }
            Node prev = null;
            Node curr = this.head;
            int count = 0;
            while(curr!=null && count <pos)
            {
                prev = curr;
                curr = curr.Next;
                count++;
            }
            newNode.Next = prev.Next;
            prev.Next = newNode;
        }
        public Node RemoveFirstElem()
        {
            if (this.head == null)
            {
                this.head = null;
            }
            this.head = this.head.Next;
            return this.head;
        }
        public Node RemoveLastElem()
        {
            if (this.head == null)
            {
                this.head = null;
            }
            if (head.Next == null)
            {
                head.Next = null;
            }
            Node newNode = head;
            while (newNode.Next.Next != null)
            {
                newNode = newNode.Next;
            }
            newNode.Next = null;
            return head;
        }
        public Node Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return this.head;
                }
                this.head = this.head.Next;
            }
            return null;
        }
        public void Size()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            int count = 0;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.Next;
                count++;
            }
            Console.WriteLine("Size of the LinkedList is " + count);
        }
        public void Sort()
        {
            Node temp = this.head;
            if (temp == null)
            {
                temp = this.head;
            }
            Node prev = this.head;
            Node curr = this.head.Next;
            while (temp != null) {
                if (prev.data < curr.data)
                {
                    prev = curr;
                    curr = curr.Next;
                    Console.WriteLine(curr + " ");
                }
                temp.Next = prev.Next;
                prev.Next = temp;
                curr.Next = prev.Next;
            }
        }
    }
}
