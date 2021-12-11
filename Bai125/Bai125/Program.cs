using System;

namespace Bai125
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int max = 100;
            int dem = 0;
            for (int i = 2; i <= max; i++)
            {
                if (PrimeNumber(i) == 1)
                {
                    dem++;
                }
            }
            Console.WriteLine("So luong so ngto nho hon 100 la: " + dem);
        }

        static int PrimeNumber(int max)
        {
            int temp = (int)Math.Sqrt(max);
            for (int i = 2; i <= temp; i++)
            {
                if (max % i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
