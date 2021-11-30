using System;

namespace Lab5_Cau2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] numberA = new int[10];
            double[] numberB = new double[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nhap so[{0}]: ", i);
                numberB[i] = double.Parse(Console.ReadLine());
            }

            numberA[0] = 0;
            numberA[1] = (int)numberB[0];
            numberA[2] = 0;
            numberA[3] = (int)numberB[1];
            numberA[4] = 0;
            numberA[5] = (int)numberB[2];
            numberA[6] = 0;
            numberA[7] = (int)numberB[3];
            numberA[8] = 0;
            numberA[9] = (int)numberB[4];
            Console.WriteLine("=================================");

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("So[{0}] = {1}", j, numberA[j]);
            }
        }
    }
}
