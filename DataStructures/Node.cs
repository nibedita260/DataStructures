using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Node<T> where T:IComparable
    {
        public T data;
        public Node<T> Next;
        public Node(T data)
        {
            this.data = data;
        }
    }
}
