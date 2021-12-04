using System;

namespace Mang_Bai122
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap so luong chu so: ");
            int size = int.Parse(Console.ReadLine());
            int[] number = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Nhap so[{0}]: ", i);
                number[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("So lon nhat trong mang la: {0}", Max(number);
        }

        static int Max(int[] number, int size)
        {
            int max = number[0];
            for (int j = 0; j < size; j++)
            {
                if (max < number[j])
                {
                    max = number[j];
                }
            }
            return max;
        }
    } 
}
