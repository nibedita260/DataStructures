using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class BalancedParanthesis
    {
        public LinkedListStack<char> stack = new LinkedListStack<char>();
        //public readonly string expresion = "(5+6)*(7+8)/(4+3)(5+6)*(7+8)/(4+3)";
        public readonly string expresion = "[(])";
        public void CheckIsBalanced()
        {
            char[] ExpArray = expresion.ToCharArray();
            for (int i = 0; i < ExpArray.Length; i++)
            {
                if (ExpArray[i] == '[' || ExpArray[i] == '(')
                {
                    stack.Push(ExpArray[i]);
                }
                if (ExpArray[i] == ']')
                {
                    if (stack.top.Equals('['))
                    {
                        stack.Pop();
                    }
                }
                if(ExpArray[i] == ')')
                {
                    if(stack.top.Equals('(')){
                        stack.Pop();
                    }
                }
            }
            if (stack.IsEmpty())
            {
                Console.WriteLine("Arithmetic expression is balanced");
            }
            else
            {
                Console.WriteLine("Arithmetic expression is not balanced");
            }
        }
    }
}
