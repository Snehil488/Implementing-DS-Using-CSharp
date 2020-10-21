using System;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(10);
            linkedList.Add(20);
            linkedList.Add(30);
            linkedList.Add(40);
            linkedList.Add(60);
            linkedList.Display();
            Console.WriteLine("-------------");
            //linkedList.InsertAtParticularPosition(5, 50);
            //linkedList.Display();
            //linkedList.RemoveFirstNode();
            //linkedList.Display();
            //linkedList.RemoveLastNode();
            //linkedList.Display();
            //Console.WriteLine(linkedList.Search(60).data);
        }
    }
}
