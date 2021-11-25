using System;

namespace BTBaiTap7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double temp = 0;
            Console.Write("Nhap vao 1 so nguyen bat ki: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    temp += i / (double)(i + 1);
                }
                Console.WriteLine("Ket qua tu 1/2 +...+ {0}/({0} + 1): {1}", number, temp);
            }
            else
            {
                Console.WriteLine("Loi");
            }
        }
    }
}
