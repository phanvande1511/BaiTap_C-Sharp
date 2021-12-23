using System;
using System.Collections;

namespace Lab9_Cau3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Queue listNumber = new Queue();
            int temp1;

            infor();

            do
            {
                Console.Write("\nChoose: ");
                temp1 = int.Parse(Console.ReadLine());

                switch (temp1)
                {
                    case 1:
                        for (int i = 0; i < 5; i++)
                        {
                            listNumber.Enqueue(new Random().Next(1, 10));
                        }
                        foreach (int temp in listNumber)
                        {
                            Console.Write(temp + " ");
                        }
                        break;
                    case 2:
                        listNumber.Enqueue(new Random().Next(1, 10));
                        foreach (int temp in listNumber)
                        {
                            Console.Write(temp + " ");
                        }
                        break;
                    case 3:
                        listNumber.Dequeue();
                        foreach (int temp in listNumber)
                        {
                            Console.Write(temp + " ");
                        }
                        break;
                    case 4:
                        Console.Write(listNumber.Peek());
                        break;
                    case 5:
                        foreach (int temp in listNumber)
                        {
                            Console.Write(temp + " ");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Thoat");
                        break;
                }
            } while (temp1 >= 1 && temp1 <= 5);
        }

        static void infor()
        {
            Console.WriteLine("Demo cac thao tac tren Queue so nguyen Java");
            Console.WriteLine("\n===========================================\n");
            Console.WriteLine("1. Khoi tao Queue");
            Console.WriteLine("2. Them 1 phan tu vao Queue");
            Console.WriteLine("3. Lay Phan tu dau ra khoi Queue");
            Console.WriteLine("4. Xem phan tu dau Queue");
            Console.WriteLine("5. Duyet phan tu");
            Console.WriteLine("0. Thoat");
        }
    }
}
