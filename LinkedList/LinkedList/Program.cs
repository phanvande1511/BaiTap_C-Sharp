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
            //removeHead();
            //removeTail();
            remove(6);
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

        static void removeHead()
        {
            if (head != null)
            {
                head = head.next;
            }
        }

        static void removeTail()
        {
            Node p = head;
            while (p.next.next != null)
            {
                p = p.next;
            }
            p.next = p.next.next;
        }

        static void remove(int n)
        {
            Node p = head;
            if (head.data == n) {
                removeHead();
                return;
            }

            Node q = head;
            while (q.data != n)
            {
                p = q;
                q = q.next;
            }
            p.next = q.next;
            q.next = null;
        }
    }
}