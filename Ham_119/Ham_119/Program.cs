using System;
using System.Collections;

namespace Ham_119
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap vao so nguyen N: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                if (PrimeNumber(i) == 1)
                {
                    Console.Write("{0} ", i);
                }
            }
        } 

        static int PrimeNumber(int number)
        {
            if (number < 2)
            {
                return 0;
            }
            int temp = (int)Math.Sqrt(number);
            for (int i = 2; i <= temp; i++)
            {
                if (number % i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
