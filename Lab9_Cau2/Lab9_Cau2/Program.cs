using System;
using System.Collections;

namespace Lab9_Cau2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack listNumber = new Stack();
            int temp;

            infor();

            do
            {
                Console.Write("\nChoose: ");
                temp = int.Parse(Console.ReadLine());

                switch(temp)
                {
                    case 1:
                        for(int i = 0; i < 5; i++)
            {
                            listNumber.Push(new Random().Next(1, 10));
                        }
                        foreach (int temp1 in listNumber)
                        {
                            Console.Write(temp1 + " ");
                        }
                        break;

                    case 2:
                        listNumber.Push(new Random().Next(1, 10));
                        foreach (int temp1 in listNumber)
                        {
                            Console.Write(temp1 + " ");
                        }
                        break;

                    case 3:
                        listNumber.Pop();
                        foreach(int temp1 in listNumber)
                        {
                            Console.Write(temp1 + " ");
                        }
                        break;

                    case 4:
                        Console.Write(listNumber.Peek());
                        break;

                    case 5:
                        foreach(int temp1 in listNumber)
                        {
                            Console.Write(temp1 + " ");
                        }
                        break;

                    case 0:
                        Console.Write("Thoat");
                        break;
                    default:
                        Console.Write("Nhap Loi");
                        break;
                }
            } while (temp >= 1 && temp <= 5);
        }

        static void infor()
        {
            Console.WriteLine("Demo cac thao tac tren so nguyen Java");
            Console.WriteLine("\n=====================================\n");
            Console.WriteLine("1. Khoi tao stack");
            Console.WriteLine("2. Them 1 phan tu vao stack");
            Console.WriteLine("3. Lay phan tu dau ra khoi danh sach");
            Console.WriteLine("4. Xem phan tu dau stack");
            Console.WriteLine("5. Duyet stack");
            Console.WriteLine("0. Thoat");
        }
    }
}
