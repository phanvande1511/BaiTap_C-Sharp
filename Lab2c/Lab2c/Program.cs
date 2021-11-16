using System;

namespace Lab2c
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap vao 1 so N: ");
            int soN = System.Int32.Parse(Console.ReadLine());
            int dem = 0;
            while (soN <= 1)
            {
                Console.Write("Nhap lai 1 so N lon hon 1: ");
                soN = System.Int32.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= soN; i++)
            {
                if (soN % i == 0)
                {
                    dem++;
                }
                
            }
            if (dem == 2)
            {
                Console.WriteLine("{0} la so ngto!", soN);
            } else
            {
                Console.WriteLine("{0} khong phai la so ngto!", soN);
            }
        }
    }
}
