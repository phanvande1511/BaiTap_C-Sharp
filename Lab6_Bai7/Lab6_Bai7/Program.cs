using System;

namespace Lab6_Bai7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Menu();
            int number = 0;
            Choose(number);
        }
        static void Menu()
        {
            Console.WriteLine("+-----------------------------------------------+");
            Console.WriteLine("|\t\t\tMENU\t\t\t|");
            Console.WriteLine("+-----------------------------------------------+");
            Console.WriteLine("|1. Menu 1\t\t\t\t\t|");
            Console.WriteLine("|2. Menu 2\t\t\t\t\t|");
            Console.WriteLine("|3. Menu 3\t\t\t\t\t|");
            Console.WriteLine("|4. Menu 4\t\t\t\t\t|");
            Console.WriteLine("|5. Exit\t\t\t\t\t|");
            Console.WriteLine("+-----------------------------------------------+");
        }

        static void Choose(int number)
        {
            do
            {
                Console.Write("Chon 1 so tu 1 - 5: ");
                number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Ban chon menu 1");
                        break;
                    case 2:
                        Console.WriteLine("Ban chon menu 2");
                        break;
                    case 3:
                        Console.WriteLine("Ban chon menu 3");
                        break;
                    case 4:
                        Console.WriteLine("Ban chon menu 4");
                        break;
                    case 5:
                        Console.WriteLine("Ban chon thoat khoi day");
                        break;
                    default: Console.WriteLine("Nhap sai roi do");
                        break;
                }
            } while (number != 1 && number != 2 && number != 3 && number != 4 && number != 5);
        }
    }
}
