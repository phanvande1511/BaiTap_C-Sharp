using System;

namespace Lab5_Cau4
{
    class MainClass
    {
        public static void Main(string[] args)
        { 
            int temp1 = 0;
            int temp2 = 0;
            int[] number = new int[10];
            int max = 0;
            int min = number[0];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Nhap so[{0}]: ", i);
                number[i] = int.Parse(Console.ReadLine());
                if (number[i] > max)
                {
                    max = number[i];
                }
                if (number[0] > number[i])
                {
                    min = number[i];
                } else
                {
                    min = number[0];
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (number[i] == max)
                {
                    temp1++;
                }
                if (min == number[i])
                {
                    temp2++;
                }
            }
            Console.WriteLine("Max = {0}, Xuat hien {1} lan", max, temp1);
            Console.WriteLine("Min = {0}, Xuat hien {1} lan", min, temp2);
        }
    }
}
