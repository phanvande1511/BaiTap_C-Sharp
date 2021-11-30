using System;

namespace Lab5_Cau5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number;
            int temp = 0;
            int[] numberA = new int[10];
            Console.Write("Nhap vao 1 so: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("\n=================================\n");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Nhap so[{0}]: ", i);
                numberA[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Vi tri cua so {0} trong mang la: ", number);
            for (int i = 0; i < 10; i++)
            {
                if (number == numberA[i])
                {
                    Console.Write(" " + i);
                }
            }
        }
    }
}
