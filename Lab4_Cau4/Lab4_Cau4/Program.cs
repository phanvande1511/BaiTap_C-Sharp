using System;

namespace Lab4_Cau4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\tSO THICH CA NHAN");
            Console.WriteLine("================================");
            Console.WriteLine("1. Doc sach");
            Console.WriteLine("2. Nghe nhac");
            Console.WriteLine("3. Choi the thao");
            Console.WriteLine("4. May tinh");
            Console.WriteLine("5. Thoat");
            Console.WriteLine("================================");

            Console.Write("Chon: ");
            int sothich = int.Parse(Console.ReadLine());
            switch (sothich)
            {
                case 1:
                    Console.WriteLine("Ban thich doc sach?");
                    break;
                case 2:
                    Console.WriteLine("Ban thich nghe nhac?");
                    break;
                case 3:
                    Console.WriteLine("Ban thich choi the thao?");
                    break;
                case 4:
                    Console.WriteLine("Ban thich may tinh?");
                    break;
                case 5:
                    Console.WriteLine("Hen gap lai?");
                    break;
            }
        }
    }
}
