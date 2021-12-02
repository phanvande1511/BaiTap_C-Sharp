using System;

namespace Ham_Bai116
{
    class MainClass
    {

        static void Main(string[] args)
        {
            Console.Write("Nhap vao 1 so nguyen N: ");
            int number = int.Parse(Console.ReadLine());
            SumNumber(number);
            
        }

        static int SumNumber(int number)
        {
            int temp = 0;
            if (number > 0)
            {
                for (int i = 0; i <= number; i++)
                {
                    temp += i;
                }
                Console.WriteLine("Tong tu 1 den {0} la: {1}", number, temp);
            }
            else
            {
                Console.WriteLine("Nhap loi");
            }
            return temp;
        }
    }
}
