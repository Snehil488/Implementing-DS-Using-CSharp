using System;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.DisplayStack();
            stack.pop();
            Console.WriteLine("After One pop operation");
            stack.DisplayStack();
        }
    }
}
