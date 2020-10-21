using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    class LinkedList
    {
        Node head;

        public void Add(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                head = node;
            }
            else
            {
                Node n = head;
                while(n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
            Console.WriteLine(node.data + " Inserted into LinkedList");
        }

        public void Display()
        {
            if(head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    Console.Write(n.data + " ");
                    n = n.next;
                }
                Console.Write(n.data + "\n");
            }
        }

        //starting position is 1
        public void InsertAtParticularPosition(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Index");
            }
            else if(position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                //for inserting at position 2 previous node will be head otherwise it is position-2
                Node n = head, prev = head, after;
                for(int pos = 1; pos < position; pos++)
                {
                    n = n.next;
                    if (pos == position - 2)
                    {
                        prev = n;
                    }   
                }
                after = n;
                prev.next = node;
                node.next = after;
            }
        }

        public Node RemoveFirstNode()
        {
            if(head == null)
            {
                Console.WriteLine("Empty LinkedList");
                return null;
            }
            else
            {
                Node n = head;
                head = head.next;
                return n;
            }
        }
        
        public Node RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("Empty LinkedList");
                return null;
            }
            else
            {
                Node n = head;
                while(n.next.next != null)
                {
                    n = n.next;
                }
                Node removedNode = n.next;
                n.next = null;
                return removedNode;
            }
        }

        public Node Search(int data)
        {
            Node n = head;
            if(head == null)
            {
                Console.WriteLine("LinkedList Empty.");
                return null;
            }
            if(head.data == data)
            {
                return head;
            }
            else
            {
                while(n.next != null)
                {
                    n = n.next;
                    if(n.data == data)
                    {
                        return n;
                    }
                }
                return null;
            }
        }
    }
}
