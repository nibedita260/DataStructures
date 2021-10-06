using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class BalancedParanthesis
    {
        public readonly string expresion = "(5+6)*(7+8)/(4+3)(5+6)*(7+8)/(4+3)";
        public void CheckIsBalanced()
        {
            LinkedListStack<string> stack = new LinkedListStack<string>();
            for (int i = 0; i < expresion.Length; i++)
            {
                if (expresion[i] == '(')
                {
                    stack.Push("(");
                }
                if (expresion[i] == ')')
                {
                    stack.Pop();
                }
            }

            if (stack.IsEmpty())
                Console.WriteLine("Arithmetic expression is balanced");
            else
                Console.WriteLine("Arithmetic expression is not balanced");
        }
    }
}
