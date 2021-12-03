using System;

namespace Ham_120
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap vao 1 so N: ");
            int number = int.Parse(Console.ReadLine());
            Test(number);
        }

        static void Test(int number)
        {
            if (number >= 1)
            {
                for (int i = 1; i <= number; i++)
                {
                    long temp = (long)(i * i);
                    if (temp <= number)
                    {
                        Console.Write("{0} ", temp);
                    }
                } 
            } else
            {
                Console.WriteLine("Nhap loi");
            }
            
        }
    }
}
