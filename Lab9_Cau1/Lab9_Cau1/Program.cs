using System;
using System.Collections;

namespace Lab9_Cau1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var listnum = new ArrayList();
            int temp;

            information();

            do
            {
                Console.Write("\nChoose: ");
                temp = int.Parse(Console.ReadLine());
                switch (temp)
                {
                    case 1:
                        for (int i = 0; i < 5; i++)
                        {
                            listnum.Add(new Random().Next(1, 10));
                        }

                        foreach (int num in listnum)
                        {
                            Console.Write("{0} ", num);
                        }
                        break;
                    case 2:
                        listnum.Add(new Random().Next(1, 10));
                        foreach (int num in listnum)
                        {
                            Console.Write("{0} ", num);
                        }
                        break;
                    case 3:
                        listnum.RemoveAt(new Random().Next(1, 5));
                        foreach (int num in listnum)
                        {
                            Console.Write("{0} ", num);
                        }
                        break;
                    case 4:
                        listnum.Insert(new Random().Next(1, 5), new Random().Next(1, 10));
                        foreach (int num in listnum)
                        {
                            Console.Write("{0} ", num);
                        }
                        break;
                    case 5:
                        foreach (int num in listnum)
                        {
                            Console.Write("{0} ", num);
                        }
                        break;
                    case 6:
                        int search = listnum.IndexOf(listnum[3]);
                        if (search == 1) Console.WriteLine("Loi");
                        else Console.Write("{0} vi tri: {1}", listnum[3], search);
                        break;
                    case 7:
                        listnum.Sort();
                        foreach (int num in listnum)
                        {
                            Console.Write("{0} ", num);
                        }
                        break;
                    case 8:
                        listnum.Reverse();
                        foreach (int num in listnum)
                        {
                            Console.Write("{0} ", num);
                        }
                        break;
                    default:
                        break;
                }
            } while (temp <= 8 && temp >= 1);
        }

        static void information()
        {
            Console.WriteLine("Demo cac thao tac tren ArrayList so nguyen Java\n");
            Console.WriteLine("===============================================\n");
            Console.WriteLine("1. Khoi tao danh sach");
            Console.WriteLine("2. Them 1 phan tu vao danh sach");
            Console.WriteLine("3. Xoa 1 phan tu ra khoi danh sach");
            Console.WriteLine("4. Chen 1 phan tu vao danh sach");
            Console.WriteLine("5. Duyet danh sach");
            Console.WriteLine("6. Tim 1 phan tu");
            Console.WriteLine("7. Sap xep danh sach tang dan");
            Console.WriteLine("8. Sap xep danh sach giam dan");
            Console.WriteLine("0. Thoat");
        }
    }
}
