using System;

namespace BTBaiTap8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double temp = 0;
            Console.Write("Nhap 1 so nguyen bat ki: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    temp += ((double)(2 * i) + 1) / ((double)(2 * i) + 2);
                }
                Console.WriteLine("Ket qua tu 1 / 2 +...+ (2 * {0} + 1) / (2 * {0} + 2): {1}", number, temp);
            } else
            {
                Console.WriteLine("Loi");
            }
        }
    }
}
