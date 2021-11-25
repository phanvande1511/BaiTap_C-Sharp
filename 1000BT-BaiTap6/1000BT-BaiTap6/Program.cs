using System;

namespace BTBaiTap6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double temp = 0;
            Console.Write("Nhap 1 so nguyen N: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    temp += 1 / (double)(i * (i + 1));
                }
                Console.WriteLine("Ket qua tu 1/(1 * 2) +...+ 1/({0} * ({0} + 1)): {1}", number, temp);
            } else
            {
                Console.WriteLine("Loi");
            }
        }
    }
}
