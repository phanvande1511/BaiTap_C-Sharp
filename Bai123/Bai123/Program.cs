using System;

namespace Bai123
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap vao so luong chu so: ");
            int size = int.Parse(Console.ReadLine());
            int[] number = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Nhap so[{0}]: ", i);
                number[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("So nho nhat o vi tri: {0}", Find(number, size));
        }

        static int Find(int[] number, int size)
        {
            int min = number[0];
            for (int i = 0; i < size; i++)
            {
                if (min > number[i])
                {
                    min = i - 1;
                }
            }
            return min;
        }
    }
}
