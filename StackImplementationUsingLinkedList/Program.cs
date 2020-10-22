using System;

namespace StackUsingLinkedListLive
{
    class Program
    {
        static void Main(string[] args)
        {
            StackUsingLinkedList Stack = new StackUsingLinkedList();
            Stack.Push(70);
            Stack.Push(30);
            Stack.Push(56);
            Stack.Display();
            //linkedListStack.Peek();
            //linkedListStack.Pop();
            //Stack.IsEmpty();
            //Stack.Display();

        }
    }
}
