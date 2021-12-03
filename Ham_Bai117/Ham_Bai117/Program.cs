using System;

namespace Ham_Bai117
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap vao so nguyen N: ");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                SumN(number);
            } else
            {
                Console.WriteLine("Loi");
            }
            
        }

        static void SumN (int number)
        {
            long temp = 0;
            for (int i = 1; i <= number; i++)
            {
                temp += (long)Math.Pow(i, i);
            }
                Console.Write("Tong cua");
                for (int i = 1; i <= number; i++)
                {
                    Console.Write(" {0} ^ {0} ", i);
                    Console.Write(" + ");
                }
                Console.Write("la: {0}", temp); 
        }
    }
}
