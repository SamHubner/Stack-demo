using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_demo
{
    class Stack
    {
        int front; int back;int count;
        string[] stack;
        public Stack()
        {
            front = 0; back = 0; count = 0;

            stack = new string[8];
        }

        public void push(string x)
        {
            if (count < 8)
            {
                
            }
            else
            {
                Console.WriteLine("Stack is full");
            }
        }

        public void pop()
        {
            if (count > 0)
            {
               
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }
        public void Print()
        {
            for (int x = 0; x < stack.Length; x = x + 1)
            {
                Console.WriteLine(stack[x]);
            }
        }

        public int size()
        {
            Console.WriteLine(Convert.ToString(count));
            return count;
        }
    }
}
