using System;

namespace LinkedList
{
    class MainClass
    {
        public static Node head = null;

        public static void Main(string[] args)
        {
            insertHead(1);
            insertHead(2);
            insertHead(3);
            insertTail(9);
            print();
        }

        static void print()
        {
            Node a = head;
            if(head == null)
            {
                Console.WriteLine("...");
            } else
            {
                Console.WriteLine(a.data);
                while (a.next != null)
                {
                    a = a.next;
                    Console.WriteLine(a.data);
                }
            }
        }

        static void insertHead(int n)
        {
            Node node = new Node(n);
            if(head == null)
            {
                head = node;
            } else
            {
                node.next = head;
                head = node;
            }
        }

        static void insertTail(int n)
        {
            Node node = new Node(n);
            Node temp = null;

            if(head == null)
            {
                head = node;
            } else
            {
                temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = node;
            }
        }
    }
}