using System;

namespace Lab5_Cau1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] number = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Nhap so[{0}]: ", i);
                number[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("====================================");
            Console.Write("Cac phan tu o vi tri chan: ");

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" " + number[i]);
                }
            }
        }
    }
}
