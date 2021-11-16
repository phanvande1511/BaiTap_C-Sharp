using System;

namespace Lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap vao 1 so N: ");
            int soX = System.Int32.Parse(Console.ReadLine());

            while (soX <= 0)
            {
                Console.Write("Nhap lai 1 so N lon hon 0: ");
                soX = System.Int32.Parse(Console.ReadLine());
            }

            Console.Write("Cac so chan nho hon N:");

            for (int i = 2; i <= soX; i++)
            {
                Console.Write(" " + i++);
            }
        }
    }
}
