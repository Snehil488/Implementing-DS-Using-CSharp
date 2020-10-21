using System;
using System.Collections.Generic;
using System.Text;

namespace QueueImplementation
{
    class Queue
    {
        int[] queue = new int[5];
        int front = -1;
        int rear = -1;
        int size = 0;

        public void enQueue(int data)
        {
            if(rear == -1)
            {
                front = 0;
                rear = 0;
                queue[rear] = data;
                rear++;
                size++;
            }
            else
            {
                queue[rear] = data;
                rear++;
                size++;
            }
        }

        public int deQueue()
        {
            int value = 0;
            if(front == -1)
            {
                Console.WriteLine("Empty Queue");
            }
            else
            {
                value = queue[front];
                front++;
                size--;
            }
            return value;
        }

        public void DisplayQueue()
        {
            Console.Write("Queue : ");
            for(int i=0; i < size; i++)
            {
                Console.Write(queue[i]+" ");
            }
        }
    }
}
