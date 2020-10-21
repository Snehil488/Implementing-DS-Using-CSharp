using System;
using System.Collections.Generic;
using System.Text;

namespace StackImplementation
{
    class Stack
    {
        int[] stack = new int[5];
        int top = -1;

        public void push(int data)
        {
            if(top == -1)
            {
                top = 0;
                stack[top] = data;
            }
            else
            {
                top++;
                stack[top] = data;
            }
        }

        public int pop()
        {
            int value = 0;
            if(top == -1)
            {
                Console.WriteLine("Stack Empty.");
            }
            else
            {
                value = stack[top];
                stack[top] = 0;
                top--;
            }
            return value;
        }

        public void DisplayStack()
        {
            for(int i =top; i>=0; i--)
            {
                Console.WriteLine(stack[i] + "\n" + "--");
            }
        }
    }
}
