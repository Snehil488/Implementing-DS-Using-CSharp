using System;

namespace QueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.enQueue(1);
            queue.enQueue(2);
            queue.enQueue(3);
            queue.enQueue(4);
            queue.DisplayQueue();
            queue.deQueue();
            Console.WriteLine("\nAfter one deQueue Operation");
            queue.DisplayQueue();
        }
    }
}
