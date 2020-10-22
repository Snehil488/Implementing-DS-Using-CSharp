using System;

namespace QueueImplementationUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QueueUsingLinkedList Queue = new QueueUsingLinkedList();
            Queue.Enqueue(56);
            Queue.Enqueue(30);
            Queue.Enqueue(70);
            Queue.Display();

        }
    }
}
